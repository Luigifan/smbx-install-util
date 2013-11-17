Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Ionic.Zip
Imports UpdateVB

Public Class Main
    Public updater As New UpdateVB.UpdateVB
    Dim xml As New XDocument


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oForm As New Settings()
        oForm.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.isFirstRun = True Then
            MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
            My.Computer.FileSystem.CreateDirectory("C:\Temp\SMBX")
            My.Settings.isFirstRun = False
            CheckForUpdates()
            RefreshAllItems()
            Label6.Text = My.Application.Info.Version.ToString
        ElseIf My.Settings.isFirstRun = False Then
            CheckForUpdates()
            RefreshAllItems()
            Label6.Text = My.Application.Info.Version.ToString
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
        ReloadWorldsDir()
        xml = XDocument.Load("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml")
        Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
        ListBox1.DataSource = games
        repoUpdated.Text = "Repo Updated"
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Button3.Enabled = True
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = ListBox1.Text)
        RichTextBox1.Text = node.@Description
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SelectedWorld As String = CStr(ListBox2.SelectedItem)
        Console.Write("Going to delete " + SelectedWorld)
        Console.WriteLine()
        My.Computer.FileSystem.DeleteDirectory(SelectedWorld, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        ReloadWorldsDir()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Expand Debug Dialogs->" Then
            Dim s As Size = Me.Size
            s.Width = 947
            Me.Size = s
            Button4.Text = "Hide Debug Dialogs<-"
        ElseIf Button4.Text = "Hide Debug Dialogs<-" Then
            Dim s As Size = Me.Size
            s.Width = 526
            Me.Size = s
            Button4.Text = "Expand Debug Dialogs->"
        End If


    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub CheckForUpdates()
        Dim curver As String = My.Application.Info.Version.ToString

        updater.checkinternet()
        updater.checkversion("https://dl.dropboxusercontent.com/u/62304851/version_smbx.txt", curver)
        If updater.updateavailable = True Then

            Dim oForm As New UpdateConfirm
            oForm.ShowDialog()
        Else
            isUpToDate.Text = "Up to date: " + curver
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("Update.exe")
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://smbxsplash.tumblr.com/")
    End Sub

    Private Sub RefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshList.Click
        RefreshAllItems()
    End Sub

    Private Sub RefreshWorlds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshWorlds.Click
        ReloadWorldsDir()
    End Sub
End Class
