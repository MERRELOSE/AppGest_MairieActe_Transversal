Imports System.Windows.Forms

Public Class MainForm

    Public Property NomUtilisateur As String ' Propriété pour le nom de l'utilisateur connecté
    Public Property ConnexionReussie As Boolean = False ' Propriété pour indiquer la réussite de la connexion

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Afficher le nom de l'utilisateur connecté


        If ConnexionReussie Then
            lblMessageConnexion.Text = "Connexion réussie !"
            lblMessageConnexion.ForeColor = Color.Green
            lblMessageConnexion.Visible = True
            Dim timer As New Timer()
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Interval = 3000 ' 3 secondes
            timer.Start()
        End If

        If ConnexionReussie Then
            ToolStripStatusLabel1.Text = "Connecté en tant que : @" & NomUtilisateur
            ToolStripStatusLabel1.ForeColor = Color.Green
            ToolStripStatusLabel1.Visible = True
        End If


        ' Initialisation du formulaire
        ' Afficher le panneau d'accueil par défaut
        ShowAccueilPanel()

    End Sub

    Private Sub OnTimerTick(sender As Object, e As EventArgs)
        lblMessageConnexion.Visible = False
        CType(sender, Timer).Stop()
    End Sub

    Private Sub ShowAccueilPanel()
        PnlAccueil.Visible = True
        ' Cacher les autres panneaux si nécessaire
        ' Panneau3, Panneau4, etc. à ajouter selon votre besoin
    End Sub

    Private Sub BtnAccueil_Click(sender As Object, e As EventArgs) Handles BtnAccueil.Click
        ShowAccueilPanel()
    End Sub

    Private Sub BtnNaissance_Click(sender As Object, e As EventArgs) Handles BtnNaissance.Click
        Dim frmNaissance As New ListeActeNaissance()
        frmNaissance.Show()
    End Sub

    Private Sub BtnMariage_Click(sender As Object, e As EventArgs) Handles BtnMariage.Click
        Dim frmMariage As New ListeActeMariage()
        frmMariage.Show()
    End Sub

    Private Sub BtnVenteTerrain_Click(sender As Object, e As EventArgs) Handles BtnVenteTerrain.Click
        Dim frmVenteTerrain As New ListeActeVenteTerrain()
        frmVenteTerrain.Show()
    End Sub

    Private Sub BtnDeconnexion_Click(sender As Object, e As EventArgs) Handles BtnDeconnexion.Click
        Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Btn2Naissance_Click(sender As Object, e As EventArgs) Handles Btn2Naissance.Click
        BtnNaissance_Click(sender, e)
    End Sub

    Private Sub Btn2Mariage_Click(sender As Object, e As EventArgs) Handles Btn2Mariage.Click
        BtnMariage_Click(sender, e)
    End Sub

    Private Sub Btn2VenteTerrain_Click(sender As Object, e As EventArgs) Handles Btn2VenteTerrain.Click
        BtnVenteTerrain_Click(sender, e)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class
