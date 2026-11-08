
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form7
    Dim conn As New MySqlConnection("Server=localhost;Database=pressing;user id=root;password=")
    Dim index As Integer


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            conn.Open()
            MessageBox.Show("Connexion Reussie a la base de donnee")
            Dim sql As String = "INSERT INTO article (TYPE,PRIXARTICLE) VALUES(@TYPE, @PRIX)"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@TYPE", TextBox1.Text)
            cmd.Parameters.AddWithValue("@PRIX", TextBox2.Text)
            cmd.ExecuteNonQuery()


            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Erreur de connexion:" & ex.Message)
            conn.Close()
        End Try
        Dim query As String = ("SELECT TYPE, PRIXARTICLE FROM article")

        Dim command As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = ("SELECT TYPE, PRIXARTICLE FROM article")

        Dim command As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub
End Class