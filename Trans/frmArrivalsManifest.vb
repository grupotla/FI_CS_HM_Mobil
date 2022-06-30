Public Class frmArrivalsManifest
    Inherits System.Windows.Forms.Form
    'Datatable que se usa para almacenar si la impresora es local o remota
    Dim dtDatos As New DataTable
    Dim strDALabel As String = ""

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
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboWhs As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCommodity As System.Windows.Forms.Label
    Friend WithEvents cboBL As System.Windows.Forms.ComboBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtManifest As System.Windows.Forms.TextBox
    Friend WithEvents cboAgent As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGet As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPackages As System.Windows.Forms.Label
    Friend WithEvents cboPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents txtContenedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bttnChange As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalsManifest))
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
        Me.cboBL = New System.Windows.Forms.ComboBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.txtManifest = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboWhs = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCommodity = New System.Windows.Forms.Label
        Me.cboAgent = New System.Windows.Forms.ComboBox
        Me.cmdGet = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblPackages = New System.Windows.Forms.Label
        Me.cboPrinter = New System.Windows.Forms.ComboBox
        Me.txtContenedor = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.bttnChange = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(56, 8)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Ingreso por Manifiesto"
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(224, 120)
        Me.lblLotNumber.Size = New System.Drawing.Size(8, 16)
        Me.lblLotNumber.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 208)
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(72, 208)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Size = New System.Drawing.Size(56, 20)
        Me.txtQty.Text = ""
        '
        'picClose
        '
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
        Me.txtLocationTarget.Size = New System.Drawing.Size(104, 20)
        Me.txtLocationTarget.Text = ""
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(8, 0)
        Me.picMINGC.Size = New System.Drawing.Size(32, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
        'cboBL
        '
        Me.cboBL.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.cboBL.Location = New System.Drawing.Point(8, 152)
        Me.cboBL.Size = New System.Drawing.Size(224, 19)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(158, 240)
        Me.btnOK.Text = "Aceptar"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 79)
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.Text = "Viaje:"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(74, 77)
        Me.txtVoyage.MaxLength = 20
        Me.txtVoyage.Size = New System.Drawing.Size(162, 20)
        Me.txtVoyage.Text = ""
        '
        'txtManifest
        '
        Me.txtManifest.Location = New System.Drawing.Point(40, 128)
        Me.txtManifest.MaxLength = 20
        Me.txtManifest.ReadOnly = True
        Me.txtManifest.Size = New System.Drawing.Size(120, 20)
        Me.txtManifest.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 128)
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.Text = "Docto:"
        '
        'cboWhs
        '
        Me.cboWhs.Location = New System.Drawing.Point(74, 30)
        Me.cboWhs.Size = New System.Drawing.Size(162, 21)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 32)
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.Text = "Ubicacion:"
        '
        'lblCommodity
        '
        Me.lblCommodity.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCommodity.Location = New System.Drawing.Point(8, 176)
        Me.lblCommodity.Size = New System.Drawing.Size(216, 32)
        '
        'cboAgent
        '
        Me.cboAgent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular)
        Me.cboAgent.Location = New System.Drawing.Point(74, 100)
        Me.cboAgent.Size = New System.Drawing.Size(162, 21)
        '
        'cmdGet
        '
        Me.cmdGet.Location = New System.Drawing.Point(164, 128)
        Me.cmdGet.Text = "Manifiesto"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 104)
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.Text = "Agente:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(136, 208)
        Me.Label7.Size = New System.Drawing.Size(16, 20)
        Me.Label7.Text = "/"
        '
        'lblPackages
        '
        Me.lblPackages.Location = New System.Drawing.Point(152, 208)
        Me.lblPackages.Size = New System.Drawing.Size(56, 20)
        Me.lblPackages.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboPrinter
        '
        Me.cboPrinter.Location = New System.Drawing.Point(16, 240)
        Me.cboPrinter.Size = New System.Drawing.Size(128, 21)
        '
        'txtContenedor
        '
        Me.txtContenedor.Location = New System.Drawing.Point(74, 54)
        Me.txtContenedor.MaxLength = 20
        Me.txtContenedor.Size = New System.Drawing.Size(162, 20)
        Me.txtContenedor.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 56)
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.Text = "Contenedor:"
        '
        'bttnChange
        '
        Me.bttnChange.Location = New System.Drawing.Point(216, 208)
        Me.bttnChange.Size = New System.Drawing.Size(16, 16)
        Me.bttnChange.Text = ".."
        '
        'frmArrivalsManifest
        '
        Me.ClientSize = New System.Drawing.Size(242, 280)
        Me.Controls.Add(Me.bttnChange)
        Me.Controls.Add(Me.txtContenedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboPrinter)
        Me.Controls.Add(Me.lblPackages)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboAgent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdGet)
        Me.Controls.Add(Me.lblCommodity)
        Me.Controls.Add(Me.txtManifest)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cboBL)
        Me.Controls.Add(Me.cboWhs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTitle)
        Me.Menu = Me.MainMenu1
        Me.Text = "Ingreso por Manifiesto"

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
    Dim dsDataBL As DataSet
    Dim iSelectedIndex As Integer = -1



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

            'txtVoyage.Text = ""
            'lblAgent.Text = ""
            'txtManifest.Text = ""
            'Call ClearCombo(cboBL)
            Me.lblPackages.Text = ""
            lblCommodity.Text = ""
            txtQty.Text = ""
            txtLocationTarget.Text = ""
            txtContenedor.Text = ""
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

                'cboPrinter.DataSource = dsData.Tables(0)
                cboPrinter.DataSource = dtDatos
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

        Dim xArrivals As New wsManifestArrival.wsManifestArrival



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

            If txtVoyage.Text.Trim.Length = 0 Then
                MsgBox("Viaje Invalido", MsgBoxStyle.Exclamation, publicProject)
                txtVoyage.Focus()
                Exit Sub
            End If
            'If lblSupplierCode.Text.Trim.Length = 0 Then
            '    MsgBox("Factura invalida", MsgBoxStyle.Exclamation, publicProject)
            '    txtPurchaseOrder.Text = ""
            '    txtPurchaseOrder.Focus()
            '    Exit Sub
            'End If
            If cboBL.Text.Trim.Length = 0 Then
                MsgBox("BL ingresado invalido", MsgBoxStyle.Exclamation, publicProject)
                cboBL.SelectedIndex = 0
                cboBL.Focus()
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

            If (CInt(dsDataBL.Tables(0).Rows(iSelectedIndex)("PACKAGES")) < CInt(Me.txtQty.Text)) Then
                MsgBox("La cantidad ingresada es mayor a la establecida en el manifiesto, no es posible hacer el ingreso", MsgBoxStyle.OKOnly)
                Exit Sub
            End If

            'If (CInt(dsDataBL.Tables(0).Rows(iSelectedIndex)("PACKAGES")) > CInt(Me.txtQty.Text)) Then

            '    If MsgBox("¿La cantidad ingresada es menor a la establecida en el manifiesto(" & dsDataBL.Tables(0).Rows(iSelectedIndex)("PACKAGES") & "), desea continuar?", MsgBoxStyle.OKCancel, publicProject) = MsgBoxResult.Cancel Then
            '        txtQty.SelectAll()
            '        txtQty.Focus()
            '        Exit Sub
            '    End If

            'End If


            'If txtTarget.Text.Trim.Length = 0 Then
            '    MsgBox("Ubicacion invalida", MsgBoxStyle.Exclamation, publicProject)
            '    txtLocationTarget.Text = ""
            '    txtLocationTarget.Focus()
            '    Exit Sub
            'End If




            Cursor.Current = Cursors.WaitCursor

            Dim sUser As String = modGlobal.publicUserID
            Dim sProduct As String = CStr(cboBL.SelectedValue)
            Dim sManifest As String = txtManifest.Text
            Dim dQty As Double = CDbl(txtQty.Text)
            Dim sPackage As String = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("PACKAGE_TYPE"))
            'Dim sTarget As String = txtTarget.Text
            Dim sAgentCode = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("AGENT_CODE"))
            Dim sWhs = CStr(Me.cboWhs.SelectedValue)
            Dim sPrefix = sManifest.Split("-")(0)
            Dim sDA = sManifest.Split("-")(1)
            Dim sBL = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("BL"))
            Dim sBLShort = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("BL_SHORT"))
            Dim sConsignee = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("CONSIGNEE_DESC"))
            Dim sContainer = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("CONTAINER"))
            Dim sAgent = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("AGENT_DESC"))
            Dim sNoResa = CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("NO_RESA"))





            'sResult = xArrivals.Arrival(modGlobal.publicUserID, CStr(cboBL.SelectedValue), sManifest, _
            '                                             CDbl(txtQty.Text), "1", CStr(Me.cboWhs.SelectedValue), CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("AGENT_CODE")), CStr(Me.cboWhs.SelectedValue))

            'Se le eliminó el combo del location_source del campo location_target y se puso ""

            sResult = xArrivals.Arrival(modGlobal.publicUserID, CStr(cboBL.SelectedValue), sManifest, _
                                             CDbl(txtQty.Text), "1", "", CStr(dsDataBL.Tables(0).Rows(iSelectedIndex).Item("AGENT_CODE")), CStr(Me.cboWhs.SelectedValue))



            Dim strResult As String
            Dim wsCommon As New wsCommonServices.wsCommonServices

            Dim strPrinterPort As String = Me.cboPrinter.SelectedValue
            'strResult = wsCommon.PrintLabelCommodity(sPrefix, sDA, sBL, sConsignee, sContainer, sAgent, "NOW", Me.txtQty.Text, Me.lblPackages.Text, strPrinterPort)
            If dtDatos.Rows(Me.cboPrinter.SelectedIndex)(3) = "LOCAL" Then
                strResult = PrintLocalManifestLabel(sPrefix, sDA, sBL, sConsignee, sContainer, sAgent, Date.Now.ToShortDateString, Me.txtQty.Text, Me.lblPackages.Text, sBLShort, dsDataBL.Tables(0).Rows(iSelectedIndex).Item("COMPANY_NAME"), strDALabel, sNoResa)
            Else
                strResult = wsCommon.PrintLabelCommodity(sPrefix, sDA, sBL, sConsignee, sContainer, sAgent, Date.Now.ToShortDateString, Me.txtQty.Text, Me.lblPackages.Text, strPrinterPort, sBLShort, dsDataBL.Tables(0).Rows(iSelectedIndex).Item("COMPANY_NAME"), strDALabel, sNoResa)
            End If


            MsgBox(strResult, MsgBoxStyle.Information, publicProject)



            Dim iPackages As Integer = CInt(dsDataBL.Tables(0).Rows(iSelectedIndex)("PACKAGES")) - CInt(Me.txtQty.Text)

            dsDataBL.Tables(0).Rows(iSelectedIndex)("PACKAGES") = dsDataBL.Tables(0).Rows(iSelectedIndex)("PACKAGES") - CDbl(txtQty.Text)

            If (dsDataBL.Tables(0).Rows(iSelectedIndex)("PACKAGES") <= 0) Then
                cboBL.SelectedIndex = 0
                dsDataBL.Tables(0).Rows(iSelectedIndex).Delete()
            End If

            dsDataBL.Tables(0).Rows(iSelectedIndex).AcceptChanges()


            cboBL.DataSource = dsDataBL.Tables(0)

            cboBL.ValueMember = "bl"
            cboBL.DisplayMember = "bl_description"

            Cursor.Current = Cursors.Default
            DrawLines()
            ClearFields()


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

            If modGlobal.publicCurrentCountry.ToLower = "ni" Then
                Me.strDALabel = "DTI"
            Else
                Me.strDALabel = "D.A."
            End If

            bIsLoading = True
            ClearFields()
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

            If publicCurrentCountry.ToUpper <> "CR" Then
                Me.bttnChange.Visible = False
            End If

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
        Me.Close()
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



    Private Sub cboBL_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBL.SelectedIndexChanged
        If Not bCommoditiesLoaded Then
            Exit Sub
        End If

        If Me.cboBL.Text <> "" Then

            iSelectedIndex = cboBL.SelectedIndex
            Me.lblCommodity.Text = dsDataBL.Tables(0).Rows(iSelectedIndex).Item("COMMODITY")
            Me.txtQty.Text = ""
            Me.txtQty.Focus()
            lblPackages.Text = dsDataBL.Tables(0).Rows(iSelectedIndex).Item("PACKAGES_TOT")
            Me.txtManifest.Text = dsDataBL.Tables(0).Rows(iSelectedIndex).Item("DA")

            If txtManifest.Text = "-" Then
                txtManifest.ReadOnly = False
                txtManifest.Focus()
                txtManifest.SelectAll()
            Else
                txtManifest.ReadOnly = True
            End If




        End If
    End Sub


    Private Sub cmdGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGet.Click
        loadBls()
    End Sub

    Private Sub loadBls()
        Dim xArrivals As New wsManifestArrival.wsManifestArrival

        Try
            bCommoditiesLoaded = False
            Cursor.Current = Cursors.WaitCursor
            Me.txtManifest.Text = ""

            iManifest = Me.cboAgent.SelectedValue

            If iManifest > -1 Then
                Dim sSQL As String
                Dim blnEncontrado As Boolean
                'Dim wsServ As New wsCommonServices.wsCommonServices
                Dim wsServ As New wsManifestArrival.wsManifestArrival
                Try


                    'If Me.txtVoyage.Text.Trim <> "" Then
                    '    sSQL = sSQL & " and MA.VOYAGE='" & Me.txtVoyage.Text & "'  "
                    'End If

                    'If iManifest <> "" Then
                    '    sSQL = sSQL & " and MA.MANIFEST='" & CStr(iManifest) & "'  "
                    'End If

                    'If Me.txtContenedor.Text.Trim <> "" Then
                    '    sSQL = sSQL & " and MA.container='" & txtContenedor.Text.Trim & "'"
                    'End If

                    '"C.PACKAGES>(SELECT IFNULL(SUM(SXL.QUANTITY),0) FROM WMS_STOCK_X_LOCATION SXL, DEF_COMMODITIES CC WHERE SXL.COD_PRODUCT=CC.COD_PRODUCT AND CC.BL=C.BL) "



                    blnEncontrado = False
                    'dsDataBL = wsServ.GetDataSet(sSQL)
                    dsDataBL = wsServ.getBLData(Me.txtVoyage.Text, Me.iManifest, Me.txtContenedor.Text)
                    If dsDataBL.Tables(0).Rows.Count = 0 Then
                        MsgBox("No se encontraron paquetes", MsgBoxStyle.Information, publicProject)
                        blnEncontrado = True
                    End If
                    cboBL.DataSource = dsDataBL.Tables(0)

                    cboBL.ValueMember = "BL"
                    cboBL.DisplayMember = "BL_DESCRIPTION"
                    cboBL.SelectedIndex = 0
                    cboBL.Focus()
                    bCommoditiesLoaded = True
                    'dsDataBL = Nothing

                    If blnEncontrado = True Then
                        Call ClearCombo(cboBL)
                    End If

                Catch ex As Exception
                    Call ClearCombo(cboBL)
                    mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
                    'Me.Close()

                End Try

            Else
                MsgBox("No se encontro agente", MsgBoxStyle.Exclamation, publicProject)
                Call ClearCombo(cboBL)
            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
            Cursor.Current = Cursors.Default
        End Try


    End Sub



    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    Dim xArrivals As New wsArrivals.wsArrivals

    '    If e.KeyCode = Keys.Enter Then
    '        If IsNumeric(txtQty.Text) Then
    '            If CDbl(txtQty.Text) > 0 Then
    '                'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboWhs.SelectedValue)
    '                'txtTarget.Focus()
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

    'Private Sub txtTarget_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            Dim xsarrivals As New wsArrivals.wsArrivals
    '            Cursor.Current = Cursors.WaitCursor
    '            'lblDescBarrDestino.Text = xsarrivals.GetLocationDescription (txtTarget.Text)
    '            Cursor.Current = Cursors.Default
    '            UpdateTask()
    '        Catch ex As Exception
    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '            Cursor.Current = Cursors.Default
    '            'txtTarget.Text = ""
    '            'txtTarget.Focus()
    '        End Try
    '    End If
    'End Sub

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

    'Private Sub txtVoyage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
    '    Dim xArrivals As New wsManifestArrival.wsManifestArrival

    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            bCommoditiesLoaded = False
    '            Cursor.Current = Cursors.WaitCursor
    '            Me.txtManifest.Text = ""

    '            dsDataBL = xArrivals.ValidateVoyage(Me.txtVoyage.Text, Me.cboWhs.SelectedValue, Me.txtContenedor.Text)

    '            If dsDataBL.Tables(0).Rows.Count > 0 Then

    '                cboAgent.DataSource = dsDataBL.Tables(0)

    '                cboAgent.ValueMember = "MANIFEST"
    '                cboAgent.DisplayMember = "SUPPLIER_NAME"
    '                cboAgent.SelectedIndex = 0
    '                cboAgent.Focus()

    '            End If
    '            Cursor.Current = Cursors.Default
    '        End If


    '    Catch ex As Exception
    '        MsgBox("No se encontro viaje asignado para esta puerta")
    '        ClearFields()
    '        Cursor.Current = Cursors.Default
    '    End Try



    'End Sub

    Private Sub txtVoyage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVoyage.KeyPress
        Dim xArrivals As New wsManifestArrival.wsManifestArrival

        Try
            If e.KeyChar = Chr(13) Then
                bCommoditiesLoaded = False
                Cursor.Current = Cursors.WaitCursor
                Me.txtManifest.Text = ""

                dsDataBL = xArrivals.ValidateVoyage(Me.txtVoyage.Text, Me.cboWhs.SelectedValue, Me.txtContenedor.Text)

                If dsDataBL.Tables(0).Rows.Count > 0 Then

                    cboAgent.DataSource = dsDataBL.Tables(0)

                    cboAgent.ValueMember = "MANIFEST"
                    cboAgent.DisplayMember = "SUPPLIER_NAME"
                    cboAgent.SelectedIndex = 0
                    cboAgent.Focus()

                End If
                Cursor.Current = Cursors.Default
            End If


        Catch ex As Exception
            MsgBox("No se encontro viaje asignado para esta puerta")
            ClearFields()
            Cursor.Current = Cursors.Default
        End Try



    End Sub

    'Private Sub txtContenedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContenedor.KeyDown
    '    Dim xArrivals As New wsManifestArrival.wsManifestArrival

    '    Try
    '        If e.KeyCode = Keys.Enter Then

    '            txtVoyage.Text = xArrivals.ValidateVoyageContainer(Me.txtContenedor.Text, Me.cboWhs.SelectedValue)
    '            If txtVoyage.Text <> "" Then
    '                Call txtVoyage_KeyDown(sender, e)
    '            End If

    '        End If


    '    Catch ex As Exception
    '        MsgBox("No se encontro viaje asignado para esta puerta")
    '        ClearFields()
    '        Cursor.Current = Cursors.WaitCursor

    '    End Try



    'End Sub

    Private Sub txtContenedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContenedor.KeyPress
        Dim xArrivals As New wsManifestArrival.wsManifestArrival

        Try
            If e.KeyChar = Chr(13) Then

                txtVoyage.Text = xArrivals.ValidateVoyageContainer(Me.txtContenedor.Text, Me.cboWhs.SelectedValue)
                If txtVoyage.Text <> "" Then
                    Call txtVoyage_KeyPress(sender, e)
                End If

            End If


        Catch ex As Exception
            MsgBox("No se encontro viaje asignado para esta puerta")
            ClearFields()
            Cursor.Current = Cursors.WaitCursor

        End Try



    End Sub

    Private Sub bttnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnChange.Click

        'Validar que un bl ha sido especificado
        sSelectedProduct = ""
        sSelectedDescription = ""

        If cboBL.Text.Trim.Length = 0 Then
            MsgBox("BL ingresado invalido", MsgBoxStyle.Exclamation, publicProject)
            If cboBL.Items.Count > 0 Then
                cboBL.SelectedIndex = 0
            End If
            cboBL.Focus()
            Exit Sub
        End If

        'Enviar codigo de producto
        sSelectedProduct = txtManifest.Text & "||" & CStr(cboBL.SelectedValue)
        sSelectedDescription = cboBL.Text

        'Llamar pantalla de modificacion
        Dim xFrm As New frmArrivalsManChange
        xFrm.ShowDialog()
        xFrm = Nothing

        'Al regresar hacer refresh para que pongan cuanto de cuanto
        ClearFields()

        loadBls()

    End Sub

    Private Sub txtVoyage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoyage.TextChanged

    End Sub

    Private Sub cboAgent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAgent.SelectedIndexChanged

    End Sub
End Class

