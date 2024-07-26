Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text

Public Class ListeActeVenteTerrain

    Private connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"

    Private Sub ListeActeVenteTerrain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim query As String = "SELECT * FROM VenteTerrain"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            Dim dataTable As New DataTable()
                            dataTable.Load(reader)
                            DataGridView1.DataSource = dataTable
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors du chargement des données: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadVenteTerrainData()
        Dim connectionString As String = GetConnectionString()
        Dim query As String = "SELECT NomVendeur, PrenomVendeur, NomAcheteur, PrenomAcheteur, SiteTerrain, Superficie, PrixVente, DateVente, TemoinsVente, Reference FROM VenteTerrain"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            ListVenteTerrain.Items.Clear()
            Dim dataFound As Boolean = False

            While reader.Read()
                dataFound = True
                Dim item As New ListViewItem(reader("NomVendeur").ToString())
                item.SubItems.Add(reader("PrenomVendeur").ToString())
                item.SubItems.Add(reader("NomAcheteur").ToString())
                item.SubItems.Add(reader("PrenomAcheteur").ToString())
                item.SubItems.Add(reader("SiteTerrain").ToString())
                item.SubItems.Add(reader("Superficie").ToString())
                item.SubItems.Add(Convert.ToDecimal(reader("PrixVente")).ToString("F2"))
                item.SubItems.Add(Convert.ToDateTime(reader("DateVente")).ToString("dd/MM/yyyy"))
                item.SubItems.Add(reader("TemoinsVente").ToString())
                item.SubItems.Add(reader("Reference").ToString())
                ListVenteTerrain.Items.Add(item)
            End While

            If Not dataFound Then
                MessageBox.Show("Aucune donnée trouvée.")
            End If

            reader.Close()
        End Using
    End Sub


    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        Dim searchTextVenteTerrain As String = TextBoxVenteTerrain.Text.Trim()
        Dim searchTextCommune As String = TextBoxCommune.Text.Trim()
        Dim searchTextPrix As String = TextBoxPrix.Text.Trim()

        SearchData(searchTextVenteTerrain, searchTextCommune, searchTextPrix)
    End Sub

    Private Sub SearchData(searchTextVenteTerrain As String, searchTextCommune As String, searchTextPrix As String)
        Try
            Dim query As New StringBuilder("SELECT * FROM VenteTerrain WHERE 1=1")

            If Not String.IsNullOrEmpty(searchTextVenteTerrain) Then
                query.Append(" AND (NomVendeur LIKE @SearchTextVenteTerrain OR PrenomVendeur LIKE @SearchTextVenteTerrain OR NomAcheteur LIKE @SearchTextVenteTerrain OR PrenomAcheteur LIKE @SearchTextVenteTerrain)")
            End If

            If Not String.IsNullOrEmpty(searchTextCommune) Then
                query.Append(" AND CommuneVente LIKE @SearchTextCommune")
            End If

            If Not String.IsNullOrEmpty(searchTextPrix) Then
                query.Append(" AND PrixVente LIKE @SearchTextPrix")
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query.ToString(), connection)
                    If Not String.IsNullOrEmpty(searchTextVenteTerrain) Then
                        command.Parameters.AddWithValue("@SearchTextVenteTerrain", "%" & searchTextVenteTerrain & "%")
                    End If

                    If Not String.IsNullOrEmpty(searchTextCommune) Then
                        command.Parameters.AddWithValue("@SearchTextCommune", "%" & searchTextCommune & "%")
                    End If

                    If Not String.IsNullOrEmpty(searchTextPrix) Then
                        command.Parameters.AddWithValue("@SearchTextPrix", "%" & searchTextPrix & "%")
                    End If

                    connection.Open()

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            Dim dataTable As New DataTable()
                            dataTable.Load(reader)
                            DataGridView1.DataSource = dataTable
                        Else
                            MessageBox.Show("Aucun acte de vente de terrain trouvé pour cette recherche.", "Résultats de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            DataGridView1.DataSource = Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la recherche : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Function TestConnection() As Boolean
        Try
            Using connection As New SqlConnection(GetConnectionString())
                connection.Open()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur de connexion : " & ex.Message)
            Return False
        End Try
    End Function

    ' Lire la chaîne de connexion depuis le fichier de configuration
    Public Function GetConnectionString() As String
        Return ConfigurationManager.ConnectionStrings("MairieDB").ConnectionString
    End Function

    ' Rediriger vers la page formulaire lorsqu'on clique sur Ajouter
    Private Sub BtnAjouterVente_Click(sender As Object, e As EventArgs) Handles BtnAjouterVente.Click
        Dim formAjouterVenteTerrain As New AjouterActeVenteTerrain(Me)
        formAjouterVenteTerrain.Show()
    End Sub

    ' Méthode pour afficher un message à l'utilisateur
    Public Sub AfficherMessage(message As String, couleur As Color)
        MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Public Sub RefreshData()
        Try
            ' Connexion à la base de données
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Requête SQL pour récupérer les données mises à jour
                Dim query As String = "SELECT * FROM Mariage"
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors du rafraîchissement des données : " & ex.Message)
        End Try
        LoadData()
    End Sub

    Public Sub AfficherMessage1(message As String, couleur As Color)
        LabelMessage.Text = message
        LabelMessage.ForeColor = couleur
        LabelMessage.Visible = True
        TimerMessage.Start()
    End Sub

    Private Sub TimerMessage_Tick(sender As Object, e As EventArgs) Handles TimerMessage.Tick
        LabelMessage.Visible = False
        TimerMessage.Stop()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        ' Vérifier si une ligne est sélectionnée
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtenir l'ID de l'élément sélectionné
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim selectedId As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

            ' Demander confirmation à l'utilisateur
            Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet acte de Vente de Terrain ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                ' Connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Requête SQL pour supprimer l'enregistrement
                    Dim query As String = "DELETE FROM VenteTerrain WHERE Id = @Id"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Id", selectedId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Rafraîchir les données du DataGridView
                LoadData()

                ' Afficher un message de confirmation
                AfficherMessage1("Acte de Vente de Terrain supprimé avec succès.", Color.Green)
            End If
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        ' Fermer la page ListeActeVenteTerrain
        Me.Close()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        ' Vérifier si une ligne est sélectionnée dans le DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Récupérer les informations de la ligne sélectionnée
            Dim id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Id").Value)
            Dim nomVendeur As String = DataGridView1.SelectedRows(0).Cells("NomVendeur").Value.ToString()
            Dim prenomVendeur As String = DataGridView1.SelectedRows(0).Cells("PrenomVendeur").Value.ToString()
            Dim nomAcheteur As String = DataGridView1.SelectedRows(0).Cells("NomAcheteur").Value.ToString()
            Dim prenomAcheteur As String = DataGridView1.SelectedRows(0).Cells("PrenomAcheteur").Value.ToString()
            Dim siteTerrain As String = DataGridView1.SelectedRows(0).Cells("SiteTerrain").Value.ToString()
            Dim superficie As Double = Convert.ToDouble(DataGridView1.SelectedRows(0).Cells("Superficie").Value)
            Dim prixVente As Decimal = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells("PrixVente").Value)
            Dim dateVente As Date = Convert.ToDateTime(DataGridView1.SelectedRows(0).Cells("DateVente").Value)
            Dim nomTemoinVente1 As String = DataGridView1.SelectedRows(0).Cells("NomTemoinVente1").Value.ToString()
            Dim prenomTemoinVente1 As String = DataGridView1.SelectedRows(0).Cells("PrenomTemoinVente1").Value.ToString()
            Dim nomTemoinVente2 As String = DataGridView1.SelectedRows(0).Cells("NomTemoinVente2").Value.ToString()
            Dim prenomTemoinVente2 As String = DataGridView1.SelectedRows(0).Cells("PrenomTemoinVente2").Value.ToString()
            Dim reference As String = DataGridView1.SelectedRows(0).Cells("Reference").Value.ToString()

            ' Créer une nouvelle instance du formulaire de modification et l'afficher
            Dim formModifier As New ModifierActeVenteTerrain(id, nomVendeur, prenomVendeur, nomAcheteur, prenomAcheteur, siteTerrain, superficie, prixVente, dateVente, nomTemoinVente1, prenomTemoinVente1, nomTemoinVente2, prenomTemoinVente2, reference)
            formModifier.Show()
            Me.Hide() ' Cacher le formulaire ListeActeVenteTerrain
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à modifier.")
        End If
    End Sub

    Private Sub BtnRafraichir_Click(sender As Object, e As EventArgs) Handles BtnRafraichir.Click
        ' Rafraîchir les données dans le DataGridView
        RefreshData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
