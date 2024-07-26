Imports System.Configuration
Imports System.Data.SqlClient

Public Class LoginForm

    Public Function TestConnection() As Boolean
        Dim connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Return True
            Catch ex As SqlException
                MessageBox.Show("Erreur de connexion à la base de données : " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Récupérer les informations de connexion
        Dim username As String = txtNomUtilisateur.Text
        Dim password As String = txtMotDePasse.Text


        ' Vérifier les informations de connexion avec la base de données
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MairieDB").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM Utilisateurs WHERE NomUtilisateur = @username AND MotDePasse = @password"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    ' Si la connexion est réussie, afficher le formulaire principal avec le message de succès
                    Dim mainForm As New MainForm()
                    mainForm.ConnexionReussie = True ' Définir la propriété
                    mainForm.NomUtilisateur = username ' Passer le nom de l'utilisateur
                    mainForm.Show()
                    mainForm.Show()
                    Me.Hide()
                Else
                    ' Si la connexion échoue, afficher un message d'erreur
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not TestConnection() Then
            MessageBox.Show("Impossible de se connecter à la base de données. L'application va se fermer.")
            Application.Exit()
        End If

        ' Configure PictureBox to show the closed eye by default
        PictureBoxShowPassword.Image = My.Resources.EyeClosed ' Nom de l'image pour l'œil fermé
        txtMotDePasse.UseSystemPasswordChar = True

        ' Ajouter l'événement KeyDown pour chaque TextBox
        AddHandler txtNomUtilisateur.KeyDown, AddressOf TextBox_KeyDown
        AddHandler txtMotDePasse.KeyDown, AddressOf TextBox_KeyDown
    End Sub


    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        ' Vérifier si la touche Enter a été pressée
        If e.KeyCode = Keys.Enter Then
            ' Empêcher le bip sonore par défaut
            e.SuppressKeyPress = True

            ' Déplacer le focus au contrôle suivant
            Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        ' Demander à l'utilisateur s'il est sûr de vouloir quitter
        Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxShowPassword.Click
        ' Toggle password visibility
        If txtMotDePasse.UseSystemPasswordChar Then
            ' Show password
            txtMotDePasse.UseSystemPasswordChar = False
            PictureBoxShowPassword.Image = My.Resources.EyeOpen ' Nom de l'image pour l'œil ouvert
        Else
            ' Hide password
            txtMotDePasse.UseSystemPasswordChar = True
            PictureBoxShowPassword.Image = My.Resources.EyeClosed ' Nom de l'image pour l'œil fermé
        End If
    End Sub
End Class
