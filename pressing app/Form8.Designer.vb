<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Panel1 = New Panel()
        Button2 = New Button()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(435, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 51)
        Label1.TabIndex = 0
        Label1.Text = "FACTURE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(228, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 29)
        Label2.TabIndex = 1
        Label2.Text = "Numero de la commande"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(441, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(155, 27)
        TextBox1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.DeepSkyBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(56, 219)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(868, 314)
        DataGridView1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(438, 90)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 32)
        Button1.TabIndex = 4
        Button1.Text = "Etablir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(37, 9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(966, 548)
        Panel1.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(780, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 35)
        Button2.TabIndex = 5
        Button2.Text = "IMPRIMER"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(66, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 26)
        Label3.TabIndex = 6
        Label3.Text = "Royal clean"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1054, 559)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form8"
        Text = "Form8"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
