Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Ionic.Zip
Imports UpdateVB
Imports Setting.IniFile

Public Class Main
    Public updater As New UpdateVB.UpdateVB
    Dim xml As New XDocument
    Dim AppDataFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Dim settingsIni As New Setting.IniFile(Environment.CurrentDirectory + "\programsettings.ini")
    


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oForm As New Settings()
        oForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsDestinationReachable("http://rohara.x10.mx/smbxpublisher/appfiles/")
        
        Dim firstRun As String
        firstRun = settingsIni.ReadValue("Settings", "isFirstRun")
        

        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\programsettings.ini") Then
            If firstRun = "True" Then
                MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
                settingsIni.WriteValue("Settings", "isFirstRun", "False")
                Label6.Text = My.Application.Info.Version.ToString
            Else
                Label6.Text = My.Application.Info.Version.ToString
            End If
        Else
            Dim sw As New System.IO.StreamWriter(Environment.CurrentDirectory + "\programsettings.ini")
            sw.WriteLine("[Settings]")
            sw.WriteLine("isFirstRun=True")
            sw.WriteLine("smbxpath=C:\SMBX")
            sw.WriteLine("worldlocation=C:\SMBX\worlds")
            sw.WriteLine("executableloc=C:\SMBX\smbx.exe")
            'sw.WriteLine("debugEnabled=False")
            sw.Close()
            If firstRun = "True" Then
                MsgBox("Hi! I see this is your first run!" & vbNewLine & "Please go to Settings and configure your SMBX directories")
                settingsIni.WriteValue("Settings", "isFirstRun", "False")
                Label6.Text = My.Application.Info.Version.ToString
            Else
                'Continue Normally
            End If
        End If

        Dim s As Size = Me.Size
        s.Width = 526
        Me.Size = s
        Button4.Text = "->"
        Label6.Text = My.Application.Info.Version.ToString
        CheckForUpdates()
        RefreshAllItems()

    End Sub

    Public Sub ReloadWorldsDir()
        'My.Settings.worldlocation.ToString

        If My.Computer.FileSystem.DirectoryExists(settingsIni.ReadValue("Settings", "worldlocation")) Then
            ListBox2.DataSource = Directory.GetDirectories(settingsIni.ReadValue("Settings", "worldlocation"))
        Else
            MsgBox("Directory not Found!", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub RefreshAllItems()
        ReloadWorldsDir()
        xml = XDocument.Load("http://rohara.x10.mx/smbxpublisher/appfiles/worldIndex.xml")
        Dim games() As String = xml...<episode>.Select(Function(n) n.Value).ToArray
        ListBox1.DataSource = games
        repoUpdated.Text = "Repo Updated"
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Button3.Enabled = True
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = ListBox1.Text)
        RichTextBox1.Text = node.@Description
        TextBox2.Text = node.@Author
        TextBox3.Text = node.@DownloadLink
        TextBox4.Text = node.@TechName
        If node.@IconLoc = "null" Then
            IconImage.ImageLocation = "http://rohara.x10.mx/smbxpublisher/appfiles/NOICON.gif"
        Else
            IconImage.ImageLocation = node.@IconLoc
        End If
        IconImage.Visible = True
        Dim ZipName As String = node.@ZipName
        Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(node.@DownloadLink)
        req.Method = "HEAD"
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Button2.Enabled = True
        Dim SelectWorld As String = CStr(ListBox2.SelectedItem)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Episode will be downloaded and saved to " + settingsIni.ReadValue("Settings", "worldlocation"))
        Dim EpisodeFolderName As String = xml...<episode>.ToString
        Dim node As XElement = xml...<episode>.First(Function(n) n.Value = ListBox1.Text)
        Dim ZipName As String = node.@ZipName
        Dim TechName As String = node.@TechName
        'MsgBox("The following episode will be download: " + ListBox1.SelectedItem() + vbNewLine + "It will be saved to " + My.Settings.worldlocation + vbNewLine + "Proceed?", MsgBoxStyle.YesNo)

        Dim DownloadedFile As String = settingsIni.ReadValue("Settings", "worldlocation") + "\" + ZipName

        'My.Computer.Network.DownloadFile(TextBox3.Text, My.Settings.worldlocation + "\" + ZipName, String.Empty, String.Empty, True, String.Empty, True)
        My.Computer.Network.DownloadFile(TextBox3.Text, settingsIni.ReadValue("Settings", "worldlocation") + "\downloaded.zip", "", "", True, 30, True)
        Dim ZiptoUnzip As String = settingsIni.ReadValue("Settings", "worldlocation") + "\downloaded.zip"
        If My.Computer.FileSystem.DirectoryExists(EpisodeFolderName) Then
            Dim TargetDir As String = EpisodeFolderName
            Using zip1 As ZipFile = ZipFile.Read(ZiptoUnzip)
                Dim entry As ZipEntry
                For Each entry In zip1
                    entry.Extract(EpisodeFolderName, ExtractExistingFileAction.OverwriteSilently)
                Next
            End Using
            ReloadWorldsDir()
        Else
            My.Computer.FileSystem.CreateDirectory(settingsIni.ReadValue("Settings", "worldlocation") + "\" + TechName)
            Dim TargetDir As String = settingsIni.ReadValue("Settings", "worldlocation") + "\" + TechName
            Using zip1 As ZipFile = ZipFile.Read(ZiptoUnzip)
                Dim entry As ZipEntry
                'DEBUG MESSAGES
                MsgBox("Extracting to " + TargetDir)
                For Each entry In zip1

                    entry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently)
                Next
                ReloadWorldsDir()
            End Using

        End If
        MsgBox("Episode completed extracting! Enjoy!")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SelectedWorld As String = CStr(ListBox2.SelectedItem)
        My.Computer.FileSystem.DeleteDirectory(SelectedWorld, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        ReloadWorldsDir()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "->" Then
            Dim s As Size = Me.Size
            s.Width = 947
            Me.Size = s
            Button4.Text = "<-"
        ElseIf Button4.Text = "<-" Then
            Dim s As Size = Me.Size
            s.Width = 526
            Me.Size = s
            Button4.Text = "->"
        End If


    End Sub

    Public Sub CheckForUpdates()
        Dim curver As String = My.Application.Info.Version.ToString

        updater.checkinternet()
        updater.checkversion("http://rohara.x10.mx/smbxpublisher/appfiles/version_smbx.txt", curver)
        If updater.updateavailable = True Then
            My.Computer.Network.DownloadFile("http://rohara.x10.mx/smbxpublisher/appfiles/Update_Latest.exe", Environment.CurrentDirectory + "\Update.exe", "", "", False, "1000", True)
            Dim oForm As New UpdateConfirm
            oForm.ShowDialog()
        Else
            isUpToDate.Text = "Up to date: " + curver
        End If

    End Sub

    Public Sub CheckDebugVisible()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Computer.Network.DownloadFile("http://rohara.x10.mx/smbxpublisher/appfiles/Update_Latest.exe", Environment.CurrentDirectory + "\Update.exe", "", "", False, "1000", True)
        Process.Start("Update.exe")
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://smbxsplash.tumblr.com/")
    End Sub

    Private Sub RefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshList.Click
        RefreshAllItems()
    End Sub

    Private Sub RefreshWorlds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshWorlds.Click
        ReloadWorldsDir()
    End Sub




    ''' <summary>
    ''' Returns true if the destination is reachable via ping
    ''' </summary>
    Public Function IsDestinationReachable(ByVal hostnameOrAddress As String)
        Dim reachable As Boolean = False
        Try
            reachable = My.Computer.Network.IsAvailable AndAlso _
                             My.Computer.Network.Ping("http://rohara.x10.mx/smbxpublisher/appfiles/")

        Catch pingException As System.Net.NetworkInformation.PingException
        Catch genericNetworkException As System.Net.NetworkInformation.NetworkInformationException

            MsgBox("Server is offline! Unable to continue", MsgBoxStyle.Critical)
            Me.Close()

        End Try
        Return reachable
    End Function


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        My.Computer.Network.DownloadFile("http://rohara.x10.mx/smbxpublisher/appfiles/SMBX.zip", "C:\SMBX.zip", "", "", True, 1000, True)
        Using zip1 As ZipFile = ZipFile.Read("C:\SMBX.zip")
            Dim entry As ZipEntry
            'DEBUG MESSAGES
            MsgBox("Extracting to " + "C:\SMBX")
            For Each entry In zip1

                entry.Extract("C:\SMBX", ExtractExistingFileAction.OverwriteSilently)
            Next
            ReloadWorldsDir()
            MsgBox("Extraction complete. Please go and reconfigure if necessary.", MsgBoxStyle.Information)
        End Using

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim SMBXExe As String = settingsIni.ReadValue("Settings", "executableloc")
        If My.Computer.FileSystem.FileExists(SMBXExe) Then
            Process.Start(SMBXExe)
        Else
            MsgBox("Can't find " + SMBXExe + " verify it exists or change some settings!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
