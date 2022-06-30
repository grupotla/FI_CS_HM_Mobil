Public Class frmIni
    Inherits System.Windows.Forms.Form
    Dim strDA As String
    Dim strBL As String
    Dim strPAD As String


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.txtBarcode.Focus()


        'Add any initialization after the InitializeComponent() call

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.Label
    Friend WithEvents txtBL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPackages As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNPackages As System.Windows.Forms.TextBox
    Friend WithEvents txtDateEnter As System.Windows.Forms.TextBox
    Friend WithEvents txtAgent As System.Windows.Forms.TextBox
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents txtConsignee As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdEnter As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.Label
        Me.txtBL = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPackages = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNPackages = New System.Windows.Forms.TextBox
        Me.txtDateEnter = New System.Windows.Forms.TextBox
        Me.txtAgent = New System.Windows.Forms.TextBox
        Me.txtContainer = New System.Windows.Forms.TextBox
        Me.txtConsignee = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdEnter = New System.Windows.Forms.Button
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 208)
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.Text = "Reiniciar"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(96, 176)
        Me.txtLocation.Size = New System.Drawing.Size(120, 22)
        Me.txtLocation.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 184)
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.Text = "Ubicación:"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(56, 8)
        Me.txtBarcode.Size = New System.Drawing.Size(176, 22)
        Me.txtBarcode.Text = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(16, 16)
        Me.txtCodigo.Size = New System.Drawing.Size(48, 16)
        Me.txtCodigo.Text = "Cód.:"
        '
        'txtBL
        '
        Me.txtBL.Location = New System.Drawing.Point(56, 32)
        Me.txtBL.ReadOnly = True
        Me.txtBL.Size = New System.Drawing.Size(176, 22)
        Me.txtBL.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 136)
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.Text = "Fecha Ingreso:"
        '
        'txtPackages
        '
        Me.txtPackages.Location = New System.Drawing.Point(136, 152)
        Me.txtPackages.ReadOnly = True
        Me.txtPackages.Size = New System.Drawing.Size(32, 22)
        Me.txtPackages.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(128, 160)
        Me.Label8.Size = New System.Drawing.Size(8, 16)
        Me.Label8.Text = "/"
        '
        'txtNPackages
        '
        Me.txtNPackages.Location = New System.Drawing.Point(96, 152)
        Me.txtNPackages.Size = New System.Drawing.Size(32, 22)
        Me.txtNPackages.Text = ""
        '
        'txtDateEnter
        '
        Me.txtDateEnter.Location = New System.Drawing.Point(96, 128)
        Me.txtDateEnter.ReadOnly = True
        Me.txtDateEnter.Size = New System.Drawing.Size(136, 22)
        Me.txtDateEnter.Text = ""
        '
        'txtAgent
        '
        Me.txtAgent.Location = New System.Drawing.Point(96, 104)
        Me.txtAgent.ReadOnly = True
        Me.txtAgent.Size = New System.Drawing.Size(136, 22)
        Me.txtAgent.Text = ""
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(96, 80)
        Me.txtContainer.ReadOnly = True
        Me.txtContainer.Size = New System.Drawing.Size(136, 22)
        Me.txtContainer.Text = ""
        '
        'txtConsignee
        '
        Me.txtConsignee.Location = New System.Drawing.Point(96, 56)
        Me.txtConsignee.ReadOnly = True
        Me.txtConsignee.Size = New System.Drawing.Size(136, 22)
        Me.txtConsignee.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 160)
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.Text = "Bultos:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 112)
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.Text = "Agente:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.Text = "Contenedor:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.Text = "Consignatario:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.Text = "BL:"
        '
        'cmdEnter
        '
        Me.cmdEnter.Location = New System.Drawing.Point(40, 208)
        Me.cmdEnter.Size = New System.Drawing.Size(72, 24)
        Me.cmdEnter.Text = "Aceptar"
        '
        'frmIni
        '
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtBL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPackages)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNPackages)
        Me.Controls.Add(Me.txtDateEnter)
        Me.Controls.Add(Me.txtAgent)
        Me.Controls.Add(Me.txtContainer)
        Me.Controls.Add(Me.txtConsignee)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdEnter)
        Me.Text = "Inicialización"

    End Sub

#End Region



    Private Sub GetData(ByVal strBarCode As String)
        Dim xCommon As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        Dim sSQL As String = ""

        Try
            Dim aBarCode As String()

            aBarCode = strBarCode.Split("|")

            Dim strBL As String = aBarCode(2)

            'Si es guatemala se envia un 288- esto se debe remover, pero en los otros paises no se debe hacer
            If modGlobal.publicCurrentCountry.ToLower = "" Or modGlobal.publicCurrentCountry.ToLower = "gt" Then
                strPAD = aBarCode(0).Split("-")(1)
                strDA = aBarCode(0).Split("-")(1)                
            Else
                strPAD = aBarCode(0)
                strDA = aBarCode(0)
            End If

            'Me.txtDA.Text = strDA
            Me.txtBL.Text = strBL

            Try
                sSQL = "select bl, cod_product from DEF_COMMODITIES where cast(bl_short as char) = '" & strBL & "'"
                dsData = xCommon.GetDataSet(sSQL)
                If dsData.Tables.Count > 0 Then
                    If dsData.Tables(0).Rows.Count > 0 Then
                        strBL = CStr(dsData.Tables(0).Rows(0).Item(0))
                    End If
                End If
                Me.txtBL.Text = strBL
                dsData = Nothing

            Catch ex As Exception

            End Try

            dsData = xCommon.GetCommodityData(strDA, strBL, modGlobal.publicCurrentCountry)
            Cursor.Current = Cursors.WaitCursor

            If dsData.Tables(0).Rows.Count > 0 Then
                Me.txtConsignee.Text = dsData.Tables(0).Rows(0)("consignee")
                Me.txtContainer.Text = dsData.Tables(0).Rows(0)("contenedor")
                Me.txtAgent.Text = dsData.Tables(0).Rows(0)("shipper")
                Me.txtDateEnter.Text = dsData.Tables(0).Rows(0)("date")
                'Me.txtNPackages.Text = dsData.Tables(0).Rows(0)("packages")
                Me.txtPackages.Text = dsData.Tables(0).Rows(0)("packages")

                'Dim strDate As String = dsData.Tables(0).Rows(0)("date")
                'Dim strDateSp As String = strDate.Split("-")(2) & "/" & strDate.Split("-")(1) & "/" & strDate.Split("-")(0)
                'Me.txtDateEnter.Text = strDateSp


            Else
                Cursor.Current = Cursors.Default
                MsgBox("No se encontraron datos")

            End If

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("Error en busqueda. " & ex.Message)

        Finally
            Cursor.Current = Cursors.Default

        End Try


    End Sub

    'Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click
    '    Dim wsCommon As New wsCommonServices.wsCommonServices
    '    Dim strBl As String
    '    Dim strPrinterPort As String = Me.cboPrinter.SelectedValue

    '    If (Me.cmdGetData.Enabled) Then
    '        strBl = cmbBL.SelectedValue
    '    Else
    '        strBl = Me.txtBL.Text
    '    End If

    '    Dim strResult As String

    '    strResult = wsCommon.PrintLabelCommodity(Me.txtPAD.Text, Me.txtDA.Text, strBl, Me.txtConsignee.Text, Me.txtContainer.Text, Me.txtAgent.Text, Me.txtDateEnter.Text, Me.txtNPackages.Text, Me.txtPackages.Text, _
    '    strPrinterPort)

    '    MsgBox(strResult)

    'End Sub

    

    

    Public Sub ClearFields()
        Me.txtBarcode.Text = ""
        'Me.txtPAD.Text = ""
        'Me.txtDA.Text = ""
        Me.txtDateEnter.Text = ""
        Me.txtBL.Text = ""
        Me.txtConsignee.Text = ""
        Me.txtContainer.Text = ""
        Me.txtAgent.Text = ""
        Me.txtDateEnter.Text = ""
        Me.txtNPackages.Text = ""
        Me.txtPackages.Text = ""
        Me.txtLocation.Text = ""
    End Sub


    Private Sub ReinitLocation()
        Dim sLocation As String
        Dim xArrivals As New wsArrivals.wsArrivals

        Try
            If txtLocation.Text.Trim.Length = 0 Then
                MsgBox("Debe ingresar una ubicacion para Reiniciar", MsgBoxStyle.Information, publicProject)
                Exit Sub
            End If

            If txtBarcode.Text.Length = 0 Or txtBarcode.Text.Length = 0 Then
                Beep()
                txtBarcode.Text = ""
                MsgBox("Producto ingresado inválido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Focus()
                Exit Sub
            End If

            If MsgBox("Esta seguro que desea reiniciar la Ubicacion ", MsgBoxStyle.YesNo, publicProject) = MsgBoxResult.No Then
                Exit Sub
            End If


            Cursor.Current = Cursors.WaitCursor
            Call xArrivals.ReinitLocation(txtLocation.Text, publicUserID, Me.txtBarcode.Text)
            txtLocation.Text = txtLocation.Text
            'lblLocationDescription.Text = xArrivals.GetLocationDescription (txtLocation.Text)
            'ShowStockOnLocation()
            ClearFields()
            txtBarcode.Focus()
            Cursor.Current = Cursors.Default
            MsgBox("Ubicacion reiniciada")

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
        Finally
            Cursor.Current = Cursors.Default            
        End Try

    End Sub

    Private Sub UpdateTask()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim iResult As Long
        Dim sResult As String
        Dim sFechaExp As String

        Try

            If txtBarcode.Text.Length = 0 Or txtBarcode.Text.Length = 0 Then
                Beep()
                txtBarcode.Text = ""
                MsgBox("Codigo ingresado inválido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Focus()
                Exit Sub
            End If

            If txtLocation.Text.Trim.Length = 0 Then
                Beep()
                txtLocation.Text = ""
                MsgBox("Ubicacion inválida", MsgBoxStyle.Exclamation, publicProject)
                txtLocation.Focus()
                Exit Sub
            End If

            If Not IsNumeric(txtNPackages.Text) Then
                Beep()
                txtNPackages.Text = "0"
                MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                txtNPackages.Focus()
                Exit Sub
            Else
                If CDbl(txtNPackages.Text) < 0 Or CDbl(txtNPackages.Text) > CDbl(txtPackages.Text) Then
                    Beep()
                    'txtNPackages.Text = "0"
                    MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                    txtNPackages.Focus()
                    Exit Sub
                End If
            End If

            Cursor.Current = Cursors.WaitCursor
            sResult = xArrivals.InitStock(modGlobal.publicUserID, txtBarcode.Text, strDA, txtNPackages.Text, txtLocation.Text, strPAD, "1", "")
            'txtLocation.Text = txtLocationTarget.Text
            'lblLocationDescription.Text = xArrivals.GetLocationDescription (txtLocation.Text)
            'ShowStockOnLocation()
            ClearFields()

            Cursor.Current = Cursors.Default
            MsgBox("Producto ingresado correctamente")
            txtBarcode.Focus()


        Catch ex As Exception
            Cursor.Current = Cursors.Default
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
        End Try

    End Sub


    

    Private Sub cmdEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click
        Try
            UpdateTask()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReinitLocation()
    End Sub

    'Private Sub txtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    If (e.KeyCode = Keys.Enter) Then
    '        GetData(Me.txtBarcode.Text)
    '        Me.txtNPackages.Focus()
    '    End If

    'End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If (e.KeyChar = Chr(13)) Then
            GetData(Me.txtBarcode.Text)
            Me.txtNPackages.Focus()
        End If

    End Sub

    'Private Sub txtNPackages_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNPackages.KeyDown
    '    If (e.KeyCode = Keys.Enter) Then
    '        Me.txtLocation.Focus()
    '    End If
    'End Sub

    Private Sub txtNPackages_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNPackages.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Me.txtLocation.Focus()
        End If
    End Sub

    'Private Sub txtLocation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocation.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Try

    '            UpdateTask()
    '        Catch ex As Exception

    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

    '        End Try


    '    End If
    'End Sub

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                UpdateTask()
            Catch ex As Exception

                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

            End Try


        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class
