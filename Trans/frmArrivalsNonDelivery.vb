Public Class frmArrivalsNonDelivery
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboReasons As System.Windows.Forms.ComboBox
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboInvoiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents lblCodProduct As System.Windows.Forms.Label
    Friend WithEvents lblCustomerCode As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalsNonDelivery))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboReasons = New System.Windows.Forms.ComboBox
        Me.txtInvoice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboInvoiceType = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.lblCodProduct = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblCustomerCode = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grdData = New System.Windows.Forms.DataGrid
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(40, 8)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Detalle de Factura"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 272)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtLocationTarget)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cboReasons)
        Me.TabPage1.Controls.Add(Me.txtInvoice)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboInvoiceType)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cboUnit)
        Me.TabPage1.Controls.Add(Me.lblLotNumber)
        Me.TabPage1.Controls.Add(Me.lblCodProduct)
        Me.TabPage1.Controls.Add(Me.txtBarcode)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblProductName)
        Me.TabPage1.Controls.Add(Me.txtQty)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(232, 246)
        Me.TabPage1.Text = "Ingreso"
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(100, 214)
        Me.txtLocationTarget.MaxLength = 20
        Me.txtLocationTarget.Size = New System.Drawing.Size(128, 22)
        Me.txtLocationTarget.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 222)
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.Text = "Destino:"
        '
        'cboReasons
        '
        Me.cboReasons.Location = New System.Drawing.Point(9, 39)
        Me.cboReasons.Size = New System.Drawing.Size(215, 22)
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(120, 63)
        Me.txtInvoice.MaxLength = 15
        Me.txtInvoice.Size = New System.Drawing.Size(104, 22)
        Me.txtInvoice.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.Text = "Factura:"
        '
        'cboInvoiceType
        '
        Me.cboInvoiceType.Location = New System.Drawing.Point(71, 63)
        Me.cboInvoiceType.Size = New System.Drawing.Size(48, 22)
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 26)
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.Text = "Motivo"
        '
        'cboUnit
        '
        Me.cboUnit.Location = New System.Drawing.Point(72, 187)
        Me.cboUnit.Size = New System.Drawing.Size(48, 22)
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLotNumber.Location = New System.Drawing.Point(123, 131)
        Me.lblLotNumber.Size = New System.Drawing.Size(96, 16)
        Me.lblLotNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCodProduct
        '
        Me.lblCodProduct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodProduct.Location = New System.Drawing.Point(8, 131)
        Me.lblCodProduct.Size = New System.Drawing.Size(96, 16)
        Me.lblCodProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(8, 107)
        Me.txtBarcode.Size = New System.Drawing.Size(216, 22)
        Me.txtBarcode.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 195)
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.Text = "Cantidad:"
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(8, 155)
        Me.lblProductName.Size = New System.Drawing.Size(212, 19)
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(124, 187)
        Me.txtQty.Size = New System.Drawing.Size(104, 22)
        Me.txtQty.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 91)
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.Text = "Cod. Barras Producto"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblCustomerCode)
        Me.TabPage2.Controls.Add(Me.lblCustomerName)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.grdData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(232, 246)
        Me.TabPage2.Text = "Detalle de Factura"
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblCustomerCode.Location = New System.Drawing.Point(48, 32)
        Me.lblCustomerCode.Size = New System.Drawing.Size(50, 16)
        Me.lblCustomerCode.Visible = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.Location = New System.Drawing.Point(8, 48)
        Me.lblCustomerName.Size = New System.Drawing.Size(216, 16)
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'grdData
        '
        Me.grdData.Location = New System.Drawing.Point(4, 72)
        Me.grdData.Size = New System.Drawing.Size(224, 168)
        Me.grdData.Text = "DataGrid1"
        '
        'frmArrivalsNonDelivery
        '
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.TabControl1)
        Me.Text = "Ingreso Flete Falso"

    End Sub

#End Region


    Dim dsData As DataSet
    Dim sCompany As String
    Dim bIsLoading As Boolean = False
    Dim sExpDate As String
    Dim sUnit As String

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            txtBarcode.Text = ""
            lblCodProduct.Text = ""
            lblLotNumber.Text = ""
            lblProductName.Text = ""
            cboUnit.Items.Clear()
            cboUnit.Text = ""
            txtQty.Text = ""
            txtBarcode.Focus()

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
            If lblCustomerCode.Text.Trim.Length = 0 Then
                MsgBox("Factura invalida", MsgBoxStyle.Exclamation, publicProject)
                txtInvoice.Text = ""
                txtInvoice.Focus()
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
            If txtLocationTarget.Text.Trim.Length = 0 Then
                MsgBox("Ubicacion invalida", MsgBoxStyle.Exclamation, publicProject)
                txtLocationTarget.Text = ""
                txtLocationTarget.Focus()
                Exit Sub
            End If
            If txtBarcode.Text.Trim.Length = 0 Then
                MsgBox("Producto invalido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Text = ""
                txtBarcode.Focus()
                Exit Sub
            End If
            
            Cursor.Current = Cursors.WaitCursor
            sValidatePurchase = xArrivals.ValidateProductOnInvoice(cboInvoiceType.Text, txtInvoice.Text, lblCodProduct.Text, CDbl(txtQty.Text), sUnit, sCompany)
            Cursor.Current = Cursors.WaitCursor
            If sValidatePurchase.Length > 0 Then
                If MsgBox(sValidatePurchase & ". Desea continuar?", MsgBoxStyle.OKCancel, publicProject) = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If
            Cursor.Current = Cursors.WaitCursor
            sResult = xArrivals.ArrivalByReturnInvoice(modGlobal.publicUserID, lblCodProduct.Text, lblLotNumber.Text, _
                                                            CDbl(txtQty.Text), txtLocationTarget.Text, cboInvoiceType.Text, txtInvoice.Text, lblCustomerCode.Text, sCompany, "", sUnit, sExpDate, "14", cboReasons.SelectedValue, False, "", False)
            Cursor.Current = Cursors.WaitCursor
            MsgBox("Transaccion ejecutada exitosamente", MsgBoxStyle.Information, publicProject)

            ClearFields()
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

        End Try
    End Sub

    Private Sub frmInit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsData As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices
        Try
            bIsLoading = True
            Select Case publicReturnCode                
                Case "16"
                    lblTitle.Text = "Flete Falso"
                Case "17"
                    lblTitle.Text = "Flete Falso - Anulacion"
            End Select

            ClearFields()
            Cursor.Current = Cursors.WaitCursor

            sSQL = "SELECT DISTINCT Doc_Type FROM VW_SBO_Facturas_Tipos " & _
                    " WHERE ERP_Warehouse = 'B040076' OR ERP_Warehouse = 'B090281' ORDER BY Doc_Type"

            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron tipos de Facturas", MsgBoxStyle.Information, publicProject)
                cboInvoiceType.Enabled = False
            Else
                cboInvoiceType.Enabled = True
            End If

            cboInvoiceType.DataSource = dsData.Tables(0)
            cboInvoiceType.DisplayMember = "Doc_Type"
            cboInvoiceType.ValueMember = "Doc_Type"
            cboInvoiceType.SelectedIndex = 0

            sSQL = "SELECT drky, drdl01 from vw_sbo_motivos_devolucion " & _
                    " order by drky"

            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron motivos de devolucion", MsgBoxStyle.Information, publicProject)
                cboReasons.Enabled = False
            Else
                cboReasons.Enabled = True
            End If

            cboReasons.DataSource = dsData.Tables(0)
            cboReasons.DisplayMember = "drdl01"
            cboReasons.ValueMember = "drky"
            cboReasons.SelectedIndex = 0

            Cursor.Current = Cursors.Default
            dsData = Nothing
            bIsLoading = False

        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()
            bIsLoading = False

        End Try

    End Sub

    Private Sub picClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateTask()
    End Sub


    


    Private Sub txtQty_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        txtQty.SelectAll()
    End Sub

    Private Sub txtLocationTarget_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLocationTarget.SelectAll()
    End Sub


    Private Sub txtBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.Click
        txtBarcode.SelectAll()
    End Sub


    Private Sub txtQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.Click
        txtQty.SelectAll()
    End Sub


    


    Private Sub TabPage1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.GotFocus
        txtBarcode.Focus()
    End Sub

    Private Sub LoadGrid()
        Dim wsServ As New wsCommonServices.wsCommonServices

        Dim sSQL As String
        Dim sLotNumber As String
        Dim sProductDescription As String
        Dim bFound As Boolean = False
        Dim bTruck As Boolean = False

        Try
            Dim ts1 As New DataGridTableStyle
            Dim TextCol As New DataGridTextBoxColumn

            ts1.MappingName = "myTable"
            TextCol.MappingName = "Task_Number"
            TextCol.HeaderText = "#"
            TextCol.Width = 30
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Cod_Product"
            TextCol.HeaderText = "Codigo"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Qty_Served"
            TextCol.HeaderText = "Cantidad"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Qty_Checked"
            TextCol.HeaderText = "Chequeado"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Measure_Unit"
            TextCol.HeaderText = "Unidad"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Description"
            TextCol.HeaderText = "Description"
            TextCol.Width = 300
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Presentacion"
            TextCol.HeaderText = "Presen."
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)
            TextCol = Nothing

            grdData.TableStyles.Clear()
            grdData.TableStyles.Add(ts1)

            sSQL = "SELECT * from x where y = z"

            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                'grdData.Enabled = False
                bFound = False
                'MsgBox("No se encontro inventario en la ubicacion ingresada", MsgBoxStyle.Information, publicProject)
            Else
                bFound = True
                'grdData.Enabled = True
            End If

            grdData.DataSource = dsData.Tables(0)

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try


    End Sub


    Private Sub txtLocationTarget_GotFocus1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLocationTarget.SelectAll()
    End Sub

    Private Sub txtInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoice.TextChanged

    End Sub

    

    Private Sub txtLocationTarget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.TextChanged

    End Sub

    

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    'Private Sub txtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    Dim xServ As New wsCommonServices.wsCommonServices
    '    Dim sLocalCompany As String

    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Cursor.Current = Cursors.WaitCursor
    '            Call xServ.ProcessBarcode(txtBarcode.Text, lblCodProduct.Text, lblLotNumber.Text, lblProductName.Text, txtQty.Text, "", sExpDate, sLocalCompany, sUnit)
    '            Cursor.Current = Cursors.Default
    '            If sLocalCompany <> sCompany Then
    '                MsgBox("Producto pertenece a una Compania diferente a la de la factura", MsgBoxStyle.Exclamation, publicProject)
    '                txtBarcode.Text = ""
    '                lblCodProduct.Text = ""
    '                lblLotNumber.Text = ""
    '                lblProductName.Text = ""
    '                txtBarcode.Focus()
    '                Exit Sub
    '            End If

    '            With cboUnit
    '                .Items.Clear()
    '                .Items.Add(sUnit)
    '                If sUnit.Trim = "CA" Then
    '                    .Items.Add("UN")
    '                End If
    '                .SelectedIndex = 0
    '            End With

    '            txtLocationTarget.Focus()

    '        End If
    '    Catch ex As Exception
    '        lblCodProduct.Text = ""
    '        lblLotNumber.Text = ""
    '        lblProductName.Text = ""
    '        sLocalCompany = ""
    '        sUnit = ""
    '        Cursor.Current = Cursors.Default
    '        MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
    '        txtBarcode.Text = ""
    '        txtBarcode.Focus()

    '    End Try

    'End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim xServ As New wsCommonServices.wsCommonServices
        Dim sLocalCompany As String

        Try
            If e.KeyChar = Chr(13) Then
                Cursor.Current = Cursors.WaitCursor
                Call xServ.ProcessBarcode(txtBarcode.Text, lblCodProduct.Text, lblLotNumber.Text, lblProductName.Text, txtQty.Text, "", sExpDate, sLocalCompany, sUnit, modGlobal.publicCurrentCountry)
                Cursor.Current = Cursors.Default
                If sLocalCompany <> sCompany Then
                    MsgBox("Producto pertenece a una Compania diferente a la de la factura", MsgBoxStyle.Exclamation, publicProject)
                    txtBarcode.Text = ""
                    lblCodProduct.Text = ""
                    lblLotNumber.Text = ""
                    lblProductName.Text = ""
                    txtBarcode.Focus()
                    Exit Sub
                End If

                With cboUnit
                    .Items.Clear()
                    .Items.Add(sUnit)
                    If sUnit.Trim = "CA" Then
                        .Items.Add("UN")
                    End If
                    .SelectedIndex = 0
                End With

                txtLocationTarget.Focus()

            End If
        Catch ex As Exception
            lblCodProduct.Text = ""
            lblLotNumber.Text = ""
            lblProductName.Text = ""
            sLocalCompany = ""
            sUnit = ""
            Cursor.Current = Cursors.Default
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
            txtBarcode.Text = ""
            txtBarcode.Focus()

        End Try

    End Sub

    'Private Sub txtQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        UpdateTask()
    '    End If
    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            UpdateTask()
        End If
    End Sub

    'Private Sub txtInvoice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInvoice.KeyDown
    '    Dim bValidation As Boolean
    '    Dim xArrivals As New wsArrivals.wsArrivals

    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            If IsNumeric(txtInvoice.Text) Then
    '                Cursor.Current = Cursors.WaitCursor
    '                bValidation = xArrivals.ValidateInvoice(cboInvoiceType.Text, txtInvoice.Text, sCompany, lblCustomerCode.Text, lblCustomerName.Text)
    '                Cursor.Current = Cursors.Default

    '                If bValidation = False Then
    '                    MsgBox("La Factura no existe", MsgBoxStyle.Information, publicProject)
    '                    txtInvoice.Text = ""
    '                    lblCustomerCode.Text = ""
    '                    lblCustomerName.Text = ""
    '                    txtInvoice.Focus()
    '                Else
    '                    txtBarcode.Focus()
    '                End If

    '            End If
    '        End If

    '    Catch ex As Exception
    '        MsgBox(FormatErrorMessage(ex.Message))
    '        Cursor.Current = Cursors.Default
    '    End Try

    'End Sub

    Private Sub txtInvoice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInvoice.KeyPress
        Dim bValidation As Boolean
        Dim xArrivals As New wsArrivals.wsArrivals

        Try
            If e.KeyChar = Chr(13) Then
                If IsNumeric(txtInvoice.Text) Then
                    Cursor.Current = Cursors.WaitCursor
                    bValidation = xArrivals.ValidateInvoice(cboInvoiceType.Text, txtInvoice.Text, sCompany, lblCustomerCode.Text, lblCustomerName.Text)
                    Cursor.Current = Cursors.Default

                    If bValidation = False Then
                        MsgBox("La Factura no existe", MsgBoxStyle.Information, publicProject)
                        txtInvoice.Text = ""
                        lblCustomerCode.Text = ""
                        lblCustomerName.Text = ""
                        txtInvoice.Focus()
                    Else
                        txtBarcode.Focus()
                    End If

                End If
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    'Private Sub txtLocationTarget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocationTarget.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        UpdateTask()
    '    End If
    'End Sub

    Private Sub txtLocationTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocationTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            UpdateTask()
        End If
    End Sub
End Class
