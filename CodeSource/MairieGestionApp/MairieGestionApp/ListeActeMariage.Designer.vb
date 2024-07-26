<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListeActeMariage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeActeMariage))
        Panel1 = New Panel()
        LabelMessage = New Label()
        BtnRechercher = New Button()
        Label4 = New Label()
        TextBoxOfficier = New TextBox()
        TextBoxCommune = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBoxMariage = New TextBox()
        GroupBox2 = New GroupBox()
        BtnRafraichir = New Button()
        BtnSupprimer = New Button()
        BtnAnnuler = New Button()
        BtnModifier = New Button()
        BtnAjouterMariage = New Button()
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        ListMariage = New ListView()
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
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        ColumnHeader15 = New ColumnHeader()
        ColumnHeader16 = New ColumnHeader()
        ColumnHeader17 = New ColumnHeader()
        Panel2 = New Panel()
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
        Panel1.Controls.Add(TextBoxOfficier)
        Panel1.Controls.Add(TextBoxCommune)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBoxMariage)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(984, 544)
        Panel1.TabIndex = 0
        ' 
        ' LabelMessage
        ' 
        LabelMessage.AutoSize = True
        LabelMessage.Font = New Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelMessage.ForeColor = Color.Green
        LabelMessage.Location = New Point(453, 8)
        LabelMessage.Name = "LabelMessage"
        LabelMessage.Size = New Size(0, 17)
        LabelMessage.TabIndex = 22
        LabelMessage.Visible = False
        ' 
        ' BtnRechercher
        ' 
        BtnRechercher.BackColor = Color.DeepSkyBlue
        BtnRechercher.Cursor = Cursors.Hand
        BtnRechercher.Location = New Point(519, 40)
        BtnRechercher.Name = "BtnRechercher"
        BtnRechercher.Size = New Size(114, 33)
        BtnRechercher.TabIndex = 15
        BtnRechercher.Text = "Rechercher"
        BtnRechercher.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(306, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 15)
        Label4.TabIndex = 21
        Label4.Text = "Officier célébrant :"
        ' 
        ' TextBoxOfficier
        ' 
        TextBoxOfficier.Location = New Point(306, 45)
        TextBoxOfficier.Name = "TextBoxOfficier"
        TextBoxOfficier.Size = New Size(110, 21)
        TextBoxOfficier.TabIndex = 20
        ' 
        ' TextBoxCommune
        ' 
        TextBoxCommune.Location = New Point(422, 45)
        TextBoxCommune.Name = "TextBoxCommune"
        TextBoxCommune.Size = New Size(91, 21)
        TextBoxCommune.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(422, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 18
        Label3.Text = "Commune"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 17)
        Label2.TabIndex = 17
        Label2.Text = "Filtrer la liste par :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(138, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 16
        Label1.Text = "Nom/Prénom"
        ' 
        ' TextBoxMariage
        ' 
        TextBoxMariage.Location = New Point(138, 45)
        TextBoxMariage.Name = "TextBoxMariage"
        TextBoxMariage.Size = New Size(162, 21)
        TextBoxMariage.TabIndex = 14
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BtnRafraichir)
        GroupBox2.Controls.Add(BtnSupprimer)
        GroupBox2.Controls.Add(BtnAnnuler)
        GroupBox2.Controls.Add(BtnModifier)
        GroupBox2.Controls.Add(BtnAjouterMariage)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Location = New Point(834, 217)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(126, 282)
        GroupBox2.TabIndex = 12
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
        BtnSupprimer.ForeColor = Color.White
        BtnSupprimer.Location = New Point(6, 242)
        BtnSupprimer.Name = "BtnSupprimer"
        BtnSupprimer.Size = New Size(114, 32)
        BtnSupprimer.TabIndex = 3
        BtnSupprimer.Text = "Supprimer"
        BtnSupprimer.UseVisualStyleBackColor = False
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.BackColor = Color.DeepSkyBlue
        BtnAnnuler.Cursor = Cursors.Hand
        BtnAnnuler.Location = New Point(6, 187)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(114, 32)
        BtnAnnuler.TabIndex = 1
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = False
        ' 
        ' BtnModifier
        ' 
        BtnModifier.BackColor = Color.DeepSkyBlue
        BtnModifier.Cursor = Cursors.Hand
        BtnModifier.Location = New Point(6, 77)
        BtnModifier.Name = "BtnModifier"
        BtnModifier.Size = New Size(114, 32)
        BtnModifier.TabIndex = 2
        BtnModifier.Text = "Modifier"
        BtnModifier.UseVisualStyleBackColor = False
        ' 
        ' BtnAjouterMariage
        ' 
        BtnAjouterMariage.BackColor = Color.DeepSkyBlue
        BtnAjouterMariage.Cursor = Cursors.Hand
        BtnAjouterMariage.Location = New Point(6, 22)
        BtnAjouterMariage.Name = "BtnAjouterMariage"
        BtnAjouterMariage.Size = New Size(114, 32)
        BtnAjouterMariage.TabIndex = 0
        BtnAjouterMariage.Text = "Ajouter"
        BtnAjouterMariage.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(ListMariage)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(806, 425)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "LISTE DES ACTES DE MARIAGE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(7, 20)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(791, 399)
        DataGridView1.TabIndex = 22
        ' 
        ' ListMariage
        ' 
        ListMariage.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader14, ColumnHeader15, ColumnHeader16, ColumnHeader17})
        ListMariage.GridLines = True
        ListMariage.Location = New Point(6, 20)
        ListMariage.Name = "ListMariage"
        ListMariage.Size = New Size(790, 380)
        ListMariage.TabIndex = 0
        ListMariage.UseCompatibleStateImageBehavior = False
        ListMariage.View = View.Details
        ListMariage.Visible = False
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Nom Époux"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Prénoms Époux"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Nom Épouse"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Prénoms Épouse"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Date"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Commune"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Nom Témoin Époux 1 "
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Prénoms Témoin Époux 1"
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Nom Témoin Époux 2"
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Prénoms Témoin Époux 2"
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "Nom Témoin Épouse 1"
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "Prénoms Témoin Épouse 1"
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "Nom Témoin Épouse 2"
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.Text = "Prénoms Témoin Épouse 2"
        ' 
        ' ColumnHeader15
        ' 
        ColumnHeader15.Text = "Nom Officier"
        ' 
        ' ColumnHeader16
        ' 
        ColumnHeader16.Text = "Prénoms Officier"
        ' 
        ' ColumnHeader17
        ' 
        ColumnHeader17.Text = "Num Référence"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Location = New Point(834, 74)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(126, 103)
        Panel2.TabIndex = 13
        ' 
        ' TimerMessage
        ' 
        TimerMessage.Interval = 3000
        ' 
        ' ListeActeMariage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(973, 544)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "ListeActeMariage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Liste des Actes de Mariage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnRechercher As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxOfficier As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCommune As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMariage As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents BtnAjouterMariage As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListMariage As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelMessage As Label
    Friend WithEvents TimerMessage As Timer
    Friend WithEvents BtnRafraichir As Button
End Class
