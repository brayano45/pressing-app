<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 45)
        Label2.TabIndex = 1
        Label2.Text = "Prix:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Dubai", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 45)
        Label3.TabIndex = 2
        Label3.Text = "Type d'article:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DeepSkyBlue
        GroupBox1.BackgroundImage = My.Resources.Resources.pngtree_vector_back_icon_png_image_931209_removebg_preview
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.FlatStyle = FlatStyle.System
        GroupBox1.Font = New Font("Dubai", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(296, 98)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(483, 215)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Definir votre tarif"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(150, 172)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 37)
        Button1.TabIndex = 5
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ScrollBar
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(90, 108)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(258, 33)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ScrollBar
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(186, 60)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(258, 34)
        TextBox1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.DeepSkyBlue
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(105, 399)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(876, 209)
        DataGridView1.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DeepSkyBlue
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Dubai", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(415, 344)
        Button2.Name = "Button2"
        Button2.Size = New Size(229, 49)
        Button2.TabIndex = 6
        Button2.Text = "Tarif"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DeepSkyBlue
        Button3.BackgroundImage = My.Resources.Resources.pngtree_vector_back_icon_png_image_931209_removebg_preview
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(13, 16)
        Button3.Name = "Button3"
        Button3.Size = New Size(70, 37)
        Button3.TabIndex = 7
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1056, 641)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "Form7"
        Text = "Form7"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
