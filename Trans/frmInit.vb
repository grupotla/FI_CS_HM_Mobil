Public Class frmInit
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
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdReinit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents lblCod_Product As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents lblLocationDescription As System.Windows.Forms.Label
    Friend WithEvents lblLocationTargetDesc As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInit))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblLocationTargetDesc = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.cmdReinit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.lblCod_Product = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblLocationDescription = New System.Windows.Forms.Label
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.cboUnit = New System.Windows.Forms.ComboBox
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 8)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Inventario Inicial"
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboUnit)
        Me.TabPage1.Controls.Add(Me.lblLocationTargetDesc)
        Me.TabPage1.Controls.Add(Me.lblLotNumber)
        Me.TabPage1.Controls.Add(Me.cmdReinit)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtLocationTarget)
        Me.TabPage1.Controls.Add(Me.lblCod_Product)
        Me.TabPage1.Controls.Add(Me.txtBarcode)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblProductName)
        Me.TabPage1.Controls.Add(Me.txtQty)
        Me.TabPage1.Controls.Add(Me.cmdAccept)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(232, 246)
        Me.TabPage1.Text = "Ingreso"
        '
        'lblLocationTargetDesc
        '
        Me.lblLocationTargetDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationTargetDesc.Location = New System.Drawing.Point(8, 200)
        Me.lblLocationTargetDesc.Size = New System.Drawing.Size(216, 16)
        Me.lblLocationTargetDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(120, 72)
        Me.lblLotNumber.Size = New System.Drawing.Size(96, 16)
        Me.lblLotNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdReinit
        '
        Me.cmdReinit.Location = New System.Drawing.Point(123, 224)
        Me.cmdReinit.Size = New System.Drawing.Size(96, 24)
        Me.cmdReinit.Text = "Reiniciar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 144)
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.Text = "Ubicación:"
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(124, 144)
        Me.txtLocationTarget.Size = New System.Drawing.Size(104, 22)
        Me.txtLocationTarget.Text = ""
        '
        'lblCod_Product
        '
        Me.lblCod_Product.Location = New System.Drawing.Point(8, 72)
        Me.lblCod_Product.Size = New System.Drawing.Size(96, 16)
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(8, 48)
        Me.txtBarcode.Size = New System.Drawing.Size(216, 22)
        Me.txtBarcode.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 176)
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.Text = "Cantidad:"
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(8, 96)
        Me.lblProductName.Size = New System.Drawing.Size(216, 40)
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(124, 168)
        Me.txtQty.Size = New System.Drawing.Size(104, 22)
        Me.txtQty.Text = ""
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(16, 224)
        Me.cmdAccept.Size = New System.Drawing.Size(96, 24)
        Me.cmdAccept.Text = "Aceptar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.Text = "Cod. Barras Producto"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblLocationDescription)
        Me.TabPage2.Controls.Add(Me.grdData)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtLocation)
        Me.TabPage2.Controls.Add(Me.picMINGC)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(232, 246)
        Me.TabPage2.Text = "Cons. X Ubicacion"
        '
        'lblLocationDescription
        '
        Me.lblLocationDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationDescription.Location = New System.Drawing.Point(8, 88)
        Me.lblLocationDescription.Size = New System.Drawing.Size(216, 16)
        Me.lblLocationDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grdData
        '
        Me.grdData.Location = New System.Drawing.Point(4, 112)
        Me.grdData.Size = New System.Drawing.Size(224, 120)
        Me.grdData.Text = "DataGrid1"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.Text = "Ubicacion:"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(104, 56)
        Me.txtLocation.Size = New System.Drawing.Size(120, 22)
        Me.txtLocation.Text = ""
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Size = New System.Drawing.Size(32, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(8, 32)
        Me.Label9.Size = New System.Drawing.Size(216, 20)
        Me.Label9.Text = "Inventario en Ultima Ubicacion"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 272)
        '
        'cboUnit
        '
        Me.cboUnit.Location = New System.Drawing.Point(72, 168)
        Me.cboUnit.Size = New System.Drawing.Size(48, 22)
        '
        'frmInit
        '
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.TabControl1)
        Me.Text = "Inventario Inicial"

    End Sub

#End Region

    Private sBarcode As String
    Private sERP_Document As String
    Private sCompany As String
    Private sExpDate As String

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            lblCod_Product.Text = ""
            lblLotNumber.Text = ""
            cboUnit.Items.Clear()
            cboUnit.Text = ""
            lblProductName.Text = ""
            txtBarcode.Text = ""
            txtLocationTarget.Text = ""
            txtQty.Text = ""
            sExpDate = ""
            txtBarcode.Focus()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
            txtQty.Enabled = False
            cmdAccept.Enabled = False
        End Try
    End Sub

    Private Sub ShowStockOnLocation()
        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        Dim sSQL As String
        Dim sLotNumber As String
        Dim sProductDescription As String

        Try
            Dim ts1 As New DataGridTableStyle
            Dim TextCol As New DataGridTextBoxColumn

            ts1.MappingName = "myTable"
            TextCol.MappingName = "Cod_Product"
            TextCol.HeaderText = "Codigo"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)
            TextCol = Nothing

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "LotNumber"
            TextCol.HeaderText = "Lote"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Quantity"
            TextCol.HeaderText = "Cant"
            TextCol.Width = 40
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Unit"
            TextCol.HeaderText = "Uni"
            TextCol.Width = 20
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Description"
            TextCol.HeaderText = "Descripcion"
            TextCol.Width = 400
            ts1.GridColumnStyles.Add(TextCol)

            grdData.TableStyles.Clear()
            grdData.TableStyles.Add(ts1)

            sSQL = "SELECT A.Cod_Product, A.LotNumber, A.Quantity, A.Unit, B.Description " & _
                    " FROM WMS_STOCK_X_LOCATION A, VW_SBO_Products B " & _
                    " WHERE A.Cod_Product = B.Cod_Product AND A.Location = '" & txtLocation.Text & "'" & _
                    " ORDER BY datetime_arrival"

            dsData = wsServ.GetDataSet(sSQL)
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontro inventario en la ubicacion ingresada", MsgBoxStyle.Information, publicProject)
            End If
            grdData.DataSource = dsData.Tables(0)

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try

    End Sub

    Private Sub ReinitLocation()
        Dim sLocation As String
        Dim xArrivals As New wsArrivals.wsArrivals

        Try
            If txtLocationTarget.Text.Trim.Length = 0 Then
                MsgBox("Debe ingresar una ubicacion para Reiniciar", MsgBoxStyle.Information, publicProject)
                Exit Sub
            End If

            If txtBarcode.Text.Length = 0 Or lblCod_Product.Text.Length = 0 Then
                Beep()
                txtBarcode.Text = ""
                MsgBox("Producto ingresado inválido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Focus()
                Exit Sub
            End If

            If MsgBox("Esta seguro que desea reiniciar la Ubicacion " & txtLocationTarget.Text & ", Producto: " & lblCod_Product.Text & "?", MsgBoxStyle.YesNo, publicProject) = MsgBoxResult.No Then
                Exit Sub
            End If
            Cursor.Current = Cursors.WaitCursor
            Call xArrivals.ReinitLocation(txtLocationTarget.Text, publicUserID, lblCod_Product.Text)
            txtLocation.Text = txtLocationTarget.Text
            lblLocationDescription.Text = xArrivals.GetLocationDescriptionNew(txtLocation.Text, publicUserID, "03")
            ShowStockOnLocation()
            ClearFields()
            txtBarcode.Focus()

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)

        End Try

    End Sub

    Private Sub UpdateTask()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim iResult As Long
        Dim sResult As String
        Dim sFechaExp As String

        Try

            If txtBarcode.Text.Length = 0 Or lblCod_Product.Text.Length = 0 Then
                Beep()
                txtBarcode.Text = ""
                MsgBox("Producto ingresado inválido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Focus()
                Exit Sub
            End If

            If txtLocationTarget.Text.Trim.Length = 0 Then
                Beep()
                txtLocationTarget.Text = ""
                MsgBox("Ubicacion inválida", MsgBoxStyle.Exclamation, publicProject)
                txtLocationTarget.Focus()
                Exit Sub
            End If

            If Not IsNumeric(txtQty.Text) Then
                Beep()
                txtQty.Text = "0"
                MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Focus()
                Exit Sub
            Else
                If CDbl(txtQty.Text) < 0 Then
                    Beep()
                    txtQty.Text = "0"
                    MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                    txtQty.Focus()
                    Exit Sub
                End If
            End If

            Cursor.Current = Cursors.WaitCursor
            sResult = xArrivals.InitStock(modGlobal.publicUserID, lblCod_Product.Text, lblLotNumber.Text, txtQty.Text, txtLocationTarget.Text, sCompany, cboUnit.Text, sExpDate)
            txtLocation.Text = txtLocationTarget.Text
            lblLocationDescription.Text = xArrivals.GetLocationDescriptionNew(txtLocation.Text, publicUserID, "04")

            ShowStockOnLocation()
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
            ClearFields()

        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()

        End Try
    End Sub

    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        UpdateTask()
    End Sub


    


    Private Sub txtQty_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        txtQty.SelectAll()
    End Sub

    Private Sub txtLocationTarget_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.GotFocus
        txtLocationTarget.SelectAll()
    End Sub




    Private Sub cmdReinit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReinit.Click
        ReinitLocation()
    End Sub
   

    Private Sub txtBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.Click
        txtBarcode.SelectAll()
    End Sub

    Private Sub txtLocationTarget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.Click
        txtLocationTarget.SelectAll()
    End Sub

  

    Private Sub txtQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.Click
        txtQty.SelectAll()
    End Sub

  

    

    

    Private Sub txtLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocation.TextChanged

    End Sub

    

    Private Sub txtLocation_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocation.GotFocus

        txtLocation.SelectAll()

    End Sub

    Private Sub txtLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocation.Click
        txtLocation.SelectAll()
    End Sub


    Private Sub grdData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdData.Click

    End Sub



    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        UpdateTask()
    '    End If
    'End Sub

    Private Sub lblTone_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLotNumber.ParentChanged

    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub TabPage2_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.EnabledChanged

    End Sub

    Private Sub TabPage2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.GotFocus
        txtLocation.Focus()
    End Sub

    Private Sub TabPage1_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.EnabledChanged

    End Sub

    Private Sub TabPage1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.GotFocus
        txtBarcode.Focus()
    End Sub

    Private Sub txtLocationTarget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.TextChanged

    End Sub

    'Private Sub txtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    Dim xServ As New wsCommonServices.wsCommonServices
    '    Dim sUnit As String
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Cursor.Current = Cursors.WaitCursor
    '            Call xServ.ProcessBarcode(txtBarcode.Text, lblCod_Product.Text, lblLotNumber.Text, lblProductName.Text, txtQty.Text, "", sExpDate, sCompany, sUnit)
    '            Cursor.Current = Cursors.Default
    '            With cboUnit
    '                .Items.Clear()
    '                .Items.Add(sUnit)
    '                If sUnit.Trim = "CA" Then
    '                    .Items.Add("UN")
    '                End If
    '                .SelectedIndex = 0
    '            End With
    '            Cursor.Current = Cursors.Default
    '            txtLocationTarget.Focus()

    '        End If
    '    Catch ex As Exception
    '        lblCod_Product.Text = ""
    '        lblLotNumber.Text = ""
    '        lblProductName.Text = ""
    '        sCompany = ""
    '        sUnit = ""
    '        Cursor.Current = Cursors.Default
    '        MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
    '        txtBarcode.Text = ""
    '        txtBarcode.Focus()

    '    End Try

    'End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim xServ As New wsCommonServices.wsCommonServices
        Dim sUnit As String
        Try
            If e.KeyChar = Chr(13) Then
                Cursor.Current = Cursors.WaitCursor
                Call xServ.ProcessBarcode(txtBarcode.Text, lblCod_Product.Text, lblLotNumber.Text, lblProductName.Text, txtQty.Text, "", sExpDate, sCompany, sUnit, modGlobal.publicCurrentCountry)
                Cursor.Current = Cursors.Default
                With cboUnit
                    .Items.Clear()
                    .Items.Add(sUnit)
                    If sUnit.Trim = "CA" Then
                        .Items.Add("UN")
                    End If
                    .SelectedIndex = 0
                End With
                Cursor.Current = Cursors.Default
                txtLocationTarget.Focus()

            End If
        Catch ex As Exception
            lblCod_Product.Text = ""
            lblLotNumber.Text = ""
            lblProductName.Text = ""
            sCompany = ""
            sUnit = ""
            Cursor.Current = Cursors.Default
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
            txtBarcode.Text = ""
            txtBarcode.Focus()

        End Try

    End Sub

    'Private Sub txtLocationTarget_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocationTarget.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If txtLocationTarget.Text.Length > 0 Then
    '            Dim xArrivals As New wsArrivals.wsArrivals
    '            lblLocationTargetDesc.Text = xArrivals.GetLocationDescription (txtLocationTarget.Text)
    '        End If
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub txtLocationTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocationTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtLocationTarget.Text.Length > 0 Then
                Dim xArrivals As New wsArrivals.wsArrivals
                lblLocationTargetDesc.Text = xArrivals.GetLocationDescriptionNew(txtLocationTarget.Text, publicUserID, "01")
            End If
            txtQty.Focus()
        End If
    End Sub

    'Private Sub txtLocation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocation.KeyDown

    '    If e.KeyCode = Keys.Enter Then
    '        Dim xArrivals As New wsArrivals.wsArrivals

    '        lblLocationDescription.Text = xArrivals.GetLocationDescription (txtLocation.Text)
    '        ShowStockOnLocation()

    '    End If
    'End Sub

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim xArrivals As New wsArrivals.wsArrivals

            lblLocationDescription.Text = xArrivals.GetLocationDescriptionNew(txtLocation.Text, publicUserID, "02")

            ShowStockOnLocation()

        End If

    End Sub

    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        UpdateTask()
    '    End If
    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            UpdateTask()
        End If
    End Sub
End Class
