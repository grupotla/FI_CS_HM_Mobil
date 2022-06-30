Public Class frmPicking
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
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblCod_Product As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTaskReason As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPend As System.Windows.Forms.Label
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLocationDesc As System.Windows.Forms.Label
    Friend WithEvents lblLocationTargetDesc As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblLocationTarget As System.Windows.Forms.Label
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents lblDisp As System.Windows.Forms.Label
    Friend WithEvents lblDescQty As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdTarget As System.Windows.Forms.Button
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents txtRow As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPicking))
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.picMain = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblLocationDesc = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblCod_Product = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTaskReason = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblPend = New System.Windows.Forms.Label
        Me.lblDisp = New System.Windows.Forms.Label
        Me.lblCant = New System.Windows.Forms.Label
        Me.lblProductName = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblLocationTargetDesc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblLocation = New System.Windows.Forms.Label
        Me.lblLocationTarget = New System.Windows.Forms.Label
        Me.myTimer = New System.Windows.Forms.Timer
        Me.lblDescQty = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblUnit = New System.Windows.Forms.Label
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdTarget = New System.Windows.Forms.Button
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.txtRow = New System.Windows.Forms.TextBox
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(240, 248)
        Me.cmdAccept.Size = New System.Drawing.Size(64, 24)
        Me.cmdAccept.Text = "Aceptar"
        Me.cmdAccept.Visible = False
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(8, 0)
        Me.picMain.Size = New System.Drawing.Size(32, 32)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 0)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Picking - "
        '
        'lblLocationDesc
        '
        Me.lblLocationDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationDesc.Location = New System.Drawing.Point(72, 112)
        Me.lblLocationDesc.Size = New System.Drawing.Size(152, 16)
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 112)
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.Text = "Ubicación:"
        '
        'lblCod_Product
        '
        Me.lblCod_Product.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCod_Product.Location = New System.Drawing.Point(8, 56)
        Me.lblCod_Product.Size = New System.Drawing.Size(224, 16)
        Me.lblCod_Product.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 200)
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.Text = "Ubicación:"
        '
        'lblTaskReason
        '
        Me.lblTaskReason.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTaskReason.Location = New System.Drawing.Point(48, 16)
        Me.lblTaskReason.Size = New System.Drawing.Size(184, 24)
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(80, 176)
        Me.txtBarcode.Size = New System.Drawing.Size(152, 22)
        Me.txtBarcode.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.Text = "Cod. Barras:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 224)
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'lblPend
        '
        Me.lblPend.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPend.Location = New System.Drawing.Point(280, 88)
        Me.lblPend.Size = New System.Drawing.Size(8, 16)
        Me.lblPend.Visible = False
        '
        'lblDisp
        '
        Me.lblDisp.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDisp.Location = New System.Drawing.Point(176, 160)
        Me.lblDisp.Size = New System.Drawing.Size(56, 16)
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCant
        '
        Me.lblCant.Location = New System.Drawing.Point(8, 160)
        Me.lblCant.Size = New System.Drawing.Size(32, 16)
        Me.lblCant.Text = "Pend"
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(8, 72)
        Me.lblProductName.Size = New System.Drawing.Size(224, 32)
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(80, 200)
        Me.txtLocation.Size = New System.Drawing.Size(152, 22)
        Me.txtLocation.Text = ""
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(112, 224)
        Me.txtQty.Size = New System.Drawing.Size(72, 22)
        Me.txtQty.Text = ""
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblCustomer
        '
        Me.lblCustomer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCustomer.Location = New System.Drawing.Point(8, 38)
        Me.lblCustomer.Size = New System.Drawing.Size(224, 16)
        '
        'lblLocationTargetDesc
        '
        Me.lblLocationTargetDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationTargetDesc.Location = New System.Drawing.Point(72, 136)
        Me.lblLocationTargetDesc.Size = New System.Drawing.Size(152, 16)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.Text = "Destino:"
        '
        'lblLocation
        '
        Me.lblLocation.Location = New System.Drawing.Point(544, 32)
        Me.lblLocation.Size = New System.Drawing.Size(8, 16)
        Me.lblLocation.Visible = False
        '
        'lblLocationTarget
        '
        Me.lblLocationTarget.Location = New System.Drawing.Point(544, 56)
        Me.lblLocationTarget.Size = New System.Drawing.Size(8, 16)
        Me.lblLocationTarget.Visible = False
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'lblDescQty
        '
        Me.lblDescQty.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescQty.Location = New System.Drawing.Point(40, 160)
        Me.lblDescQty.Size = New System.Drawing.Size(96, 16)
        Me.lblDescQty.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(144, 160)
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.Text = "Disp"
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(80, 224)
        Me.lblUnit.Size = New System.Drawing.Size(32, 20)
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(8, 248)
        Me.cmdRefresh.Size = New System.Drawing.Size(104, 24)
        Me.cmdRefresh.Text = "Refrescar"
        '
        'cmdTarget
        '
        Me.cmdTarget.Location = New System.Drawing.Point(120, 248)
        Me.cmdTarget.Size = New System.Drawing.Size(104, 24)
        Me.cmdTarget.Text = "Llevar a Puerta"
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(128, 48)
        Me.lblLotNumber.Size = New System.Drawing.Size(112, 16)
        Me.lblLotNumber.Visible = False
        '
        'txtRow
        '
        Me.txtRow.Location = New System.Drawing.Point(192, 224)
        Me.txtRow.Size = New System.Drawing.Size(40, 22)
        Me.txtRow.Text = "0"
        '
        'frmPicking
        '
        Me.ClientSize = New System.Drawing.Size(234, 271)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.cmdTarget)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDescQty)
        Me.Controls.Add(Me.lblLocationTarget)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblLocationTargetDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblLocationDesc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblCod_Product)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.lblTaskReason)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPend)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Text = "WMS - Picking"

    End Sub

#End Region

    Private nPicking_Task As Long = 0
    Private sERP_Document As String
    Private sLastDocument As String = ""
    Private sLastTarget As String = ""
    Private sLastTargetDesc As String = ""
    Private sLastProduct As String = ""
    Private sLastTask As String = ""
    Private bInTransaction As Boolean = False
    Private bDiscretional As Boolean = False
    Private bWorking As Boolean = False
    Dim sUnit As String
    Dim Graphics As Graphics
    Dim Pen As New Pen(Color.Black)
    Dim sUserType As String
    Dim sCod_Product As String
    Dim sLotNumber As String

    Dim isCFS As Boolean = False

    Private Sub DrawLines()
        Graphics = Nothing
        Graphics = Me.CreateGraphics
        Graphics.Clear(Color.White)
        Graphics.DrawLine(Pen, 5, 54, 235, 54)      'Upper
        Graphics.DrawLine(Pen, 5, 54, 5, 270)       'Left   
        Graphics.DrawLine(Pen, 235, 54, 235, 270)   'Right
        Graphics.DrawLine(Pen, 5, 164, 235, 164)    'Middle 2
    End Sub

    Private Sub GetFirstTask()
        Dim xPicking As New wsPicking.wsPicking

        Try
            Cursor.Current = Cursors.WaitCursor
            nPicking_Task = xPicking.GetFirstTaskIntelligent(modGlobal.publicUserID, nPicking_Task, lblLocation.Text, sLastDocument)            
            Cursor.Current = Cursors.Default
            If nPicking_Task <> -1 Then
                FillTaskData()
                myTimer.Enabled = True
            Else
                MsgBox("No se encontraron Tareas de Picking Asignadas", MsgBoxStyle.Information, modGlobal.publicProject)
                Me.Close()
            End If

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)

        End Try

    End Sub

    Private Sub FillTaskData()
        Dim xPicking As New wsPicking.wsPicking
        Dim xServ As New wsCommonServices.wsCommonServices
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String
        Dim nIndividualPicking As String
        Dim nConversion As Integer = 1

        Try
            lblProductName.Text = ""
            Me.txtRow.Visible = False
            'Me.txtRow.Text = ""
            Cursor.Current = Cursors.WaitCursor
            sResult = xPicking.GetTaskData(nPicking_Task, lblCod_Product.Text, lblLotNumber.Text, lblProductName.Text, _
                                       lblLocation.Text, lblLocationDesc.Text, lblLocationTarget.Text, lblLocationTargetDesc.Text, nQTY_Task, nQTY_Pending, nQTY, lblUnit.Text, lblTaskReason.Text, _
                                       lblCustomer.Text, sERP_Document, "", publicUserID)
            Cursor.Current = Cursors.Default

            If sResult = "-1" Then
                GetFirstTask() '
                Exit Sub
            End If

            If sLastTarget.Trim.Length > 0 Then
                If xPicking.MoreTasks(modGlobal.publicUserID, sLastTarget) = False Then
                    If bInTransaction Then
                        publicReturnCode = sLastTarget
                        publicReturnDesc = sLastTargetDesc
                        Dim x As New frmPickConfirmTarget
                        x.ShowDialog()
                        x = Nothing
                        sLastDocument = ""
                        bInTransaction = False
                    End If
                End If
            End If

            If sLastProduct <> lblCod_Product.Text.Trim Then
                txtLocation.Text = ""
                sLastProduct = lblCod_Product.Text.Trim
            End If

            If sLastTask.Trim <> CStr(nPicking_Task).Trim Then
                txtLocation.Text = ""
                sLastTask = CStr(nPicking_Task).Trim
            End If

            sLastDocument = sERP_Document
            sLastTarget = lblLocationTarget.Text
            sLastTargetDesc = lblLocationTargetDesc.Text
            lblLocationTargetDesc.Text = lblLocationTarget.Text
            lblTitle.Text = "Picking - " & CStr(nPicking_Task)
            lblTaskReason.Text = lblTaskReason.Text.ToUpper
            'lblDisp.Text = Format$(Math.Round((nQTY / nConversion)), "#,##0.00")
            'lblPend.Text = Format$(Math.Round((nQTY_Pending / nConversion)), "#,##0.00")
            lblDisp.Text = Format$(Math.Round((nQTY / nConversion), 2), "#,##0.00")
            lblPend.Text = Format$(Math.Round((nQTY_Pending / nConversion), 2), "#,##0.00")
            lblDescQty.Text = Format$(nQTY_Pending / nConversion, "#,##0") & " de " & Format$(nQTY_Task / nConversion, "#,##0")
            txtBarcode.Text = ""

            Me.isCFS = False
            If Me.lblCod_Product.Text.Length > 3 Then
                If Me.lblCod_Product.Text.Substring(0, 3) = "CFS" Then
                    Me.txtRow.Visible = True
                    Me.isCFS = True
                End If
            End If

            Me.txtQty.Enabled = True
            If nIndividualPicking = 1 Then
                txtQty.ReadOnly = True
                txtQty.Text = "1"
                If lblLocation.Text <> txtLocation.Text Then
                    txtLocation.Text = ""
                    txtLocation.ReadOnly = False
                Else
                    txtLocation.ReadOnly = True
                End If
            Else
                txtQty.ReadOnly = False
                txtQty.Text = ""
                txtLocation.Text = ""
                txtLocation.ReadOnly = False
            End If

            If lblLocation.Text = "-1" Then
                MsgBox("No se encontro inventario disponible para la tarea", MsgBoxStyle.Exclamation)
                txtQty.Enabled = False
                cmdAccept.Enabled = False
            Else
                txtQty.Enabled = True
                cmdAccept.Enabled = True
                txtBarcode.Focus()
            End If

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation)
            txtQty.Enabled = False
            txtLocation.Enabled = False
            cmdAccept.Enabled = False
        End Try
    End Sub

    Private Sub UpdateTask()
        Dim xPicking As New wsPicking.wsPicking
        Dim xServ As New wsCommonServices.wsCommonServices
        Dim iResult As Long
        Dim sResult As String

        Try
            If txtBarcode.Text.Length = 0 Or lblCod_Product.Text.Length = 0 Then
                Beep()
                txtBarcode.Text = ""
                MsgBox("Producto ingresado inválido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Focus()
                Exit Sub
            End If

            If lblCod_Product.Text = "" Then
                Beep()
                txtBarcode.Text = ""
                MsgBox("Producto ingresado inválido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Focus()
                Exit Sub
            End If

            If txtLocation.Text.Trim.Length = 0 Then
                Beep()
                txtLocation.Text = ""
                MsgBox("Ubicacion ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                txtLocation.Focus()
                Exit Sub
            End If

            If txtLocation.Text.Trim <> lblLocation.Text Then
                Beep()
                MsgBox("Ubicacion ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                txtLocation.Text = ""
                txtLocation.Focus()
                Exit Sub
            End If

            If Not IsNumeric(txtQty.Text) Then
                Beep()
                txtQty.Text = ""
                MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Focus()
                Exit Sub
            Else
                If CDbl(txtQty.Text) <= 0 Then
                    Beep()
                    txtQty.Text = ""
                    MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                    txtQty.Focus()
                    Exit Sub
                End If

                If CDbl(txtQty.Text) > CDbl(lblPend.Text) Then
                    Beep()
                    txtQty.Text = ""
                    MsgBox("Cantidad ingresada no puede ser mayor a la pedida", MsgBoxStyle.Exclamation, publicProject)
                    txtQty.Focus()
                    Exit Sub
                End If

                If CDbl(txtQty.Text) > CDbl(lblDisp.Text) Then
                    Beep()
                    txtQty.Text = ""
                    MsgBox("Cantidad ingresada no puede ser mayor al disponible en la Ubicacion", MsgBoxStyle.Exclamation, publicProject)
                    txtQty.Focus()
                    Exit Sub
                End If
            End If

            Cursor.Current = Cursors.WaitCursor
            If bWorking Then Exit Sub
            bWorking = True
            Dim strBarCode As String = lblCod_Product.Text.Replace("/", "~")
            sResult = xPicking.UpdateTask(nPicking_Task, "1", modGlobal.publicUserID, txtBarcode.Text, _
                                            lblLotNumber.Text, CDbl(txtQty.Text), sUnit, txtLocation.Text, lblLocationTarget.Text, sERP_Document, Me.txtRow.Text)
            bWorking = False
            Cursor.Current = Cursors.Default

            If Me.isCFS Then
                Dim xFrm As New frmPickingCFS
                xFrm.iPickingTaskNumber = nPicking_Task
                xFrm.ShowDialog()
                xFrm = Nothing
            End If

            MsgBox("Tarea ejecutada exitosamente", MsgBoxStyle.Exclamation, publicProject)

            bInTransaction = True
            If sUserType = "00" Then
                publicReturnCode = sLastTarget
                publicReturnDesc = sLastTargetDesc
                Dim x As New frmPickConfirmTarget
                x.ShowDialog()
                x.Dispose()
                x = Nothing
                bInTransaction = False
            End If

            GetFirstTask()

        Catch ex As Exception
            bWorking = False
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try
    End Sub

    Private Sub frmPicking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim xServ As New wsCommonServices.wsCommonServices
            Cursor.Current = Cursors.WaitCursor
            sUserType = xServ.GetUserType(publicUserID)
            Cursor.Current = Cursors.Default
            GetFirstTask()

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            Me.Close()

        End Try
    End Sub

    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub






    Private Sub txtLocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocation.GotFocus
        txtLocation.SelectAll()
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        txtQty.SelectAll()
    End Sub



    Private Sub txtBarcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.GotFocus
        txtBarcode.SelectAll()
    End Sub

    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        DrawLines()
        myTimer.Enabled = False
    End Sub

    Private Sub frmPicking_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If bInTransaction Then
            If sLastDocument.Trim.Length > 0 Then
                publicReturnCode = sLastTarget
                publicReturnDesc = sLastTargetDesc
                Dim x As New frmPickConfirmTarget
                x.ShowDialog()
                x = Nothing
                sLastDocument = ""
                bInTransaction = False
            End If
        End If
    End Sub

    Private Sub Clear_Fields()
        lblUnit.Text = ""
        lblLocationDesc.Text = ""
        lblLocationTargetDesc.Text = ""
        lblDescQty.Text = ""
        lblDisp.Text = ""
        txtBarcode.Text = ""
        txtLocation.Text = ""
        txtQty.Text = ""
        lblCustomer.Text = ""
        lblTaskReason.Text = ""
        lblCod_Product.Text = ""
        lblLotNumber.Text = ""
        lblProductName.Text = ""
        lblTitle.Text = "Picking - "
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        If txtBarcode.Text.Trim = "" Then
            sCod_Product = ""
            sLotNumber = ""
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        GetFirstTask()
    End Sub

    Private Sub cmdTarget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTarget.Click
        txtQty.Enabled = False
        UpdateTask()
        txtQty.Enabled = True
    End Sub


    'Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    Dim xServ As New wsCommonServices.wsCommonServices


    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            If txtBarcode.Text <> "" Then
    '                Cursor.Current = Cursors.WaitCursor
    '                Call xServ.ProcessBarcode(txtBarcode.Text, sCod_Product, sLotNumber, "", txtQty.Text, "", "", "", sUnit)
    '                Cursor.Current = Cursors.Default
    '            End If

    '            If sCod_Product.Trim = lblCod_Product.Text Then
    '                txtLocation.Focus()
    '            Else
    '                MsgBox("Codigo o lote ingresado no corresponde al Producto en Tarea", MsgBoxStyle.Exclamation, publicProject)
    '                txtBarcode.Text = ""
    '                txtBarcode.Focus()
    '            End If
    '        End If

    '    Catch ex As Exception
    '        sCod_Product = ""
    '        sLotNumber = ""
    '        txtQty.Text = ""
    '        Cursor.Current = Cursors.Default
    '        MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
    '        txtBarcode.Text = ""
    '        txtBarcode.Focus()
    '    End Try

    'End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim xServ As New wsCommonServices.wsCommonServices
        Try
            If e.KeyChar = Chr(13) Then
                If txtBarcode.Text <> "" Then
                    Cursor.Current = Cursors.WaitCursor
                    Call xServ.ProcessBarcode(txtBarcode.Text, sCod_Product, sLotNumber, "", txtQty.Text, "", "", "", sUnit, modGlobal.publicCurrentCountry)
                    Cursor.Current = Cursors.Default
                End If

                If sCod_Product.Trim = lblCod_Product.Text Then
                    txtLocation.Focus()
                Else
                    MsgBox("Codigo o lote ingresado no corresponde al Producto en Tarea", MsgBoxStyle.Exclamation, publicProject)
                    txtBarcode.Text = ""
                    txtBarcode.Focus()
                End If
            End If

        Catch ex As Exception
            sCod_Product = ""
            sLotNumber = ""
            txtQty.Text = ""
            Cursor.Current = Cursors.Default
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
            txtBarcode.Text = ""
            txtBarcode.Focus()
        End Try

    End Sub

    'Private Sub txtLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocation.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQty.Focus()
        End If
    End Sub

    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtQty.Enabled = False
    '        UpdateTask()
    '        txtQty.Enabled = True
    '    End If
    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQty.Enabled = False
            UpdateTask()
            txtQty.Enabled = True
        End If
    End Sub

End Class
