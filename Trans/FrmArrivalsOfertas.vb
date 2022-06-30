Public Class frmArrivalOfertas
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
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblDateExpire As System.Windows.Forms.Label
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cboDoctos As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocationDescription As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.myTimer = New System.Windows.Forms.Timer
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboWhs = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboDoctos = New System.Windows.Forms.ComboBox
        Me.lblDateExpire = New System.Windows.Forms.Label
        Me.lblLote = New System.Windows.Forms.Label
        Me.lblProductDescription = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblLocationDescription = New System.Windows.Forms.Label
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 4)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Ingreso por Ofertas"
        '
        'lblDesde
        '
        Me.lblDesde.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDesde.Location = New System.Drawing.Point(16, 80)
        Me.lblDesde.Size = New System.Drawing.Size(216, 16)
        Me.lblDesde.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(224, 124)
        Me.lblLotNumber.Size = New System.Drawing.Size(8, 16)
        Me.lblLotNumber.Visible = False
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(8, 96)
        Me.txtBarcode.Size = New System.Drawing.Size(224, 22)
        Me.txtBarcode.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 172)
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(128, 172)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Size = New System.Drawing.Size(104, 22)
        Me.txtQty.Text = ""
        '
        'picClose
        '
        Me.picClose.Location = New System.Drawing.Point(216, 4)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(64, 195)
        Me.txtLocationTarget.MaxLength = 20
        Me.txtLocationTarget.Size = New System.Drawing.Size(168, 22)
        Me.txtLocationTarget.Text = ""
        '
        'picMINGC
        '
        Me.picMINGC.Location = New System.Drawing.Point(8, 0)
        Me.picMINGC.Size = New System.Drawing.Size(32, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.Text = "Orden Prod."
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 195)
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.Text = "Destino:"
        '
        'cboWhs
        '
        Me.cboWhs.Location = New System.Drawing.Point(88, 32)
        Me.cboWhs.Size = New System.Drawing.Size(144, 22)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.Text = "Empresa:"
        '
        'cboDoctos
        '
        Me.cboDoctos.Location = New System.Drawing.Point(88, 54)
        Me.cboDoctos.Size = New System.Drawing.Size(144, 22)
        '
        'lblDateExpire
        '
        Me.lblDateExpire.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblDateExpire.Location = New System.Drawing.Point(9, 152)
        Me.lblDateExpire.Size = New System.Drawing.Size(224, 16)
        '
        'lblLote
        '
        Me.lblLote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblLote.Location = New System.Drawing.Point(9, 136)
        Me.lblLote.Size = New System.Drawing.Size(224, 16)
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblProductDescription.Location = New System.Drawing.Point(9, 120)
        Me.lblProductDescription.Size = New System.Drawing.Size(224, 16)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 240)
        Me.btnOK.Text = "Aceptar"
        '
        'lblLocationDescription
        '
        Me.lblLocationDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblLocationDescription.Location = New System.Drawing.Point(8, 218)
        Me.lblLocationDescription.Size = New System.Drawing.Size(224, 16)
        '
        'frmArrivalOfertas
        '
        Me.ClientSize = New System.Drawing.Size(242, 264)
        Me.Controls.Add(Me.lblLocationDescription)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblDateExpire)
        Me.Controls.Add(Me.lblLote)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.cboDoctos)
        Me.Controls.Add(Me.cboWhs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Text = "Ingreso por Oferta"

    End Sub

#End Region

    Private nArrivals_Task As Long
    Private sBarcode As String
    Private sERP_Document As String
    Dim Graphics As Graphics
    Dim dtDateExpire As Date
    Dim Pen As New Pen(Color.Black)
    Dim strCodProducto, strLote, strUnit As String
    Dim blncambio As Boolean
    Dim sTone As String
    Dim sUnit As String


    Private Sub DrawLines()

        Graphics = Nothing
        Graphics = Me.CreateGraphics
        Graphics.Clear(Color.White)
        'Graphics.DrawLine(Pen, 5, 32, 235, 32)      'Upper
        Graphics.DrawLine(Pen, 5, 32, 5, 275)       'Left   
        Graphics.DrawLine(Pen, 235, 32, 235, 275)   'Right
        'Graphics.DrawLine(Pen, 5, 240, 235, 240)    'Bottom
        'Graphics.DrawLine(Pen, 5, 78, 235, 78)      'Middle 1
        'Graphics.DrawLine(Pen, 5, 150, 235, 150)    'Middle 2

    End Sub

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            lblDateExpire.Text = ""
            lblDesde.Text = ""
            lblLotNumber.Text = ""
            lblProductDescription.Text = ""
            txtBarcode.Text = ""
            txtLocationTarget.Text = ""
            txtQty.Text = ""
            blncambio = True
            cboWhs.SelectedIndex = -1
            cboDoctos.SelectedValue = -1
            lblLote.Text = ""
            lblLocationDescription.Text = ""
            Call ClearCombo(cboDoctos)
            blncambio = False
            DrawLines()

        Catch ex As Exception
            MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
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
                MsgBox("Empresa Invalida", MsgBoxStyle.Exclamation, publicProject)
                cboWhs.SelectedIndex = 0
                cboWhs.Focus()
                Exit Sub
            End If
            If cboDoctos.Text.Trim.Length = 0 Then
                MsgBox("Orden de Produccion Invalida", MsgBoxStyle.Exclamation, publicProject)
                cboDoctos.SelectedIndex = 0
                cboDoctos.Focus()
                Exit Sub
            End If
            If txtBarcode.Text.Trim.Length = 0 Then
                MsgBox("Producto ingresado invalido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Text = ""
                txtBarcode.Focus()
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

            Cursor.Current = Cursors.WaitCursor
            sValidatePurchase = "" ' xArrivals.ValidateOrderOrProduct(cboDoctos.SelectedValue, strCodProducto, CDbl(txtQty.Text), cboWhs.SelectedValue, strUnit, "6")
            If sValidatePurchase.Length > 0 Then
                MsgBox(sValidatePurchase & ". no se puede continuar")
                Exit Sub
            End If

            sResult = xArrivals.ArrivalToWarehouse(modGlobal.publicUserID, strCodProducto, strLote, _
                                                                        CDbl(txtQty.Text), txtLocationTarget.Text, "", cboDoctos.SelectedValue, "", strUnit, 18, dtDateExpire, "")
            MsgBox("Transaccion ejecutada exitosamente", MsgBoxStyle.Information, publicProject)
            Cursor.Current = Cursors.Default
            ClearFields()
            DrawLines()

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try
    End Sub

    Private Sub frmArrivalsDisc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dsData As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices
        Try
            ClearFields()
            Cursor.Current = Cursors.WaitCursor
            blncambio = True
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
            blncambio = False
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()

        End Try
    End Sub

    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        UpdateTask()

    End Sub


    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown

        'Try
        '    Dim xServ As New wsCommonServices.wsCommonServices
        '    If e.KeyCode = Keys.Enter Then
        '        Call xServ.ProcessBarcode(txtBarcode.Text, lblCod_Product.Text, sTone, sUnit, lblProductName.Text, "", "", "")
        '        Label6.Text = "Cantidad: (" & xServ.GetConversionFactor(lblCod_Product.Text, sUnit) & " U.)"
        '        xServ.GetDomain("TONES", sTone, lblTone.Text, "", "", "", "")
        '        xServ.GetDomain("MEASURE_UNITS", sUnit, lblUnit.Text, "", "", "", "")
        '        txtQty.Focus()
        '    End If
        'Catch ex As Exception
        '    MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        '    txtBarcode.Text = ""
        '    txtBarcode.Focus()
        'End Try

        If e.KeyCode = Keys.Enter Then

            Try
                Dim xArrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                lblProductDescription.Text = xArrivals.GetProductDescription(txtBarcode.Text)

                strCodProducto = txtBarcode.Text
                strLote = 15
                strUnit = ""
                lblLote.Text = "Lote: " & strLote
                lblDateExpire.Text = "Fecha de Vencimiento 10/10/2007"
                dtDateExpire = "10/10/2007"
                Cursor.Current = Cursors.Default
                txtQty.Focus()

            Catch ex As Exception
                MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtBarcode.Text = ""
                Cursor.Current = Cursors.Default
                strCodProducto = ""
                strLote = ""
                strUnit = ""
                lblLote.Text = ""
                lblDateExpire.Text = ""
                lblProductDescription.Text = ""
                txtBarcode.Focus()
            End Try
        End If

    End Sub


    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        txtQty.SelectAll()
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        Dim xArrivals As New wsArrivals.wsArrivals

        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtQty.Text) Then
                If CDbl(txtQty.Text) > 0 Then
                    'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboWhs.SelectedValue)
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

    Private Sub txtBarcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.GotFocus
        txtBarcode.SelectAll()
    End Sub


    Private Sub txtLocationTarget_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocationTarget.GotFocus
        txtLocationTarget.SelectAll()
    End Sub

    Private Sub txtLocationTarget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocationTarget.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim xsarrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                lblLocationDescription.Text = xsarrivals.GetLocationDescription(txtLocationTarget.Text)
                Cursor.Current = Cursors.Default
                UpdateTask()
            Catch ex As Exception
                MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtLocationTarget.Text = ""
                Cursor.Current = Cursors.Default
                txtLocationTarget.Focus()
            End Try
        End If
    End Sub

    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        DrawLines()
        myTimer.Enabled = False
    End Sub



    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call UpdateTask()
    End Sub

    Private Sub cboWhs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboWhs.SelectedIndexChanged
        If blncambio = True Then Exit Sub
        If cboWhs.SelectedIndex > -1 Then
            Try
                blncambio = True
                Cursor.Current = Cursors.WaitCursor
                Dim dsData As DataSet
                Dim sSQL As String
                Dim wsServ As New wsCommonServices.wsCommonServices
                'sSQL = "select * from VW_SBO_Orders_Header where mov_empresa ='" & cboWhs.SelectedValue & "' and mov_tipo_orden='DW'"

                sSQL = "SELECT * " & _
                                  " FROM WMS_Transactions " & _
                                  " WHERE  cod_company='" & cboWhs.SelectedValue & "'" & _
                                      " AND Transaction_Type ='6' and ERP_SENT=0"

                dsData = wsServ.GetDataSet(sSQL)
                If dsData.Tables(0).Rows.Count = 0 Then
                    MsgBox("No se encontraron ordenes de producción de ofertas", MsgBoxStyle.Information, publicProject)
                    cboDoctos.Enabled = False
                Else
                    cboDoctos.Enabled = True

                End If


                cboDoctos.DataSource = dsData.Tables(0)
                cboDoctos.DisplayMember = "ERP_DOCUMENT"
                cboDoctos.ValueMember = "ERP_DOCUMENT"
                cboDoctos.SelectedIndex = 0

                dsData = Nothing
                blncambio = False
                Cursor.Current = Cursors.Default
            Catch ex As Exception
                MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    'Private Sub cboDoctos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDoctos.SelectedIndexChanged
    '    If blncambio = True Then Exit Sub
    '    If cboWhs.SelectedIndex > -1 Then
    '        Dim xArrivals As New wsArrivals.wsArrivals
    '        lblDesde.Text = xArrivals.GetLocationArrivalTransfer(cboWhs.SelectedValue, cboDoctos.SelectedValue)
    '    End If
    'End Sub




    Private Sub ClearCombo(ByVal cb As ComboBox)
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        Try
            Cursor.Current = Cursors.WaitCursor
            sSQL = "SELECT  '' as Valor, '' as DESCRIPTION "
            dsData = wsServ.GetDataSet(sSQL)
            cb.DataSource = dsData.Tables(0)
            cb.DisplayMember = "DESCRIPTION"
            cb.ValueMember = "Valor"
            cb.SelectedIndex = 0
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
            Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class

