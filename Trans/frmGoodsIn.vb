Public Class frmGoodsIn
    Inherits System.Windows.Forms.Form
    Friend WithEvents cmdAccept As System.Windows.Forms.Button


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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCod_Product As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents picMGOOI As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboReason As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGoodsIn))
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblCod_Product = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.picMGOOI = New System.Windows.Forms.PictureBox
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblSize = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboReason = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(64, 256)
        Me.cmdAccept.Size = New System.Drawing.Size(112, 24)
        Me.cmdAccept.Text = "Aceptar"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 8)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Ingreso Otros Motivos"
        '
        'lblCod_Product
        '
        Me.lblCod_Product.Location = New System.Drawing.Point(88, 96)
        Me.lblCod_Product.Size = New System.Drawing.Size(136, 16)
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(224, 104)
        Me.lblLotNumber.Size = New System.Drawing.Size(8, 16)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.Text = "Producto:"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(88, 64)
        Me.txtBarcode.Size = New System.Drawing.Size(144, 22)
        Me.txtBarcode.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.Text = "Cod. Barras:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 168)
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(8, 120)
        Me.lblProductName.Size = New System.Drawing.Size(224, 16)
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(128, 168)
        Me.txtQty.Size = New System.Drawing.Size(104, 22)
        Me.txtQty.Text = ""
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 224)
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.Text = "Conf. Destino:"
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(128, 224)
        Me.txtLocationTarget.Size = New System.Drawing.Size(104, 22)
        Me.txtLocationTarget.Text = ""
        '
        'picMGOOI
        '
        Me.picMGOOI.Image = CType(resources.GetObject("picMGOOI.Image"), System.Drawing.Image)
        Me.picMGOOI.Location = New System.Drawing.Point(8, 0)
        Me.picMGOOI.Size = New System.Drawing.Size(32, 32)
        Me.picMGOOI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(128, 200)
        Me.lblLocationTarget.Size = New System.Drawing.Size(96, 16)
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 200)
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.Text = "Destino:"
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(104, 144)
        Me.lblSize.Size = New System.Drawing.Size(128, 16)
        Me.lblSize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 144)
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.Text = "Dimensiones:"
        '
        'cboReason
        '
        Me.cboReason.Location = New System.Drawing.Point(88, 40)
        Me.cboReason.Size = New System.Drawing.Size(144, 22)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.Text = "Motivo:"
        '
        'frmGoodsIn
        '
        Me.Controls.Add(Me.cboReason)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.picMGOOI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblCod_Product)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmdAccept)
        Me.Text = "Ingreso Otros Motivos"

    End Sub

#End Region

    Private nArrivals_Task As Long
    Private sBarcode As String
    Private sERP_Document As String

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            FillDomainCombo(cboReason, "INGRESOS_MOTIVOS", "DOMAINVALUE", "MEANING")
            lblCod_Product.Text = ""
            lblLotNumber.Text = ""
            lblProductName.Text = ""
            txtBarcode.Text = ""
            txtLocationTarget.Text = ""
            txtQty.Text = ""
            lblSize.Text = ""
            cboReason.Focus()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
            txtQty.Enabled = False
            cmdAccept.Enabled = False
        End Try
    End Sub

    Private Sub UpdateTask()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim iResult As Long
        Dim sResult As String

        Try
            If MsgBox("Desea ejecutar la transaccion?", MsgBoxStyle.OKCancel, publicProject) = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            'Validate data

            If txtBarcode.Text.Length = 0 Or lblCod_Product.Text.Length = 0 Then
                Beep()
                txtBarcode.Text = ""
                MsgBox("Producto ingresado inválido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Focus()
                Exit Sub
            End If

            If Not IsNumeric(txtQty.Text) Then
                Beep()
                txtQty.Text = "0"
                MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Focus()
                Exit Sub
            Else
                If CDbl(txtQty.Text) <= 0 Then
                    Beep()
                    txtQty.Text = "0"
                    MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                    txtQty.Focus()
                    Exit Sub
                End If
            End If

            sResult = xArrivals.GoodsIn(modGlobal.publicUserID, cboReason.SelectedValue, lblCod_Product.Text, lblLotNumber.Text, _
                                        CDbl(txtQty.Text), txtLocationTarget.Text, "", 0, 0, 0)

            MsgBox("Transaccion ejecutada exitosamente", MsgBoxStyle.Information, publicProject)
            ClearFields()

        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

        End Try
    End Sub

    Private Sub frmInit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ClearFields()

        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()

        End Try
    End Sub

    Private Sub picClose_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.ParentChanged

    End Sub


    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        UpdateTask()
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    

    Private Sub txtLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        txtQty.SelectAll()
    End Sub

    

    Private Sub txtBarcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.GotFocus
        txtBarcode.SelectAll()
    End Sub

    Private Sub txtLocationTarget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.TextChanged

    End Sub

    Private Sub txtLocationTarget_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocationTarget.GotFocus
        txtLocationTarget.SelectAll()
    End Sub

    

    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    Dim xArrivals As New wsArrivals.wsArrivals
    '    If e.KeyCode = Keys.Enter Then
    '        lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, txtQty.Text, "")
    '        txtLocationTarget.Focus()
    '    End If

    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim xArrivals As New wsArrivals.wsArrivals
        If e.KeyChar = Chr(13) Then
            lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, txtQty.Text, "")
            txtLocationTarget.Focus()
        End If

    End Sub

    'Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    Dim xServ As New wsCommonServices.wsCommonServices
    '    Dim sD1 As String
    '    Dim sD2 As String
    '    Dim sD3 As String

    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            'Call xServ.ProcessBarcode(txtBarcode.Text, lblCod_Product.Text, lblLotNumber.Text, "", lblProductName.Text, sD1, sD2, sD3)
    '            lblSize.Text = sD1 & " X " & sD2 & " X " & sD3
    '            txtQty.Focus()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
    '    End Try

    'End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim xServ As New wsCommonServices.wsCommonServices
        Dim sD1 As String
        Dim sD2 As String
        Dim sD3 As String

        Try
            If e.KeyChar = Chr(13) Then
                'Call xServ.ProcessBarcode(txtBarcode.Text, lblCod_Product.Text, lblLotNumber.Text, "", lblProductName.Text, sD1, sD2, sD3)
                lblSize.Text = sD1 & " X " & sD2 & " X " & sD3
                txtQty.Focus()
            End If
        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
        End Try

    End Sub

    'Private Sub txtLocationTarget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocationTarget.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub txtLocationTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocationTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQty.Focus()
        End If
    End Sub
End Class
