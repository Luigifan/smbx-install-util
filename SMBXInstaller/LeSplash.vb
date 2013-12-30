Public NotInheritable Class LeSplash

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Public Function GenerateRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim random As New Random()
        Return random.Next(1, 5)
    End Function

    Private Sub LeSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub


    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
