<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox1 = New PictureBox()
        Suivant = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackgroundWorker1
        ' 
        BackgroundWorker1.WorkerSupportsCancellation = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-4, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(538, 709)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Suivant
        ' 
        Suivant.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Suivant.Cursor = Cursors.Hand
        Suivant.FlatAppearance.BorderSize = 0
        Suivant.FlatStyle = FlatStyle.Flat
        Suivant.Font = New Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Suivant.Location = New Point(924, 630)
        Suivant.Name = "Suivant"
        Suivant.Size = New Size(179, 45)
        Suivant.TabIndex = 1
        Suivant.Text = "Suivant"
        Suivant.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMinSize = New Size(0, 2)
        BackgroundImage = My.Resources.Resources.rangee_serviette_douce_coloree_pliee_fond_bleu_23_2148184406
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1164, 706)
        Controls.Add(Suivant)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Padding = New Padding(0, 20, 20, 30)
        StartPosition = FormStartPosition.CenterScreen
        Text = "."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Suivant As Button

End Class
