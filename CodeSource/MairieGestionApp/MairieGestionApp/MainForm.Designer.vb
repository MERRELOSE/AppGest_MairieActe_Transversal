<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
    ' Déclaration du Label pour le message de connexion
    Private lblMessageConnexion As Label

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        BtnNaissance = New Button()
        BtnMariage = New Button()
        BtnVenteTerrain = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ContextMenuStrip2 = New ContextMenuStrip(components)
        Panel1 = New Panel()
        Label10 = New Label()
        BtnDeconnexion = New Button()
        BtnAccueil = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        LblTitle = New Label()
        PnlAccueil = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel7 = New Panel()
        Btn2VenteTerrain = New Button()
        Panel6 = New Panel()
        Btn2Mariage = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel5 = New Panel()
        Btn2Naissance = New Button()
        Label2 = New Label()
        Label1 = New Label()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        lblMessageConnexion = New Label()
        Label11 = New Label()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        PnlAccueil.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnNaissance
        ' 
        BtnNaissance.BackColor = Color.DeepSkyBlue
        BtnNaissance.Cursor = Cursors.Hand
        BtnNaissance.FlatAppearance.BorderColor = Color.Gray
        BtnNaissance.FlatAppearance.BorderSize = 2
        BtnNaissance.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNaissance.ForeColor = Color.Black
        BtnNaissance.Image = CType(resources.GetObject("BtnNaissance.Image"), Image)
        BtnNaissance.Location = New Point(0, 146)
        BtnNaissance.Name = "BtnNaissance"
        BtnNaissance.Size = New Size(171, 44)
        BtnNaissance.TabIndex = 0
        BtnNaissance.Text = " NAISSANCE"
        BtnNaissance.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnNaissance.UseVisualStyleBackColor = False
        ' 
        ' BtnMariage
        ' 
        BtnMariage.BackColor = Color.DeepSkyBlue
        BtnMariage.Cursor = Cursors.Hand
        BtnMariage.FlatAppearance.BorderColor = Color.Gray
        BtnMariage.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnMariage.ForeColor = Color.Black
        BtnMariage.Image = CType(resources.GetObject("BtnMariage.Image"), Image)
        BtnMariage.Location = New Point(0, 193)
        BtnMariage.Name = "BtnMariage"
        BtnMariage.Size = New Size(171, 44)
        BtnMariage.TabIndex = 1
        BtnMariage.Text = " MARIAGE"
        BtnMariage.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMariage.UseVisualStyleBackColor = False
        ' 
        ' BtnVenteTerrain
        ' 
        BtnVenteTerrain.BackColor = Color.DeepSkyBlue
        BtnVenteTerrain.Cursor = Cursors.Hand
        BtnVenteTerrain.FlatAppearance.BorderColor = Color.Gray
        BtnVenteTerrain.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVenteTerrain.ForeColor = Color.Black
        BtnVenteTerrain.Image = CType(resources.GetObject("BtnVenteTerrain.Image"), Image)
        BtnVenteTerrain.Location = New Point(0, 241)
        BtnVenteTerrain.Name = "BtnVenteTerrain"
        BtnVenteTerrain.Size = New Size(171, 44)
        BtnVenteTerrain.TabIndex = 2
        BtnVenteTerrain.Text = " TERRAIN"
        BtnVenteTerrain.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnVenteTerrain.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(BtnDeconnexion)
        Panel1.Controls.Add(BtnAccueil)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(BtnMariage)
        Panel1.Controls.Add(BtnNaissance)
        Panel1.Controls.Add(BtnVenteTerrain)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(171, 538)
        Panel1.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(33, 60)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 18)
        Label10.TabIndex = 12
        Label10.Text = "CITY HALL"
        ' 
        ' BtnDeconnexion
        ' 
        BtnDeconnexion.BackColor = Color.Red
        BtnDeconnexion.Cursor = Cursors.Hand
        BtnDeconnexion.FlatAppearance.BorderColor = Color.Gray
        BtnDeconnexion.FlatStyle = FlatStyle.Flat
        BtnDeconnexion.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDeconnexion.ForeColor = Color.White
        BtnDeconnexion.Location = New Point(0, 507)
        BtnDeconnexion.Name = "BtnDeconnexion"
        BtnDeconnexion.Size = New Size(171, 31)
        BtnDeconnexion.TabIndex = 11
        BtnDeconnexion.Text = "DECONNEXION" & vbCrLf
        BtnDeconnexion.UseVisualStyleBackColor = False
        ' 
        ' BtnAccueil
        ' 
        BtnAccueil.BackColor = Color.DeepSkyBlue
        BtnAccueil.Cursor = Cursors.Hand
        BtnAccueil.FlatAppearance.BorderColor = Color.Gray
        BtnAccueil.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAccueil.ForeColor = Color.Black
        BtnAccueil.Image = CType(resources.GetObject("BtnAccueil.Image"), Image)
        BtnAccueil.Location = New Point(0, 99)
        BtnAccueil.Name = "BtnAccueil"
        BtnAccueil.Size = New Size(171, 44)
        BtnAccueil.TabIndex = 9
        BtnAccueil.Text = " ACCUEIL"
        BtnAccueil.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnAccueil.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(171, 47)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(711, 491)
        Panel3.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(50, 5, 0, 0)
        PictureBox1.Size = New Size(171, 538)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DodgerBlue
        Panel2.Controls.Add(LblTitle)
        Panel2.Dock = DockStyle.Top
        Panel2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(171, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(711, 77)
        Panel2.TabIndex = 7
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTitle.ForeColor = Color.Cornsilk
        LblTitle.Location = New Point(138, 22)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(434, 31)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Système de Gestion de la Mairie"
        ' 
        ' PnlAccueil
        ' 
        PnlAccueil.BackColor = Color.White
        PnlAccueil.Controls.Add(Label9)
        PnlAccueil.Controls.Add(Label8)
        PnlAccueil.Controls.Add(Label7)
        PnlAccueil.Controls.Add(Panel7)
        PnlAccueil.Controls.Add(Panel6)
        PnlAccueil.Controls.Add(Label6)
        PnlAccueil.Controls.Add(Label5)
        PnlAccueil.Controls.Add(Label4)
        PnlAccueil.Controls.Add(Label3)
        PnlAccueil.Controls.Add(Panel5)
        PnlAccueil.Controls.Add(Label2)
        PnlAccueil.Controls.Add(Label1)
        PnlAccueil.Controls.Add(Panel4)
        PnlAccueil.Location = New Point(171, 75)
        PnlAccueil.Name = "PnlAccueil"
        PnlAccueil.Size = New Size(711, 463)
        PnlAccueil.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(521, 406)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 15)
        Label9.TabIndex = 10
        Label9.Text = "Email :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(321, 406)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 15)
        Label8.TabIndex = 9
        Label8.Text = "Téléphone :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(40, 406)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 15)
        Label7.TabIndex = 8
        Label7.Text = "Adresse :"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Gray
        Panel7.Controls.Add(Btn2VenteTerrain)
        Panel7.Location = New Point(483, 135)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(197, 182)
        Panel7.TabIndex = 4
        ' 
        ' Btn2VenteTerrain
        ' 
        Btn2VenteTerrain.Cursor = Cursors.Hand
        Btn2VenteTerrain.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn2VenteTerrain.Image = CType(resources.GetObject("Btn2VenteTerrain.Image"), Image)
        Btn2VenteTerrain.Location = New Point(13, 6)
        Btn2VenteTerrain.Name = "Btn2VenteTerrain"
        Btn2VenteTerrain.Size = New Size(170, 170)
        Btn2VenteTerrain.TabIndex = 0
        Btn2VenteTerrain.Text = "Acte de Vente de Terrain"
        Btn2VenteTerrain.TextImageRelation = TextImageRelation.TextAboveImage
        Btn2VenteTerrain.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Gray
        Panel6.Controls.Add(Btn2Mariage)
        Panel6.Location = New Point(255, 135)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(197, 182)
        Panel6.TabIndex = 3
        ' 
        ' Btn2Mariage
        ' 
        Btn2Mariage.Cursor = Cursors.Hand
        Btn2Mariage.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn2Mariage.Image = CType(resources.GetObject("Btn2Mariage.Image"), Image)
        Btn2Mariage.Location = New Point(13, 6)
        Btn2Mariage.Name = "Btn2Mariage"
        Btn2Mariage.Size = New Size(170, 170)
        Btn2Mariage.TabIndex = 0
        Btn2Mariage.Text = "Acte de Mariage"
        Btn2Mariage.TextImageRelation = TextImageRelation.TextAboveImage
        Btn2Mariage.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(568, 405)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 15)
        Label6.TabIndex = 7
        Label6.Text = "contact@mairie.fr"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(393, 405)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 15)
        Label5.TabIndex = 6
        Label5.Text = "01 23 45 67 89"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(94, 405)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 15)
        Label4.TabIndex = 5
        Label4.Text = "123 Rue de la République, Ville"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 357)
        Label3.Name = "Label3"
        Label3.Size = New Size(294, 16)
        Label3.TabIndex = 4
        Label3.Text = "Contactez-nous pour plus d'informations : "
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Gray
        Panel5.Controls.Add(Btn2Naissance)
        Panel5.Location = New Point(29, 135)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(197, 182)
        Panel5.TabIndex = 2
        ' 
        ' Btn2Naissance
        ' 
        Btn2Naissance.Cursor = Cursors.Hand
        Btn2Naissance.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn2Naissance.Image = CType(resources.GetObject("Btn2Naissance.Image"), Image)
        Btn2Naissance.Location = New Point(13, 6)
        Btn2Naissance.Name = "Btn2Naissance"
        Btn2Naissance.Size = New Size(170, 170)
        Btn2Naissance.TabIndex = 0
        Btn2Naissance.Text = "Acte de Naissance"
        Btn2Naissance.TextImageRelation = TextImageRelation.TextAboveImage
        Btn2Naissance.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(40, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(657, 18)
        Label2.TabIndex = 1
        Label2.Text = "Veuillez sélectionner une option pour commencer la gestion des actes de déclaration :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label1.Location = New Point(29, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(667, 20)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenue dans l'application de gestion des actes de déclaration de votre Mairie :)"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(171, 516)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(711, 22)
        StatusStrip1.TabIndex = 9
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(0, 17)
        ' 
        ' lblMessageConnexion
        ' 
        lblMessageConnexion.AutoSize = True
        lblMessageConnexion.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMessageConnexion.ForeColor = Color.Green
        lblMessageConnexion.Location = New Point(400, 60)
        lblMessageConnexion.Name = "lblMessageConnexion"
        lblMessageConnexion.Size = New Size(0, 17)
        lblMessageConnexion.TabIndex = 10
        lblMessageConnexion.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.DodgerBlue
        Label11.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(106, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(121, 15)
        Label11.TabIndex = 11
        Label11.Text = "NOS RUBRIQUES"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DodgerBlue
        Panel4.Controls.Add(Label11)
        Panel4.Location = New Point(15, 86)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(681, 259)
        Panel4.TabIndex = 12
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 538)
        Controls.Add(StatusStrip1)
        Controls.Add(PnlAccueil)
        Controls.Add(lblMessageConnexion)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Page d'accueil"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        PnlAccueil.ResumeLayout(False)
        PnlAccueil.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnNaissance As Button
    Friend WithEvents BtnMariage As Button
    Friend WithEvents BtnVenteTerrain As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAccueil As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PnlAccueil As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents BtnDeconnexion As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn2Naissance As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Btn2VenteTerrain As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn2Mariage As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel


End Class
