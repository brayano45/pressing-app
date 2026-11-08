<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Panel1 = New Panel()
        DateTime = New DateTimePicker()
        quantite = New TextBox()
        num = New TextBox()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Text2 = New TextBox()
        Label6 = New Label()
        Button2 = New Button()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(434, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 39)
        Button1.TabIndex = 0
        Button1.Text = "Nouvelle commande"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.Controls.Add(DateTime)
        Panel1.Controls.Add(quantite)
        Panel1.Controls.Add(num)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(45, 149)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1004, 203)
        Panel1.TabIndex = 1
        ' 
        ' DateTime
        ' 
        DateTime.Format = DateTimePickerFormat.Short
        DateTime.ImeMode = ImeMode.Alpha
        DateTime.Location = New Point(187, 100)
        DateTime.Name = "DateTime"
        DateTime.Size = New Size(106, 27)
        DateTime.TabIndex = 10
        DateTime.Value = New Date(2025, 5, 8, 0, 0, 0, 0)
        ' 
        ' quantite
        ' 
        quantite.Location = New Point(644, 14)
        quantite.Name = "quantite"
        quantite.Size = New Size(111, 27)
        quantite.TabIndex = 9
        ' 
        ' num
        ' 
        num.Location = New Point(187, 53)
        num.Name = "num"
        num.Size = New Size(219, 27)
        num.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(187, 10)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(219, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(546, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 39)
        Label4.TabIndex = 3
        Label4.Text = "Quantite"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 39)
        Label3.TabIndex = 2
        Label3.Text = "Numero client"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(31, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 39)
        Label2.TabIndex = 1
        Label2.Text = "Date depot"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 39)
        Label1.TabIndex = 0
        Label1.Text = "Type d'article"
        ' 
        ' Text2
        ' 
        Text2.Location = New Point(448, 14)
        Text2.Name = "Text2"
        Text2.Size = New Size(188, 27)
        Text2.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(482, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 39)
        Label6.TabIndex = 10
        Label6.Text = "Commande"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DeepSkyBlue
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.World, CByte(0))
        Button2.Location = New Point(926, 358)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 52)
        Button2.TabIndex = 11
        Button2.Text = "Ajouter"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(311, 384)
        Label7.Name = "Label7"
        Label7.Size = New Size(445, 39)
        Label7.TabIndex = 12
        Label7.Text = "Liste des differents articles de la commande "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(96, 426)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(868, 208)
        DataGridView1.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(206, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 34)
        Label5.TabIndex = 14
        Label5.Text = "Nombre total des articles"
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(983, 535)
        Button3.Name = "Button3"
        Button3.Size = New Size(104, 51)
        Button3.TabIndex = 15
        Button3.Text = "Facture"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1097, 630)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(Text2)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents quantite As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents num As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTime As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
End Class
