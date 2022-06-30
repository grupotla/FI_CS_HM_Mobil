Public Class frmArrivalReturnHAME
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents chkState As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblBarLocation As System.Windows.Forms.Label
    Friend WithEvents txtCodBarProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCodProduct As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerCode As System.Windows.Forms.Label
    Friend WithEvents cboInvoiceType As System.Windows.Forms.ComboBox
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboReasons As System.Windows.Forms.ComboBox
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtAssignTo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalReturnHAME))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.lblProductDescription = New System.Windows.Forms.Label
        Me.chkState = New System.Windows.Forms.CheckBox
        Me.txtCodBarProduct = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblBarLocation = New System.Windows.Forms.Label
        Me.lblCodProduct = New System.Windows.Forms.Label
        Me.cboInvoiceType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.lblCustomerCode = New System.Windows.Forms.Label
        Me.txtInvoice = New System.Windows.Forms.TextBox
        Me.myTimer = New System.Windows.Forms.Timer
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.cboReasons = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.txtAssignTo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 0)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Ingreso por Flete Falso"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 192)
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(112, 192)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Size = New System.Drawing.Size(120, 22)
        Me.txtQty.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 296)
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.Text = "Conf. Destino:"
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(8, 0)
        Me.picMINGC.Size = New System.Drawing.Size(26, 26)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(128, 280)
        Me.lblLocationTarget.Size = New System.Drawing.Size(104, 16)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 224)
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.Text = "Destino:"
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(112, 216)
        Me.txtLocationTarget.MaxLength = 20
        Me.txtLocationTarget.Size = New System.Drawing.Size(120, 22)
        Me.txtLocationTarget.Text = ""
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblProductDescription.Location = New System.Drawing.Point(8, 112)
        Me.lblProductDescription.Size = New System.Drawing.Size(224, 16)
        '
        'chkState
        '
        Me.chkState.Location = New System.Drawing.Point(8, 256)
        Me.chkState.Size = New System.Drawing.Size(88, 20)
        Me.chkState.Text = "Mal Estado"
        '
        'txtCodBarProduct
        '
        Me.txtCodBarProduct.Location = New System.Drawing.Point(48, 72)
        Me.txtCodBarProduct.Size = New System.Drawing.Size(184, 22)
        Me.txtCodBarProduct.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 256)
        Me.btnOK.Text = "Aceptar"
        '
        'lblBarLocation
        '
        Me.lblBarLocation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBarLocation.Location = New System.Drawing.Point(8, 240)
        Me.lblBarLocation.Size = New System.Drawing.Size(224, 16)
        Me.lblBarLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCodProduct
        '
        Me.lblCodProduct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCodProduct.Location = New System.Drawing.Point(16, 96)
        Me.lblCodProduct.Size = New System.Drawing.Size(104, 16)
        Me.lblCodProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboInvoiceType
        '
        Me.cboInvoiceType.Location = New System.Drawing.Point(64, 128)
        Me.cboInvoiceType.Size = New System.Drawing.Size(48, 22)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 128)
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.Text = "Factura:"
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLotNumber.Location = New System.Drawing.Point(128, 96)
        Me.lblLotNumber.Size = New System.Drawing.Size(104, 16)
        Me.lblLotNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerName.Location = New System.Drawing.Point(16, 152)
        Me.lblCustomerName.Size = New System.Drawing.Size(216, 16)
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblCustomerCode.Location = New System.Drawing.Point(128, 152)
        Me.lblCustomerCode.Size = New System.Drawing.Size(50, 16)
        Me.lblCustomerCode.Visible = False
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(120, 128)
        Me.txtInvoice.MaxLength = 15
        Me.txtInvoice.Size = New System.Drawing.Size(112, 22)
        Me.txtInvoice.Text = ""
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(224, 0)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        '
        'cboReasons
        '
        Me.cboReasons.Location = New System.Drawing.Point(8, 48)
        Me.cboReasons.Size = New System.Drawing.Size(224, 22)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.Text = "Barras"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 32)
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.Text = "Motivo"
        '
        'cboUnit
        '
        Me.cboUnit.Location = New System.Drawing.Point(64, 192)
        Me.cboUnit.Size = New System.Drawing.Size(48, 22)
        '
        'txtAssignTo
        '
        Me.txtAssignTo.Location = New System.Drawing.Point(113, 168)
        Me.txtAssignTo.MaxLength = 20
        Me.txtAssignTo.Size = New System.Drawing.Size(120, 22)
        Me.txtAssignTo.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 176)
        Me.Label4.Size = New System.Drawing.Size(63, 14)
        Me.Label4.Text = "Asignar A:"
        '
        'frmArrivalReturnHAME
        '
        Me.ClientSize = New System.Drawing.Size(242, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAssignTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboInvoiceType)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboReasons)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.lblCustomerCode)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBarLocation)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtCodBarProduct)
        Me.Controls.Add(Me.lblCodProduct)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.chkState)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)

    End Sub

#End Region

    'Dim sUnit As String
    Dim sCompany As String
    Dim sExpDate As String
    Dim Graphics As Graphics
    Dim Pen As New Pen(Color.Black)
    Dim bIsLoading As Boolean = False

    Private Sub DrawLines()
        Graphics = Nothing
        Graphics = Me.CreateGraphics
        Graphics.Clear(Color.White)
        Graphics.DrawLine(Pen, 5, 8, 5, 275)       'Left   
        Graphics.DrawLine(Pen, 235, 8, 235, 275)   'Right
    End Sub

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            lblCodProduct.Text = ""
            txtCodBarProduct.Text = ""
            lblLotNumber.Text = ""
            lblBarLocation.Text = ""
            lblLotNumber.Text = ""
            txtLocationTarget.Text = ""
            txtQty.Text = ""
            lblProductDescription.Text = ""
            cboUnit.Items.Clear()
            lblCustomerName.Text = ""
            lblBarLocation.Text = ""
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
        Dim bBadState As Boolean = False

        Try
            If chkState.Checked Then bBadState = True
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
            If txtCodBarProduct.Text.Trim.Length = 0 Then
                MsgBox("Producto invalido", MsgBoxStyle.Exclamation, publicProject)
                txtCodBarProduct.Text = ""
                txtCodBarProduct.Focus()
                Exit Sub
            End If
            
            Cursor.Current = Cursors.WaitCursor
            sValidatePurchase = xArrivals.ValidateProductOnInvoice(cboInvoiceType.Text, txtInvoice.Text, lblCodProduct.Text, CDbl(txtQty.Text), cboUnit.Text, sCompany)
            Cursor.Current = Cursors.Default
            If sValidatePurchase.Length > 0 Then
                If MsgBox(sValidatePurchase & ". Desea continuar?", MsgBoxStyle.OKCancel, publicProject) = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If

            Cursor.Current = Cursors.WaitCursor
            sResult = xArrivals.ArrivalByReturnInvoice(modGlobal.publicUserID, lblCodProduct.Text, lblLotNumber.Text, _
                                                            CDbl(txtQty.Text), txtLocationTarget.Text, cboInvoiceType.Text, txtInvoice.Text, lblCustomerCode.Text, sCompany, "NA", cboUnit.Text, sExpDate, publicReturnCode, cboReasons.SelectedValue, bBadState, txtAssignTo.Text, False)
            Cursor.Current = Cursors.Default
            MsgBox("Transaccion ejecutada exitosamente", MsgBoxStyle.Information, publicProject)

            ClearFields()
            DrawLines()
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

        End Try
    End Sub


    Private Sub frmArrivalsDisc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsData As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices
        Try
            bIsLoading = True
            Select Case publicReturnCode
                Case "14"
                    lblTitle.Text = "Devolucion"
                Case "15"
                    lblTitle.Text = "Cambio Directo"
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

    Private Sub picClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        UpdateTask()

    End Sub

    


    

    Private Sub txtInvoice_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        DrawLines()
        myTimer.Enabled = False
    End Sub





    



    


    

    

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call UpdateTask()
    End Sub


    Private Sub txtLocationTarget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.TextChanged

    End Sub

    Private Sub txtInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoice.TextChanged

    End Sub

    Private Sub txtCodBarProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodBarProduct.TextChanged

    End Sub

    Private Sub Label3_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.ParentChanged

    End Sub

    Private Sub txtAssignTo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAssignTo.TextChanged

    End Sub

    Private Sub txtAssignTo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAssignTo.GotFocus
        txtAssignTo.SelectAll()
    End Sub


    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim xArrivals As New wsArrivals.wsArrivals

        If e.KeyChar = Chr(13) Then
            If IsNumeric(txtQty.Text) Then
                If CDbl(txtQty.Text) > 0 Then
                    txtLocationTarget.Focus()
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

    Private Sub txtLocationTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocationTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Dim xsarrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                lblBarLocation.Text = xsarrivals.GetLocationDescriptionNew(txtLocationTarget.Text, publicUserID, "09")

                Cursor.Current = Cursors.Default
                UpdateTask()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtLocationTarget.Text = ""
                Cursor.Current = Cursors.Default
                txtLocationTarget.Focus()
            End Try
        End If
    End Sub



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
                    End If
                End If
                txtAssignTo.Focus()
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub txtCodBarProduct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBarProduct.KeyPress
        Dim sUnit As String

        If e.KeyChar = Chr(13) Then
            Try
                Dim xserv As New wsCommonServices.wsCommonServices
                Cursor.Current = Cursors.WaitCursor
                xserv.ProcessBarcode(txtCodBarProduct.Text, lblCodProduct.Text, lblLotNumber.Text, lblProductDescription.Text, "", "", sExpDate, sCompany, sUnit, modGlobal.publicCurrentCountry)
                Cursor.Current = Cursors.Default

                With cboUnit
                    .Items.Clear()
                    .Items.Add(sUnit)
                    If sUnit.Trim = "CA" Then
                        .Items.Add("UN")
                    End If
                    .SelectedIndex = 0
                End With

            Catch ex As Exception
                lblCodProduct.Text = ""
                lblLotNumber.Text = ""
                lblProductDescription.Text = ""
                sCompany = ""
                sUnit = ""
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                Cursor.Current = Cursors.Default
                txtCodBarProduct.Text = ""
                txtCodBarProduct.Focus()

            End Try
            txtInvoice.Focus()
        End If
    End Sub

    'Private Sub cboReasons_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If e.KeyCode = Keys.Enter Then
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub cboReasons_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboReasons.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQty.Focus()
        End If
    End Sub

    'Private Sub txtVale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        txtLocationTarget.Focus()
    '    End If
    'End Sub

    Private Sub txtVale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtLocationTarget.Focus()
        End If
    End Sub

    'Private Sub txtAssignTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAssignTo.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub txtAssignTo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAssignTo.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQty.Focus()
        End If
    End Sub
End Class
