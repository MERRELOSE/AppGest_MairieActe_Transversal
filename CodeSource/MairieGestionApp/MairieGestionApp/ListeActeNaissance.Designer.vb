<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListeActeNaissance
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeActeNaissance))
        Panel1 = New Panel()
        LabelMessage = New Label()
        BtnRechercher = New Button()
        Label4 = New Label()
        TextBoxCommune = New TextBox()
        TextBoxHopital = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBoxNaissance = New TextBox()
        Panel2 = New Panel()
        GroupBox2 = New GroupBox()
        BtnRafraichir = New Button()
        BtnSupprimer = New Button()
        BtnModifier = New Button()
        BtnAnnuler = New Button()
        BtnAjouterNaissance = New Button()
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        ListNaissance = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        TimerMessage = New Timer(components)
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(LabelMessage)
        Panel1.Controls.Add(BtnRechercher)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBoxCommune)
        Panel1.Controls.Add(TextBoxHopital)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBoxNaissance)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(942, 543)
        Panel1.TabIndex = 0
        ' 
        ' LabelMessage
        ' 
        LabelMessage.AutoSize = True
        LabelMessage.BackColor = Color.DodgerBlue
        LabelMessage.Font = New Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelMessage.ForeColor = Color.Green
        LabelMessage.Location = New Point(397, 9)
        LabelMessage.Name = "LabelMessage"
        LabelMessage.Size = New Size(0, 17)
        LabelMessage.TabIndex = 12
        LabelMessage.Visible = False
        ' 
        ' BtnRechercher
        ' 
        BtnRechercher.BackColor = Color.DeepSkyBlue
        BtnRechercher.Cursor = Cursors.Hand
        BtnRechercher.Location = New Point(519, 43)
        BtnRechercher.Name = "BtnRechercher"
        BtnRechercher.Size = New Size(114, 33)
        BtnRechercher.TabIndex = 4
        BtnRechercher.Text = "Rechercher"
        BtnRechercher.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(422, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 10
        Label4.Text = "Hôpital"
        ' 
        ' TextBoxCommune
        ' 
        TextBoxCommune.Location = New Point(306, 48)
        TextBoxCommune.Name = "TextBoxCommune"
        TextBoxCommune.Size = New Size(110, 21)
        TextBoxCommune.TabIndex = 9
        ' 
        ' TextBoxHopital
        ' 
        TextBoxHopital.Location = New Point(422, 48)
        TextBoxHopital.Name = "TextBoxHopital"
        TextBoxHopital.Size = New Size(91, 21)
        TextBoxHopital.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(306, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 6
        Label3.Text = "Commune"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 17)
        Label2.TabIndex = 5
        Label2.Text = "Filtrer la liste par :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(138, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 4
        Label1.Text = "Nom/Prénom"
        ' 
        ' TextBoxNaissance
        ' 
        TextBoxNaissance.Location = New Point(138, 48)
        TextBoxNaissance.Name = "TextBoxNaissance"
        TextBoxNaissance.Size = New Size(162, 21)
        TextBoxNaissance.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Location = New Point(805, 77)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(126, 108)
        Panel2.TabIndex = 2
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BtnRafraichir)
        GroupBox2.Controls.Add(BtnSupprimer)
        GroupBox2.Controls.Add(BtnModifier)
        GroupBox2.Controls.Add(BtnAnnuler)
        GroupBox2.Controls.Add(BtnAjouterNaissance)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Location = New Point(805, 260)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(126, 272)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "ACTIONS"
        ' 
        ' BtnRafraichir
        ' 
        BtnRafraichir.BackColor = Color.DeepSkyBlue
        BtnRafraichir.Cursor = Cursors.Hand
        BtnRafraichir.Location = New Point(6, 132)
        BtnRafraichir.Name = "BtnRafraichir"
        BtnRafraichir.Size = New Size(114, 32)
        BtnRafraichir.TabIndex = 4
        BtnRafraichir.Text = "Rafraîchir"
        BtnRafraichir.UseVisualStyleBackColor = False
        ' 
        ' BtnSupprimer
        ' 
        BtnSupprimer.BackColor = Color.Red
        BtnSupprimer.Cursor = Cursors.Hand
        BtnSupprimer.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSupprimer.ForeColor = Color.White
        BtnSupprimer.Location = New Point(6, 232)
        BtnSupprimer.Name = "BtnSupprimer"
        BtnSupprimer.Size = New Size(114, 32)
        BtnSupprimer.TabIndex = 3
        BtnSupprimer.Text = "Supprimer"
        BtnSupprimer.UseVisualStyleBackColor = False
        ' 
        ' BtnModifier
        ' 
        BtnModifier.BackColor = Color.DeepSkyBlue
        BtnModifier.Cursor = Cursors.Hand
        BtnModifier.Location = New Point(6, 82)
        BtnModifier.Name = "BtnModifier"
        BtnModifier.Size = New Size(114, 32)
        BtnModifier.TabIndex = 2
        BtnModifier.Text = "Modifier"
        BtnModifier.UseVisualStyleBackColor = False
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.BackColor = Color.DeepSkyBlue
        BtnAnnuler.Cursor = Cursors.Hand
        BtnAnnuler.Location = New Point(6, 182)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(114, 32)
        BtnAnnuler.TabIndex = 1
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = False
        ' 
        ' BtnAjouterNaissance
        ' 
        BtnAjouterNaissance.BackColor = Color.DeepSkyBlue
        BtnAjouterNaissance.Cursor = Cursors.Hand
        BtnAjouterNaissance.Location = New Point(6, 32)
        BtnAjouterNaissance.Name = "BtnAjouterNaissance"
        BtnAjouterNaissance.Size = New Size(114, 32)
        BtnAjouterNaissance.TabIndex = 0
        BtnAjouterNaissance.Text = "Ajouter"
        BtnAjouterNaissance.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(ListNaissance)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 77)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(773, 455)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "LISTE DES ACTES DE NAISSANCE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(6, 20)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(761, 427)
        DataGridView1.TabIndex = 11
        ' 
        ' ListNaissance
        ' 
        ListNaissance.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10})
        ListNaissance.GridLines = True
        ListNaissance.Location = New Point(6, 20)
        ListNaissance.Name = "ListNaissance"
        ListNaissance.Size = New Size(709, 323)
        ListNaissance.TabIndex = 0
        ListNaissance.UseCompatibleStateImageBehavior = False
        ListNaissance.View = View.Details
        ListNaissance.Visible = False
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Nom"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Prénoms"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Date"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Commune"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Hôpital"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Nom Père"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Prénoms Père"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Nom Mère"
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Prénoms Mère"
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Référence"
        ' 
        ' TimerMessage
        ' 
        TimerMessage.Interval = 3000
        ' 
        ' ListeActeNaissance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(943, 544)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "ListeActeNaissance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Liste des Actes de Naissance"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAjouterNaissance As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCommune As TextBox
    Friend WithEvents TextBoxHopital As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents ListNaissance As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TimerMessage As Timer
    Friend WithEvents LabelMessage As Label
    Friend WithEvents BtnRafraichir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNaissance As TextBox
End Class
