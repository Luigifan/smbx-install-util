Imports System.IO
Imports System.Text
Imports System.Xml.Serialization

Public Class XMLMain
    Dim destFile As String = Environment.CurrentDirectory() + "\submission.sub"

    Private Sub CreateExampleData()
        'Hi guys! This is where the data is submitted!
        Using sr As StreamWriter = New StreamWriter(destFile)
            sr.Write("<episode " + "IconLoc=""" + TextBox7.Text + """ TechName=""" + TextBox5.Text + """ Description=""" + TextBox3.Text + """ Author=""" + TextBox2.Text + " DownloadLink=null " + " ZipName=""" + TextBox4.Text + """>" + TextBox1.Text + "</episode>")
        End Using



    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = My.Application.Info.Version.ToString()

        TextBox6.Text = destFile
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CreateExampleData()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CreateExampleData()
        MsgBox("XML Saved to " + destFile, MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(Environment.CurrentDirectory)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Due to limitations of Visual Basic and XML, please place your strings INSIDE the quotations marks for you episode to be submitted." & vbNewLine & "Episode names are not required to be in quotation marks" & vbNewLine & "Thank you!", MsgBoxStyle.Critical)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim oForm As New Help
        oForm.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
