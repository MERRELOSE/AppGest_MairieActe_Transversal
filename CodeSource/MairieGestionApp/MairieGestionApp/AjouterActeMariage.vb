Imports System.Data.SqlClient

Public Class AjouterActeMariage
    Private listeActeMariageForm As ListeActeMariage

    ' Constructeur qui accepte une instance de ListeActeMariage
    Public Sub New(listeActeMariageForm As ListeActeMariage)
        InitializeComponent()
        Me.listeActeMariageForm = listeActeMariageForm
    End Sub


    Private Sub AjouterActeMariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Définir le focus sur le premier TextBox
        TextBoxNomEpoux.Focus()

        ' Ajouter l'événement KeyDown pour chaque TextBox
        AddHandler TextBoxNomEpoux.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomEpoux.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomEpouse.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomEpouse.KeyDown, AddressOf TextBox_KeyDown
        AddHandler DateTimePickerDateMariage.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxCommuneMariage.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomTemoinEpoux1.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomTemoinEpoux1.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomTemoinEpoux2.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomTemoinEpoux2.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomTemoinEpouse1.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomTemoinEpouse1.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomTemoinEpouse2.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomTemoinEpouse2.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomOfficierCelebrant.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomOfficierCelebrant.KeyDown, AddressOf TextBox_KeyDown
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
            Dim nomEpoux As String = TextBoxNomEpoux.Text
            Dim prenomEpoux As String = TextBoxPrenomEpoux.Text
            Dim nomEpouse As String = TextBoxNomEpouse.Text
            Dim prenomEpouse As String = TextBoxPrenomEpouse.Text
            Dim dateMariage As Date = DateTimePickerDateMariage.Value
            Dim communeMariage As String = TextBoxCommuneMariage.Text
            Dim nomTemoinEpoux1 As String = TextBoxNomTemoinEpoux1.Text
            Dim prenomTemoinEpoux1 As String = TextBoxPrenomTemoinEpoux1.Text
            Dim nomTemoinEpoux2 As String = TextBoxNomTemoinEpoux2.Text
            Dim prenomTemoinEpoux2 As String = TextBoxPrenomTemoinEpoux2.Text
            Dim nomTemoinEpouse1 As String = TextBoxNomTemoinEpouse1.Text
            Dim prenomTemoinEpouse1 As String = TextBoxPrenomTemoinEpouse1.Text
            Dim nomTemoinEpouse2 As String = TextBoxNomTemoinEpouse2.Text
            Dim prenomTemoinEpouse2 As String = TextBoxPrenomTemoinEpouse2.Text
            Dim nomOfficierCelebrant As String = TextBoxNomOfficierCelebrant.Text
            Dim prenomOfficierCelebrant As String = TextBoxPrenomOfficierCelebrant.Text
            Dim reference As String = TextBoxReference.Text

            ' Connexion à la base de données
            Dim connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Requête SQL pour insérer les données dans la table Mariage
                Dim query As String = "INSERT INTO Mariage (NomEpoux, PrenomEpoux, NomEpouse, PrenomEpouse, DateMariage, CommuneMariage, NomTemoinEpoux1, PrenomTemoinEpoux1, NomTemoinEpoux2, PrenomTemoinEpoux2, NomTemoinEpouse1, PrenomTemoinEpouse1, NomTemoinEpouse2, PrenomTemoinEpouse2, NomOfficierCelebrant, PrenomOfficierCelebrant, Reference) VALUES (@NomEpoux, @PrenomEpoux, @NomEpouse, @PrenomEpouse, @DateMariage, @CommuneMariage, @NomTemoinEpoux1, @PrenomTemoinEpoux1, @NomTemoinEpoux2, @PrenomTemoinEpoux2, @NomTemoinEpouse1, @PrenomTemoinEpouse1, @NomTemoinEpouse2, @PrenomTemoinEpouse2, @NomOfficierCelebrant, @PrenomOfficierCelebrant, @Reference)"
                Using command As New SqlCommand(query, connection)
                    ' Ajouter les paramètres avec les valeurs
                    command.Parameters.AddWithValue("@NomEpoux", nomEpoux)
                    command.Parameters.AddWithValue("@PrenomEpoux", prenomEpoux)
                    command.Parameters.AddWithValue("@NomEpouse", nomEpouse)
                    command.Parameters.AddWithValue("@PrenomEpouse", prenomEpouse)
                    command.Parameters.AddWithValue("@DateMariage", dateMariage)
                    command.Parameters.AddWithValue("@CommuneMariage", communeMariage)
                    command.Parameters.AddWithValue("@NomTemoinEpoux1", nomTemoinEpoux1)
                    command.Parameters.AddWithValue("@PrenomTemoinEpoux1", prenomTemoinEpoux1)
                    command.Parameters.AddWithValue("@NomTemoinEpoux2", nomTemoinEpoux2)
                    command.Parameters.AddWithValue("@PrenomTemoinEpoux2", prenomTemoinEpoux2)
                    command.Parameters.AddWithValue("@NomTemoinEpouse1", nomTemoinEpouse1)
                    command.Parameters.AddWithValue("@PrenomTemoinEpouse1", prenomTemoinEpouse1)
                    command.Parameters.AddWithValue("@NomTemoinEpouse2", nomTemoinEpouse2)
                    command.Parameters.AddWithValue("@PrenomTemoinEpouse2", prenomTemoinEpouse2)
                    command.Parameters.AddWithValue("@NomOfficierCelebrant", nomOfficierCelebrant)
                    command.Parameters.AddWithValue("@PrenomOfficierCelebrant", prenomOfficierCelebrant)
                    command.Parameters.AddWithValue("@Reference", reference)

                    ' Exécuter la commande SQL
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Afficher un message de confirmation
            MessageBox.Show("Ajout effectué avec succès")

            ' Rafraîchir le DataGridView dans le formulaire ListeActeMariage
            Dim listeActeMariageForm As New ListeActeMariage()
            listeActeMariageForm.RefreshData()

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
