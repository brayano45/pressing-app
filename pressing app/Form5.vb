Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Form5
    Dim conn As New MySqlConnection("Server=localhost;Database=pressing;user id=root;password=")
    Dim connString As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            conn.Open()
            MessageBox.Show("Connexion Reussie a la base de donnee")
            Dim sql As String = "INSERT INTO client (NOM,NUMERO,EMAIL,ADRESSE) VALUES(@nom, @numero, @email, @adresse)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nom", nom.Text)
            cmd.Parameters.AddWithValue("@numero", numero.Text)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@adresse", adresse.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Le client a ete ajouter avec succes")

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Erreur de connexion:" & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form2 As New Form2
        Form2.Show()
        Me.Hide()
    End Sub
End Class