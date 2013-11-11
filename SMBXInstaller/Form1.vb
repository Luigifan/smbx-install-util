Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml

Public Class Form1
    Dim INI_File As New IniFile(Environment.CurrentDirectory + "\worldIndex.ini")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oForm As New Settings()
        oForm.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.isFirstRun = True Then
            MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
            UpdateRepo()

            My.Settings.isFirstRun = False

        ElseIf My.Settings.isFirstRun = False Then
            UpdateRepo()
        End If




        ListBox2.DataSource = Directory.GetDirectories(My.Settings.worldlocation.ToString)

        Dim SelectWorld As String = CStr(ListBox2.SelectedItem)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub UpdateRepo()
        Dim appdir As String = Environment.CurrentDirectory
        'https://dl.dropboxusercontent.com/u/62304851/worldIndex.ini
        MsgBox("Updating Repo", MsgBoxStyle.SystemModal)
        If My.Computer.FileSystem.FileExists(appdir + "\worldIndex.ini") Then
            My.Computer.FileSystem.DeleteFile(appdir + "\worldIndex.ini")
        End If

        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/62304851/worldIndex.ini", appdir + "\worldIndex.ini")

        



    End Sub
    Public Sub ReadSections()

    End Sub

    Public Sub ReloadWorldsDir()
        If My.Computer.FileSystem.DirectoryExists(My.Settings.worldlocation.ToString) Then
            ListBox2.DataSource = Directory.GetDirectories(My.Settings.worldlocation.ToString)
        Else
            MsgBox("Directory not Found!", MsgBoxStyle.Critical)
        End If

    End Sub
End Class
