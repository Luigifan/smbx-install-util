Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Ionic.Zip

Public Class Form1
    Dim xml As New XDocument

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oForm As New Settings()
        oForm.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.isFirstRun = True Then
            MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
            My.Settings.isFirstRun = False
            RefreshAllItems()


        ElseIf My.Settings.isFirstRun = False Then
            RefreshAllItems()
        End If
    End Sub

    Public Sub ReloadWorldsDir()
        If My.Computer.FileSystem.DirectoryExists(My.Settings.worldlocation.ToString) Then
            ListBox2.DataSource = Directory.GetDirectories(My.Settings.worldlocation.ToString)
        Else
            MsgBox("Directory not Found!", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub RefreshAllItems()
        ListBox2.DataSource = Directory.GetDirectories(My.Settings.worldlocation.ToString)
        xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
        ListBox1.DataSource = games
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Button3.Enabled = True
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = ListBox1.Text)
        TextBox1.Text = node.@Description
        TextBox2.Text = node.@Author
        TextBox3.Text = node.@DownloadLink
        TextBox4.Text = node.@TechName
        Dim ZipName As String = node.@ZipName
        Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(node.@DownloadLink)
        req.Method = "HEAD"
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Button2.Enabled = True
        Dim SelectWorld As String = CStr(ListBox2.SelectedItem)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Episode will be downloaded and saved to " + My.Settings.worldlocation)
        Dim EpisodeFolderName As String = xml...<episode>.ToString
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = ListBox1.Text)
        Dim ZipName As String = node.@ZipName
        Dim TechName As String = node.@TechName
        'MsgBox("The following episode will be download: " + ListBox1.SelectedItem() + vbNewLine + "It will be saved to " + My.Settings.worldlocation + vbNewLine + "Proceed?", MsgBoxStyle.YesNo)

        Dim DownloadedFile As String = My.Settings.worldlocation + "\" + ZipName

        'My.Computer.Network.DownloadFile(TextBox3.Text, My.Settings.worldlocation + "\" + ZipName, String.Empty, String.Empty, True, String.Empty, True)
        My.Computer.Network.DownloadFile(TextBox3.Text, My.Settings.worldlocation + "\downloaded.zip", "", "", True, 30, True)
        Dim ZiptoUnzip As String = My.Settings.worldlocation + "\downloaded.zip"
        If My.Computer.FileSystem.DirectoryExists(EpisodeFolderName) Then
            Dim TargetDir As String = EpisodeFolderName
            Using zip1 As ZipFile = ZipFile.Read(ZiptoUnzip)
                Dim entry As ZipEntry
                For Each entry In zip1
                    entry.Extract(EpisodeFolderName, ExtractExistingFileAction.OverwriteSilently)
                Next
            End Using
            ReloadWorldsDir()
        Else
            My.Computer.FileSystem.CreateDirectory(My.Settings.worldlocation + "\" + TechName)
            Dim TargetDir As String = My.Settings.worldlocation + "\" + TechName
            Using zip1 As ZipFile = ZipFile.Read(ZiptoUnzip)
                Dim entry As ZipEntry
                'DEBUG MESSAGES
                MsgBox("Extracting to " + TargetDir)
                For Each entry In zip1

                    entry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                Next
                ReloadWorldsDir()
            End Using

        End If
        MsgBox("Episode completed extracting! Enjoy!")
    End Sub
End Class
