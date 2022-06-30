Public Class frmStartPickingCFS
    Inherits System.Windows.Forms.Form
    Friend WithEvents txtPickingNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnContinue As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStartPickingCFS))
        Me.txtPickingNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bttnContinue = New System.Windows.Forms.Button
        Me.bttnCancel = New System.Windows.Forms.Button
        Me.picMain = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        '
        'txtPickingNumber
        '
        Me.txtPickingNumber.Location = New System.Drawing.Point(32, 104)
        Me.txtPickingNumber.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.Text = "Picking a actualizar"
        '
        'bttnContinue
        '
        Me.bttnContinue.Location = New System.Drawing.Point(152, 160)
        Me.bttnContinue.Size = New System.Drawing.Size(72, 24)
        Me.bttnContinue.Text = "Continuar"
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(72, 160)
        Me.bttnCancel.Size = New System.Drawing.Size(64, 24)
        Me.bttnCancel.Text = "Cancelar"
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(16, 16)
        Me.picMain.Size = New System.Drawing.Size(32, 32)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(56, 16)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Picking - CFS"
        '
        'frmStartPickingCFS
        '
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnContinue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPickingNumber)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Text = "Picking CFS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub bttnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnContinue.Click
        If Me.txtPickingNumber.Text = "" Then
            MessageBox.Show("Debe especificar un numero de picking")
        Else
            Dim xFrm As New frmPickingCFS
            xFrm.iPickingTaskNumber = Me.txtPickingNumber.Text
            xFrm.ShowDialog()
            xFrm = Nothing
        End If
        
    End Sub

    Private Sub frmStartPickingCFS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtPickingNumber.Focus()
    End Sub

    Private Sub txtPickingNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPickingNumber.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.bttnContinue.Focus()
        End If
    End Sub
End Class
