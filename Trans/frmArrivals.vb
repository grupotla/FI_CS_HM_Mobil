Public Class frmArrivals
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
    Friend WithEvents lblCod_Product As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents lblSupplierCode As System.Windows.Forms.Label
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTarget As System.Windows.Forms.TextBox
    Friend WithEvents cboTones As System.Windows.Forms.ComboBox
    Friend WithEvents cboUnits As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseOrder As System.Windows.Forms.TextBox
    Friend WithEvents chkState As System.Windows.Forms.CheckBox
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivals))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblCod_Product = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.lblSupplierName = New System.Windows.Forms.Label
        Me.lblSupplierCode = New System.Windows.Forms.Label
        Me.myTimer = New System.Windows.Forms.Timer
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboWhs = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboProduct = New System.Windows.Forms.ComboBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.cboTones = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboUnits = New System.Windows.Forms.ComboBox
        Me.txtTarget = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPurchaseOrder = New System.Windows.Forms.TextBox
        Me.chkState = New System.Windows.Forms.CheckBox
        Me.lblProductDescription = New System.Windows.Forms.Label
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 8)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Ingreso por Compra"
        '
        'lblCod_Product
        '
        Me.lblCod_Product.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCod_Product.Location = New System.Drawing.Point(16, 152)
        Me.lblCod_Product.Size = New System.Drawing.Size(56, 16)
        Me.lblCod_Product.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(224, 96)
        Me.lblLotNumber.Size = New System.Drawing.Size(8, 16)
        Me.lblLotNumber.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(128, 200)
        Me.txtQty.Size = New System.Drawing.Size(104, 22)
        Me.txtQty.Text = ""
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 8)
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
        Me.picMINGC.Location = New System.Drawing.Point(8, 0)
        Me.picMINGC.Size = New System.Drawing.Size(32, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(128, 280)
        Me.lblLocationTarget.Size = New System.Drawing.Size(104, 16)
        '
        'lblSupplierName
        '
        Me.lblSupplierName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupplierName.Location = New System.Drawing.Point(72, 80)
        Me.lblSupplierName.Size = New System.Drawing.Size(160, 16)
        '
        'lblSupplierCode
        '
        Me.lblSupplierCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupplierCode.Location = New System.Drawing.Point(8, 80)
        Me.lblSupplierCode.Size = New System.Drawing.Size(64, 16)
        Me.lblSupplierCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 192)
        Me.Label8.Size = New System.Drawing.Size(216, 16)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 224)
        Me.Label3.Text = "Destino:"
        '
        'cboWhs
        '
        Me.cboWhs.Location = New System.Drawing.Point(88, 32)
        Me.cboWhs.Size = New System.Drawing.Size(144, 22)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 32)
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.Text = "Empresa:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 152)
        Me.Label7.Text = "Tono:"
        '
        'cboProduct
        '
        Me.cboProduct.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.cboProduct.Location = New System.Drawing.Point(8, 96)
        Me.cboProduct.Size = New System.Drawing.Size(224, 19)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(158, 248)
        Me.btnOK.Text = "Aceptar"
        '
        'cboTones
        '
        Me.cboTones.Location = New System.Drawing.Point(88, 152)
        Me.cboTones.Size = New System.Drawing.Size(144, 22)
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 176)
        Me.Label9.Text = "Presentacion:"
        '
        'cboUnits
        '
        Me.cboUnits.Location = New System.Drawing.Point(88, 176)
        Me.cboUnits.Size = New System.Drawing.Size(144, 22)
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(128, 224)
        Me.txtTarget.Size = New System.Drawing.Size(104, 22)
        Me.txtTarget.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 56)
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.Text = "Orden Prod."
        '
        'txtPurchaseOrder
        '
        Me.txtPurchaseOrder.Location = New System.Drawing.Point(88, 56)
        Me.txtPurchaseOrder.Size = New System.Drawing.Size(144, 22)
        Me.txtPurchaseOrder.Text = ""
        '
        'chkState
        '
        Me.chkState.Location = New System.Drawing.Point(8, 248)
        Me.chkState.Text = "Mal Estado"
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblProductDescription.Location = New System.Drawing.Point(8, 120)
        Me.lblProductDescription.Size = New System.Drawing.Size(224, 32)
        '
        'frmArrivals
        '
        Me.ClientSize = New System.Drawing.Size(242, 280)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.txtPurchaseOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.cboUnits)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboTones)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkState)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboWhs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSupplierCode)
        Me.Controls.Add(Me.lblSupplierName)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblCod_Product)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label8)
        Me.Text = "Ingreso por Compra"

    End Sub

#End Region

    Private nArrivals_Task As Long
    Private sBarcode As String
    Private nConversionFactor As String
    Private sERP_Document As String
    Dim Graphics As Graphics
    Dim Pen As New Pen(Color.Black)
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
            lblCod_Product.Text = ""
            lblLotNumber.Text = ""
            txtTarget.Text = ""
            txtQty.Text = ""
            lblProductDescription.Text = ""
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
            If txtPurchaseOrder.Text.Trim.Length = 0 Then
                MsgBox("Factura Invalida", MsgBoxStyle.Exclamation, publicProject)
                txtPurchaseOrder.Focus()
                Exit Sub
            End If
            If lblSupplierCode.Text.Trim.Length = 0 Then
                MsgBox("Factura invalida", MsgBoxStyle.Exclamation, publicProject)
                txtPurchaseOrder.Text = ""
                txtPurchaseOrder.Focus()
                Exit Sub
            End If
            If cboProduct.Text.Trim.Length = 0 Then
                MsgBox("Producto ingresado invalido", MsgBoxStyle.Exclamation, publicProject)
                cboProduct.SelectedIndex = 0
                cboProduct.Focus()
                Exit Sub
            End If
            If cboTones.Text.Trim.Length = 0 Then
                MsgBox("Tono ingresado invalido", MsgBoxStyle.Exclamation, publicProject)
                cboTones.SelectedIndex = 0
                cboTones.Focus()
                Exit Sub
            End If
            If cboUnits.Text.Trim.Length = 0 Then
                MsgBox("Presentacion ingresada invalido", MsgBoxStyle.Exclamation, publicProject)
                cboUnits.SelectedIndex = 0
                cboUnits.Focus()
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

            sValidatePurchase = xArrivals.ValidateProductOnPurchaseOrder(txtPurchaseOrder.Text, cboProduct.SelectedValue, CDbl(txtQty.Text), "1", cboUnits.SelectedValue)
            If sValidatePurchase.Length > 0 Then
                If MsgBox(sValidatePurchase & ". Desea continuar?", MsgBoxStyle.OKCancel, publicProject) = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If

            'sResult = xArrivals.ArrivalToWarehouse(modGlobal.publicUserID, cboProduct.SelectedValue, cboTones.SelectedValue, _
            '                                                CDbl(txtQty.Text), txtTarget.Text, lblSupplierCode.Text, txtPurchaseOrder.Text, "1", cboUnits.SelectedValue, IIf(Me.chkState.Checked = True, "1", "0"), 0, "", "")
            ''MsgBox("Transaccion ejecutada exitosamente", MsgBoxStyle.Information, publicProject)
            ClearFields()
            DrawLines()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try
    End Sub


    Private Sub frmArrivalsDisc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsData As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices
        Try
            bIsLoading = True
            ClearFields()


            sSQL = "SELECT a.COD_COMPANY, a.description" & _
                      " FROM DEF_COMPANIES A, DEF_USERS_WAREHOUSES B " & _
                      " WHERE A.Cod_Warehouse = B.Cod_Warehouse " & _
                      " AND B.Cod_User = '" & publicUserID & "' "

            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron Empresas", MsgBoxStyle.Information, publicProject)
                cboWhs.Enabled = False
            Else
                cboWhs.Enabled = True
            End If
            cboWhs.DataSource = dsData.Tables(0)
            cboWhs.DisplayMember = "description"
            cboWhs.ValueMember = "cod_company"
            cboWhs.SelectedIndex = 0

            'FillDocuments()
            dsData = Nothing


            sSQL = "SELECT domainvalue,meaning" & _
                      " FROM DEF_DOMAINS where DOMAIN='TONES'"
            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron Tonos", MsgBoxStyle.Information, publicProject)
                cboTones.Enabled = False
            Else
                cboTones.Enabled = True
            End If
            cboTones.DataSource = dsData.Tables(0)
            cboTones.DisplayMember = "meaning"
            cboTones.ValueMember = "domainvalue"
            cboTones.SelectedIndex = 0
            dsData = Nothing
            sSQL = "SELECT domainvalue,meaning" & _
                      " FROM DEF_DOMAINS where DOMAIN='MEASURE_UNITS'"
            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron Presentaciones", MsgBoxStyle.Information, publicProject)
                cboUnits.Enabled = False
            Else
                cboUnits.Enabled = True
            End If
            cboUnits.DataSource = dsData.Tables(0)
            cboUnits.DisplayMember = "meaning"
            cboUnits.ValueMember = "domainvalue"
            cboUnits.SelectedIndex = 0
            bIsLoading = False

        Catch ex As Exception

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
            xCS.GetDomain("UBICACIONES_ESPECIALES", "MAL", "", txtTarget.Text, "", "", "")
            txtTarget.Enabled = False
        Else
            txtTarget.Enabled = True
            txtTarget.Text = ""
            txtTarget.Focus()
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        UpdateTask()
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Dim xCS As New wsCommonServices.wsCommonServices
        txtQty.SelectAll()
        If cboUnits.SelectedValue <> "ST" Then
            nConversionFactor = 1
            Label6.Text = "Cantidad: " & CStr(nConversionFactor) & " U."
        Else
            nConversionFactor = 1
            Label6.Text = "Cantidad: "
        End If
    End Sub

    Private Sub cboProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct.SelectedIndexChanged
        Dim xArrivals As New wsArrivals.wsArrivals

        Try
            'Get Product Description
            If cboProduct.Text <> Nothing Then
                lblProductDescription.Text = xArrivals.GetProductDescription(cboProduct.SelectedValue)
            Else
                lblProductDescription.Text = ""
            End If

        Catch ex As Exception
            lblProductDescription.Text = ""
        End Try

    End Sub

    Private Sub cboWhs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWhs.SelectedIndexChanged

        If Not bIsLoading Then
            FillDocuments()
        End If

    End Sub

    Private Sub FillDocuments()
        Dim dsData As DataSet
        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim sSQL As String
        Try

            If cboWhs.Text <> Nothing Then
                sSQL = "SELECT DISTINCT ERP_Number, ERP_Number AS DocDescription" & _
                        " FROM WMS_ARRIVALS A, DEF_WAREHOUSES B " & _
                        " WHERE A.Warehouse_Id = B.ERP_Warehouse " & _
                            " AND A.Status = '0' " & _
                            " AND A.Company_Id = '1' " & _
                            " AND B.Cod_Warehouse = '" & cboWhs.SelectedValue & "' "


                dsData = wsServ.GetDataSet(sSQL)
                If dsData.Tables(0).Rows.Count = 0 Then
                    'MsgBox("No se encontraron Facturas disponibles para ser recibidas", MsgBoxStyle.Information, publicProject)
                    dsData = Nothing
                    Exit Sub
                End If

                'txtPurchaseOrder.DataSource = dsData.Tables(0)
                'txtPurchaseOrder.DisplayMember = "DocDescription"
                'txtPurchaseOrder.ValueMember = "ERP_Number"
                'txtPurchaseOrder.SelectedIndex = 0

            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))

        End Try
    End Sub

    

    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    Dim xArrivals As New wsArrivals.wsArrivals

    '    If e.KeyCode = Keys.Enter Then
    '        If IsNumeric(txtQty.Text) Then
    '            If CDbl(txtQty.Text) > 0 Then
    '                'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboWhs.SelectedValue)
    '                txtTarget.Focus()
    '            Else
    '                txtQty.Text = ""
    '                MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
    '            End If
    '        Else
    '            txtQty.Text = ""
    '            MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
    '        End If
    '    End If

    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim xArrivals As New wsArrivals.wsArrivals

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

    'Private Sub txtTarget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTarget.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        UpdateTask()
    '    End If
    'End Sub

    Private Sub txtTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            UpdateTask()
        End If
    End Sub

    'Private Sub txtPurchaseOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPurchaseOrder.KeyDown
    '    Dim xArrivals As New wsArrivals.wsArrivals

    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            If IsNumeric(txtPurchaseOrder.Text) Then
    '                If xArrivals.ValidatePurchaseOrder(txtPurchaseOrder.Text, lblSupplierCode.Text, lblSupplierName.Text, "1") Then
    '                    Dim dsData As DataSet
    '                    Dim sSQL As String
    '                    Dim wsServ As New wsCommonServices.wsCommonServices
    '                    Try
    '                        sSQL = " select top 1 ' ' AS cod_product, ' ' as description from vw_sbo_products "

    '                        sSQL = sSQL & " union select c.cod_product, c.cod_product+'-'+c.description as description from " & _
    '                                " vw_sbo_purchases_header a, " & _
    '                                " vw_sbo_purchases_detail B, " & _
    '                                " vw_sbo_products c " & _
    '                                " where a.docentry = b.docentry And a.company = b.company " & _
    '                                " and b.company=c.company " & _
    '                                " and b.itemcode=c.cod_product " & _
    '                                " and a.docNum='" & txtPurchaseOrder.Text & "'" & _
    '                                " and a.company='1'"

    '                        dsData = wsServ.GetDataSet(sSQL)
    '                        If dsData.Tables(0).Rows.Count = 0 Then
    '                            MsgBox("No se encontraron Productos", MsgBoxStyle.Information, publicProject)
    '                        End If
    '                        cboProduct.DataSource = dsData.Tables(0)
    '                        cboProduct.DisplayMember = "description"
    '                        cboProduct.ValueMember = "cod_product"
    '                        cboProduct.SelectedIndex = 0
    '                        cboProduct.Focus()
    '                        dsData = Nothing

    '                    Catch ex As Exception

    '                        mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
    '                        Me.Close()

    '                    End Try

    '                Else
    '                    lblSupplierCode.Text = ""
    '                    lblSupplierName.Text = ""
    '                    MsgBox("Factura no existe", MsgBoxStyle.Exclamation, publicProject)
    '                    txtPurchaseOrder.Focus()
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(FormatErrorMessage(ex.Message))
    '    End Try

    'End Sub

    Private Sub txtPurchaseOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurchaseOrder.KeyPress
        Dim xArrivals As New wsArrivals.wsArrivals

        Try
            If e.KeyChar = Chr(13) Then
                If IsNumeric(txtPurchaseOrder.Text) Then
                    If xArrivals.ValidatePurchaseOrder(txtPurchaseOrder.Text, lblSupplierCode.Text, lblSupplierName.Text, "1") Then
                        Dim dsData As DataSet
                        Dim sSQL As String
                        Dim wsServ As New wsCommonServices.wsCommonServices
                        Try
                            sSQL = " select top 1 ' ' AS cod_product, ' ' as description from vw_sbo_products "

                            sSQL = sSQL & " union select c.cod_product, c.cod_product+'-'+c.description as description from " & _
                                    " vw_sbo_purchases_header a, " & _
                                    " vw_sbo_purchases_detail B, " & _
                                    " vw_sbo_products c " & _
                                    " where a.docentry = b.docentry And a.company = b.company " & _
                                    " and b.company=c.company " & _
                                    " and b.itemcode=c.cod_product " & _
                                    " and a.docNum='" & txtPurchaseOrder.Text & "'" & _
                                    " and a.company='1'"

                            dsData = wsServ.GetDataSet(sSQL)
                            If dsData.Tables(0).Rows.Count = 0 Then
                                MsgBox("No se encontraron Productos", MsgBoxStyle.Information, publicProject)
                            End If
                            cboProduct.DataSource = dsData.Tables(0)
                            cboProduct.DisplayMember = "description"
                            cboProduct.ValueMember = "cod_product"
                            cboProduct.SelectedIndex = 0
                            cboProduct.Focus()
                            dsData = Nothing

                        Catch ex As Exception

                            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
                            Me.Close()

                        End Try

                    Else
                        lblSupplierCode.Text = ""
                        lblSupplierName.Text = ""
                        MsgBox("Factura no existe", MsgBoxStyle.Exclamation, publicProject)
                        txtPurchaseOrder.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        End Try

    End Sub
End Class
