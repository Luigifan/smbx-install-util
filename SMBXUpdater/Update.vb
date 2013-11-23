Public Class Update

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CurrentExe As String = Environment.CurrentDirectory + "\SMBXInstaller.exe"
        Dim BackupExe As String = Environment.CurrentDirectory + "\SMBXInstaller_old.exe"

        If My.Computer.FileSystem.FileExists(BackupExe) Then
            My.Computer.FileSystem.DeleteFile(BackupExe)
        End If
        My.Computer.FileSystem.MoveFile(CurrentExe, BackupExe)
        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/62304851/SMBXInstaller.exe", "SMBXInstaller.exe", "", "", True, "1000000", True)
        Dim endUpdate = MsgBox("Update complete, launch now?", MsgBoxStyle.YesNo)
        If endUpdate = DialogResult.Yes Then
            Process.Start(CurrentExe)
            Me.Close()
        ElseIf endUpdate = DialogResult.No Then
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
