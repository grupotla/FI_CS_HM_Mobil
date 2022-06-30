Public Class frmArrivalsCFS
    Inherits System.Windows.Forms.Form
    'Datatable que se usa para almacenar si la impresora es local o remota
    Dim dtDatos As New DataTable

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        GetPrinterPorts()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents cboWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboFabricas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDetalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdGet As System.Windows.Forms.Button
    Friend WithEvents lblPackages As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents cboConsignatarios As System.Windows.Forms.ComboBox
    Friend WithEvents cboViajes As System.Windows.Forms.ComboBox
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblEstilo As System.Windows.Forms.Label
    Friend WithEvents lblPackagexItem As System.Windows.Forms.Label
    Friend WithEvents lblKgxItem As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCBMS As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTarima As System.Windows.Forms.Label
    Friend WithEvents chkNewTarima As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalsCFS))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.cboWhs = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboFabricas = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboConsignatarios = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboDetalle = New System.Windows.Forms.ComboBox
        Me.cboViajes = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdGet = New System.Windows.Forms.Button
        Me.lblPackages = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboPrinter = New System.Windows.Forms.ComboBox
        Me.myTimer = New System.Windows.Forms.Timer
        Me.lblIdentificacion = New System.Windows.Forms.Label
        Me.lblColor = New System.Windows.Forms.Label
        Me.lblEstilo = New System.Windows.Forms.Label
        Me.lblPackagexItem = New System.Windows.Forms.Label
        Me.lblKgxItem = New System.Windows.Forms.Label
        Me.txtCBMS = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTarima = New System.Windows.Forms.Label
        Me.chkNewTarima = New System.Windows.Forms.CheckBox
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(64, 0)
        Me.lblTitle.Size = New System.Drawing.Size(136, 20)
        Me.lblTitle.Text = "Ingreso CFS"
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(8, 0)
        Me.picMINGC.Size = New System.Drawing.Size(48, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(224, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        '
        'cboWhs
        '
        Me.cboWhs.Location = New System.Drawing.Point(75, 32)
        Me.cboWhs.Size = New System.Drawing.Size(162, 21)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 32)
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.Text = "Ubicacion:"
        '
        'cboFabricas
        '
        Me.cboFabricas.Location = New System.Drawing.Point(75, 56)
        Me.cboFabricas.Size = New System.Drawing.Size(162, 21)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 56)
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.Text = "Fabrica:"
        '
        'cboConsignatarios
        '
        Me.cboConsignatarios.Location = New System.Drawing.Point(75, 80)
        Me.cboConsignatarios.Size = New System.Drawing.Size(162, 21)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(5, 80)
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.Text = "Consignatario:"
        '
        'cboDetalle
        '
        Me.cboDetalle.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.cboDetalle.Location = New System.Drawing.Point(9, 128)
        Me.cboDetalle.Size = New System.Drawing.Size(224, 19)
        '
        'cboViajes
        '
        Me.cboViajes.Location = New System.Drawing.Point(48, 104)
        Me.cboViajes.Size = New System.Drawing.Size(136, 21)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(5, 104)
        Me.Label4.Size = New System.Drawing.Size(43, 24)
        Me.Label4.Text = "# Viaje:"
        '
        'cmdGet
        '
        Me.cmdGet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular)
        Me.cmdGet.Location = New System.Drawing.Point(184, 104)
        Me.cmdGet.Size = New System.Drawing.Size(48, 24)
        Me.cmdGet.Text = "Viajes"
        '
        'lblPackages
        '
        Me.lblPackages.Location = New System.Drawing.Point(112, 232)
        Me.lblPackages.Size = New System.Drawing.Size(24, 20)
        Me.lblPackages.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(96, 224)
        Me.Label7.Size = New System.Drawing.Size(16, 20)
        Me.Label7.Text = "/"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(64, 224)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Size = New System.Drawing.Size(32, 20)
        Me.txtQty.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 248)
        Me.btnOK.Text = "Aceptar"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 224)
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'cboPrinter
        '
        Me.cboPrinter.Location = New System.Drawing.Point(16, 248)
        Me.cboPrinter.Size = New System.Drawing.Size(128, 21)
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblIdentificacion.Location = New System.Drawing.Point(8, 152)
        Me.lblIdentificacion.Size = New System.Drawing.Size(224, 16)
        '
        'lblColor
        '
        Me.lblColor.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblColor.Location = New System.Drawing.Point(120, 176)
        Me.lblColor.Size = New System.Drawing.Size(112, 16)
        '
        'lblEstilo
        '
        Me.lblEstilo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblEstilo.Location = New System.Drawing.Point(8, 176)
        Me.lblEstilo.Size = New System.Drawing.Size(104, 16)
        '
        'lblPackagexItem
        '
        Me.lblPackagexItem.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblPackagexItem.Location = New System.Drawing.Point(8, 184)
        Me.lblPackagexItem.Size = New System.Drawing.Size(104, 16)
        '
        'lblKgxItem
        '
        Me.lblKgxItem.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblKgxItem.Location = New System.Drawing.Point(120, 184)
        Me.lblKgxItem.Size = New System.Drawing.Size(112, 16)
        '
        'txtCBMS
        '
        Me.txtCBMS.Location = New System.Drawing.Point(176, 224)
        Me.txtCBMS.MaxLength = 15
        Me.txtCBMS.Size = New System.Drawing.Size(56, 20)
        Me.txtCBMS.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(136, 224)
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.Text = "CBMS:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(120, 200)
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.Text = "Tarima"
        '
        'lblTarima
        '
        Me.lblTarima.Location = New System.Drawing.Point(192, 208)
        Me.lblTarima.Size = New System.Drawing.Size(40, 16)
        Me.lblTarima.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkNewTarima
        '
        Me.chkNewTarima.Location = New System.Drawing.Point(8, 200)
        Me.chkNewTarima.Text = "Nueva Tarima"
        '
        'frmArrivalsCFS
        '
        Me.ClientSize = New System.Drawing.Size(242, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkNewTarima)
        Me.Controls.Add(Me.lblTarima)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCBMS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblKgxItem)
        Me.Controls.Add(Me.lblPackagexItem)
        Me.Controls.Add(Me.lblEstilo)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.cboPrinter)
        Me.Controls.Add(Me.lblPackages)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdGet)
        Me.Controls.Add(Me.cboViajes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboDetalle)
        Me.Controls.Add(Me.cboConsignatarios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFabricas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboWhs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.lblTitle)
        Me.Text = "Ingreso CFS"

    End Sub

#End Region

    Private nArrivals_Task As Long
    Private sBarcode As String
    Private nConversionFactor As String
    Private sERP_Document As String
    Dim Graphics As Graphics
    Dim strCodProducto, strLote, strUnit As String
    Dim Pen As New Pen(Color.Black)
    Dim bIsLoading As Boolean = False
    Dim bCommoditiesLoaded As Boolean = False
    Dim dsDataDetail As DataSet
    Dim iSelectedIndex As Integer = -1

    Dim myArrivalsCFS As New wsArrivalsCFS.wsArrivalsCFS

    Private Sub DrawLines()

        Graphics = Nothing
        Graphics = Me.CreateGraphics
        Graphics.Clear(Color.White)
        Graphics.DrawLine(Pen, 2, 32, 2, 275)       'Left   
        Graphics.DrawLine(Pen, 238, 32, 238, 275)   'Right

    End Sub

    Private Sub ClearFields()

        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try

            'Call ClearCombo(cboBL)
            Me.lblPackages.Text = ""            
            txtQty.Text = ""
            Me.txtCBMS.Text = ""
            Me.lblIdentificacion.Text = ""
            Me.lblColor.Text = ""
            Me.lblEstilo.Text = ""
            Me.lblPackagexItem.Text = ""
            Me.lblKgxItem.Text = ""


            DrawLines()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
            txtQty.Enabled = False
        End Try

    End Sub

    Private Sub GetPrinterPorts()
        Dim xCommon As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        'Dim strPAD As String 2017-07-19
        'xCommon.GetDomain("PAD", "AIMAR", strPAD, "", "", "", "")

        Try
            dsData = xCommon.GetPrinterPorts(publicUserID)
            dtDatos = dsData.Tables(0)

            If dsData.Tables(0).Rows.Count > 0 Then

                cboPrinter.DataSource = dsData.Tables(0)
                cboPrinter.DisplayMember = "MEANING"
                cboPrinter.ValueMember = "MPC01"
                cboPrinter.SelectedIndex = 0
            Else
                Cursor.Current = Cursors.Default
                MsgBox("No se encontraron impresoras")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Dim iManifest As String = ""

    Private Sub UpdateTask()
        Dim xArrivals As New wsArrivalsCFS.wsArrivalsCFS

        Dim iResult As Long
        Dim sResult As String
        Dim sValidateManifest As String = ""

        Try

            If MsgBox("¿Desea ejecutar la transaccion?", MsgBoxStyle.OKCancel, publicProject) = MsgBoxResult.Cancel Then
                Exit Sub
            End If

            'Validations

            If cboWhs.Text.Trim.Length = 0 Then
                MsgBox("Bodega Invalida", MsgBoxStyle.Exclamation, publicProject)
                cboWhs.SelectedIndex = 0
                cboWhs.Focus()
                Exit Sub
            End If

            If Me.cboDetalle.SelectedIndex < 0 Then
                MsgBox("No se ha seleccionado un detalle", MsgBoxStyle.Exclamation, publicProject)
                Me.cboFabricas.SelectedIndex = 0
                Me.cboFabricas.Focus()
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

            'If CDbl(txtCBMS.Text) <= 0 Or txtCBMS.Text = "" Then
            '    MsgBox("Debe especificar una cantidad valida de cbms", MsgBoxStyle.Exclamation, publicProject)
            '    txtCBMS.Text = ""
            '    txtCBMS.Focus()
            '    Exit Sub
            'End If


            If (CInt(dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CANTIDAD")) < CInt(Me.txtQty.Text)) Then
                MsgBox("La cantidad ingresada es mayor a la establecida en el manifiesto, no es posible hacer el ingreso", MsgBoxStyle.OKOnly)
                Exit Sub
            End If


            Cursor.Current = Cursors.WaitCursor

            Dim sUser As String = modGlobal.publicUserID
            'Dim sProduct As String = CStr(cboBL.SelectedValue)
            'Dim sManifest As String = txtManifest.Text
            Dim dQty As Double = CDbl(txtQty.Text)
            'Dim sPackage As String = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("PACKAGE_TYPE"))
            'Dim sTarget As String = txtTarget.Text
            'Dim sAgentCode = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("AGENT_CODE"))
            Dim sWhs = CStr(Me.cboWhs.SelectedValue)
            'Dim sPrefix = sManifest.Split("-")(0)
            'Dim sDA = sManifest.Split("-")(1)
            'Dim sBL = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("BL"))
            'Dim sConsignee = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("CONSIGNEE_DESC"))
            'Dim sContainer = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("CONTAINER"))
            'Dim sAgent = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("AGENT_DESC"))





            'sResult = xArrivals.Arrival(modGlobal.publicUserID, CStr(cboBL.SelectedValue), sManifest, _
            '                                             CDbl(txtQty.Text), "1", CStr(Me.cboWhs.SelectedValue), CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("AGENT_CODE")), CStr(Me.cboWhs.SelectedValue))

            

            sResult = xArrivals.Arrival(modGlobal.publicUserID, CStr(Me.cboDetalle.SelectedValue), CStr(Me.cboViajes.SelectedValue), _
                                        CDbl(Me.txtQty.Text), "1", CStr(Me.cboWhs.SelectedValue), "COMPANY", CStr(Me.cboWhs.SelectedValue), CDbl(Me.txtCBMS.Text), Me.lblTarima.Text, Me.chkNewTarima.Checked)


            Dim strResult As String = "Print not implemented"
            'Dim wsCommon As New wsCommonServices.wsCommonServices

            If Me.chkNewTarima.Checked Then


                Dim strPrinterPort As String = Me.cboPrinter.SelectedValue

                'strResult = xArrivals.PrintLabelViajeDetail(CStr(Me.cboViajes.SelectedValue), CStr(Me.cboDetalle.SelectedValue), CStr(Me.cboDetalle.Text), "APL", CStr(Me.cboFabricas.Text), CStr(Me.cboConsignatarios.Text), "NOW", Me.txtQty.Text, Me.lblPackages.Text, strPrinterPort)
                Try
                    If dtDatos.Rows(Me.cboPrinter.SelectedIndex)(3) = "LOCAL" Then
                        'strResult = PrintLocalManifestLabel(Me.txtPAD.Text, Me.txtDA.Text, strBl, Me.txtConsignee.Text, Me.txtContainer.Text, Me.txtAgent.Text, Me.txtDateEnter.Text, Me.txtNPackages.Text, Me.txtPackages.Text)
                        strResult = PrintLocalCFSLabel(CStr(Me.cboViajes.SelectedValue), Me.lblTarima.Text, CStr(Me.cboDetalle.Text), dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CANTIDAD"), CStr(Me.cboFabricas.Text), CStr(Me.cboConsignatarios.Text), Date.Now.ToShortDateString, Me.txtQty.Text, Me.lblPackages.Text, dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("COMPANY_NAME"))
                    Else
                        'strResult = xArrivals.PrintLabelViajeDetail(CStr(Me.cboViajes.SelectedValue), CStr(Me.cboDetalle.SelectedValue), CStr(Me.cboDetalle.Text), "APL", CStr(Me.cboFabricas.Text), CStr(Me.cboConsignatarios.Text), "NOW", Me.txtQty.Text, Me.lblPackages.Text, strPrinterPort)
                        strResult = xArrivals.PrintLabelViajeDetail(CStr(Me.cboViajes.SelectedValue), Me.lblTarima.Text, CStr(Me.cboDetalle.Text), dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CANTIDAD"), CStr(Me.cboFabricas.Text), CStr(Me.cboConsignatarios.Text), Date.Now.ToShortDateString, Me.txtQty.Text, Me.lblPackages.Text, strPrinterPort, dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("COMPANY_NAME"))
                    End If


                Catch ex As Exception
                    MsgBox("Error al imprimir: " & ex.ToString)
                End Try

                MsgBox(strResult, MsgBoxStyle.Information, publicProject)
            End If

            'Actualizar detalle
            searchViajesDetail()
            detalleSelected()

            Cursor.Current = Cursors.Default
            DrawLines()
            ClearFields()


        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            Cursor.Current = Cursors.Default
        End Try


    End Sub


    Private Sub frmArrivalsCFS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsData As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices


        Try
            bIsLoading = True
            ClearFields()
            Me.lblTarima.Text = ""
            Cursor.Current = Cursors.WaitCursor

            sSQL = "SELECT " & _
                   "L.LOCATION, " & _
                   "L.DESCRIPTION " & _
                   "FROM " & _
                   "DEF_LOCATIONS L, " & _
                   "DEF_USERS_WAREHOUSES UW " & _
                   "WHERE " & _
                   "L.ALLOW_ARRIVALS=1 AND " & _
                   "UW.COD_USER='" & modGlobal.publicUserID & "' AND " & _
                   "UW.COD_WAREHOUSE = L.COD_WAREHOUSE "


            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron bodegas", MsgBoxStyle.Information, publicProject)
                cboWhs.Enabled = False
            Else
                cboWhs.Enabled = True
            End If
            cboWhs.DataSource = dsData.Tables(0)
            cboWhs.DisplayMember = "DESCRIPTION"
            cboWhs.ValueMember = "LOCATION"
            cboWhs.SelectedIndex = 0

            dsData = Nothing


            Me.cboFabricas.DataSource = myArrivalsCFS.getFabricas().Tables(0)
            Me.cboFabricas.DisplayMember = "DESCRIPTION"
            Me.cboFabricas.ValueMember = "COD_FABRICA"

            Me.cboConsignatarios.DataSource = myArrivalsCFS.getConsignatarios.Tables(0)
            Me.cboConsignatarios.DisplayMember = "DESCRIPTION"
            Me.cboConsignatarios.ValueMember = "COD_CONSIGNATARIO"


            bIsLoading = False
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()
            bIsLoading = False

        End Try

    End Sub

    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown

    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateTask()
    End Sub







    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        DrawLines()
        myTimer.Enabled = False
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        UpdateTask()
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Dim xCS As New wsCommonServices.wsCommonServices
        txtQty.SelectAll()
        'If cboUnits.SelectedValue <> "ST" Then
        '    nConversionFactor = xCS.GetConversionFactor(cboProduct.SelectedValue, cboUnits.SelectedValue)
        '    Label6.Text = "Cantidad: " & CStr(nConversionFactor) & " U."
        'Else
        '    nConversionFactor = 1
        '    Label6.Text = "Cantidad: "
        'End If
    End Sub

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


    Private Sub cmdGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGet.Click
        Try
            Me.bIsLoading = True

            Cursor.Current = Cursors.WaitCursor
            Me.cboViajes.DataSource = Nothing
            Me.cboDetalle.DataSource = Nothing

            Me.cboViajes.DataSource = myArrivalsCFS.getViajes(Me.cboWhs.SelectedValue, Me.cboFabricas.SelectedValue, Me.cboConsignatarios.SelectedValue).Tables(0)
            Me.cboViajes.DisplayMember = "VIAJE"
            Me.cboViajes.ValueMember = "ID_VIAJE"

            If Me.cboViajes.SelectedIndex >= 0 Then
                searchViajesDetail()
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
            Me.bIsLoading = False
        End Try
    End Sub


    Private Sub cboViajes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboViajes.SelectedIndexChanged
        If Not Me.bIsLoading Then
            searchViajesDetail()
        End If
    End Sub

    Sub searchViajesDetail()
        Dim rsInfo As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices


        Try
            Cursor.Current = Cursors.WaitCursor

            Me.cboDetalle.DataSource = Nothing
            Me.dsDataDetail = Nothing

            If Me.cboViajes.SelectedIndex >= 0 Then
                dsDataDetail = myArrivalsCFS.getViajesDetail(Me.cboViajes.SelectedValue)
                Me.cboDetalle.DataSource = dsDataDetail.Tables(0)
                Me.cboDetalle.DisplayMember = "DESCRIPTION"
                Me.cboDetalle.ValueMember = "ID_DETAIL"
            End If

            ' Verifica que numero de tarima debe poner
            ' Busca el ultimo numero de tarima para ese viaje y su estado
            '    Si esta recibido    -> numero tarima + 1
            '    Si no esta recibido -> numero tarima

            sSQL = " select id_estado, ifnull(numero_tarima,1) as numero_tarima, tarima_closed " & _
                    " from CFS_VIAJE_IN_DETAIL d " & _
                    " where id_viaje = '" & Me.cboViajes.SelectedValue & "' " & _
                    " order by numero_tarima desc, tarima_closed desc" & _
                    " limit 1"

            rsInfo = wsServ.GetDataSet(sSQL)
            Me.lblTarima.Text = "1"
            If rsInfo.Tables(0).Rows.Count > 0 Then
                If CStr(rsInfo.Tables(0).Rows(0).Item("tarima_closed")) = "1" Then 'Tarima cerrada
                    Me.lblTarima.Text = CStr(CInt(rsInfo.Tables(0).Rows(0).Item("numero_tarima")) + 1)
                Else
                    Me.lblTarima.Text = CStr(rsInfo.Tables(0).Rows(0).Item("numero_tarima"))
                End If
            End If


        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cboDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDetalle.SelectedIndexChanged
        detalleSelected()
    End Sub

    Sub detalleSelected()
        Try
            Cursor.Current = Cursors.WaitCursor

            Me.txtQty.Text = ""
            If Me.cboDetalle.SelectedIndex >= 0 Then
                Me.lblPackages.Text = dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CANTIDAD")
                Me.lblIdentificacion.Text = "Lote/# item/SKU: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("IDENTIFICACION")
                Me.lblColor.Text = "Color: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("COLOR")
                Me.lblEstilo.Text = "Estilo: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("ESTILO")
                Me.lblPackagexItem.Text = "Piezas x Item: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("PIEZAS_X_ITEM")
                Me.lblKgxItem.Text = "Kg x Item: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("KILOS_X_ITEM")
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub


    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim xArrivals As New wsArrivals.wsArrivals

        If e.KeyChar = Chr(13) Then
            If IsNumeric(txtQty.Text) Then
                If CDbl(txtQty.Text) > 0 Then
                    'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboWhs.SelectedValue)
                    'txtTarget.Focus()
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


    Private Sub txtTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Try
                Dim xsarrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                'lblDescBarrDestino.Text = xsarrivals.GetLocationDescription (txtTarget.Text)
                Cursor.Current = Cursors.Default
                UpdateTask()
            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                Cursor.Current = Cursors.Default
                'txtTarget.Text = ""
                'txtTarget.Focus()
            End Try
        End If
    End Sub


    Private Sub txtCBMS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCBMS.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(txtCBMS.Text) Then
                If CDbl(txtCBMS.Text) >= 0 Then
                    'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboWhs.SelectedValue)
                    'txtTarget.Focus()
                    Me.btnOK.Focus()
                Else
                    txtCBMS.Text = ""
                    MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
                End If
            Else
                txtCBMS.Text = ""
                MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
            End If
        End If
    End Sub

    Private Sub picClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub cboWhs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWhs.SelectedIndexChanged

    End Sub
End Class
