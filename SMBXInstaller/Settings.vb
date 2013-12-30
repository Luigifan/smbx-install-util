Imports Setting.IniFile
Public Class Settings
    Dim AppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\programsettings.ini")
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = settingsIni.ReadValue("Settings", "smbxpath")
        TextBox2.Text = settingsIni.ReadValue("Settings", "worldlocation")
        TextBox3.Text = settingsIni.ReadValue("Settings", "executableloc")
        'CheckBox1.Checked = settingsIni.ReadValue("Settings", "debugEnabled")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SaveSettings()

        Main.RefreshAllItems()
        Main.ReloadWorldsDir()
        'If CheckBox1.Checked = True Then
        'Main.Button4.Visible = True
        'Else
        'Main.Button4.Visible = False
        'End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        settingsIni.WriteValue("Settings", "isFirstRun", "True")
        Application.Exit()
    End Sub

    Public Sub SaveSettings()
        MsgBox("Settings saved!")

        settingsIni.WriteValue("Settings", "smbxpath", TextBox1.Text)
        settingsIni.WriteValue("Settings", "worldlocation", TextBox2.Text)
        settingsIni.WriteValue("Settings", "executableloc", TextBox3.Text)
        'settingsIni.WriteValue("Settings", "debugEnabled", CheckBox1.Checked)


        Main.ReloadWorldsDir()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
<<<<<<< HEAD
        Dim smbxexe = ""
        Dim smbxexeworld = ""
        Dim smbxexedir = ""
        Dim fileDialogBox As New OpenFileDialog()
        fileDialogBox.Filter = "Executable Files (*.exe)|*.exe"
        fileDialogBox.FilterIndex = 1
        fileDialogBox.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        If (fileDialogBox.ShowDialog() = DialogResult.OK) Then
            smbxexe = fileDialogBox.FileName
            smbxexeworld = fileDialogBox.FileName
            smbxexedir = fileDialogBox.FileName
        End If

        Dim smbxdirw As String = Replace(smbxexeworld, "smbx.exe", "worlds")
        Dim smbxdir As String = Replace(smbxexedir, "smbx.exe", "")
        TextBox3.Text = smbxexe
        TextBox2.Text = smbxdirw
        TextBox3.Text = smbxdir
=======
        
        Dim smbxexedir = ""
        Dim fileDialogBox As New OpenFileDialog()
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        

        If (FolderBrowserDialog1.ShowDialog = DialogResult.OK) Then

            smbxexedir = FolderBrowserDialog1.SelectedPath
        End If

        TextBox1.Text = smbxexedir
        TextBox2.Text = smbxexedir + "\worlds"
        TextBox3.Text = smbxexedir + "\smbx.exe"

>>>>>>> 1.4.1.0 Update


    End Sub
End Class