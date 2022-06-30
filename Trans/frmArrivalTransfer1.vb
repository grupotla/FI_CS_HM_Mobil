Public Class frmArrivalTransfer1
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
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTarget As System.Windows.Forms.TextBox
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents chkState As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtCodBarProduct As System.Windows.Forms.TextBox
    Friend WithEvents lblCodProduct As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAssignTo As System.Windows.Forms.TextBox
    Friend WithEvents lblDescriptions As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTraslado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalTransfer1))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTarget = New System.Windows.Forms.TextBox
        Me.lblProductDescription = New System.Windows.Forms.Label
        Me.chkState = New System.Windows.Forms.CheckBox
        Me.txtCodBarProduct = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblDescriptions = New System.Windows.Forms.Label
        Me.lblCodProduct = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.myTimer = New System.Windows.Forms.Timer
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboWarehouse = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.txtAssignTo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTraslado = New System.Windows.Forms.TextBox
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 0)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Ingreso por Traslado"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(136, 128)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Size = New System.Drawing.Size(96, 20)
        Me.txtQty.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 248)
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.Text = "Conf. Destino:"
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(128, 248)
        Me.txtLocationTarget.Size = New System.Drawing.Size(104, 20)
        Me.txtLocationTarget.Text = ""
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(8, -8)
        Me.picMINGC.Size = New System.Drawing.Size(26, 26)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(128, 232)
        Me.lblLocationTarget.Size = New System.Drawing.Size(104, 16)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 152)
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.Text = "Destino:"
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(112, 152)
        Me.txtTarget.MaxLength = 20
        Me.txtTarget.Size = New System.Drawing.Size(120, 20)
        Me.txtTarget.Text = ""
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblProductDescription.Location = New System.Drawing.Point(8, 112)
        Me.lblProductDescription.Size = New System.Drawing.Size(224, 16)
        '
        'chkState
        '
        Me.chkState.Location = New System.Drawing.Point(8, 208)
        Me.chkState.Size = New System.Drawing.Size(88, 20)
        Me.chkState.Text = "Mal Estado"
        '
        'txtCodBarProduct
        '
        Me.txtCodBarProduct.Location = New System.Drawing.Point(8, 72)
        Me.txtCodBarProduct.Size = New System.Drawing.Size(224, 20)
        Me.txtCodBarProduct.Text = ""
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 208)
        Me.btnOK.Text = "Aceptar"
        '
        'lblDescriptions
        '
        Me.lblDescriptions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDescriptions.Location = New System.Drawing.Point(8, 192)
        Me.lblDescriptions.Size = New System.Drawing.Size(224, 16)
        Me.lblDescriptions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCodProduct
        '
        Me.lblCodProduct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblCodProduct.Location = New System.Drawing.Point(8, 96)
        Me.lblCodProduct.Size = New System.Drawing.Size(104, 16)
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular)
        Me.lblLotNumber.Location = New System.Drawing.Point(128, 96)
        Me.lblLotNumber.Size = New System.Drawing.Size(104, 16)
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.Text = "Codigo de Barras"
        '
        'cboWarehouse
        '
        Me.cboWarehouse.Location = New System.Drawing.Point(8, 32)
        Me.cboWarehouse.Size = New System.Drawing.Size(120, 21)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.Text = "Origen:"
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 0)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        '
        'cboUnit
        '
        Me.cboUnit.Location = New System.Drawing.Point(56, 128)
        Me.cboUnit.Size = New System.Drawing.Size(56, 21)
        '
        'txtAssignTo
        '
        Me.txtAssignTo.Location = New System.Drawing.Point(112, 168)
        Me.txtAssignTo.MaxLength = 20
        Me.txtAssignTo.Size = New System.Drawing.Size(120, 20)
        Me.txtAssignTo.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Size = New System.Drawing.Size(96, 14)
        Me.Label4.Text = "Asignar Reubi A:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(136, 16)
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.Text = "Traslado No:"
        '
        'txtTraslado
        '
        Me.txtTraslado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.txtTraslado.Location = New System.Drawing.Point(136, 32)
        Me.txtTraslado.Size = New System.Drawing.Size(96, 22)
        Me.txtTraslado.Text = ""
        '
        'frmArrivalTransfer1
        '
        Me.ClientSize = New System.Drawing.Size(348, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTraslado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAssignTo)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.cboWarehouse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.lblDescriptions)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtCodBarProduct)
        Me.Controls.Add(Me.lblCodProduct)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.chkState)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)

    End Sub

#End Region

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
            lblDescriptions.Text = ""
            lblLotNumber.Text = ""
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
            If txtTraslado.Text = "" Then
                MsgBox("Debe ingresar numero de traslado", MsgBoxStyle.Exclamation, publicProject)
                Exit Sub
            End If
            If Not IsNumeric(txtTraslado.Text) Then
                MsgBox("Numero de traslado invalido", MsgBoxStyle.Exclamation, publicProject)
                Exit Sub
            End If

            If Not IsNumeric(txtQty.Text) Then
                MsgBox("Cantidad ingresada invalida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Text = ""
                txtQty.Focus()
                Exit Sub
            End If

            If cboUnit.Text = "" Then
                MsgBox("Unidad ingresada invalida", MsgBoxStyle.Exclamation, publicProject)
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

            If txtAssignTo.Text.Trim.Length = 0 Then
                MsgBox("Usuario Asignado Invalido", MsgBoxStyle.Exclamation, publicProject)
                txtAssignTo.Text = ""
                txtAssignTo.Focus()
                Exit Sub
            End If

            If txtCodBarProduct.Text.Trim.Length = 0 Then
                MsgBox("Producto invalido", MsgBoxStyle.Exclamation, publicProject)
                txtCodBarProduct.Text = ""
                txtCodBarProduct.Focus()
                Exit Sub
            End If

            Cursor.Current = Cursors.WaitCursor

            sResult = xArrivals.ArrivalByTransfer(modGlobal.publicUserID, lblCodProduct.Text, lblLotNumber.Text, _
                                                            cboUnit.Text, CDbl(txtQty.Text), txtTarget.Text, cboWarehouse.SelectedValue, sCompany, "", txtTraslado.Text, sExpDate, "92", txtAssignTo.Text)
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


            sSQL = " SELECT COD_DC, Description FROM DEF_DISTRIBUTION_CENTERS  "

            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron Bodegas de Origen", MsgBoxStyle.Information, publicProject)
                cboWarehouse.Enabled = False
            Else
                cboWarehouse.Enabled = True
            End If

            cboWarehouse.DataSource = dsData.Tables(0)
            cboWarehouse.DisplayMember = "Description"
            cboWarehouse.ValueMember = "COD_DC"
            cboWarehouse.SelectedIndex = 0
            Cursor.Current = Cursors.Default
            dsData = Nothing
            bIsLoading = False

        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()
            bIsLoading = False

        End Try
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


    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub


    Private Sub txtAssignTo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAssignTo.GotFocus
        txtAssignTo.SelectAll()
    End Sub



    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    Dim xArrivals As New wsArrivals.wsArrivals

    '    If e.KeyCode = Keys.Enter Then
    '        If IsNumeric(txtQty.Text) Then
    '            If CDbl(txtQty.Text) > 0 Then
    '                txtLocationTarget.Focus()
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

    'Private Sub txtTarget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTarget.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            Dim xsarrivals As New wsArrivals.wsArrivals
    '            Cursor.Current = Cursors.WaitCursor
    '            lblDescriptions.Text = xsarrivals.GetLocationDescription (txtTarget.Text)
    '            Cursor.Current = Cursors.Default
    '            txtAssignTo.Focus()

    '        Catch ex As Exception
    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '            txtTarget.Text = ""
    '            Cursor.Current = Cursors.Default
    '            txtTarget.Focus()
    '        End Try
    '    End If
    'End Sub

    Private Sub txtTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Dim xsarrivals As New wsPicking.wsPicking
                Cursor.Current = Cursors.WaitCursor
                lblDescriptions.Text = xsarrivals.GetLocationDescription(txtTarget.Text, publicUserID)
                Cursor.Current = Cursors.Default
                txtAssignTo.Focus()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtTarget.Text = ""
                Cursor.Current = Cursors.Default
                txtTarget.Focus()
            End Try
        End If
    End Sub

    'Private Sub txtCodBarProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarProduct.KeyDown
    '    If e.KeyCode = Keys.Enter Then

    '        Try
    '            Dim sUnit As String
    '            Dim xserv As New wsCommonServices.wsCommonServices
    '            Cursor.Current = Cursors.WaitCursor
    '            xserv.ProcessBarcode(txtCodBarProduct.Text, lblCodProduct.Text, lblLotNumber.Text, lblProductDescription.Text, "", "", sExpDate, sCompany, sUnit)
    '            Cursor.Current = Cursors.Default
    '            With cboUnit
    '                .Items.Clear()
    '                .Items.Add(sUnit)
    '                If sUnit.Trim = "CA" Then
    '                    .Items.Add("UN")
    '                End If
    '                .SelectedIndex = 0
    '            End With

    '        Catch ex As Exception
    '            lblCodProduct.Text = ""
    '            lblLotNumber.Text = ""
    '            lblProductDescription.Text = ""
    '            sCompany = ""
    '            cboUnit.Text = ""
    '            cboUnit.Items.Clear()
    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '            Cursor.Current = Cursors.Default
    '            txtCodBarProduct.Text = ""
    '            txtCodBarProduct.Focus()

    '        End Try


    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub txtCodBarProduct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBarProduct.KeyPress
        If e.KeyChar = Chr(13) Then

            Try
                Dim sUnit As String
                Dim xserv As New wsCommonServices.wsCommonServices
                Cursor.Current = Cursors.WaitCursor
                xserv.ProcessBarcode(txtCodBarProduct.Text, lblCodProduct.Text, lblLotNumber.Text, lblProductDescription.Text, "", "", sExpDate, sCompany, sUnit, modGlobal.publicCurrentCountry)

                If Me.lblCodProduct.Text <> "" And Me.txtTraslado.Text = "" Then
                    Try
                        Me.txtTraslado.Text = xserv.getLatestTransfer(Me.lblCodProduct.Text)
                    Catch ex As Exception

                    End Try
                End If

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
                cboUnit.Text = ""
                cboUnit.Items.Clear()
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                Cursor.Current = Cursors.Default
                txtCodBarProduct.Text = ""
                txtCodBarProduct.Focus()

            End Try


            txtQty.Focus()
        End If
    End Sub

    'Private Sub cboReasons_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If e.KeyCode = Keys.Enter Then
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub cboReasons_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Chr(13) Then
            txtQty.Focus()
        End If
    End Sub

    'Private Sub txtVale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        txtTarget.Focus()
    '    End If
    'End Sub

    Private Sub txtVale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtTarget.Focus()
        End If
    End Sub

    'Private Sub txtAssignTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAssignTo.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            Dim xServ As New wsLogin.wsLogin
    '            Cursor.Current = Cursors.WaitCursor
    '            lblDescriptions.Text = xServ.GetUserName(txtAssignTo.Text)
    '            Cursor.Current = Cursors.Default
    '            txtAssignTo.Focus()

    '        Catch ex As Exception
    '            Cursor.Current = Cursors.Default
    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '            txtAssignTo.Text = ""
    '            lblDescriptions.Text = ""
    '            txtAssignTo.Focus()
    '        End Try
    '    End If
    'End Sub

    Private Sub txtAssignTo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAssignTo.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Dim xServ As New wsLogin.wsLogin
                Cursor.Current = Cursors.WaitCursor
                lblDescriptions.Text = xServ.GetUserNameVerify(txtAssignTo.Text, publicCurrentCountry)
                Cursor.Current = Cursors.Default

                If lblDescriptions.Text = "" Then
                    Cursor.Current = Cursors.Default
                    MsgBox("Usuario especificado invalido", MsgBoxStyle.Critical, publicProject)
                    txtAssignTo.Text = ""
                    lblDescriptions.Text = ""
                End If

                txtAssignTo.Focus()

            Catch ex As Exception
                Cursor.Current = Cursors.Default
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtAssignTo.Text = ""
                lblDescriptions.Text = ""
                txtAssignTo.Focus()
            End Try
        End If
    End Sub
End Class
