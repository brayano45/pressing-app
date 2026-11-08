Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub Suivant_Click(sender As Object, e As EventArgs) Handles Suivant.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub


End Class





