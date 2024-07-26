Imports System.Data.SqlClient

Public Class AjouterActeVenteTerrain
    Private listeActeVenteTerrainForm As ListeActeVenteTerrain

    ' Constructeur qui accepte une instance de ListeActeVenteTerrain
    Public Sub New(listeActeVenteTerrainForm As ListeActeVenteTerrain)
        InitializeComponent()
        Me.listeActeVenteTerrainForm = listeActeVenteTerrainForm
    End Sub

    Private Sub AjouterActeVenteTerrain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajouter l'événement KeyDown pour chaque TextBox
        AddHandler TextBoxNomVendeur.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomVendeur.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomAcheteur.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomAcheteur.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxSiteTerrain.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxSuperficie.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrixVente.KeyDown, AddressOf TextBox_KeyDown
        AddHandler DateTimePickerDateVente.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomTemoinVente1.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomTemoinVente1.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxNomTemoinVente2.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxPrenomTemoinVente2.KeyDown, AddressOf TextBox_KeyDown
        AddHandler TextBoxReference.KeyDown, AddressOf TextBox_KeyDown
        ' Ajoutez des handlers pour d'autres TextBox si nécessaire
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
            ' Récupérer les valeurs des champs du formulaire avec validation
            Dim nomVendeur As String = TextBoxNomVendeur.Text
            Dim prenomVendeur As String = TextBoxPrenomVendeur.Text
            Dim nomAcheteur As String = TextBoxNomAcheteur.Text
            Dim prenomAcheteur As String = TextBoxPrenomAcheteur.Text
            Dim siteTerrain As String = TextBoxSiteTerrain.Text
            Dim superficie As Double
            Dim prixVente As Decimal

            ' Valider et convertir Superficie
            If Not Double.TryParse(TextBoxSuperficie.Text, superficie) Then
                MessageBox.Show("Veuillez entrer une superficie valide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxSuperficie.Focus()
                Return
            End If

            ' Valider et convertir PrixVente
            If Not Decimal.TryParse(TextBoxPrixVente.Text, prixVente) Then
                MessageBox.Show("Veuillez entrer un prix de vente valide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxPrixVente.Focus()
                Return
            End If

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

                ' Requête SQL pour insérer les données dans la table VenteTerrain
                Dim query As String = "INSERT INTO VenteTerrain (NomVendeur, PrenomVendeur, NomAcheteur, PrenomAcheteur, SiteTerrain, Superficie, PrixVente, DateVente, NomTemoinVente1, PrenomTemoinVente1, NomTemoinVente2, PrenomTemoinVente2, Reference) VALUES (@NomVendeur, @PrenomVendeur, @NomAcheteur, @PrenomAcheteur, @SiteTerrain, @Superficie, @PrixVente, @DateVente, @NomTemoinVente1, @PrenomTemoinVente1, @NomTemoinVente2, @PrenomTemoinVente2, @Reference)"
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

                    ' Exécuter la commande SQL
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Afficher un message de confirmation
            MessageBox.Show("Ajout effectué avec succès")

            ' Rafraîchir le DataGridView dans le formulaire ListeActeVenteTerrain
            Dim listeActeVenteTerrainForm As New ListeActeVenteTerrain()
            listeActeVenteTerrainForm.RefreshData()

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
