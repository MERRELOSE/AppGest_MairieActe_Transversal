Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text
Public Class ListeActeMariage

    Private connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"

    Private Sub ListeActeMariage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Dim query As String = "SELECT * FROM Mariage"
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

    Private Sub LoadMariageData()
        Dim connectionString As String = GetConnectionString()
        Dim query As String = "SELECT NomEpoux, PrenomEpoux, NomEpouse, PrenomEpouse, DateMariage, CommuneMariage, TemoinsEpoux, TemoinsEpouse, OfficierCelebrant, Reference FROM Mariage"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            ListMariage.Items.Clear()
            Dim dataFound As Boolean = False

            While reader.Read()
                dataFound = True
                Dim item As New ListViewItem(reader("NomEpoux").ToString())
                item.SubItems.Add(reader("PrenomEpoux").ToString())
                item.SubItems.Add(reader("NomEpouse").ToString())
                item.SubItems.Add(reader("PrenomEpouse").ToString())
                item.SubItems.Add(Convert.ToDateTime(reader("DateMariage")).ToString("dd/MM/yyyy"))
                item.SubItems.Add(reader("CommuneMariage").ToString())
                item.SubItems.Add(reader("TemoinsEpoux").ToString())
                item.SubItems.Add(reader("TemoinsEpouse").ToString())
                item.SubItems.Add(reader("OfficierCelebrant").ToString())
                item.SubItems.Add(reader("Reference").ToString())
                ListMariage.Items.Add(item)
            End While

            If Not dataFound Then
                MessageBox.Show("Aucune donnée trouvée.")
            End If

            reader.Close()
        End Using
    End Sub


    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        Dim searchTextMariage As String = TextBoxMariage.Text.Trim()
        Dim searchTextCommune As String = TextBoxCommune.Text.Trim()
        Dim searchTextOfficier As String = TextBoxOfficier.Text.Trim()

        SearchData(searchTextMariage, searchTextCommune, searchTextOfficier)
    End Sub

    Private Sub SearchData(searchTextMariage As String, searchTextCommune As String, searchTextOfficier As String)
        Try
            Dim query As New StringBuilder("SELECT * FROM Mariage WHERE 1=1")

            If Not String.IsNullOrEmpty(searchTextMariage) Then
                query.Append(" AND (NomEpoux LIKE @SearchTextMariage OR PrenomEpoux LIKE @SearchTextMariage OR NomEpouse LIKE @SearchTextMariage OR PrenomEpouse LIKE @SearchTextMariage)")
            End If

            If Not String.IsNullOrEmpty(searchTextCommune) Then
                query.Append(" AND CommuneMariage LIKE @SearchTextCommune")
            End If

            If Not String.IsNullOrEmpty(searchTextOfficier) Then
                query.Append(" AND (NomOfficierCelebrant LIKE @SearchTextOfficier OR PrenomOfficierCelebrant LIKE @SearchTextOfficier)")
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query.ToString(), connection)
                    If Not String.IsNullOrEmpty(searchTextMariage) Then
                        command.Parameters.AddWithValue("@SearchTextMariage", "%" & searchTextMariage & "%")
                    End If

                    If Not String.IsNullOrEmpty(searchTextCommune) Then
                        command.Parameters.AddWithValue("@SearchTextCommune", "%" & searchTextCommune & "%")
                    End If

                    If Not String.IsNullOrEmpty(searchTextOfficier) Then
                        command.Parameters.AddWithValue("@SearchTextOfficier", "%" & searchTextOfficier & "%")
                    End If

                    connection.Open()

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            Dim dataTable As New DataTable()
                            dataTable.Load(reader)
                            DataGridView1.DataSource = dataTable
                        Else
                            MessageBox.Show("Aucun acte de mariage trouvé pour cette recherche.", "Résultats de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    Public Function GetActeMariageData() As DataTable
        ' Code pour récupérer les données de la base de données
        ' Par exemple :
        Dim dataTable As New DataTable()
        ' Code pour remplir le DataTable avec les données de la base de données
        Return dataTable
    End Function


    ' Lire la chaîne de connexion depuis le fichier de configuration
    Public Function GetConnectionString() As String
        Return ConfigurationManager.ConnectionStrings("MairieDB").ConnectionString
    End Function

    ' Rediriger vers la page formulaire lorsqu'on clique sur Ajouter
    Private Sub BtnAjouterMariage_Click(sender As Object, e As EventArgs) Handles BtnAjouterMariage.Click
        Dim formAjouterMariage As New AjouterActeMariage(Me)
        formAjouterMariage.Show()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        ' Vérifier si une ligne est sélectionnée
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtenir l'ID de l'élément sélectionné
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim selectedId As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)

            ' Demander confirmation à l'utilisateur
            Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet acte de mariage ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                ' Connexion à la base de données
                Dim connectionString As String = "Data Source=DESKTOP-PI1N4QU\SQLEXPRESS;Initial Catalog=MAIRIEDB;Integrated Security=True"
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Requête SQL pour supprimer l'enregistrement
                    Dim query As String = "DELETE FROM Mariage WHERE Id = @Id"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Id", selectedId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Rafraîchir les données du DataGridView
                LoadData()

                ' Afficher un message de confirmation
                AfficherMessage("Acte de mariage supprimé avec succès.", Color.Green)
            End If
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        ' Fermer la page ListeActeMariage
        Me.Close()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        ' Vérifiez qu'une ligne est bien sélectionnée dans le DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Récupérez les informations de la ligne sélectionnée
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Récupérez les valeurs des cellules de la ligne sélectionnée
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Id").Value)
            Dim nomEpoux As String = selectedRow.Cells("NomEpoux").Value.ToString()
            Dim prenomEpoux As String = selectedRow.Cells("PrenomEpoux").Value.ToString()
            Dim nomEpouse As String = selectedRow.Cells("NomEpouse").Value.ToString()
            Dim prenomEpouse As String = selectedRow.Cells("PrenomEpouse").Value.ToString()
            Dim dateMariage As DateTime = Convert.ToDateTime(selectedRow.Cells("DateMariage").Value)
            Dim communeMariage As String = selectedRow.Cells("CommuneMariage").Value.ToString()
            Dim nomTemoinEpoux1 As String = selectedRow.Cells("NomTemoinEpoux1").Value.ToString()
            Dim prenomTemoinEpoux1 As String = selectedRow.Cells("PrenomTemoinEpoux1").Value.ToString()
            Dim nomTemoinEpoux2 As String = selectedRow.Cells("NomTemoinEpoux2").Value.ToString()
            Dim prenomTemoinEpoux2 As String = selectedRow.Cells("PrenomTemoinEpoux2").Value.ToString()
            Dim nomTemoinEpouse1 As String = selectedRow.Cells("NomTemoinEpouse1").Value.ToString()
            Dim prenomTemoinEpouse1 As String = selectedRow.Cells("PrenomTemoinEpouse1").Value.ToString()
            Dim nomTemoinEpouse2 As String = selectedRow.Cells("NomTemoinEpouse2").Value.ToString()
            Dim prenomTemoinEpouse2 As String = selectedRow.Cells("PrenomTemoinEpouse2").Value.ToString()
            Dim nomOfficierCelebrant As String = selectedRow.Cells("NomOfficierCelebrant").Value.ToString()
            Dim prenomOfficierCelebrant As String = selectedRow.Cells("PrenomOfficierCelebrant").Value.ToString()
            Dim reference As String = selectedRow.Cells("Reference").Value.ToString()

            ' Créez une instance du formulaire de modification et passez les informations récupérées
            Dim formModifier As New ModifierActeMariage(id, nomEpoux, prenomEpoux, nomEpouse, prenomEpouse, dateMariage, communeMariage, nomTemoinEpoux1, prenomTemoinEpoux1, nomTemoinEpoux2, prenomTemoinEpoux2, nomTemoinEpouse1, prenomTemoinEpouse1, nomTemoinEpouse2, prenomTemoinEpouse2, nomOfficierCelebrant, prenomOfficierCelebrant, reference)
            formModifier.ShowDialog() ' Utilisez ShowDialog pour ouvrir le formulaire en modal

            ' Rafraîchir les données après la fermeture du formulaire de modification
            RefreshData()
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à modifier.")
        End If
    End Sub

    ' Assurez-vous que vous avez une méthode RefreshData pour rafraîchir le DataGridView
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
    End Sub


    Private Sub BtnRafraichir_Click(sender As Object, e As EventArgs) Handles BtnRafraichir.Click
        ' Rafraîchir les données dans le DataGridView
        RefreshData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
