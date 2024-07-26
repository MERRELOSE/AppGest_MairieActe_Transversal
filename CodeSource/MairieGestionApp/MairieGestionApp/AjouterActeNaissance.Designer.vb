<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterActeNaissance
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        GroupBox8 = New GroupBox()
        BtnAnnuler = New Button()
        BtnEnregistrer = New Button()
        GroupBox7 = New GroupBox()
        RichTextBox1 = New RichTextBox()
        GroupBox4 = New GroupBox()
        TextBoxCommuneNaissance = New TextBox()
        TextBoxReference = New TextBox()
        TextBoxHopital = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox3 = New GroupBox()
        GroupBox6 = New GroupBox()
        TextBoxPrenomMere = New TextBox()
        TextBoxNomMere = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        GroupBox5 = New GroupBox()
        TextBoxPrenomPere = New TextBox()
        TextBoxNomPere = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        DateTimePickerDateNaissance = New DateTimePicker()
        TextBoxPrenomEnfant = New TextBox()
        TextBoxNomEnfant = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox8.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox8)
        GroupBox1.Controls.Add(GroupBox7)
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.FlatStyle = FlatStyle.System
        GroupBox1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(717, 520)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "INFORMATIONS"
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Controls.Add(BtnAnnuler)
        GroupBox8.Controls.Add(BtnEnregistrer)
        GroupBox8.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox8.Location = New Point(572, 187)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(126, 154)
        GroupBox8.TabIndex = 4
        GroupBox8.TabStop = False
        GroupBox8.Text = "ACTIONS"
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.BackColor = Color.Red
        BtnAnnuler.Cursor = Cursors.Hand
        BtnAnnuler.ForeColor = Color.White
        BtnAnnuler.Location = New Point(6, 90)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(114, 32)
        BtnAnnuler.TabIndex = 1
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = False
        ' 
        ' BtnEnregistrer
        ' 
        BtnEnregistrer.BackColor = Color.DeepSkyBlue
        BtnEnregistrer.Cursor = Cursors.Hand
        BtnEnregistrer.Location = New Point(6, 30)
        BtnEnregistrer.Name = "BtnEnregistrer"
        BtnEnregistrer.Size = New Size(114, 32)
        BtnEnregistrer.TabIndex = 11
        BtnEnregistrer.Text = "Enrégistrer"
        BtnEnregistrer.UseVisualStyleBackColor = False
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(RichTextBox1)
        GroupBox7.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox7.Location = New Point(572, 20)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(126, 138)
        GroupBox7.TabIndex = 3
        GroupBox7.TabStop = False
        GroupBox7.Text = "Notification"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.DodgerBlue
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Font = New Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.ForeColor = Color.White
        RichTextBox1.Location = New Point(3, 14)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(120, 121)
        RichTextBox1.TabIndex = 100
        RichTextBox1.Text = "Pour ajouter un acte de naissance, veuillez renseignez tous les champs présent et cliquez sur le bouton ""Enrégistrer"" !"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(TextBoxCommuneNaissance)
        GroupBox4.Controls.Add(TextBoxReference)
        GroupBox4.Controls.Add(TextBoxHopital)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(288, 20)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(266, 138)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        GroupBox4.Text = "AUTRES"
        ' 
        ' TextBoxCommuneNaissance
        ' 
        TextBoxCommuneNaissance.Location = New Point(95, 63)
        TextBoxCommuneNaissance.Name = "TextBoxCommuneNaissance"
        TextBoxCommuneNaissance.Size = New Size(165, 18)
        TextBoxCommuneNaissance.TabIndex = 5
        ' 
        ' TextBoxReference
        ' 
        TextBoxReference.Location = New Point(95, 26)
        TextBoxReference.Name = "TextBoxReference"
        TextBoxReference.Size = New Size(165, 18)
        TextBoxReference.TabIndex = 4
        ' 
        ' TextBoxHopital
        ' 
        TextBoxHopital.Location = New Point(95, 98)
        TextBoxHopital.Name = "TextBoxHopital"
        TextBoxHopital.Size = New Size(165, 18)
        TextBoxHopital.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 13)
        Label10.TabIndex = 11
        Label10.Text = "Num référence :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 65)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 13)
        Label11.TabIndex = 12
        Label11.Text = "Commune :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 101)
        Label12.Name = "Label12"
        Label12.Size = New Size(54, 13)
        Label12.TabIndex = 13
        Label12.Text = "Hôpital :"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(GroupBox6)
        GroupBox3.Controls.Add(GroupBox5)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(19, 187)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(535, 154)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "IDENTITÉ DES PARENTS"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(TextBoxPrenomMere)
        GroupBox6.Controls.Add(TextBoxNomMere)
        GroupBox6.Controls.Add(Label9)
        GroupBox6.Controls.Add(Label2)
        GroupBox6.Location = New Point(269, 17)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(260, 121)
        GroupBox6.TabIndex = 2
        GroupBox6.TabStop = False
        GroupBox6.Text = "MÈRE"
        ' 
        ' TextBoxPrenomMere
        ' 
        TextBoxPrenomMere.Location = New Point(89, 73)
        TextBoxPrenomMere.Name = "TextBoxPrenomMere"
        TextBoxPrenomMere.Size = New Size(165, 18)
        TextBoxPrenomMere.TabIndex = 10
        ' 
        ' TextBoxNomMere
        ' 
        TextBoxNomMere.Location = New Point(89, 36)
        TextBoxNomMere.Name = "TextBoxNomMere"
        TextBoxNomMere.Size = New Size(165, 18)
        TextBoxNomMere.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 76)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 13)
        Label9.TabIndex = 17
        Label9.Text = "Prénoms :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 13)
        Label2.TabIndex = 16
        Label2.Text = "Nom :"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(TextBoxPrenomPere)
        GroupBox5.Controls.Add(TextBoxNomPere)
        GroupBox5.Controls.Add(Label3)
        GroupBox5.Controls.Add(Label4)
        GroupBox5.Location = New Point(6, 17)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(250, 121)
        GroupBox5.TabIndex = 1
        GroupBox5.TabStop = False
        GroupBox5.Text = "PÈRE"
        ' 
        ' TextBoxPrenomPere
        ' 
        TextBoxPrenomPere.Location = New Point(79, 73)
        TextBoxPrenomPere.Name = "TextBoxPrenomPere"
        TextBoxPrenomPere.Size = New Size(165, 18)
        TextBoxPrenomPere.TabIndex = 8
        ' 
        ' TextBoxNomPere
        ' 
        TextBoxNomPere.Location = New Point(79, 36)
        TextBoxNomPere.Name = "TextBoxNomPere"
        TextBoxNomPere.Size = New Size(165, 18)
        TextBoxNomPere.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 13)
        Label3.TabIndex = 2
        Label3.Text = "Prénoms :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 13)
        Label4.TabIndex = 3
        Label4.Text = "Nom :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DateTimePickerDateNaissance)
        GroupBox2.Controls.Add(TextBoxPrenomEnfant)
        GroupBox2.Controls.Add(TextBoxNomEnfant)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(19, 20)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(256, 138)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "IDENTITÉ DE L'ENFANT"
        ' 
        ' DateTimePickerDateNaissance
        ' 
        DateTimePickerDateNaissance.Location = New Point(85, 98)
        DateTimePickerDateNaissance.Name = "DateTimePickerDateNaissance"
        DateTimePickerDateNaissance.Size = New Size(165, 18)
        DateTimePickerDateNaissance.TabIndex = 3
        ' 
        ' TextBoxPrenomEnfant
        ' 
        TextBoxPrenomEnfant.Location = New Point(85, 61)
        TextBoxPrenomEnfant.Name = "TextBoxPrenomEnfant"
        TextBoxPrenomEnfant.Size = New Size(165, 18)
        TextBoxPrenomEnfant.TabIndex = 2
        ' 
        ' TextBoxNomEnfant
        ' 
        TextBoxNomEnfant.Location = New Point(85, 23)
        TextBoxNomEnfant.Name = "TextBoxNomEnfant"
        TextBoxNomEnfant.Size = New Size(165, 18)
        TextBoxNomEnfant.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 13)
        Label5.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 13)
        Label6.TabIndex = 5
        Label6.Text = "Birthday :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 13)
        Label7.TabIndex = 6
        Label7.Text = "Prénoms :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 13)
        Label8.TabIndex = 7
        Label8.Text = "Nom :"
        ' 
        ' AjouterActeNaissance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(740, 544)
        Controls.Add(GroupBox1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        MinimizeBox = False
        Name = "AjouterActeNaissance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ajouter un Acte de Naissance"
        GroupBox1.ResumeLayout(False)
        GroupBox8.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub


    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxPrenomPere As TextBox
    Friend WithEvents TextBoxNomPere As TextBox
    Friend WithEvents TextBoxPrenomEnfant As TextBox
    Friend WithEvents TextBoxNomEnfant As TextBox
    Friend WithEvents DateTimePickerDateNaissance As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxHopital As TextBox
    Friend WithEvents TextBoxReference As TextBox
    Friend WithEvents TextBoxCommuneNaissance As TextBox
    Friend WithEvents TextBoxPrenomMere As TextBox
    Friend WithEvents TextBoxNomMere As TextBox
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents RichTextBox1 As RichTextBox

End Class
