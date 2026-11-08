Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Form8
    Dim conn As New MySqlConnection("Server=localhost;Database=pressing;user id=root;password=")
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            conn.Open()


            Dim connect As String = ("SELECT  article.PRIXARTICLE, effect.* FROM article INNER JOIN effect ON article.TYPE = effect.type WHERE effect.NUMEROCMDE=@num")
            Dim cmm As New MySqlCommand(connect, conn)
            cmm.Parameters.AddWithValue("@num", TextBox1.Text)
            cmm.ExecuteNonQuery()
            Dim command As New MySqlCommand(connect, conn)
            Dim adap As New MySqlDataAdapter(command)
            Dim selec As New DataTable()
            adap.Fill(selec)
            DataGridView1.DataSource = selec
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Erreur de connexion:" & ex.Message)
            conn.Close()
        End Try

        Label2.Visible = Not Label2.Visible
        Button1.Visible = Not Button1.Visible
        TextBox1.Visible = Not TextBox1.Visible
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class