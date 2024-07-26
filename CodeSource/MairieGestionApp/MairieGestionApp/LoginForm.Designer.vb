<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        GroupBox1 = New GroupBox()
        PictureBoxShowPassword = New PictureBox()
        Label4 = New Label()
        BtnQuitter = New Button()
        BtnLogin = New Button()
        txtMotDePasse = New TextBox()
        txtNomUtilisateur = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBoxShowPassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBoxShowPassword)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(BtnQuitter)
        GroupBox1.Controls.Add(BtnLogin)
        GroupBox1.Controls.Add(txtMotDePasse)
        GroupBox1.Controls.Add(txtNomUtilisateur)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Cursor = Cursors.Hand
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(326, 226)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' PictureBoxShowPassword
        ' 
        PictureBoxShowPassword.Image = CType(resources.GetObject("PictureBoxShowPassword.Image"), Image)
        PictureBoxShowPassword.Location = New Point(298, 101)
        PictureBoxShowPassword.Name = "PictureBoxShowPassword"
        PictureBoxShowPassword.Size = New Size(22, 21)
        PictureBoxShowPassword.TabIndex = 8
        PictureBoxShowPassword.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(59, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 29)
        Label4.TabIndex = 7
        Label4.Text = "Connectez-vous"
        ' 
        ' BtnQuitter
        ' 
        BtnQuitter.BackColor = Color.Red
        BtnQuitter.FlatAppearance.BorderSize = 7
        BtnQuitter.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnQuitter.ForeColor = Color.White
        BtnQuitter.Location = New Point(171, 163)
        BtnQuitter.Name = "BtnQuitter"
        BtnQuitter.Size = New Size(107, 34)
        BtnQuitter.TabIndex = 6
        BtnQuitter.Text = "Quitter"
        BtnQuitter.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.AccessibleName = ""
        BtnLogin.BackColor = Color.DeepSkyBlue
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BtnLogin.FlatAppearance.BorderSize = 7
        BtnLogin.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.Black
        BtnLogin.Location = New Point(47, 163)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(111, 34)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Se connecter"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtMotDePasse
        ' 
        txtMotDePasse.Location = New Point(142, 100)
        txtMotDePasse.Name = "txtMotDePasse"
        txtMotDePasse.Size = New Size(178, 23)
        txtMotDePasse.TabIndex = 4
        txtMotDePasse.UseSystemPasswordChar = True
        ' 
        ' txtNomUtilisateur
        ' 
        txtNomUtilisateur.Location = New Point(142, 52)
        txtNomUtilisateur.Name = "txtNomUtilisateur"
        txtNomUtilisateur.Size = New Size(178, 23)
        txtNomUtilisateur.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(6, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 17)
        Label3.TabIndex = 2
        Label3.Text = "Mot de passe :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(150, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(6, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 17)
        Label1.TabIndex = 0
        Label1.Text = "Nom d'utilisateur :"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(351, 248)
        Controls.Add(GroupBox1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Page de connexion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBoxShowPassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents txtNomUtilisateur As TextBox
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnLogin As Button

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBoxShowPassword As PictureBox
End Class
