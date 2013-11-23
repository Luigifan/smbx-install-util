Public Class Update

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As Size = Me.Size
        s.Width = 312
        Me.Size = s

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CurrentExe As String = Environment.CurrentDirectory + "\SMBXInstaller.exe"
        Dim BackupExe As String = Environment.CurrentDirectory + "\SMBXInstaller_old.exe"

        If My.Computer.FileSystem.FileExists(BackupExe) Then
            My.Computer.FileSystem.DeleteFile(BackupExe)
        End If
        My.Computer.FileSystem.MoveFile(CurrentExe, BackupExe)
        My.Computer.Network.DownloadFile("http://rohara.x10.mx/smbxpublisher/appfiles/SMBXInstaller_Latest.exe", "SMBXInstaller.exe", "", "", True, "1000000", True)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "More Options->" Then
            Dim s As Size = Me.Size
            s.Width = 666
            Me.Size = s
            Button3.Text = "Collapse<-"
        ElseIf Button3.Text = "Collapse<-" Then
            Dim s As Size = Me.Size
            s.Width = 312
            Me.Size = s
            Button3.Text = "More Options->"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim CurrentSubmission As String = Environment.CurrentDirectory + "\SMBXSubmission.exe"
        Dim BackupSubmission As String = Environment.CurrentDirectory + "\SMBXSubmission.exe"
        'http://rohara.x10.mx/smbxpublisher/appfiles/SMBXSubmission_Latest.exe

        If My.Computer.FileSystem.FileExists(BackupSubmission) Then
            My.Computer.FileSystem.DeleteFile(BackupSubmission)
        End If
        My.Computer.FileSystem.MoveFile(CurrentSubmission, BackupSubmission)
        My.Computer.Network.DownloadFile("http://rohara.x10.mx/smbxpublisher/appfiles/SMBXSubmission_Latest", "SMBXSubmission.exe", "", "", True, "1000000", True)
        MsgBox("SMBXSubmission update complete", MsgBoxStyle.Information)
    End Sub
End Class
