<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Fermer = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        A2 = New Label()
        T1 = New TextBox()
        Button6 = New Button()
        D1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(D1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Left
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Fermer)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(A2)
        Panel1.Location = New Point(-6, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 694)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Image = My.Resources.Resources.search_icon_simple_flat_logo_260nw_449915272_removebg_preview
        PictureBox2.Location = New Point(43, 135)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(26, 20)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
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
        Button4.Text = "Accuiel"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.ImageAlign = ContentAlignment.TopLeft
        Button3.Location = New Point(21, 194)
        Button3.Name = "Button3"
        Button3.Size = New Size(214, 33)
        Button3.TabIndex = 5
        Button3.Text = "Accuiel"
        Button3.TextAlign = ContentAlignment.TopCenter
        Button3.UseVisualStyleBackColor = True
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
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.SteelBlue
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = SystemColors.InactiveBorder
        TextBox3.Location = New Point(24, 12)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(202, 34)
        TextBox3.TabIndex = 0
        TextBox3.Text = "PRESSING APP"
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
        ' 
        ' T1
        ' 
        T1.BackColor = SystemColors.ScrollBar
        T1.BorderStyle = BorderStyle.None
        T1.Location = New Point(388, 39)
        T1.Name = "T1"
        T1.PlaceholderText = "Recherche"
        T1.Size = New Size(645, 20)
        T1.TabIndex = 3
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DeepSkyBlue
        Button6.BackgroundImage = My.Resources.Resources.search_icon_simple_flat_logo_260nw_449915272_removebg_preview
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(343, 36)
        Button6.Name = "Button6"
        Button6.Size = New Size(39, 26)
        Button6.TabIndex = 5
        Button6.UseVisualStyleBackColor = False
        ' 
        ' D1
        ' 
        DataGridViewCellStyle1.BackColor = Color.Transparent
        DataGridViewCellStyle1.Format = "E2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        D1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        D1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        D1.BackgroundColor = Color.DeepSkyBlue
        D1.BorderStyle = BorderStyle.None
        D1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        D1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        D1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        D1.EnableHeadersVisualStyles = False
        D1.GridColor = Color.White
        D1.Location = New Point(416, 81)
        D1.Name = "D1"
        D1.ReadOnly = True
        D1.RowHeadersWidth = 51
        D1.ScrollBars = ScrollBars.Horizontal
        D1.Size = New Size(578, 425)
        D1.TabIndex = 4
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1158, 570)
        Controls.Add(Button6)
        Controls.Add(D1)
        Controls.Add(T1)
        Controls.Add(Panel1)
        Name = "Form6"
        Text = "Form6"
        TransparencyKey = Color.Red
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(D1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Fermer As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents A2 As Label
    Friend WithEvents T1 As TextBox
    Friend WithEvents D1 As DataGridView
    Friend WithEvents Button6 As Button
End Class
