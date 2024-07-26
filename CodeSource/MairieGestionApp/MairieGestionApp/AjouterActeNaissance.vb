Imports System.Data.SqlClient

Public Class AjouterActeNaissance

    Private Sub AjouterActeNaissance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Définir le focus sur le premier TextBox
        TextBoxNomEnfant.Focus()

        ' Ajouter l'événement KeyDown pour chaque TextBox
        AddHandler TextBoxNomEnfant.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomEnfant.KeyDown, AddressOf TextBox_KeyDown
        AddHandler DateTimePickerDateNaissance.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxCommuneNaissance.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxHopital.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomPere.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomPere.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomMere.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomMere.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxReference.KeyDown, AddressOf TextBox_KeyDown
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

    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        Try
            ' Récupérer les valeurs des champs du formulaire
            Dim nomEnfant As String = TextBoxNomEnfant.Text
            Dim prenomEnfant As String = TextBoxPrenomEnfant.Text
            Dim dateNaissance As Date = DateTimePickerDateNaissance.Value
            Dim commune As String = TextBoxCommuneNaissance.Text
            Dim hopital As String = TextBoxHopital.Text
            Dim nomPere As String = TextBoxNomPere.Text
            Dim prenomPere As String = TextBoxPrenomPere.Text
            Dim nomMere As String = TextBoxNomMere.Text
            Dim prenomMere As String = TextBoxPrenomMere.Text
            Dim reference As String = TextBoxReference.Text

            ' Connexion à la base de données
            Dim connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Requête SQL pour insérer les données dans la table Naissance
                Dim query As String = "INSERT INTO Naissance (NomEnfant, PrenomEnfant, DateNaissance, Commune, Hopital, NomPere, PrenomPere, NomMere, PrenomMere, Reference) VALUES (@NomEnfant, @PrenomEnfant, @DateNaissance, @Commune, @Hopital, @NomPere, @PrenomPere, @NomMere, @PrenomMere, @Reference)"
                Using command As New SqlCommand(query, connection)
                    ' Ajouter les paramètres avec les valeurs
                    command.Parameters.AddWithValue("@NomEnfant", nomEnfant)
                    command.Parameters.AddWithValue("@PrenomEnfant", prenomEnfant)
                    command.Parameters.AddWithValue("@DateNaissance", dateNaissance)
                    command.Parameters.AddWithValue("@Commune", commune)
                    command.Parameters.AddWithValue("@Hopital", hopital)
                    command.Parameters.AddWithValue("@NomPere", nomPere)
                    command.Parameters.AddWithValue("@PrenomPere", prenomPere)
                    command.Parameters.AddWithValue("@NomMere", nomMere)
                    command.Parameters.AddWithValue("@PrenomMere", prenomMere)
                    command.Parameters.AddWithValue("@Reference", reference)

                    ' Exécuter la commande SQL
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Afficher un message de confirmation
            MessageBox.Show("Ajout effectué avec succès")

            ' Rafraîchir le DataGridView dans le formulaire ListeActeNaissance
            Dim listeActeNaissanceForm As New ListeActeNaissance()
            listeActeNaissanceForm.RefreshData()

            ' Fermer le formulaire d'ajout après l'insertion des données
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        ' Fermer la page 
        Me.Close()
    End Sub
End Class