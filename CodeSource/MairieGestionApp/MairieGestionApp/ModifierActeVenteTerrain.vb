Imports System.Data.SqlClient

Public Class ModifierActeVenteTerrain
    Private id As Integer

    ' Constructeur personnalisé
    Public Sub New(id As Integer, nomVendeur As String, prenomVendeur As String, nomAcheteur As String, prenomAcheteur As String, siteTerrain As String, superficie As Double, prixVente As Decimal, dateVente As DateTime, nomTemoinVente1 As String, prenomTemoinVente1 As String, nomTemoinVente2 As String, prenomTemoinVente2 As String, reference As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.id = id
        TextBoxNomVendeur.Text = nomVendeur
        TextBoxPrenomVendeur.Text = prenomVendeur
        TextBoxNomAcheteur.Text = nomAcheteur
        TextBoxPrenomAcheteur.Text = prenomAcheteur
        TextBoxSiteTerrain.Text = siteTerrain
        TextBoxSuperficie.Text = superficie.ToString()
        TextBoxPrixVente.Text = prixVente.ToString()
        DateTimePickerDateVente.Value = dateVente
        TextBoxNomTemoinVente1.Text = nomTemoinVente1
        TextBoxPrenomTemoinVente1.Text = prenomTemoinVente1
        TextBoxNomTemoinVente2.Text = nomTemoinVente2
        TextBoxPrenomTemoinVente2.Text = prenomTemoinVente2
        TextBoxReference.Text = reference
    End Sub

    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        ' Récupérer les valeurs des champs du formulaire
        Dim nomVendeur As String = TextBoxNomVendeur.Text
        Dim prenomVendeur As String = TextBoxPrenomVendeur.Text
        Dim nomAcheteur As String = TextBoxNomAcheteur.Text
        Dim prenomAcheteur As String = TextBoxPrenomAcheteur.Text
        Dim siteTerrain As String = TextBoxSiteTerrain.Text
        Dim superficie As Double = Convert.ToDouble(TextBoxSuperficie.Text)
        Dim prixVente As Decimal = Convert.ToDecimal(TextBoxPrixVente.Text)
        Dim dateVente As Date = DateTimePickerDateVente.Value
        Dim nomTemoinVente1 As String = TextBoxNomTemoinVente1.Text
        Dim prenomTemoinVente1 As String = TextBoxPrenomTemoinVente1.Text
        Dim nomTemoinVente2 As String = TextBoxNomTemoinVente2.Text
        Dim prenomTemoinVente2 As String = TextBoxPrenomTemoinVente2.Text
        Dim reference As String = TextBoxReference.Text

        ' Connexion à la base de données
        Dim connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Requête SQL pour mettre à jour les données dans la table VenteTerrain
            Dim query As String = "UPDATE VenteTerrain SET NomVendeur = @NomVendeur, PrenomVendeur = @PrenomVendeur, NomAcheteur = @NomAcheteur, PrenomAcheteur = @PrenomAcheteur, SiteTerrain = @SiteTerrain, Superficie = @Superficie, PrixVente = @PrixVente, DateVente = @DateVente, NomTemoinVente1 = @NomTemoinVente1, PrenomTemoinVente1 = @PrenomTemoinVente1, NomTemoinVente2 = @NomTemoinVente2, PrenomTemoinVente2 = @PrenomTemoinVente2, Reference = @Reference WHERE Id = @Id"
            Using command As New SqlCommand(query, connection)
                ' Ajouter les paramètres avec les valeurs
                command.Parameters.AddWithValue("@NomVendeur", nomVendeur)
                command.Parameters.AddWithValue("@PrenomVendeur", prenomVendeur)
                command.Parameters.AddWithValue("@NomAcheteur", nomAcheteur)
                command.Parameters.AddWithValue("@PrenomAcheteur", prenomAcheteur)
                command.Parameters.AddWithValue("@SiteTerrain", siteTerrain)
                command.Parameters.AddWithValue("@Superficie", superficie)
                command.Parameters.AddWithValue("@PrixVente", prixVente)
                command.Parameters.AddWithValue("@DateVente", dateVente)
                command.Parameters.AddWithValue("@NomTemoinVente1", nomTemoinVente1)
                command.Parameters.AddWithValue("@PrenomTemoinVente1", prenomTemoinVente1)
                command.Parameters.AddWithValue("@NomTemoinVente2", nomTemoinVente2)
                command.Parameters.AddWithValue("@PrenomTemoinVente2", prenomTemoinVente2)
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


End Class
