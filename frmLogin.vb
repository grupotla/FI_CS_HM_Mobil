

Public Class frmLogin
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents picCancel As System.Windows.Forms.PictureBox
    Friend WithEvents picEnter As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.picCancel = New System.Windows.Forms.PictureBox
        Me.picEnter = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblServer = New System.Windows.Forms.Label
        Me.lblData = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(88, 144)
        Me.txtUserID.MaxLength = 20
        Me.txtUserID.Size = New System.Drawing.Size(128, 20)
        Me.txtUserID.Text = ""
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(88, 168)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(128, 20)
        Me.txtPassword.Text = ""
        '
        'picCancel
        '
        Me.picCancel.Image = CType(resources.GetObject("picCancel.Image"), System.Drawing.Image)
        Me.picCancel.Location = New System.Drawing.Point(160, 192)
        Me.picCancel.Size = New System.Drawing.Size(20, 20)
        Me.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'picEnter
        '
        Me.picEnter.Image = CType(resources.GetObject("picEnter.Image"), System.Drawing.Image)
        Me.picEnter.Location = New System.Drawing.Point(128, 192)
        Me.picEnter.Size = New System.Drawing.Size(24, 24)
        Me.picEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 144)
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(8, 168)
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.Text = "Password"
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.Location = New System.Drawing.Point(16, 216)
        Me.lblVersion.Size = New System.Drawing.Size(224, 16)
        Me.lblVersion.Text = "eWMS Mobile"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 232)
        Me.PictureBox1.Size = New System.Drawing.Size(72, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblServer
        '
        Me.lblServer.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblServer.ForeColor = System.Drawing.Color.Black
        Me.lblServer.Location = New System.Drawing.Point(16, 232)
        Me.lblServer.Size = New System.Drawing.Size(224, 16)
        Me.lblServer.Text = "WS:"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblData
        '
        Me.lblData.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblData.Location = New System.Drawing.Point(16, 248)
        Me.lblData.Size = New System.Drawing.Size(224, 16)
        Me.lblData.Text = "DB:"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(40, 0)
        Me.PictureBox2.Size = New System.Drawing.Size(160, 144)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(208, 8)
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.Text = "102"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        '
        'frmLogin
        '
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCancel)
        Me.Controls.Add(Me.picEnter)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Menu = Me.MainMenu1
        Me.Text = "eWMS"

    End Sub

#End Region

    Private Function CheckLogin() As Boolean
        Dim xLogin As New wsLogin.wsLogin
        Dim Cod_user As String
        Try
            Cursor.Current = Cursors.WaitCursor
            'login actual
            'Call xLogin.ValidateUser(txtUserID.Text, txtPassword.Text, publicMobileVersion)
            'modGlobal.publicUserID = txtUserID.Text
            'modGlobal.publicCurrentCountry = xLogin.getUserParam(txtUserID.Text)

            'login nuevo
            Cod_user = xLogin.ValidateUser2(txtUserID.Text, txtPassword.Text, publicMobileVersion)
            modGlobal.publicUserID = Cod_user
            modGlobal.publicCurrentCountry = xLogin.getUserParam(Cod_user)

            Cursor.Current = Cursors.Default
            Return True

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, modGlobal.publicProject)
            txtUserID.Text = ""
            txtPassword.Text = ""
            txtUserID.Focus()
            Return False
        End Try

    End Function

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        

        Try
            Dim xServ As New wsCommonServices.wsCommonServices
            Dim sData As String
            Dim aData(1) As Object
            Dim sVer As String
            lblVersion.Text = "eWMS Mobile Ver. " & publicMobileVersion
            'sVer = xServ.GetCurrentVersion()
            'If sVer.Trim.ToUpper <> publicMobileVersion.Trim.ToUpper Then
            '    MsgBox("Se ha detectado una nueva version en el Servidor.  El sistema se actualizara Automaticamente", MsgBoxStyle.Information, publicProject)
            '    'Execute("\program files\Aimar\eWMSUpdate.exe")
            '    Execute("\program files\Aimar\eWMSUpdate.exe")
            '    Application.Exit()
            'End If
            lblVersion.Text = "eWMS Mobile Ver. " & publicMobileVersion
            sData = xServ.GetServerData()
            aData = sData.Split("|")
            lblServer.Text = "Servidor: " & aData(0)
            lblData.Text = "" & aData(1)

        Catch ex As Exception
            lblServer.Text = ex.Message
            lblData.Text = ""
        End Try

        txtUserID.Focus()

    End Sub

    Private Sub txtUserID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserID.GotFocus
        txtUserID.SelectAll()
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.SelectAll()
    End Sub

    Private Sub picCancel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCancel.MouseDown
        Application.Exit()
    End Sub

    Private Sub frmLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not CheckLogin() Then
            e.Cancel = True
        End If

    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPassword.Focus()
        End If

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Close()
        End If

    End Sub

End Class
