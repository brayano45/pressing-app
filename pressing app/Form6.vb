Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form6

    Dim conn As New MySqlConnection("Server=localhost;Database=pressing;user id=root;password=")

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles D1.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim da As New MySqlConnection
        Dim dt As New MySqlConnection
        Try
            conn.Open()
            Dim query As String = ("SELECT * FROM client WHERE NUMERO= @valeur")

            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@valeur", T1.Text)

            ' Adapter pour remplir les données
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            ' Remplir le DataTable et afficher dans un DataGridView
            adapter.Fill(table)
            D1.DataSource = table
        Catch ex As Exception

        End Try



    End Sub

    Private Sub T1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged

    End Sub
End Class