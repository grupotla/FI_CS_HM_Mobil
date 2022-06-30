Public Class frmCheckPicking
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtWavePicking As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents lblCod_Product As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents lblLocationDesc As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grdData2 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckPicking))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblCheck = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.lblLocationDesc = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtWavePicking = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.lblCod_Product = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grdData2 = New System.Windows.Forms.DataGrid
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 8)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Chequeo de Despacho"
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 272)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCheck)
        Me.TabPage1.Controls.Add(Me.cboUnit)
        Me.TabPage1.Controls.Add(Me.lblLocationDesc)
        Me.TabPage1.Controls.Add(Me.txtLocationTarget)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtWavePicking)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblLotNumber)
        Me.TabPage1.Controls.Add(Me.lblCod_Product)
        Me.TabPage1.Controls.Add(Me.txtBarcode)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblProductName)
        Me.TabPage1.Controls.Add(Me.txtQty)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(232, 246)
        Me.TabPage1.Text = "Chequeo"
        '
        'lblCheck
        '
        Me.lblCheck.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCheck.Location = New System.Drawing.Point(9, 100)
        Me.lblCheck.Size = New System.Drawing.Size(211, 20)
        Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboUnit
        '
        Me.cboUnit.Location = New System.Drawing.Point(72, 215)
        Me.cboUnit.Size = New System.Drawing.Size(48, 22)
        '
        'lblLocationDesc
        '
        Me.lblLocationDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationDesc.Location = New System.Drawing.Point(8, 55)
        Me.lblLocationDesc.Size = New System.Drawing.Size(216, 15)
        Me.lblLocationDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(120, 31)
        Me.txtLocationTarget.Size = New System.Drawing.Size(104, 22)
        Me.txtLocationTarget.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 39)
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.Text = "Rampa:"
        '
        'txtWavePicking
        '
        Me.txtWavePicking.Enabled = False
        Me.txtWavePicking.Location = New System.Drawing.Point(120, 71)
        Me.txtWavePicking.Size = New System.Drawing.Size(104, 22)
        Me.txtWavePicking.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 79)
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.Text = "Ola de Picking:"
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLotNumber.Location = New System.Drawing.Point(124, 159)
        Me.lblLotNumber.Size = New System.Drawing.Size(96, 16)
        Me.lblLotNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCod_Product
        '
        Me.lblCod_Product.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCod_Product.Location = New System.Drawing.Point(12, 159)
        Me.lblCod_Product.Size = New System.Drawing.Size(97, 16)
        Me.lblCod_Product.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(8, 135)
        Me.txtBarcode.Size = New System.Drawing.Size(216, 22)
        Me.txtBarcode.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 223)
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.Text = "Cantidad:"
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(12, 183)
        Me.lblProductName.Size = New System.Drawing.Size(209, 26)
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(124, 215)
        Me.txtQty.Size = New System.Drawing.Size(104, 22)
        Me.txtQty.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 119)
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.Text = "Cod. Barras Producto"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(232, 246)
        Me.TabPage2.Text = "Productos"
        '
        'grdData
        '
        Me.grdData.Location = New System.Drawing.Point(4, 32)
        Me.grdData.Size = New System.Drawing.Size(224, 200)
        Me.grdData.Text = "DataGrid1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.grdData2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(232, 246)
        Me.TabPage3.Text = "Detalle"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'grdData2
        '
        Me.grdData2.Location = New System.Drawing.Point(4, 32)
        Me.grdData2.Size = New System.Drawing.Size(224, 200)
        Me.grdData2.Text = "DataGrid1"
        '
        'frmCheckPicking
        '
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.TabControl1)
        Me.Text = "Chequeo de Despacho"

    End Sub

#End Region


    Dim dsData As DataSet
    Dim sCompany As String
    Dim bIsWorking As Boolean = False

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            bIsWorking = False
            lblCod_Product.Text = ""
            lblLotNumber.Text = ""
            cboUnit.Items.Clear()
            cboUnit.Text = ""
            lblProductName.Text = ""
            txtBarcode.Text = ""
            txtQty.Text = ""
            lblCheck.Text = ""
            txtBarcode.Focus()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
            txtQty.Enabled = False

        End Try
    End Sub



    Private Sub UpdateTask()
        Dim xPicking As New wsPicking.wsPicking
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
            If bIsWorking Then Exit Sub
            bIsWorking = True
            Cursor.Current = Cursors.WaitCursor
            sResult = xPicking.CheckPickingTask(lblCod_Product.Text, lblLotNumber.Text, txtQty.Text, cboUnit.Text, modGlobal.publicUserID, txtWavePicking.Text, txtLocationTarget.Text)
            bIsWorking = False
            ClearFields()
            LoadGrid()
            LoadGrid2()
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            bIsWorking = False
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
            txtLocationTarget.Focus()
        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()

        End Try
    End Sub

    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
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



    Private Sub grdData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    

    Private Sub lblTone_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLotNumber.ParentChanged

    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub TabPage2_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        Dim xPick As New wsPicking.wsPicking

        Try
            lblCheck.Text = "Chequeado: " & xPick.GetTotalCheckTasks(txtLocationTarget.Text, txtWavePicking.Text)

            Dim ts1 As New DataGridTableStyle
            Dim TextCol As New DataGridTextBoxColumn

            ts1.MappingName = "myTable"
            TextCol.MappingName = "IsChecked"
            TextCol.HeaderText = ""
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

            TextCol = Nothing

            grdData.TableStyles.Clear()
            grdData.TableStyles.Add(ts1)

            sSQL = "SELECT IsChecked=Case When A.Status='4' then '' else '*' end, a.Cod_Product, a.Qty_Served, a.Qty_Checked, a.Measure_Unit, B.Description, A.Status  " & _
                    " FROM WMS_PICKING_TASKS A, VW_SBO_Products B " & _
                    " WHERE A.Cod_Product = B.Cod_Product " & _
                        " AND A.ERP_Document = '" & txtWavePicking.Text & "' " & _
                        " AND (A.Status = '4' OR A.Status = '5') " & _
                        " AND A.Location_Target = '" & txtLocationTarget.Text & "' " & _
                    " ORDER BY A.Status, A.Datetime_End "

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
            txtLocationTarget.SelectAll()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try

    End Sub

    Private Sub LoadGrid2()
        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim sSQL As String

        Try

            Dim ts1 As New DataGridTableStyle
            Dim TextCol As New DataGridTextBoxColumn

            ts1.MappingName = "myTable"
            TextCol.MappingName = "Cod_Product"
            TextCol.HeaderText = "Codigo"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "LotNumber"
            TextCol.HeaderText = "Lote"
            TextCol.Width = 60
            ts1.GridColumnStyles.Add(TextCol)

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Quantity"
            TextCol.HeaderText = "Cantidad"
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

            grdData2.TableStyles.Clear()
            grdData2.TableStyles.Add(ts1)

            sSQL = "SELECT A.Cod_Product, A.LotNumber, SUM(a.Quantity) AS Quantity, A.Unit, C.Description  " & _
                    " FROM WMS_PICKING_DETAIL A, WMS_PICKING_TASKS B, VW_SBO_Products C " & _
                    " WHERE A.Task_Number = B.Task_Number AND A.Cod_Product = C.Cod_Product " & _
                        " AND B.ERP_Document = '" & txtWavePicking.Text & "' " & _
                        " AND (B.Status = '4' OR B.Status = '5') " & _
                        " AND B.Location_Target = '" & txtLocationTarget.Text & "' " & _
                    " GROUP By A.Cod_Product, A.LotNumber, A.Unit, C.Description " & _
                    " ORDER BY A.Cod_Product, A.LotNumber, A.Unit "

            dsData = wsServ.GetDataSet(sSQL)
            grdData2.DataSource = dsData.Tables(0)

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try

    End Sub
    Private Sub txtLocationTarget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.TextChanged

    End Sub

    Private Sub txtLocationTarget_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocationTarget.GotFocus
        txtLocationTarget.SelectAll()
    End Sub

    

    'Private Sub txtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    Dim xServ As New wsCommonServices.wsCommonServices
    '    Dim sUnit As String
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Cursor.Current = Cursors.WaitCursor
    '            Call xServ.ProcessBarcode(txtBarcode.Text, lblCod_Product.Text, lblLotNumber.Text, lblProductName.Text, txtQty.Text, "", "", sCompany, sUnit)
    '            With cboUnit
    '                .Items.Clear()
    '                .Items.Add(sUnit)
    '                If sUnit.Trim = "CA" Then
    '                    .Items.Add("UN")
    '                End If
    '                .SelectedIndex = 0
    '            End With
    '            Cursor.Current = Cursors.Default
    '            txtQty.Focus()

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
                Call xServ.ProcessBarcode(txtBarcode.Text, lblCod_Product.Text, lblLotNumber.Text, lblProductName.Text, txtQty.Text, "", "", sCompany, sUnit, modGlobal.publicCurrentCountry)
                With cboUnit
                    .Items.Clear()
                    .Items.Add(sUnit)
                    If sUnit.Trim = "CA" Then
                        .Items.Add("UN")
                    End If
                    .SelectedIndex = 0
                End With
                Cursor.Current = Cursors.Default
                txtQty.Focus()

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

    'Private Sub txtLocationTarget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocationTarget.KeyDown

    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            Dim xPick As New wsPicking.wsPicking
    '            lblLocationDesc.Text = xPick.GetLocationDescription (txtLocationTarget.Text)
    '            xPick.GetDataForCheck(txtLocationTarget.Text, txtWavePicking.Text)
    '            LoadGrid()
    '            LoadGrid2()

    '        Catch ex As Exception
    '            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
    '        End Try
    '    End If

    'End Sub

    Private Sub txtLocationTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocationTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Dim xPick As New wsPicking.wsPicking
                lblLocationDesc.Text = xPick.GetLocationDescription(txtLocationTarget.Text, "")
                xPick.GetDataForCheck(txtLocationTarget.Text, txtWavePicking.Text)
                LoadGrid()
                LoadGrid2()

            Catch ex As Exception
                MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
            End Try
        End If

    End Sub
End Class
