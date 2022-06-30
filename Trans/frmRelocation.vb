Public Class frmRelocation
    Inherits System.Windows.Forms.Form
    Friend WithEvents cmdAccept As System.Windows.Forms.Button


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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblCod_Product As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTaskReason As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPend As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picRelocationTasks As System.Windows.Forms.PictureBox
    Friend WithEvents lblLocationSource As System.Windows.Forms.Label
    Friend WithEvents txtLocationSource As System.Windows.Forms.TextBox
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLocationTarget As System.Windows.Forms.TextBox
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdAccept2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRelocation))
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblLocationSource = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblCod_Product = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTaskReason = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblPend = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.lblCant = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.txtLocationSource = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.picRelocationTasks = New System.Windows.Forms.PictureBox
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLocationTarget = New System.Windows.Forms.TextBox
        Me.myTimer = New System.Windows.Forms.Timer
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUnit = New System.Windows.Forms.Label
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdAccept2 = New System.Windows.Forms.Button
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(80, 272)
        Me.cmdAccept.Size = New System.Drawing.Size(80, 24)
        Me.cmdAccept.Text = "Aceptar"
        Me.cmdAccept.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 8)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Reubicacion -"
        '
        'lblLocationSource
        '
        Me.lblLocationSource.Location = New System.Drawing.Point(96, 88)
        Me.lblLocationSource.Size = New System.Drawing.Size(136, 16)
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 112)
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.Text = "Destino:"
        '
        'lblCod_Product
        '
        Me.lblCod_Product.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCod_Product.Location = New System.Drawing.Point(8, 48)
        Me.lblCod_Product.Size = New System.Drawing.Size(224, 16)
        Me.lblCod_Product.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(16, 0)
        Me.lblLotNumber.Size = New System.Drawing.Size(216, 8)
        Me.lblLotNumber.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 152)
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.Text = "Origen:"
        '
        'lblTaskReason
        '
        Me.lblTaskReason.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTaskReason.Location = New System.Drawing.Point(48, 24)
        Me.lblTaskReason.Size = New System.Drawing.Size(184, 16)
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(88, 176)
        Me.txtBarcode.Size = New System.Drawing.Size(144, 22)
        Me.txtBarcode.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.Text = "Cod. Barras:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(136, 128)
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.Text = "de"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'lblPend
        '
        Me.lblPend.Location = New System.Drawing.Point(72, 128)
        Me.lblPend.Size = New System.Drawing.Size(64, 16)
        Me.lblPend.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQty
        '
        Me.lblQty.Location = New System.Drawing.Point(160, 128)
        Me.lblQty.Size = New System.Drawing.Size(72, 16)
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCant
        '
        Me.lblCant.Location = New System.Drawing.Point(8, 128)
        Me.lblCant.Size = New System.Drawing.Size(72, 16)
        Me.lblCant.Text = "Pendiente:"
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(16, 64)
        Me.lblProductName.Size = New System.Drawing.Size(216, 16)
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLocationSource
        '
        Me.txtLocationSource.Location = New System.Drawing.Point(128, 152)
        Me.txtLocationSource.Size = New System.Drawing.Size(104, 22)
        Me.txtLocationSource.Text = ""
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
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'picRelocationTasks
        '
        Me.picRelocationTasks.Image = CType(resources.GetObject("picRelocationTasks.Image"), System.Drawing.Image)
        Me.picRelocationTasks.Location = New System.Drawing.Point(8, 4)
        Me.picRelocationTasks.Size = New System.Drawing.Size(40, 32)
        Me.picRelocationTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(96, 112)
        Me.lblLocationTarget.Size = New System.Drawing.Size(136, 16)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 224)
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.Text = "Destino:"
        '
        'txtLocationTarget
        '
        Me.txtLocationTarget.Location = New System.Drawing.Point(128, 224)
        Me.txtLocationTarget.Size = New System.Drawing.Size(104, 22)
        Me.txtLocationTarget.Text = ""
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.Text = "Origen:"
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(96, 200)
        Me.lblUnit.Size = New System.Drawing.Size(32, 16)
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(8, 248)
        Me.cmdRefresh.Text = "Refrescar"
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(80, 248)
        Me.cmdNext.Text = "Siguiente"
        '
        'cmdAccept2
        '
        Me.cmdAccept2.Location = New System.Drawing.Point(152, 248)
        Me.cmdAccept2.Text = "Aceptar"
        '
        'frmRelocation
        '
        Me.ClientSize = New System.Drawing.Size(242, 270)
        Me.Controls.Add(Me.cmdAccept2)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocationTarget)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.picRelocationTasks)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblLocationSource)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblCod_Product)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTaskReason)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPend)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.txtLocationSource)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmdAccept)
        Me.Text = "WMS - Reubicacion"

    End Sub

#End Region

    Private nRelocation_Task As Long
    Private sBarcode As String
    Private sERP_Document As String
    Dim sLocationSource As String
    Dim sLocationTarget As String
    Dim Graphics As Graphics
    Dim sUnitCheck As String
    Dim sCompany As String
    Dim Pen As New Pen(Color.Black)

    Private Sub DrawLines()

        Graphics = Nothing
        Graphics = Me.CreateGraphics
        Graphics.Clear(Color.White)
        Graphics.DrawLine(Pen, 5, 46, 235, 46)      'Upper
        Graphics.DrawLine(Pen, 5, 46, 5, 275)       'Left   
        Graphics.DrawLine(Pen, 235, 46, 235, 275)   'Right
        'Graphics.DrawLine(Pen, 5, 240, 235, 240)    'Bottom
        'Graphics.DrawLine(Pen, 5, 56, 235, 56)      'Middle 1
        Graphics.DrawLine(Pen, 5, 126, 235, 126)    'Middle 2

    End Sub

    Private Sub GetFirstTask()
        Dim xRelocation As New wsRelocation.wsRelocation

        Try

            nRelocation_Task = xRelocation.GetFirstTask(modGlobal.publicUserID)
            If nRelocation_Task <> -1 Then
                FillTaskData()
            Else
                MsgBox("No se encontraron tareas en proceso", MsgBoxStyle.Information, modGlobal.publicProject)
                Me.Close()
            End If
        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub FillTaskData()
        Dim xRelocation As New wsRelocation.wsRelocation
        Dim xService As New wsCommonServices.wsCommonServices
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String
        Dim nConversion As Integer

        Try
            Dim strProduct As String
            sResult = xRelocation.GetTaskData(nRelocation_Task, strProduct, lblLotNumber.Text, lblProductName.Text, sBarcode, _
                                       sLocationSource, sLocationTarget, nQTY_Task, nQTY_Pending, nQTY, lblTaskReason.Text, _
                                       "", lblUnit.Text, lblLocationSource.Text, lblLocationTarget.Text)


            Me.lblCod_Product.Text = strProduct
            nConversion = 1
            If sResult = "-1" Then
                GetFirstTask()
                Exit Sub
            End If
            lblTitle.Text = "Reubicacion - " & CStr(nRelocation_Task)
            lblQty.Text = Format(nQTY_Task / nConversion, "#,##0.00")
            lblPend.Text = Format$(nQTY_Pending / nConversion, "#,##0.00")

            If sLocationSource = "-1" Then
                MsgBox("No se encontro inventario disponible para la tarea", MsgBoxStyle.Exclamation)
                txtQty.Enabled = False
                cmdAccept.Enabled = False
            Else
                txtQty.Enabled = True
                cmdAccept.Enabled = True
            End If

            txtBarcode.Text = ""
            txtLocationSource.Text = ""
            txtLocationTarget.Text = ""
            txtQty.Text = ""
            txtLocationSource.Focus()
            Label6.Text = "Cantidad:"
            DrawLines()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
            txtQty.Enabled = False
            cmdAccept.Enabled = False
        End Try
    End Sub

    Private Sub UpdateTask()
        Dim xRelocation As New wsRelocation.wsRelocation
        Dim iResult As Long
        Dim sResult As String
        Dim xService As New wsCommonServices.wsCommonServices
        Dim nConversion As Integer

        Try

            If sLocationSource.Trim.ToUpper <> txtLocationSource.Text.Trim.ToUpper Then
                MsgBox("Ubicacion fuente elegida invalida", MsgBoxStyle.Exclamation, publicProject)
                txtLocationSource.Text = ""
                txtLocationSource.Focus()
                Exit Sub
            End If

            'cuando ya no sean discresionales
            If sLocationTarget <> Nothing Then
                If lblLocationTarget.Text <> "Discrecional" Then
                    If sLocationTarget.Trim.ToUpper <> txtLocationTarget.Text.Trim.ToUpper Then
                        MsgBox("Ubicacion destino elegida invalida", MsgBoxStyle.Exclamation, publicProject)
                        txtLocationTarget.Text = ""
                        txtLocationTarget.Focus()
                        Exit Sub
                    End If
                End If
            End If

            If xService.ValidateLocation(txtLocationTarget.Text) = False Then
                MsgBox("Ubicacion destino elegida invalida", MsgBoxStyle.Exclamation, publicProject)
                txtLocationTarget.Text = ""
                txtLocationTarget.Focus()
                Exit Sub
            End If

            If txtLocationTarget.Text.Trim.ToUpper = "" Then
                MsgBox("Debe ingresar una ubicacion Destino valida ", MsgBoxStyle.Exclamation, publicProject)
                txtLocationTarget.Text = ""
                txtLocationTarget.Focus()
                Exit Sub
            End If

            If txtLocationSource.Text.Trim.ToUpper = "" Then
                MsgBox("Debe ingresar una ubicacion Origen valida ", MsgBoxStyle.Exclamation, publicProject)
                txtLocationSource.Text = ""
                txtLocationSource.Focus()
                Exit Sub
            End If

            If txtLocationSource.Text.Trim.ToUpper = txtLocationTarget.Text.Trim.ToUpper Then
                MsgBox("Ubicacion destino es igual a la de origen", MsgBoxStyle.Exclamation, publicProject)
                txtLocationTarget.Text = ""
                txtLocationTarget.Focus()
                Exit Sub
            End If

            If Not IsNumeric(txtQty.Text) Or _
                    CDbl(txtQty.Text) > CDbl(lblPend.Text) Or _
                    CDbl(txtQty.Text) < 0 Then
                MsgBox("Cantidad ingresada invalida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Text = ""
                txtQty.Focus()
                Exit Sub
            End If
            sCompany = ""

            sResult = xRelocation.UpdateTask(nRelocation_Task, "1", modGlobal.publicUserID, lblCod_Product.Text, _
                                           lblLotNumber.Text, CDbl(txtQty.Text), txtLocationSource.Text, txtLocationTarget.Text, lblUnit.Text, sCompany.Trim)

            MsgBox("Tarea ejecutada exitosamente", MsgBoxStyle.Information, publicProject)

            FillTaskData()

        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

        End Try
    End Sub

    Private Sub frmRelocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            GetFirstTask()
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




    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        txtQty.SelectAll()
    End Sub



    Private Sub txtBarcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.GotFocus
        txtBarcode.SelectAll()
    End Sub

    Private Sub txtLocationSource_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocationSource.GotFocus
        txtBarcode.SelectAll()
    End Sub

    Private Sub txtLocationTarget_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocationTarget.GotFocus
        txtLocationTarget.SelectAll()
    End Sub



    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        DrawLines()
        myTimer.Enabled = False
    End Sub



    Private Sub cmdAccept2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept2.Click
        UpdateTask()
    End Sub


    Private Sub txtLocationTarget_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocationTarget.TextChanged

    End Sub

    'Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    Dim sCodProduct As String
    '    Dim sLotNumber As String

    '    Try
    '        Dim xServ As New wsCommonServices.wsCommonServices
    '        If e.KeyCode = Keys.Enter Then
    '            Call xServ.ProcessBarcode(txtBarcode.Text, sCodProduct, sLotNumber, "", txtQty.Text, "", "", sCompany, sUnitCheck)
    '            If sCodProduct <> lblCod_Product.Text.Trim Then
    '                MsgBox("Producto en Codigo de Barras Invalido", MsgBoxStyle.Exclamation, "WMS Mobile - AIMAR")
    '                txtBarcode.Text = ""
    '                txtBarcode.Focus()
    '                Exit Sub
    '            End If

    '            If sLotNumber <> lblLotNumber.Text.Trim Then
    '                MsgBox("Lote del producto en Codigo de Barras Invalido", MsgBoxStyle.Exclamation, "WMS Mobile - AIMAR")
    '                txtBarcode.Text = ""
    '                txtBarcode.Focus()
    '                Exit Sub
    '            End If

    '            txtQty.Focus()
    '        End If
    '    Catch ex As Exception
    '        sCodProduct = ""
    '        sLotNumber = ""
    '        sCompany = ""
    '        sUnitCheck = ""
    '        mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '        txtBarcode.Text = ""
    '        txtBarcode.Focus()
    '    End Try
    'End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim sCodProduct As String
        Dim sLotNumber As String

        Try
            Dim xServ As New wsCommonServices.wsCommonServices
            If e.KeyChar = Chr(13) Then
                Call xServ.ProcessBarcode(txtBarcode.Text, sCodProduct, sLotNumber, "", txtQty.Text, "", "", sCompany, sUnitCheck, modGlobal.publicCurrentCountry)
                'MessageBox.Show("Codigo obtenido: [" & sCodProduct & "]")
                'MessageBox.Show("Codigo de la tarea: [" & lblCod_Product.Text.Trim & "]")

                If sCodProduct.Length = 13 Then

                ElseIf sCodProduct <> lblCod_Product.Text.Trim Then
                    MsgBox("Producto en Codigo de Barras Invalido", MsgBoxStyle.Exclamation, "WMS Mobile - AIMAR")
                    txtBarcode.Text = ""
                    txtBarcode.Focus()
                    Exit Sub
                End If

                If sCodProduct.Length = 13 Then

                ElseIf sLotNumber <> lblLotNumber.Text.Trim Then
                    MsgBox("Lote del producto en Codigo de Barras Invalido", MsgBoxStyle.Exclamation, "WMS Mobile - AIMAR")
                    txtBarcode.Text = ""
                    txtBarcode.Focus()
                    Exit Sub
                End If

                txtQty.Focus()
            End If
        Catch ex As Exception
            sCodProduct = ""
            sLotNumber = ""
            sCompany = ""
            sUnitCheck = ""
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            txtBarcode.Text = ""
            txtBarcode.Focus()
        End Try
    End Sub

    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtLocationTarget.Focus()
    '    End If
    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            txtLocationTarget.Focus()
        End If
    End Sub

    'Private Sub txtLocationSource_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocationSource.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If txtLocationSource.Text <> "" Then
    '            If txtLocationSource.Text.Trim.ToUpper <> sLocationSource.Trim.ToUpper Then
    '                MsgBox("Ubicacion Fuente Invalida", MsgBoxStyle.Exclamation, modGlobal.publicProject)
    '                txtLocationSource.Text = ""
    '                Exit Sub
    '            End If
    '        End If
    '        txtBarcode.Focus()
    '    End If
    'End Sub

    Private Sub txtLocationSource_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocationSource.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtLocationSource.Text <> "" Then
                If txtLocationSource.Text.Trim.ToUpper <> sLocationSource.Trim.ToUpper Then
                    MsgBox("Ubicacion Fuente Invalida", MsgBoxStyle.Exclamation, modGlobal.publicProject)
                    txtLocationSource.Text = ""
                    Exit Sub
                End If
            End If
            txtBarcode.Focus()
        End If
    End Sub

    'Private Sub txtLocationTarget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocationTarget.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        'If txtLocationTarget.Text <> "" Then
    '        '    If txtLocationTarget.Text.Trim.ToUpper <> sLocationTarget.Trim.ToUpper And sLocationTarget.Trim.ToUpper <> "DISCRECIONAL" Then
    '        '        MsgBox("Ubicacion Destino Invalida", MsgBoxStyle.Exclamation, modGlobal.publicProject)
    '        '        txtLocationTarget.Text = ""
    '        '        Exit Sub
    '        '    End If
    '        'End If
    '        UpdateTask()
    '    End If
    'End Sub

    Private Sub txtLocationTarget_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocationTarget.KeyPress
        If e.KeyChar = Chr(13) Then
            'If txtLocationTarget.Text <> "" Then
            '    If txtLocationTarget.Text.Trim.ToUpper <> sLocationTarget.Trim.ToUpper And sLocationTarget.Trim.ToUpper <> "DISCRECIONAL" Then
            '        MsgBox("Ubicacion Destino Invalida", MsgBoxStyle.Exclamation, modGlobal.publicProject)
            '        txtLocationTarget.Text = ""
            '        Exit Sub
            '    End If
            'End If
            UpdateTask()
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class
