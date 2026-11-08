<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        Fermer = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        A1 = New Label()
        A2 = New Label()
        PictureBox3 = New PictureBox()
        Button6 = New Button()
        Button7 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Fermer)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(A1)
        Panel1.Controls.Add(A2)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 694)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.ImageAlign = ContentAlignment.TopLeft
        Button5.Location = New Point(21, 128)
        Button5.Name = "Button5"
        Button5.Size = New Size(214, 33)
        Button5.TabIndex = 7
        Button5.Text = "Recherche"
        Button5.TextAlign = ContentAlignment.TopCenter
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.ImageAlign = ContentAlignment.TopLeft
        Button4.Location = New Point(21, 161)
        Button4.Name = "Button4"
        Button4.Size = New Size(214, 33)
        Button4.TabIndex = 6
        Button4.Text = "Tarif"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(33, 100)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 22)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Fermer
        ' 
        Fermer.Location = New Point(109, 602)
        Fermer.Name = "Fermer"
        Fermer.Size = New Size(78, 29)
        Fermer.TabIndex = 4
        Fermer.Text = "Fermer"
        Fermer.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(14, 602)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 29)
        Button2.TabIndex = 3
        Button2.Text = "Retour"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(21, 95)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 33)
        Button1.TabIndex = 2
        Button1.Text = "Accuiel"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.SteelBlue
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(94, 67)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(132, 21)
        TextBox2.TabIndex = 1
        TextBox2.Text = "MENU"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.SteelBlue
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.InactiveBorder
        TextBox1.Location = New Point(24, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(202, 34)
        TextBox1.TabIndex = 0
        TextBox1.Text = "PRESSING APP"
        ' 
        ' A1
        ' 
        A1.AutoSize = True
        A1.BackColor = Color.DeepSkyBlue
        A1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        A1.Location = New Point(3, 91)
        A1.Margin = New Padding(2, 0, 3, 0)
        A1.Name = "A1"
        A1.Size = New Size(257, 38)
        A1.TabIndex = 1
        A1.Text = "                              "
        ' 
        ' A2
        ' 
        A2.AutoSize = True
        A2.BackColor = Color.DeepSkyBlue
        A2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        A2.Location = New Point(0, 129)
        A2.Name = "A2"
        A2.Size = New Size(257, 38)
        A2.TabIndex = 10
        A2.Text = "                              "
        A2.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
        PictureBox3.Image = My.Resources.Resources.Screenshot_2025_04_12_040352
        PictureBox3.Location = New Point(275, 39)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(876, 235)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DeepSkyBlue
        Button6.BackgroundImage = My.Resources.Resources._1d33997d_e536_486e_98ac_9161120675cb1
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(296, 324)
        Button6.Name = "Button6"
        Button6.Size = New Size(156, 132)
        Button6.TabIndex = 2
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.DeepSkyBlue
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(621, 311)
        Button7.Name = "Button7"
        Button7.Size = New Size(194, 187)
        Button7.TabIndex = 3
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(321, 470)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 58)
        Label1.TabIndex = 4
        Label1.Text = "Enregistre un " & vbCrLf & "      client"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Dubai", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(660, 470)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 58)
        Label2.TabIndex = 5
        Label2.Text = "Enregistre une " & vbCrLf & "    commande"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1174, 685)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(PictureBox3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Fermer As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents A1 As Label
    Friend WithEvents A2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label3 As Label
End Class
