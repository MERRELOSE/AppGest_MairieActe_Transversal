Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class ModifierActeNaissance

    Private id As Integer

    ' Constructeur personnalisé
    Public Sub New(id As Integer, nomEnfant As String, prenomEnfant As String, dateNaissance As DateTime, communeNaissance As String, hopital As String, nomPere As String, prenomPere As String, nomMere As String, prenomMere As String, reference As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.id = id
        TextBoxNomEnfant.Text = nomEnfant
        TextBoxPrenomEnfant.Text = prenomEnfant
        DateTimePickerDateNaissance.Value = dateNaissance
        TextBoxCommuneNaissance.Text = communeNaissance
        TextBoxHopital.Text = hopital
        TextBoxNomPere.Text = nomPere
        TextBoxPrenomPere.Text = prenomPere
        TextBoxNomMere.Text = nomMere
        TextBoxPrenomMere.Text = prenomMere
        TextBoxReference.Text = reference
    End Sub


    ' Dans la classe ModifierActeNaissance

    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        ' Récupérer les valeurs des champs du formulaire
        Dim nomEnfant As String = TextBoxNomEnfant.Text
        Dim prenomEnfant As String = TextBoxPrenomEnfant.Text
        Dim dateNaissance As Date = DateTimePickerDateNaissance.Value
        Dim communeNaissance As String = TextBoxCommuneNaissance.Text
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

            ' Requête SQL pour mettre à jour les données dans la table Naissance
            Dim query As String = "UPDATE Naissance SET NomEnfant = @NomEnfant, PrenomEnfant = @PrenomEnfant, DateNaissance = @DateNaissance, CommuneNaissance = @CommuneNaissance, Hopital = @Hopital, NomPere = @NomPere, PrenomPere = @PrenomPere, NomMere = @NomMere, PrenomMere = @PrenomMere, Reference = @Reference WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                ' Ajouter les paramètres avec les valeurs
                command.Parameters.AddWithValue("@NomEnfant", nomEnfant)
                command.Parameters.AddWithValue("@PrenomEnfant", prenomEnfant)
                command.Parameters.AddWithValue("@DateNaissance", dateNaissance)
                command.Parameters.AddWithValue("@CommuneNaissance", communeNaissance)
                command.Parameters.AddWithValue("@Hopital", hopital)
                command.Parameters.AddWithValue("@NomPere", nomPere)
                command.Parameters.AddWithValue("@PrenomPere", prenomPere)
                command.Parameters.AddWithValue("@NomMere", nomMere)
                command.Parameters.AddWithValue("@PrenomMere", prenomMere)
                command.Parameters.AddWithValue("@Reference", reference)
                command.Parameters.AddWithValue("@Id", Me.id) ' Utiliser la variable d'instance 'id'

                ' Exécuter la commande SQL
                command.ExecuteNonQuery()
            End Using
        End Using

        ' Afficher un message de confirmation
        MessageBox.Show("Modifications enregistrées avec succès !")

        ' Fermer le formulaire de modification
        Me.Close()
    End Sub


    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        ' Fermer la page ListeActeNaissance
        Me.Close()
    End Sub


End Class
