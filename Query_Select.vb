Imports System.Data

Public Class Query_Select

    Private dtQueries As DataTable

    Private Sub Query_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = GetData()
        ListBox1.DisplayMember = "Query"
    End Sub

    Private Function GetData() As DataTable
        dtQueries = New DataTable()
        dtQueries.Columns.Add("Query", GetType(String))
        dtQueries.Rows.Add("Component Search")
        dtQueries.Rows.Add("EOM Counter Update")
        Return dtQueries
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dvQueries As New DataView
        dvQueries = dtQueries.DefaultView
        dvQueries.RowFilter = "Query LIKE '%" + TextBox1.Text + "%'"
        If (dvQueries.Table.Rows.Count = 0) Then
            View.Enabled = False
        Else
            View.Enabled = True
        End If
    End Sub

    Private Sub View_Click(sender As Object, e As EventArgs) Handles View.Click
        Try
            Dim obj As New Query_View
            obj.query = ListBox1.GetItemText(ListBox1.SelectedItem)
            obj.Show()
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Me.Close()
    End Sub
End Class