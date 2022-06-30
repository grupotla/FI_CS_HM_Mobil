Public Class frmPickConfirmTarget
    Inherits System.Windows.Forms.Form
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label

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
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents lblLocationTargetDesc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPickConfirmTarget))
        Me.picMain = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.lblLocationTargetDesc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(8, 0)
        Me.picMain.Size = New System.Drawing.Size(32, 32)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(40, 8)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Confirmar Destino"
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(240, 72)
        Me.lblLocationTarget.Size = New System.Drawing.Size(8, 16)
        Me.lblLocationTarget.Visible = False
        '
        'lblLocationTargetDesc
        '
        Me.lblLocationTargetDesc.Location = New System.Drawing.Point(72, 136)
        Me.lblLocationTargetDesc.Size = New System.Drawing.Size(152, 16)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 136)
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.Text = "Destino:"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(120, 160)
        Me.txtLocation.Size = New System.Drawing.Size(104, 22)
        Me.txtLocation.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 160)
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.Text = "Confirmar:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Size = New System.Drawing.Size(216, 72)
        Me.Label1.Text = "Ha finalizado un Documento o ha decidido salir de la ventana de Picking.  Confirm" & _
        "ar la Ubicacion Destino del Ultimo documento atendido"
        '
        'frmPickConfirmTarget
        '
        Me.ClientSize = New System.Drawing.Size(240, 191)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.lblLocationTargetDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.lblTitle)
        Me.Text = "Confirmar Destino"

    End Sub

#End Region

    Private Sub frmPickConfirmTarget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblLocationTarget.Text = publicReturnCode
        lblLocationTargetDesc.Text = publicReturnDesc
        txtLocation.Focus()

    End Sub

    Private Sub frmPickConfirmTarget_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try

            If txtLocation.Text.Trim <> lblLocationTarget.Text Then
                MsgBox("Ubicacion Destino Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
                txtLocation.Text = ""
                txtLocation.Focus()
                e.Cancel = True
            End If

        Catch ex As Exception

            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
            e.Cancel = True

        End Try

    End Sub

    Private Sub txtLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocation.TextChanged

    End Sub

    Private Sub txtLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocation.GotFocus
        txtLocation.SelectAll()
    End Sub

    Private Sub txtLocation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocation.Click
        txtLocation.SelectAll()
    End Sub

    'Private Sub txtLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocation.KeyDown
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Me.Close()
    '        End If

    '    Catch ex As Exception
    '        MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
    '    End Try
    'End Sub
    

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
        End Try
    End Sub
End Class
