Imports System.Net
Imports System.IO

Public Class UpdateConfirm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(Environment.CurrentDirectory + "\Update.exe")
        Me.Close()
        Main.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim versionreader As String
        versionreader = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "\version.txt")
        MsgBox("Will not update!")
        Me.Close()
        
        Main.isUpToDate.Text = "New version: " + versionreader
    End Sub

    Private Sub UpdateConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim address2 As String = "https://dl.dropboxusercontent.com/u/62304851/version_smbx.txt"
        Dim client2 As WebClient = New WebClient()
        Dim newversion As StreamReader = New StreamReader(client2.OpenRead(address2))


        Dim address As String = "https://dl.dropboxusercontent.com/u/62304851/changelog_smbx.txt"
        Dim client As WebClient = New WebClient()
        Dim changelog As StreamReader = New StreamReader(client.OpenRead(address))

        RichTextBox1.Text = changelog.ReadToEnd
        CurrentVer.Text = My.Application.Info.Version.ToString
        NewestVer.Text = newversion.ReadToEnd
    End Sub
End Class