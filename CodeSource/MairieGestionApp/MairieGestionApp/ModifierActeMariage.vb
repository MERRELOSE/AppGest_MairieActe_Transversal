Imports System.Data.SqlClient

Public Class ModifierActeMariage
    Private id As Integer

    ' Constructeur personnalisé
    Public Sub New(id As Integer, nomEpoux As String, prenomEpoux As String, nomEpouse As String, prenomEpouse As String, dateMariage As DateTime, communeMariage As String, nomTemoinEpoux1 As String, prenomTemoinEpoux1 As String, nomTemoinEpoux2 As String, prenomTemoinEpoux2 As String, nomTemoinEpouse1 As String, prenomTemoinEpouse1 As String, nomTemoinEpouse2 As String, prenomTemoinEpouse2 As String, nomOfficierCelebrant As String, prenomOfficierCelebrant As String, reference As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.id = id
        TextBoxNomEpoux.Text = nomEpoux
        TextBoxPrenomEpoux.Text = prenomEpoux
        TextBoxNomEpouse.Text = nomEpouse
        TextBoxPrenomEpouse.Text = prenomEpouse
        DateTimePickerDateMariage.Value = dateMariage
        TextBoxCommuneMariage.Text = communeMariage
        TextBoxNomTemoinEpoux1.Text = nomTemoinEpoux1
        TextBoxPrenomTemoinEpoux1.Text = prenomTemoinEpoux1
        TextBoxNomTemoinEpoux2.Text = nomTemoinEpoux2
        TextBoxPrenomTemoinEpoux2.Text = prenomTemoinEpoux2
        TextBoxNomTemoinEpouse1.Text = nomTemoinEpouse1
        TextBoxPrenomTemoinEpouse1.Text = prenomTemoinEpouse1
        TextBoxNomTemoinEpouse2.Text = nomTemoinEpouse2
        TextBoxPrenomTemoinEpouse2.Text = prenomTemoinEpouse2
        TextBoxNomOfficierCelebrant.Text = nomOfficierCelebrant
        TextBoxPrenomOfficierCelebrant.Text = prenomOfficierCelebrant
        TextBoxReference.Text = reference
    End Sub

    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
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

            ' Requête SQL pour mettre à jour les données dans la table Mariage
            Dim query As String = "UPDATE Mariage SET NomEpoux = @NomEpoux, PrenomEpoux = @PrenomEpoux, NomEpouse = @NomEpouse, PrenomEpouse = @PrenomEpouse, DateMariage = @DateMariage, CommuneMariage = @CommuneMariage, NomTemoinEpoux1 = @NomTemoinEpoux1, PrenomTemoinEpoux1 = @PrenomTemoinEpoux1, NomTemoinEpoux2 = @NomTemoinEpoux2, PrenomTemoinEpoux2 = @PrenomTemoinEpoux2, NomTemoinEpouse1 = @NomTemoinEpouse1, PrenomTemoinEpouse1 = @PrenomTemoinEpouse1, NomTemoinEpouse2 = @NomTemoinEpouse2, PrenomTemoinEpouse2 = @PrenomTemoinEpouse2, NomOfficierCelebrant = @NomOfficierCelebrant, PrenomOfficierCelebrant = @PrenomOfficierCelebrant, Reference = @Reference WHERE Id = @Id"
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
        ' Fermer la page 
        Me.Close()
    End Sub

    Private Sub ModifierActeMariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
