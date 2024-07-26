Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text

Public Class ListeActeNaissance

    Private connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"




    Private Sub ListeActeNaissance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim query As String = "SELECT * FROM Naissance"
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


    Private Sub LoadNaissanceData()
        Dim connectionString As String = GetConnectionString()
        Dim query As String = "SELECT NomEnfant, PrenomEnfant, DateNaissance, CommuneNaissance, Hopital, NomPere, PrenomPere, NomMere, PrenomMere, Reference FROM Naissance"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            ListNaissance.Items.Clear()
            Dim dataFound As Boolean = False

            While reader.Read()
                dataFound = True
                Dim item As New ListViewItem(reader("NomEnfant").ToString())
                item.SubItems.Add(reader("PrenomEnfant").ToString())
                item.SubItems.Add(Convert.ToDateTime(reader("DateNaissance")).ToString("dd/MM/yyyy"))
                item.SubItems.Add(reader("CommuneNaissance").ToString())
                item.SubItems.Add(reader("Hopital").ToString())
                item.SubItems.Add(reader("NomPere").ToString())
                item.SubItems.Add(reader("PrenomPere").ToString())
                item.SubItems.Add(reader("NomMere").ToString())
                item.SubItems.Add(reader("PrenomMere").ToString())
                item.SubItems.Add(reader("Reference").ToString())
                ListNaissance.Items.Add(item)
            End While

            If Not dataFound Then
                MessageBox.Show("Aucune donnée trouvée.")
            End If

            reader.Close()
        End Using
    End Sub


    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        Dim searchTextNaissance As String = TextBoxNaissance.Text.Trim()
        Dim searchTextCommune As String = TextBoxCommune.Text.Trim()
        Dim searchTextHopital As String = TextBoxHopital.Text.Trim()

        SearchData(searchTextNaissance, searchTextCommune, searchTextHopital)
    End Sub

    Private Sub SearchData(searchTextNaissance As String, searchTextCommune As String, searchTextHopital As String)
        Try
            Dim query As New StringBuilder("SELECT * FROM Naissance WHERE 1=1")

            If Not String.IsNullOrEmpty(searchTextNaissance) Then
                query.Append(" AND (NomEnfant LIKE @SearchTextNaissance OR PrenomEnfant LIKE @SearchTextNaissance OR NomPere LIKE @SearchTextNaissance OR PrenomPere LIKE @SearchTextNaissance OR NomMere LIKE @SearchTextNaissance OR PrenomMere LIKE @SearchTextNaissance)")
            End If

            If Not String.IsNullOrEmpty(searchTextCommune) Then
                query.Append(" AND CommuneNaissance LIKE @SearchTextCommune")
            End If

            If Not String.IsNullOrEmpty(searchTextHopital) Then
                query.Append(" AND Hopital LIKE @SearchTextHopital")
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query.ToString(), connection)
                    If Not String.IsNullOrEmpty(searchTextNaissance) Then
                        command.Parameters.AddWithValue("@SearchTextNaissance", "%" & searchTextNaissance & "%")
                    End If

                    If Not String.IsNullOrEmpty(searchTextCommune) Then
                        command.Parameters.AddWithValue("@SearchTextCommune", "%" & searchTextCommune & "%")
                    End If

                    If Not String.IsNullOrEmpty(searchTextHopital) Then
                        command.Parameters.AddWithValue("@SearchTextHopital", "%" & searchTextHopital & "%")
                    End If

                    connection.Open()

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            Dim dataTable As New DataTable()
                            dataTable.Load(reader)
                            DataGridView1.DataSource = dataTable
                        Else
                            MessageBox.Show("Aucun acte de naissance trouvé pour cette recherche.", "Résultats de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    'lire la chaîne de connexion depuis le fichier de configuration
    Public Function GetConnectionString() As String
        Return ConfigurationManager.ConnectionStrings("MairieDB").ConnectionString
    End Function



    ' Assurez-vous que vous avez une méthode RefreshData pour rafraîchir le DataGridView
    Public Sub RefreshData()
        Try
            ' Connexion à la base de données
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Requête SQL pour récupérer les données mises à jour
                Dim query As String = "SELECT * FROM Naissance"
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
    End Sub


    'rediriger vers la page formulaire lorsqu'on click sur Ajouter
    Private Sub BtnAjouterNaissance_Click(sender As Object, e As EventArgs) Handles BtnAjouterNaissance.Click
        Dim formAjouterNaissance As New AjouterActeNaissance()
        formAjouterNaissance.Show()
    End Sub
    Public Sub MettreAJourDataGridView()
        ' Code pour mettre à jour le DataGridView avec les nouvelles données de la base de données
        ' Par exemple :
        DataGridView1.DataSource = GetConnectionString()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        ' Vérifier si une ligne est sélectionnée
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtenir l'ID de l'élément sélectionné
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim selectedId As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

            ' Demander confirmation à l'utilisateur
            Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet acte de naissance ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                ' Connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Requête SQL pour supprimer l'enregistrement
                    Dim query As String = "DELETE FROM Naissance WHERE Id = @Id"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Id", selectedId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Rafraîchir les données du DataGridView
                LoadData()

                ' Afficher un message de confirmation
                AfficherMessage("Acte de naissance supprimé avec succès.", Color.Green)
            End If
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        RefreshData()
    End Sub

    Public Sub AfficherMessage(message As String, couleur As Color)
        LabelMessage.Text = message
        LabelMessage.ForeColor = couleur
        LabelMessage.Visible = True
        TimerMessage.Start()
    End Sub

    Private Sub TimerMessage_Tick(sender As Object, e As EventArgs) Handles TimerMessage.Tick
        LabelMessage.Visible = False
        TimerMessage.Stop()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        ' Fermer la page ListeActeNaissance
        Me.Close()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        ' Vérifiez qu'une ligne est bien sélectionnée dans le DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Récupérez les informations de la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Récupérez les valeurs des cellules de la ligne sélectionnée
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)
            Dim nomEnfant As String = selectedRow.Cells("NomEnfant").Value.ToString()
            Dim prenomEnfant As String = selectedRow.Cells("PrenomEnfant").Value.ToString()
            Dim dateNaissance As DateTime = Convert.ToDateTime(selectedRow.Cells("DateNaissance").Value)
            Dim communeNaissance As String = selectedRow.Cells("CommuneNaissance").Value.ToString()
            Dim hopital As String = selectedRow.Cells("Hopital").Value.ToString()
            Dim nomPere As String = selectedRow.Cells("NomPere").Value.ToString()
            Dim prenomPere As String = selectedRow.Cells("PrenomPere").Value.ToString()
            Dim nomMere As String = selectedRow.Cells("NomMere").Value.ToString()
            Dim prenomMere As String = selectedRow.Cells("PrenomMere").Value.ToString()
            Dim reference As String = selectedRow.Cells("Reference").Value.ToString()

            ' Créez une instance du formulaire de modification et passez les informations récupérées
            Dim formModifier As New ModifierActeNaissance(id, nomEnfant, prenomEnfant, dateNaissance, communeNaissance, hopital, nomPere, prenomPere, nomMere, prenomMere, reference)
            formModifier.ShowDialog() ' Utilisez ShowDialog pour ouvrir le formulaire en modal

            ' Rafraîchir les données après la fermeture du formulaire de modification
            RefreshData()
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à modifier.")
        End If
    End Sub

    Private Sub BtnRafraichir_Click(sender As Object, e As EventArgs) Handles BtnRafraichir.Click
        ' Rafraîchir les données dans le DataGridView
        RefreshData()
    End Sub

End Class
