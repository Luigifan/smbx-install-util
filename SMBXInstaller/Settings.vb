Imports Setting.IniFile
Public Class Settings
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\programsettings.ini")
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = settingsIni.ReadValue("Settings", "smbxpath")
        TextBox2.Text = settingsIni.ReadValue("Settings", "worldlocation")
        TextBox3.Text = settingsIni.ReadValue("Settings", "executableloc")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        SaveSettings()

        Main.RefreshAllItems()
        Main.ReloadWorldsDir()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        settingsIni.WriteValue("Settings", "isFirstRun", "True")
        Application.Exit()
    End Sub

    Public Sub SaveSettings()
        MsgBox("Changing SMBX Path from " + My.Settings.smbxpath + " to " + TextBox1.Text)
        MsgBox("Changing World Location from " + My.Settings.worldlocation + " to " + TextBox2.Text)
        MsgBox("Changing SMBX Path from " + My.Settings.executableloc + " to " + TextBox3.Text)

        settingsIni.WriteValue("Settings", "smbxpath", TextBox1.Text)
        settingsIni.WriteValue("Settings", "worldlocation", TextBox2.Text)
        settingsIni.WriteValue("Settings", "executableloc", TextBox3.Text)
       
        Main.ReloadWorldsDir()
        Me.Close()
    End Sub
End Class