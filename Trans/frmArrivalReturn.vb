Public Class frmArrivalReturn
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTarget As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerCode As System.Windows.Forms.Label
    Friend WithEvents chkState As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents cboMotivos As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodBarProduct As System.Windows.Forms.TextBox
    Friend WithEvents lblDateExpire As System.Windows.Forms.Label
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblBarLocation As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalReturn))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.myTimer = New System.Windows.Forms.Timer
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboWhs = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboMotivos = New System.Windows.Forms.ComboBox
        Me.txtTarget = New System.Windows.Forms.TextBox
        Me.txtInvoice = New System.Windows.Forms.TextBox
        Me.lblCustomerCode = New System.Windows.Forms.Label
        Me.chkState = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.txtCodBarProduct = New System.Windows.Forms.TextBox
        Me.lblDateExpire = New System.Windows.Forms.Label
        Me.lblLote = New System.Windows.Forms.Label
        Me.lblProductDescription = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblBarLocation = New System.Windows.Forms.Label
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 0)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Ingreso por Cambio"
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(224, 104)
        Me.lblLotNumber.Size = New System.Drawing.Size(8, 16)
        Me.lblLotNumber.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(9, 184)
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.Text = "Cantidad:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(128, 182)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Size = New System.Drawing.Size(104, 22)
        Me.txtQty.Text = ""
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 0)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 296)
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.Text = "Conf. Destino:"
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(128, 296)
        Me.txtLocationTarget.Size = New System.Drawing.Size(104, 22)
        Me.txtLocationTarget.Text = ""
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(8, -8)
        Me.picMINGC.Size = New System.Drawing.Size(32, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(128, 280)
        Me.lblLocationTarget.Size = New System.Drawing.Size(104, 16)
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 206)
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.Text = "Destino:"
        '
        'cboWhs
        '
        Me.cboWhs.Location = New System.Drawing.Point(88, 24)
        Me.cboWhs.Size = New System.Drawing.Size(144, 22)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 24)
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.Text = "Empresa:"
        '
        'cboMotivos
        '
        Me.cboMotivos.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.cboMotivos.Location = New System.Drawing.Point(8, 112)
        Me.cboMotivos.Size = New System.Drawing.Size(224, 19)
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(128, 204)
        Me.txtTarget.MaxLength = 20
        Me.txtTarget.Size = New System.Drawing.Size(104, 22)
        Me.txtTarget.Text = ""
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(88, 48)
        Me.txtInvoice.MaxLength = 20
        Me.txtInvoice.Size = New System.Drawing.Size(144, 22)
        Me.txtInvoice.Text = ""
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerCode.Location = New System.Drawing.Point(16, 72)
        Me.lblCustomerCode.Size = New System.Drawing.Size(56, 16)
        '
        'chkState
        '
        Me.chkState.Location = New System.Drawing.Point(8, 245)
        Me.chkState.Size = New System.Drawing.Size(88, 20)
        Me.chkState.Text = "Mal Estado"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.Text = "Factura:"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.Location = New System.Drawing.Point(80, 72)
        Me.lblCustomerName.Size = New System.Drawing.Size(152, 16)
        '
        'txtCodBarProduct
        '
        Me.txtCodBarProduct.Location = New System.Drawing.Point(8, 88)
        Me.txtCodBarProduct.Size = New System.Drawing.Size(224, 22)
        Me.txtCodBarProduct.Text = ""
        '
        'lblDateExpire
        '
        Me.lblDateExpire.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblDateExpire.Location = New System.Drawing.Point(9, 165)
        Me.lblDateExpire.Size = New System.Drawing.Size(224, 16)
        '
        'lblLote
        '
        Me.lblLote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblLote.Location = New System.Drawing.Point(9, 151)
        Me.lblLote.Size = New System.Drawing.Size(224, 16)
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblProductDescription.Location = New System.Drawing.Point(9, 138)
        Me.lblProductDescription.Size = New System.Drawing.Size(224, 16)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 245)
        Me.btnOK.Text = "Aceptar"
        '
        'lblBarLocation
        '
        Me.lblBarLocation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblBarLocation.Location = New System.Drawing.Point(8, 226)
        Me.lblBarLocation.Size = New System.Drawing.Size(224, 16)
        '
        'frmArrivalReturn
        '
        Me.ClientSize = New System.Drawing.Size(242, 272)
        Me.Controls.Add(Me.lblBarLocation)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblDateExpire)
        Me.Controls.Add(Me.lblLote)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.txtCodBarProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCustomerCode)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.chkState)
        Me.Controls.Add(Me.cboMotivos)
        Me.Controls.Add(Me.cboWhs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Text = "Ingreso por Cambio"

    End Sub

#End Region

    Private nArrivals_Task As Long
    Private sBarcode As String
    Private nConversionFactor As String
    Private sERP_Document As String
    Dim Graphics As Graphics
    Dim dtDateExpire As Date
    Dim Pen As New Pen(Color.Black)
    Dim strCodProducto, strLote, strUnit As String
    Dim bIsLoading As Boolean = False


    Private Sub DrawLines()

        Graphics = Nothing
        Graphics = Me.CreateGraphics
        Graphics.Clear(Color.White)
        'Graphics.DrawLine(Pen, 5, 32, 235, 32)      'Upper
        Graphics.DrawLine(Pen, 5, 32, 5, 275)       'Left   
        Graphics.DrawLine(Pen, 235, 32, 235, 275)   'Right
        'Graphics.DrawLine(Pen, 5, 240, 235, 240)    'Bottom
        'Graphics.DrawLine(Pen, 5, 68, 235, 68)      'Middle 1
        'Graphics.DrawLine(Pen, 5, 136, 235, 136)    'Middle 2

    End Sub

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            lblBarLocation.Text = ""
            lblCustomerCode.Text = ""
            lblCustomerName.Text = ""
            lblDateExpire.Text = ""
            lblLocationTarget.Text = ""
            lblLotNumber.Text = ""
            txtCodBarProduct.Text = ""
            txtInvoice.Text = ""
            txtTarget.Text = ""
            txtQty.Text = ""
            lblProductDescription.Text = ""
            cboMotivos.SelectedIndex = -1
            cboWhs.SelectedIndex = -1
            DrawLines()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
            txtQty.Enabled = False
        End Try
    End Sub

    Private Sub UpdateTask()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim iResult As Long
        Dim sResult As String
        Dim sValidatePurchase As String = ""
        Dim sFechaExp As String

        Try
            If MsgBox("Desea ejecutar la transaccion?", MsgBoxStyle.OKCancel, publicProject) = MsgBoxResult.Cancel Then
                Exit Sub
            End If

            'Validations

            If cboWhs.Text.Trim.Length = 0 Then
                MsgBox("Bodega Invalida", MsgBoxStyle.Exclamation, publicProject)
                cboWhs.SelectedIndex = 0
                cboWhs.Focus()
                Exit Sub
            End If
            If txtInvoice.Text.Trim.Length = 0 Then
                MsgBox("Factura Invalida", MsgBoxStyle.Exclamation, publicProject)
                txtInvoice.Focus()
                Exit Sub
            End If
            If lblCustomerCode.Text.Trim.Length = 0 Then
                MsgBox("Factura invalida", MsgBoxStyle.Exclamation, publicProject)
                txtInvoice.Text = ""
                txtInvoice.Focus()
                Exit Sub
            End If
            If cboMotivos.Text.Trim.Length = 0 Then
                MsgBox("Motivo ingresado invalido", MsgBoxStyle.Exclamation, publicProject)
                cboMotivos.SelectedIndex = 0
                cboMotivos.Focus()
                Exit Sub
            End If

            If Not IsNumeric(txtQty.Text) Then
                MsgBox("Cantidad ingresada invalida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Text = ""
                txtQty.Focus()
                Exit Sub
            End If
            If CDbl(txtQty.Text) <= 0 Then
                MsgBox("Cantidad ingresada invalida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Text = ""
                txtQty.Focus()
                Exit Sub
            End If
            If txtTarget.Text.Trim.Length = 0 Then
                MsgBox("Ubicacion invalida", MsgBoxStyle.Exclamation, publicProject)
                txtLocationTarget.Text = ""
                txtLocationTarget.Focus()
                Exit Sub
            End If
            Cursor.Current = Cursors.WaitCursor
            'sValidatePurchase = xArrivals.ValidateProductOnInvoice(txtInvoice.Text, strCodProducto, CDbl(txtQty.Text), "", "")
            If sValidatePurchase.Length > 0 Then
                MsgBox(sValidatePurchase & ". no se puede continuar")
                Exit Sub
            End If
            sResult = xArrivals.ArrivalByChange(modGlobal.publicUserID, strCodProducto, strLote, _
                                                            CDbl(txtQty.Text), txtTarget.Text, txtInvoice.Text, lblCustomerCode.Text, cboWhs.SelectedValue, "", strUnit, dtDateExpire)
            MsgBox("Transaccion ejecutada exitosamente", MsgBoxStyle.Information, publicProject)
            ClearFields()
            DrawLines()
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            Cursor.Current = Cursors.Default
        End Try
    End Sub


    Private Sub frmArrivalsDisc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsData As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices
        Try
            bIsLoading = True
            ClearFields()
            Cursor.Current = Cursors.WaitCursor

            sSQL = "SELECT  A.COD_COMPANY, A.DESCRIPTION FROM VW_EMPRESAS "

            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron Empresas", MsgBoxStyle.Information, publicProject)
                cboWhs.Enabled = False
            Else
                cboWhs.Enabled = True
            End If
            cboWhs.DataSource = dsData.Tables(0)
            cboWhs.DisplayMember = "DESCRIPTION"
            cboWhs.ValueMember = "COD_COMPANY"
            cboWhs.SelectedIndex = 0

            dsData = Nothing

            sSQL = "select * from DEF_DOMAINS where DOMAIN ='CAMBIO_MOTIVOS'"
            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron Motivos", MsgBoxStyle.Information, publicProject)
                cboMotivos.Enabled = False
            Else
                cboMotivos.Enabled = True
            End If


            cboMotivos.DataSource = dsData.Tables(0)
            cboMotivos.DisplayMember = "MEANING"
            cboMotivos.ValueMember = "DOMAINVALUE"
            cboMotivos.SelectedIndex = 0

            dsData = Nothing
            Cursor.Current = Cursors.Default
            bIsLoading = False

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()
            bIsLoading = False

        End Try
    End Sub

    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        UpdateTask()

    End Sub

    



    


    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        DrawLines()
        myTimer.Enabled = False
    End Sub


    Private Sub chkState_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkState.CheckStateChanged
        Dim xCS As New wsCommonServices.wsCommonServices
        If chkState.Checked Then
            Cursor.Current = Cursors.WaitCursor
            xCS.GetDomain("UBICACIONES_ESPECIALES", "MAL", "", txtTarget.Text, "", "", "")
            Cursor.Current = Cursors.Default
            txtTarget.Enabled = False
        Else
            txtTarget.Enabled = True
            txtTarget.Text = ""
            txtTarget.Focus()
        End If
    End Sub

  
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call UpdateTask()
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim xArrivals As New wsArrivals.wsArrivals
        If e.KeyChar = Chr(13) Then
            Try
                Dim xsarrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                lblBarLocation.Text = xsarrivals.GetLocationDescriptionNew(txtTarget.Text, publicUserID, "10")

                Cursor.Current = Cursors.Default
                UpdateTask()
            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                Cursor.Current = Cursors.Default
                txtTarget.Text = ""
                txtTarget.Focus()
            End Try
        End If
        If e.KeyChar = Chr(13) Then
            If IsNumeric(txtQty.Text) Then
                If CDbl(txtQty.Text) > 0 Then
                    'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboWhs.SelectedValue)
                    txtTarget.Focus()
                Else
                    txtQty.Text = ""
                    MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
                End If
            Else
                txtQty.Text = ""
                MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
            End If
        End If

    End Sub


    Private Sub txtTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Dim xsarrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                lblBarLocation.Text = xsarrivals.GetLocationDescriptionNew(txtTarget.Text, publicUserID, "11")

                Cursor.Current = Cursors.Default
                UpdateTask()
            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                Cursor.Current = Cursors.Default
                txtTarget.Text = ""
                txtTarget.Focus()
            End Try
        End If
    End Sub

    Private Sub txtInvoice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvoice.KeyPress
        Dim bValidation As Boolean
        Dim xArrivals As New wsArrivals.wsArrivals

        Try
            If e.KeyChar = Chr(13) Then
                'If IsNumeric(txtInvoice.Text) Then
                Cursor.Current = Cursors.WaitCursor
                bValidation = xArrivals.ValidateInvoice("", "", "", "", "")

                If bValidation = False Then
                    MsgBox("La Factura no existe", MsgBoxStyle.Information, publicProject)
                    txtInvoice.Text = ""
                    lblCustomerCode.Text = ""
                    lblCustomerName.Text = ""
                    MsgBox("Factura no existe", MsgBoxStyle.Exclamation, publicProject)
                    txtInvoice.Focus()
                Else
                    txtCodBarProduct.Focus()
                End If
                Cursor.Current = Cursors.Default
                'End If
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
            Cursor.Current = Cursors.Default
        End Try
    End Sub


    Private Sub txtCodBarProduct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBarProduct.KeyPress
        If e.KeyChar = Chr(13) Then

            Try
                Dim xArrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                lblProductDescription.Text = xArrivals.GetProductDescription(txtCodBarProduct.Text)
                Cursor.Current = Cursors.Default
                strCodProducto = txtCodBarProduct.Text
                strLote = 15
                strUnit = ""
                lblLote.Text = "Lote: " & strLote
                lblDateExpire.Text = "Fecha de Vencimiento 10/10/2007"
                dtDateExpire = "10/10/2007"
                cboMotivos.Focus()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtCodBarProduct.Text = ""
                strCodProducto = ""
                strLote = ""
                strUnit = ""
                lblLote.Text = ""
                lblDateExpire.Text = ""
                lblProductDescription.Text = ""
                Cursor.Current = Cursors.Default
                txtCodBarProduct.Focus()
            End Try
        End If
    End Sub

    Private Sub cboMotivos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMotivos.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQty.Focus()
        End If
    End Sub

    Private Sub cboWhs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboWhs.KeyPress
        If e.KeyChar = Chr(13) Then
            txtInvoice.Focus()
        End If
    End Sub

End Class
