Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Public Class Form1
    <Serializable()> Class StoryEpisodes
        Property Episodes As List(Of Episode)

        Public Sub New()
            Episodes = New List(Of Episode)
        End Sub
    End Class

    <Serializable()> Public Class Episode
        Property EpisodeName As String
        Property WorldName As String
        Property Description As String
        Property ZipSize As Long
        Property Author As String
        Property DownloadLink As String
        Property ZipName As String

    End Class




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oForm As New Settings()
        oForm.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.isFirstRun = True Then
            MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
            UpdateRepo()
            RefreshAllItems()
            My.Settings.isFirstRun = False

        ElseIf My.Settings.isFirstRun = False Then
            'UpdateRepo()
            RefreshAllItems()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub UpdateRepo()
        Dim appdir As String = Environment.CurrentDirectory
        'https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml
        MsgBox("Updating Repo", MsgBoxStyle.SystemModal)
        If My.Computer.FileSystem.FileExists(appdir + "\worldIndex.xml") Then
            My.Computer.FileSystem.DeleteFile(appdir + "\worldIndex.xml")
        End If

        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/62304851/worldIndex.xml", appdir + "\worldIndex.xml")





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
        Dim SelectWorld As String = CStr(ListBox2.SelectedItem)
    End Sub

End Class
