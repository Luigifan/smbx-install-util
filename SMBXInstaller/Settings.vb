Public Class Settings

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.smbxpath
        TextBox2.Text = My.Settings.worldlocation
        TextBox3.Text = My.Settings.executableloc

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Changing SMBX Path from " + My.Settings.smbxpath + " to " + TextBox1.Text)
        MsgBox("Changing World Location from " + My.Settings.worldlocation + " to " + TextBox2.Text)
        MsgBox("Changing SMBX Path from " + My.Settings.executableloc + " to " + TextBox3.Text)

        If TextBox1.Text = My.Settings.smbxpath Then

        Else
            My.Settings.smbxpath = TextBox1.Text
        End If

        If TextBox2.Text = My.Settings.smbxpath Then
        Else
            My.Settings.worldlocation = TextBox2.Text
        End If

        If TextBox3.Text = My.Settings.smbxpath Then
        Else

            My.Settings.executableloc = TextBox3.Text
        End If

        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class