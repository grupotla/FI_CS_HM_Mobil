Public Class frmLabelsCFS
    Inherits System.Windows.Forms.Form

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

    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents lblKgxItem As System.Windows.Forms.Label
    Friend WithEvents lblPackagexItem As System.Windows.Forms.Label
    Friend WithEvents lblEstilo As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents cboPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cmdGet As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboDetalle As System.Windows.Forms.ComboBox
    Friend WithEvents cboConsignatarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFabricas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label

    Friend WithEvents lblCbms As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTarimas As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLabelsCFS))
        Me.lblCbms = New System.Windows.Forms.Label
        Me.myTimer = New System.Windows.Forms.Timer
        Me.lblKgxItem = New System.Windows.Forms.Label
        Me.lblPackagexItem = New System.Windows.Forms.Label
        Me.lblEstilo = New System.Windows.Forms.Label
        Me.lblColor = New System.Windows.Forms.Label
        Me.lblIdentificacion = New System.Windows.Forms.Label
        Me.cboPrinter = New System.Windows.Forms.ComboBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.cmdGet = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboDetalle = New System.Windows.Forms.ComboBox
        Me.cboConsignatarios = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFabricas = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.cboTarimas = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        '
        'lblCbms
        '
        Me.lblCbms.Location = New System.Drawing.Point(112, 200)
        Me.lblCbms.Size = New System.Drawing.Size(120, 20)
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'lblKgxItem
        '
        Me.lblKgxItem.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblKgxItem.Location = New System.Drawing.Point(120, 184)
        Me.lblKgxItem.Size = New System.Drawing.Size(112, 16)
        '
        'lblPackagexItem
        '
        Me.lblPackagexItem.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblPackagexItem.Location = New System.Drawing.Point(8, 184)
        Me.lblPackagexItem.Size = New System.Drawing.Size(104, 16)
        '
        'lblEstilo
        '
        Me.lblEstilo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblEstilo.Location = New System.Drawing.Point(8, 168)
        Me.lblEstilo.Size = New System.Drawing.Size(104, 16)
        '
        'lblColor
        '
        Me.lblColor.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblColor.Location = New System.Drawing.Point(120, 168)
        Me.lblColor.Size = New System.Drawing.Size(112, 16)
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblIdentificacion.Location = New System.Drawing.Point(8, 152)
        Me.lblIdentificacion.Size = New System.Drawing.Size(224, 16)
        '
        'cboPrinter
        '
        Me.cboPrinter.Location = New System.Drawing.Point(16, 232)
        Me.cboPrinter.Size = New System.Drawing.Size(128, 22)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 232)
        Me.btnOK.Text = "Imprimir"
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(8, 200)
        Me.lblCantidad.Size = New System.Drawing.Size(104, 20)
        '
        'cmdGet
        '
        Me.cmdGet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular)
        Me.cmdGet.Location = New System.Drawing.Point(176, 80)
        Me.cmdGet.Size = New System.Drawing.Size(56, 20)
        Me.cmdGet.Text = "Detalle"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.Text = "# PO:"
        '
        'cboDetalle
        '
        Me.cboDetalle.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.cboDetalle.Location = New System.Drawing.Point(8, 128)
        Me.cboDetalle.Size = New System.Drawing.Size(224, 19)
        '
        'cboConsignatarios
        '
        Me.cboConsignatarios.Location = New System.Drawing.Point(72, 56)
        Me.cboConsignatarios.Size = New System.Drawing.Size(162, 22)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.Text = "Consignatario:"
        '
        'cboFabricas
        '
        Me.cboFabricas.Location = New System.Drawing.Point(72, 32)
        Me.cboFabricas.Size = New System.Drawing.Size(162, 22)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.Text = "Fabrica:"
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(224, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(8, 0)
        Me.picMINGC.Size = New System.Drawing.Size(32, 24)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(64, 8)
        Me.lblTitle.Size = New System.Drawing.Size(136, 20)
        Me.lblTitle.Text = "Reimpresion CFS"
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(72, 80)
        Me.txtPO.Text = ""
        '
        'cboTarimas
        '
        Me.cboTarimas.Location = New System.Drawing.Point(72, 104)
        Me.cboTarimas.Size = New System.Drawing.Size(104, 22)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.Text = "Tarimas:"
        '
        'frmLabelsCFS
        '
        Me.ClientSize = New System.Drawing.Size(242, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTarimas)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.lblKgxItem)
        Me.Controls.Add(Me.lblPackagexItem)
        Me.Controls.Add(Me.lblEstilo)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Controls.Add(Me.cboPrinter)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.cmdGet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboDetalle)
        Me.Controls.Add(Me.cboConsignatarios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFabricas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCbms)
        Me.Text = "Etiquetas CFS"

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
    Dim iManifest As String = ""

    Private iViajeId As String = ""

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
            'Me.lblPackages.Text = ""
            'txtQty.Text = ""
            'Me.txtCBMS.Text = ""
            Me.lblIdentificacion.Text = ""
            Me.lblColor.Text = ""
            Me.lblEstilo.Text = ""
            Me.lblPackagexItem.Text = ""
            Me.lblKgxItem.Text = ""
            Me.lblCantidad.Text = ""
            Me.lblCbms.Text = ""

            DrawLines()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)            
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

    Private Sub frmLabelsCFS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsData As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices


        Try
            bIsLoading = True
            ClearFields()
            Cursor.Current = Cursors.WaitCursor

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

    Private Sub cmdGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGet.Click
        Try
            Dim myViaje As System.Data.DataSet

            Me.bIsLoading = True

            Cursor.Current = Cursors.WaitCursor
            Me.cboDetalle.DataSource = Nothing
            Me.iViajeId = ""

            myViaje = myArrivalsCFS.getViaje(Me.cboFabricas.SelectedValue, Me.cboConsignatarios.SelectedValue, Me.txtPO.Text)
            
            If myViaje.Tables.Count > 0 Then
                If myViaje.Tables(0).Rows.Count > 0 Then
                    Me.iViajeId = CStr(myViaje.Tables(0).Rows(0).Item(0))
                    'searchViajesDetail(CStr(myViaje.Tables(0).Rows(0).Item(0)))
                    searchViajesTarimas(Me.iViajeId)
                End If
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
            Me.bIsLoading = False
        End Try
    End Sub

    Sub searchViajesDetail(ByVal theViajeId As String, ByVal theTarima As String)
        Try
            Cursor.Current = Cursors.WaitCursor

            Me.cboDetalle.DataSource = Nothing
            Me.dsDataDetail = Nothing

            If theViajeId <> "" Then
                dsDataDetail = myArrivalsCFS.getViajesDetailFull(theViajeId, theTarima)
                Me.cboDetalle.DataSource = dsDataDetail.Tables(0)
                Me.cboDetalle.DisplayMember = "DESCRIPTION"
                Me.cboDetalle.ValueMember = "NUMERO_TARIMA"
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub searchViajesTarimas(ByVal theViajeId As String)
        Try
            Cursor.Current = Cursors.WaitCursor

            Me.cboDetalle.DataSource = Nothing
            Me.dsDataDetail = Nothing

            If theViajeId <> "" Then
                bIsLoading = True
                dsDataDetail = myArrivalsCFS.getTarimasFromViajes(theViajeId)
                Me.cboTarimas.DataSource = dsDataDetail.Tables(0)
                Me.cboTarimas.DisplayMember = "NUMERO_TARIMA"
                Me.cboTarimas.ValueMember = "NUMERO_TARIMA"
                bIsLoading = False

                If dsDataDetail.Tables.Count > 0 Then
                    If dsDataDetail.Tables(0).Rows.Count > 0 Then
                        searchViajesDetail(Me.iViajeId, CStr(dsDataDetail.Tables(0).Rows(0).Item(0)))
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub detalleSelected()
        Try
            Cursor.Current = Cursors.WaitCursor

            If Me.cboDetalle.SelectedIndex >= 0 Then
                Me.lblIdentificacion.Text = "Lote/# item/SKU: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("IDENTIFICACION")
                Me.lblColor.Text = "Color: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("COLOR")
                Me.lblEstilo.Text = "Estilo: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("ESTILO")
                Me.lblPackagexItem.Text = "Piezas x Item: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("PIEZAS_X_ITEM")
                Me.lblKgxItem.Text = "Kg x Item: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("KILOS_X_ITEM")
                Me.lblCantidad.Text = "Cantidad: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CANTIDAD")
                Me.lblCbms.Text = "Cbms: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CBMS_RECIBIDOS")
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim strResult As String = "Print not implemented"
        Dim wsCommon As New wsCommonServices.wsCommonServices
        Dim strSql As String = ""
        Dim dsRes As DataSet

        Dim strPrinterPort As String = Me.cboPrinter.SelectedValue

        'strResult = xArrivals.PrintLabelViajeDetail(CStr(Me.cboViajes.SelectedValue), CStr(Me.cboDetalle.SelectedValue), CStr(Me.cboDetalle.Text), "APL", CStr(Me.cboFabricas.Text), CStr(Me.cboConsignatarios.Text), "NOW", Me.txtQty.Text, Me.lblPackages.Text, strPrinterPort)
        Try
            If dtDatos.Rows(Me.cboPrinter.SelectedIndex)(3) = "LOCAL" Then
                Dim iCantidadItems As String = "0"

                Try

                
                'strResult = PrintLocalManifestLabel(Me.txtPAD.Text, Me.txtDA.Text, strBl, Me.txtConsignee.Text, Me.txtContainer.Text, Me.txtAgent.Text, Me.txtDateEnter.Text, Me.txtNPackages.Text, Me.txtPackages.Text)
                'Buscar cantidad de items de 
                strSql = " select count(1) from ( " & _
                         " select distinct id_detail " & _
                         " from CFS_VIAJE_IN_PALLETS " & _
                         " where id_viaje = '" & iViajeId & "' " & _
                         "   and numero_tarima = '" & CStr(Me.cboDetalle.SelectedValue) & "' " & _
                         " ) a "
                dsRes = wsCommon.GetDataSet(strSql)

                If dsRes.Tables.Count > 0 Then
                    If dsRes.Tables(0).Rows.Count > 0 Then
                            iCantidadItems = CStr(dsRes.Tables(0).Rows(0).Item(0))
                    End If
                End If
                Catch ex As Exception
                    iCantidadItems = "0"
                End Try

                strResult = PrintLocalCFSLabel(Me.iViajeId, CStr(Me.cboDetalle.SelectedValue), CStr(Me.cboDetalle.Text), dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CUSTOMER_NAME"), CStr(Me.cboFabricas.Text), CStr(Me.cboConsignatarios.Text), Date.Now.ToShortDateString, iCantidadItems, iCantidadItems, dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("COMPANY_NAME"))
            Else
                strResult = myArrivalsCFS.PrintLabelViajeDetail(Me.iViajeId, CStr(Me.cboDetalle.SelectedValue), CStr(Me.cboDetalle.Text), dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CUSTOMER_NAME"), CStr(Me.cboFabricas.Text), CStr(Me.cboConsignatarios.Text), Date.Now.ToShortDateString, "", Me.lblCantidad.Text, strPrinterPort, dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("COMPANY_NAME"))
            End If



        Catch ex As Exception
            MsgBox("Error al imprimir: " & ex.ToString)
        End Try

        MsgBox(strResult, MsgBoxStyle.Information, publicProject)

        Cursor.Current = Cursors.Default
        'DrawLines()
        'ClearFields()

    End Sub

    Private Sub cboDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDetalle.SelectedIndexChanged
        detalleSelected()
    End Sub

    Private Sub picClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picClose.Click
        Me.Close()
    End Sub


    Private Sub cboTarimas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTarimas.SelectedIndexChanged
        If Not bIsLoading Then
            MessageBox.Show("selected value")
            MessageBox.Show(cboTarimas.SelectedValue)
            searchViajesDetail(Me.iViajeId, cboTarimas.SelectedValue)
        End If
    End Sub
End Class
