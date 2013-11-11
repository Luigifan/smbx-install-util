Imports System.IO

Public Class Main

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If System.IO.File.Exists(TextBox6.Text) = True Then
            MsgBox("File " + TextBox6.Text + " already exists! Please delete it to continue", MsgBoxStyle.Critical)
        Else
            Dim File As New System.IO.StreamWriter(TextBox6.Text)

            File.WriteLine("[" + TextBox1.Text + "]")
            File.WriteLine("worldName=" + TextBox1.Text)
            File.WriteLine("Description=" + TextBox2.Text)
            File.WriteLine("zipSize=" + TextBox3.Text)
            File.WriteLine("Author=" + TextBox4.Text)
            File.WriteLine("downloadLink=null")
            File.WriteLine("zipName=" + TextBox5.Text)
            File.Close()
        End If
    End Sub

    

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox6.Text = "C:\Users\" + Environment.UserName + "\Desktop\submission.ini"
    End Sub
End Class
