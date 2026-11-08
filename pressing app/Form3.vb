
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form3
    Private cmdeT As Integer
    Dim conn As New MySqlConnection("Server=localhost;Database=pressing;user id=root;password=")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query As String = ("SELECT TYPE FROM article")



            Dim command As New MySqlCommand(query, conn)
            Using Reader As MySqlDataReader = command.ExecuteReader()

                Dim table As New DataTable()

                table.Load(Reader)
                ComboBox1.DataSource = table
                ComboBox1.DisplayMember = "TYPE"
                ComboBox1.ValueMember = "TYPE"
            End Using
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Erreur de connexion:" & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click





        Try
            conn.Open()

            Dim query As String = ("INSERT INTO effect (NUMERO,DATE_DEPOT,quantite,type)  VALUES(@num,@date,@quantite,@type)")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@num", num.Text)
            cmd.Parameters.AddWithValue("@date", DateTime.CustomFormat)
            cmd.Parameters.AddWithValue("@quantite", quantite.Text)
            cmd.Parameters.AddWithValue("@type", ComboBox1.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Erreur de connexion:" & ex.Message)
            conn.Close()
        End Try


        Try

            conn.Open()
            Dim cn As String = ("SELECT PRIXARTICLE FROM article where TYPE=@type")
            Dim prixTotal As Integer

            Dim comman As New MySqlCommand(cn, conn)
            comman.Parameters.AddWithValue("@type", ComboBox1.Text)
            Dim result As Object = comman.ExecuteScalar()

            If result IsNot Nothing Then
                prixTotal = Convert.ToInt32(result)
            Else
                prixTotal = 0
            End If
            Dim n As Integer
            Dim x As Integer
            If Integer.TryParse(quantite.Text, x) Then
                n = x * result
            Else
                prixTotal = 0
            End If


            Dim cq As String = ("UPDATE effect set prix_total=@prixt WHERE type=@typ ")
            Dim a As New MySqlCommand(cq, conn)
            a.Parameters.AddWithValue("@typ", ComboBox1.Text)
            a.Parameters.AddWithValue("@prixt", n)
            a.ExecuteNonQuery()
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Erreur de connexion:" & ex.Message)
            conn.Close()
        End Try
        Try
            conn.Open()
            Dim cmde As String = ("SELECT NUMEROCMDE FROM commande where NOMBRE_ARTICLE=@nombre")
            Dim num As New MySqlCommand(cmde, conn)
            num.Parameters.AddWithValue("@nombre", Text2.Text)
            Dim resul As Object = num.ExecuteScalar()



            Dim nume As String = ("UPDATE effect set NUMEROCMDE=@nume WHERE type=@typ")
            Dim numero As New MySqlCommand(nume, conn)
            numero.Parameters.AddWithValue("@typ", ComboBox1.Text)
            numero.Parameters.AddWithValue("@nume", resul)

            numero.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur de connexion:" & ex.Message)
            conn.Close()
        End Try


        Try

            Dim connect As String = ("SELECT  article.PRIXARTICLE, effect.* FROM article INNER JOIN effect ON article.TYPE = effect.type ")

            conn.Open()



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


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Text2.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim query As String = ("INSERT INTO commande (NOMBRE_ARTICLE) VALUES(@type)")
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@type", Text2.Text)
            cmd.ExecuteNonQuery()
            conn.Close()


        Catch ex As Exception

        End Try

        Label5.Visible = Not Label5.Visible
        Text2.Visible = Not Text2.Visible
        Button1.Visible = Not Button1.Visible
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form8 As New Form8()
        Form8.Show()
        Me.Hide()
    End Sub
End Class