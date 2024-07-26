<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierActeMariage
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
        GroupBox1 = New GroupBox()
        GroupBox8 = New GroupBox()
        BtnAnnuler = New Button()
        BtnEnregistrer = New Button()
        GroupBox4 = New GroupBox()
        GroupBox10 = New GroupBox()
        Label9 = New Label()
        TextBoxPrenomOfficierCelebrant = New TextBox()
        Label13 = New Label()
        TextBoxNomOfficierCelebrant = New TextBox()
        DateTimePickerDateMariage = New DateTimePicker()
        TextBoxCommuneMariage = New TextBox()
        TextBoxReference = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox7 = New GroupBox()
        RichTextBox1 = New RichTextBox()
        GroupBox3 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox11 = New GroupBox()
        Label14 = New Label()
        TextBoxPrenomTemoinEpouse2 = New TextBox()
        Label15 = New Label()
        TextBoxNomTemoinEpouse2 = New TextBox()
        GroupBox6 = New GroupBox()
        Label2 = New Label()
        TextBoxPrenomTemoinEpouse1 = New TextBox()
        Label6 = New Label()
        TextBoxNomTemoinEpouse1 = New TextBox()
        TextBoxPrenomEpouse = New TextBox()
        TextBoxNomEpouse = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        GroupBox5 = New GroupBox()
        GroupBox12 = New GroupBox()
        Label16 = New Label()
        TextBoxPrenomTemoinEpoux2 = New TextBox()
        Label17 = New Label()
        TextBoxNomTemoinEpoux2 = New TextBox()
        GroupBox9 = New GroupBox()
        Label1 = New Label()
        TextBoxPrenomTemoinEpoux1 = New TextBox()
        Label5 = New Label()
        TextBoxNomTemoinEpoux1 = New TextBox()
        TextBoxPrenomEpoux = New TextBox()
        TextBoxNomEpoux = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox8.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox10.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox11.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox12.SuspendLayout()
        GroupBox9.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DodgerBlue
        GroupBox1.Controls.Add(GroupBox8)
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(GroupBox7)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.FlatStyle = FlatStyle.System
        GroupBox1.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(14, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(721, 520)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "INFORMATIONS"
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Controls.Add(BtnAnnuler)
        GroupBox8.Controls.Add(BtnEnregistrer)
        GroupBox8.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox8.Location = New Point(583, 207)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(126, 133)
        GroupBox8.TabIndex = 4
        GroupBox8.TabStop = False
        GroupBox8.Text = "ACTIONS"
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.BackColor = Color.Red
        BtnAnnuler.Cursor = Cursors.Hand
        BtnAnnuler.ForeColor = Color.White
        BtnAnnuler.Location = New Point(6, 76)
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
        BtnEnregistrer.Location = New Point(6, 25)
        BtnEnregistrer.Name = "BtnEnregistrer"
        BtnEnregistrer.Size = New Size(114, 32)
        BtnEnregistrer.TabIndex = 3
        BtnEnregistrer.Text = "Enrégistrer"
        BtnEnregistrer.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(GroupBox10)
        GroupBox4.Controls.Add(DateTimePickerDateMariage)
        GroupBox4.Controls.Add(TextBoxCommuneMariage)
        GroupBox4.Controls.Add(TextBoxReference)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(10, 346)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(560, 138)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        GroupBox4.Text = "AUTRES"
        ' 
        ' GroupBox10
        ' 
        GroupBox10.Controls.Add(Label9)
        GroupBox10.Controls.Add(TextBoxPrenomOfficierCelebrant)
        GroupBox10.Controls.Add(Label13)
        GroupBox10.Controls.Add(TextBoxNomOfficierCelebrant)
        GroupBox10.Location = New Point(281, 26)
        GroupBox10.Name = "GroupBox10"
        GroupBox10.Size = New Size(255, 92)
        GroupBox10.TabIndex = 24
        GroupBox10.TabStop = False
        GroupBox10.Text = "OFFICIER CÉLÉBRANT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 60)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 13)
        Label9.TabIndex = 18
        Label9.Text = "Prénoms :"
        ' 
        ' TextBoxPrenomOfficierCelebrant
        ' 
        TextBoxPrenomOfficierCelebrant.Location = New Point(73, 55)
        TextBoxPrenomOfficierCelebrant.Name = "TextBoxPrenomOfficierCelebrant"
        TextBoxPrenomOfficierCelebrant.Size = New Size(165, 18)
        TextBoxPrenomOfficierCelebrant.TabIndex = 20
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(6, 30)
        Label13.Name = "Label13"
        Label13.Size = New Size(39, 13)
        Label13.TabIndex = 19
        Label13.Text = "Nom :"
        ' 
        ' TextBoxNomOfficierCelebrant
        ' 
        TextBoxNomOfficierCelebrant.Location = New Point(73, 27)
        TextBoxNomOfficierCelebrant.Name = "TextBoxNomOfficierCelebrant"
        TextBoxNomOfficierCelebrant.Size = New Size(165, 18)
        TextBoxNomOfficierCelebrant.TabIndex = 21
        ' 
        ' DateTimePickerDateMariage
        ' 
        DateTimePickerDateMariage.Location = New Point(96, 64)
        DateTimePickerDateMariage.Name = "DateTimePickerDateMariage"
        DateTimePickerDateMariage.Size = New Size(165, 18)
        DateTimePickerDateMariage.TabIndex = 11
        ' 
        ' TextBoxCommuneMariage
        ' 
        TextBoxCommuneMariage.Location = New Point(95, 101)
        TextBoxCommuneMariage.Name = "TextBoxCommuneMariage"
        TextBoxCommuneMariage.Size = New Size(165, 18)
        TextBoxCommuneMariage.TabIndex = 20
        ' 
        ' TextBoxReference
        ' 
        TextBoxReference.Location = New Point(95, 26)
        TextBoxReference.Name = "TextBoxReference"
        TextBoxReference.Size = New Size(165, 18)
        TextBoxReference.TabIndex = 21
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
        Label11.Location = New Point(6, 104)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 13)
        Label11.TabIndex = 12
        Label11.Text = "Commune :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 66)
        Label12.Name = "Label12"
        Label12.Size = New Size(91, 13)
        Label12.TabIndex = 13
        Label12.Text = "Date Mariage :"
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(RichTextBox1)
        GroupBox7.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox7.Location = New Point(583, 20)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(126, 165)
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
        RichTextBox1.Size = New Size(120, 148)
        RichTextBox1.TabIndex = 23
        RichTextBox1.Text = "Pour ajouter un acte de mariage, veuillez renseignez tous les champs présent et cliquez sur le bouton ""Enrégistrer"" !"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Controls.Add(GroupBox5)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(10, 20)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(560, 320)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "MARIÉS"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox11)
        GroupBox2.Controls.Add(GroupBox6)
        GroupBox2.Controls.Add(TextBoxPrenomEpouse)
        GroupBox2.Controls.Add(TextBoxNomEpouse)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(287, 17)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(267, 294)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "ÉPOUSE"
        ' 
        ' GroupBox11
        ' 
        GroupBox11.Controls.Add(Label14)
        GroupBox11.Controls.Add(TextBoxPrenomTemoinEpouse2)
        GroupBox11.Controls.Add(Label15)
        GroupBox11.Controls.Add(TextBoxNomTemoinEpouse2)
        GroupBox11.Location = New Point(6, 190)
        GroupBox11.Name = "GroupBox11"
        GroupBox11.Size = New Size(255, 92)
        GroupBox11.TabIndex = 24
        GroupBox11.TabStop = False
        GroupBox11.Text = "TEMOIN2"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(6, 60)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 13)
        Label14.TabIndex = 18
        Label14.Text = "Prénoms :"
        ' 
        ' TextBoxPrenomTemoinEpouse2
        ' 
        TextBoxPrenomTemoinEpouse2.Location = New Point(73, 55)
        TextBoxPrenomTemoinEpouse2.Name = "TextBoxPrenomTemoinEpouse2"
        TextBoxPrenomTemoinEpouse2.Size = New Size(165, 18)
        TextBoxPrenomTemoinEpouse2.TabIndex = 20
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(6, 30)
        Label15.Name = "Label15"
        Label15.Size = New Size(39, 13)
        Label15.TabIndex = 19
        Label15.Text = "Nom :"
        ' 
        ' TextBoxNomTemoinEpouse2
        ' 
        TextBoxNomTemoinEpouse2.Location = New Point(73, 27)
        TextBoxNomTemoinEpouse2.Name = "TextBoxNomTemoinEpouse2"
        TextBoxNomTemoinEpouse2.Size = New Size(165, 18)
        TextBoxNomTemoinEpouse2.TabIndex = 21
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(Label2)
        GroupBox6.Controls.Add(TextBoxPrenomTemoinEpouse1)
        GroupBox6.Controls.Add(Label6)
        GroupBox6.Controls.Add(TextBoxNomTemoinEpouse1)
        GroupBox6.Location = New Point(6, 91)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(255, 92)
        GroupBox6.TabIndex = 23
        GroupBox6.TabStop = False
        GroupBox6.Text = "TEMOIN1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 13)
        Label2.TabIndex = 18
        Label2.Text = "Prénoms :"
        ' 
        ' TextBoxPrenomTemoinEpouse1
        ' 
        TextBoxPrenomTemoinEpouse1.Location = New Point(73, 55)
        TextBoxPrenomTemoinEpouse1.Name = "TextBoxPrenomTemoinEpouse1"
        TextBoxPrenomTemoinEpouse1.Size = New Size(165, 18)
        TextBoxPrenomTemoinEpouse1.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 13)
        Label6.TabIndex = 19
        Label6.Text = "Nom :"
        ' 
        ' TextBoxNomTemoinEpouse1
        ' 
        TextBoxNomTemoinEpouse1.Location = New Point(73, 27)
        TextBoxNomTemoinEpouse1.Name = "TextBoxNomTemoinEpouse1"
        TextBoxNomTemoinEpouse1.Size = New Size(165, 18)
        TextBoxNomTemoinEpouse1.TabIndex = 21
        ' 
        ' TextBoxPrenomEpouse
        ' 
        TextBoxPrenomEpouse.Location = New Point(79, 59)
        TextBoxPrenomEpouse.Name = "TextBoxPrenomEpouse"
        TextBoxPrenomEpouse.Size = New Size(165, 18)
        TextBoxPrenomEpouse.TabIndex = 16
        ' 
        ' TextBoxNomEpouse
        ' 
        TextBoxNomEpouse.Location = New Point(79, 22)
        TextBoxNomEpouse.Name = "TextBoxNomEpouse"
        TextBoxNomEpouse.Size = New Size(165, 18)
        TextBoxNomEpouse.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 13)
        Label7.TabIndex = 2
        Label7.Text = "Prénoms :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 13)
        Label8.TabIndex = 3
        Label8.Text = "Nom :"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(GroupBox12)
        GroupBox5.Controls.Add(GroupBox9)
        GroupBox5.Controls.Add(TextBoxPrenomEpoux)
        GroupBox5.Controls.Add(TextBoxNomEpoux)
        GroupBox5.Controls.Add(Label3)
        GroupBox5.Controls.Add(Label4)
        GroupBox5.Location = New Point(6, 17)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(267, 294)
        GroupBox5.TabIndex = 1
        GroupBox5.TabStop = False
        GroupBox5.Text = "ÉPOUX"
        ' 
        ' GroupBox12
        ' 
        GroupBox12.Controls.Add(Label16)
        GroupBox12.Controls.Add(TextBoxPrenomTemoinEpoux2)
        GroupBox12.Controls.Add(Label17)
        GroupBox12.Controls.Add(TextBoxNomTemoinEpoux2)
        GroupBox12.Location = New Point(6, 190)
        GroupBox12.Name = "GroupBox12"
        GroupBox12.Size = New Size(255, 92)
        GroupBox12.TabIndex = 24
        GroupBox12.TabStop = False
        GroupBox12.Text = "TEMOIN2"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(6, 60)
        Label16.Name = "Label16"
        Label16.Size = New Size(63, 13)
        Label16.TabIndex = 18
        Label16.Text = "Prénoms :"
        ' 
        ' TextBoxPrenomTemoinEpoux2
        ' 
        TextBoxPrenomTemoinEpoux2.Location = New Point(73, 55)
        TextBoxPrenomTemoinEpoux2.Name = "TextBoxPrenomTemoinEpoux2"
        TextBoxPrenomTemoinEpoux2.Size = New Size(165, 18)
        TextBoxPrenomTemoinEpoux2.TabIndex = 20
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(6, 30)
        Label17.Name = "Label17"
        Label17.Size = New Size(39, 13)
        Label17.TabIndex = 19
        Label17.Text = "Nom :"
        ' 
        ' TextBoxNomTemoinEpoux2
        ' 
        TextBoxNomTemoinEpoux2.Location = New Point(73, 27)
        TextBoxNomTemoinEpoux2.Name = "TextBoxNomTemoinEpoux2"
        TextBoxNomTemoinEpoux2.Size = New Size(165, 18)
        TextBoxNomTemoinEpoux2.TabIndex = 21
        ' 
        ' GroupBox9
        ' 
        GroupBox9.Controls.Add(Label1)
        GroupBox9.Controls.Add(TextBoxPrenomTemoinEpoux1)
        GroupBox9.Controls.Add(Label5)
        GroupBox9.Controls.Add(TextBoxNomTemoinEpoux1)
        GroupBox9.Location = New Point(6, 91)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Size = New Size(255, 92)
        GroupBox9.TabIndex = 23
        GroupBox9.TabStop = False
        GroupBox9.Text = "TEMOIN1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 13)
        Label1.TabIndex = 18
        Label1.Text = "Prénoms :"
        ' 
        ' TextBoxPrenomTemoinEpoux1
        ' 
        TextBoxPrenomTemoinEpoux1.Location = New Point(73, 55)
        TextBoxPrenomTemoinEpoux1.Name = "TextBoxPrenomTemoinEpoux1"
        TextBoxPrenomTemoinEpoux1.Size = New Size(165, 18)
        TextBoxPrenomTemoinEpoux1.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 13)
        Label5.TabIndex = 19
        Label5.Text = "Nom :"
        ' 
        ' TextBoxNomTemoinEpoux1
        ' 
        TextBoxNomTemoinEpoux1.Location = New Point(73, 27)
        TextBoxNomTemoinEpoux1.Name = "TextBoxNomTemoinEpoux1"
        TextBoxNomTemoinEpoux1.Size = New Size(165, 18)
        TextBoxNomTemoinEpoux1.TabIndex = 21
        ' 
        ' TextBoxPrenomEpoux
        ' 
        TextBoxPrenomEpoux.Location = New Point(79, 59)
        TextBoxPrenomEpoux.Name = "TextBoxPrenomEpoux"
        TextBoxPrenomEpoux.Size = New Size(165, 18)
        TextBoxPrenomEpoux.TabIndex = 16
        ' 
        ' TextBoxNomEpoux
        ' 
        TextBoxNomEpoux.Location = New Point(79, 22)
        TextBoxNomEpoux.Name = "TextBoxNomEpoux"
        TextBoxNomEpoux.Size = New Size(165, 18)
        TextBoxNomEpoux.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 13)
        Label3.TabIndex = 2
        Label3.Text = "Prénoms :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 13)
        Label4.TabIndex = 3
        Label4.Text = "Nom :"
        ' 
        ' ModifierActeMariage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(749, 544)
        Controls.Add(GroupBox1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        MinimizeBox = False
        Name = "ModifierActeMariage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Modifier un Acte de Mariage"
        GroupBox1.ResumeLayout(False)
        GroupBox8.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox10.ResumeLayout(False)
        GroupBox10.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox11.ResumeLayout(False)
        GroupBox11.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox12.ResumeLayout(False)
        GroupBox12.PerformLayout()
        GroupBox9.ResumeLayout(False)
        GroupBox9.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxPrenomOfficierCelebrant As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxNomOfficierCelebrant As TextBox
    Friend WithEvents DateTimePickerDateMariage As DateTimePicker
    Friend WithEvents TextBoxCommuneMariage As TextBox
    Friend WithEvents TextBoxReference As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxPrenomTemoinEpouse2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxNomTemoinEpouse2 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPrenomTemoinEpouse1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNomTemoinEpouse1 As TextBox
    Friend WithEvents TextBoxPrenomEpouse As TextBox
    Friend WithEvents TextBoxNomEpouse As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxPrenomTemoinEpoux2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxNomTemoinEpoux2 As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPrenomTemoinEpoux1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNomTemoinEpoux1 As TextBox
    Friend WithEvents TextBoxPrenomEpoux As TextBox
    Friend WithEvents TextBoxNomEpoux As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
