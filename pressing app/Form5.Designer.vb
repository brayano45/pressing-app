<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        nom = New TextBox()
        email = New TextBox()
        adresse = New TextBox()
        numero = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.Font = New Font("Elephant", 29.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(265, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(655, 64)
        Label1.TabIndex = 0
        Label1.Text = "Enregistrement du client"
        ' 
        ' nom
        ' 
        nom.BackColor = Color.DeepSkyBlue
        nom.Font = New Font("Dubai", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nom.Location = New Point(399, 206)
        nom.Name = "nom"
        nom.PlaceholderText = "Nom"
        nom.Size = New Size(394, 46)
        nom.TabIndex = 1
        ' 
        ' email
        ' 
        email.BackColor = Color.DeepSkyBlue
        email.Font = New Font("Dubai", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        email.Location = New Point(399, 310)
        email.Name = "email"
        email.PlaceholderText = "Email"
        email.Size = New Size(394, 46)
        email.TabIndex = 2
        ' 
        ' adresse
        ' 
        adresse.BackColor = Color.DeepSkyBlue
        adresse.Font = New Font("Dubai", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        adresse.Location = New Point(399, 362)
        adresse.Name = "adresse"
        adresse.PlaceholderText = "Adresse"
        adresse.Size = New Size(394, 46)
        adresse.TabIndex = 3
        ' 
        ' numero
        ' 
        numero.BackColor = Color.DeepSkyBlue
        numero.Font = New Font("Dubai", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numero.Location = New Point(399, 258)
        numero.Name = "numero"
        numero.PlaceholderText = "Numero"
        numero.Size = New Size(394, 46)
        numero.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Dubai", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(487, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(212, 45)
        Button1.TabIndex = 5
        Button1.Text = "Enregistrement"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.pngtree_vector_back_icon_png_image_931209_removebg_preview
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(12, 634)
        Button2.Name = "Button2"
        Button2.Size = New Size(54, 42)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        BackgroundImage = My.Resources.Resources.front_view_pile_towels_with_iron
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1177, 688)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(numero)
        Controls.Add(adresse)
        Controls.Add(email)
        Controls.Add(nom)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents adresse As TextBox
    Friend WithEvents numero As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
