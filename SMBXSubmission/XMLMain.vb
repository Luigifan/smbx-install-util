Imports System.IO
Imports System.Text
Imports System.Xml.Serialization

Public Class XMLMain
    Dim destFile As String = Environment.CurrentDirectory() + "\submission.xml"
    <Serializable()> Class StoryEpisodes
        Property Episodes As List(Of Episode)

        Public Sub New()
            Episodes = New List(Of Episode)
        End Sub
    End Class

    <Serializable()> Public Class Episode
        Property EpisodeName As String
        Property WorldName As String
        Property Description As String
        Property ZipSize As String
        Property Author As String
        Property DownloadLink As String
        Property ZipName As String

    End Class

    Private Sub CreateExampleData()
        Dim seps As New StoryEpisodes

        seps.Episodes.Add(New Episode With {.EpisodeName = TextBox1.Text,
                                            .Author = TextBox2.Text,
                                            .Description = TextBox3.Text,
                                            .DownloadLink = "NULL EDIT LATER K",
                                            .WorldName = TextBox1.Text,
                                            .ZipName = TextBox4.Text,
                                            .ZipSize = TextBox5.Text})
        
        ' Save the data to an XML file.
        'Dim destFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "epsiodes.xml")

        Dim srlzr As New XmlSerializer(GetType(StoryEpisodes))

        Using sw As New StreamWriter(destFile)
            srlzr.Serialize(sw, seps)
        End Using

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


        TextBox6.Text = destFile
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CreateExampleData()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        CreateExampleData()

    End Sub
End Class