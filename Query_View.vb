Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class Query_View

    Public Property query As String
    Private path As String
    Private count As Integer
    Private up, down As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        If (up + 1 = count) Then
            Button2.Enabled = False
        End If
        up = up + 1
        PictureBox1.ImageLocation = path & "\" & up & ".jpg"
        TextBox1.Text = System.IO.File.ReadAllText(path & "\" & up & ".txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        If (up - 1 = 1) Then
            Button1.Enabled = False
        End If
        up = up - 1
        PictureBox1.ImageLocation = path & "\" & up & ".jpg"
        TextBox1.Text = System.IO.File.ReadAllText(path & "\" & up & ".txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim obj As New Query_Select
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Query_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Me.Location = New Point(x, y)
        Me.TopMost = True
        Me.Text = query
        path = "\\DESKTOP-5HELUA6\Backup Drive\AMOS Tutorial\" & query
        count = (Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length) / 2
        up = 1
        down = 1
        Button1.Enabled = False
        PictureBox1.ImageLocation = path & "\" & up & ".jpg"
        TextBox1.Text = System.IO.File.ReadAllText(path & "\" & up & ".txt")
    End Sub


End Class