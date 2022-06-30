Public Class frmProductCount
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
    Friend WithEvents lblConteo As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdTerminar As System.Windows.Forms.Button
    Friend WithEvents lblCod_Producto As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNombre_Producto As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grdListado As System.Windows.Forms.DataGrid
    Friend WithEvents lblNo_Tarea As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents cmdReiniciar As System.Windows.Forms.Button
    Friend WithEvents picMenu As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblUbiDesc As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProductCount))
        Me.lblConteo = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.lblUbicacion = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUbicacion = New System.Windows.Forms.TextBox
        Me.cmdReiniciar = New System.Windows.Forms.Button
        Me.lblNo_Tarea = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.picMenu = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdTerminar = New System.Windows.Forms.Button
        Me.lblCod_Producto = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblNombre_Producto = New System.Windows.Forms.Label
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grdListado = New System.Windows.Forms.DataGrid
        Me.lblUbiDesc = New System.Windows.Forms.Label
        '
        'lblConteo
        '
        Me.lblConteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblConteo.Location = New System.Drawing.Point(216, 16)
        Me.lblConteo.Size = New System.Drawing.Size(88, 16)
        Me.lblConteo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 272)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblUbiDesc)
        Me.TabPage1.Controls.Add(Me.cboUnit)
        Me.TabPage1.Controls.Add(Me.lblUbicacion)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtUbicacion)
        Me.TabPage1.Controls.Add(Me.cmdReiniciar)
        Me.TabPage1.Controls.Add(Me.lblNo_Tarea)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.picMenu)
        Me.TabPage1.Controls.Add(Me.lblTitulo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmdTerminar)
        Me.TabPage1.Controls.Add(Me.lblCod_Producto)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblNombre_Producto)
        Me.TabPage1.Controls.Add(Me.txtCodigoBarras)
        Me.TabPage1.Controls.Add(Me.cmdAceptar)
        Me.TabPage1.Controls.Add(Me.txtCantidad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(232, 246)
        Me.TabPage1.Text = "Tarea"
        '
        'cboUnit
        '
        Me.cboUnit.Location = New System.Drawing.Point(64, 184)
        Me.cboUnit.Size = New System.Drawing.Size(48, 22)
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUbicacion.Location = New System.Drawing.Point(208, 64)
        Me.lblUbicacion.Size = New System.Drawing.Size(8, 16)
        Me.lblUbicacion.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.Text = "Ubicacion:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 160)
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.Text = "Ubicacion:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(112, 160)
        Me.txtUbicacion.Size = New System.Drawing.Size(112, 22)
        Me.txtUbicacion.Text = ""
        '
        'cmdReiniciar
        '
        Me.cmdReiniciar.Location = New System.Drawing.Point(80, 216)
        Me.cmdReiniciar.Size = New System.Drawing.Size(72, 24)
        Me.cmdReiniciar.Text = "Reiniciar"
        '
        'lblNo_Tarea
        '
        Me.lblNo_Tarea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNo_Tarea.Location = New System.Drawing.Point(80, 40)
        Me.lblNo_Tarea.Size = New System.Drawing.Size(136, 16)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(208, 8)
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'picMenu
        '
        Me.picMenu.Image = CType(resources.GetObject("picMenu.Image"), System.Drawing.Image)
        Me.picMenu.Location = New System.Drawing.Point(8, 0)
        Me.picMenu.Size = New System.Drawing.Size(40, 32)
        Me.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(56, 8)
        Me.lblTitulo.Size = New System.Drawing.Size(144, 20)
        Me.lblTitulo.Text = "Conteo de Productos"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.Text = "Conteo:"
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(160, 216)
        Me.cmdTerminar.Size = New System.Drawing.Size(72, 24)
        Me.cmdTerminar.Text = "Finalizar"
        '
        'lblCod_Producto
        '
        Me.lblCod_Producto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCod_Producto.Location = New System.Drawing.Point(80, 88)
        Me.lblCod_Producto.Size = New System.Drawing.Size(136, 16)
        Me.lblCod_Producto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 88)
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.Text = "Producto:"
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(8, 184)
        Me.lblCantidad.Size = New System.Drawing.Size(56, 20)
        Me.lblCantidad.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.Text = "Cod. Barras:"
        '
        'lblNombre_Producto
        '
        Me.lblNombre_Producto.Location = New System.Drawing.Point(8, 112)
        Me.lblNombre_Producto.Size = New System.Drawing.Size(216, 16)
        Me.lblNombre_Producto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(80, 136)
        Me.txtCodigoBarras.Size = New System.Drawing.Size(144, 22)
        Me.txtCodigoBarras.Text = ""
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(0, 216)
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.Text = "Aceptar"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(112, 184)
        Me.txtCantidad.Size = New System.Drawing.Size(112, 22)
        Me.txtCantidad.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdListado)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(232, 246)
        Me.TabPage2.Text = "Detalle"
        '
        'grdListado
        '
        Me.grdListado.Location = New System.Drawing.Point(8, 8)
        Me.grdListado.Size = New System.Drawing.Size(216, 208)
        Me.grdListado.Text = "DataGrid1"
        '
        'lblUbiDesc
        '
        Me.lblUbiDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUbiDesc.Location = New System.Drawing.Point(80, 64)
        Me.lblUbiDesc.Size = New System.Drawing.Size(136, 16)
        Me.lblUbiDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmProductCount
        '
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblConteo)
        Me.Text = "Conteo de Productos"

    End Sub

#End Region

    Dim sLotNumber As String

    Private Sub frmContar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ObtenerProducto()

    End Sub

    Private Sub ObtenerProducto()

        Dim wsCallCount As New Conteos.Conteos
        Dim sServ As New wsCommonServices.wsCommonServices
        Dim sResult As String
        Dim sDatos(1) As Object
        Dim dsData As DataSet

        Try
            lblConteo.Text = ""
            lblCod_Producto.Text = ""
            lblNombre_Producto.Text = ""
            txtCodigoBarras.Text = ""
            txtCantidad.Text = ""
            txtUbicacion.Text = ""

            sResult = wsCallCount.FindProductCountTask(modGlobal.publicUserID)

            If Trim(sResult) = "" Then
                MsgBox("No se encontraron Tareas de Conteo asignadas", MsgBoxStyle.Information, modGlobal.publicProject)
                Me.Close()
                Exit Sub
            Else
                sDatos = Split(sResult, "!|!")
                lblConteo.Text = sDatos(1)
                lblCod_Producto.Text = sDatos(0)
                lblUbicacion.Text = sDatos(2)
                lblUbiDesc.Text = sDatos(3)
                lblNombre_Producto.Text = sDatos(4)
                txtCodigoBarras.Focus()
                lblNo_Tarea.Text = lblConteo.Text
            End If

            'Llenar el Grid de Detalle
            Refrescar_Detalle()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            Me.Close()
        End Try

    End Sub


    Private Sub ContarProducto()
        Dim wsCount As New Conteos.Conteos

        cmdAceptar.Enabled = False

        If txtCodigoBarras.Text.Trim() = "" Then
            MsgBox("Ingrese un Código de Barras válido", MsgBoxStyle.Exclamation, publicProject)
            txtCodigoBarras.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If

        If lblUbicacion.Text.ToUpper <> "RASTREO" Then
            If txtUbicacion.Text.Trim <> Me.lblUbicacion.Text.Trim Then
                MsgBox("Ubicacion ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
                txtUbicacion.Text = ""
                txtUbicacion.Focus()
                cmdAceptar.Enabled = True
                Exit Sub
            End If
        End If

        If txtUbicacion.Text.Trim = "" Then
            MsgBox("Ubicacion ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
            txtUbicacion.Text = ""
            txtUbicacion.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If
        If Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
            txtCantidad.Text = ""
            txtCantidad.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If

        If CDbl(txtCantidad.Text) < 0 Then
            MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
            txtCantidad.Text = ""
            txtCantidad.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If

        Try
            'Validar que la ub
            If lblUbicacion.Text.ToUpper = "RASTREO" Then
                If wsCount.ValidateLocationForCount(lblConteo.Text, lblCod_Producto.Text, txtUbicacion.Text) = 1 Then
                    MsgBox("La ubicacion elegida fue incluida en una Tarea de Conteo.  No puede ser incluida en el rastreo", MsgBoxStyle.Exclamation, publicProject)
                    cmdAceptar.Enabled = True
                    Exit Sub
                End If
            End If

            Call wsCount.ContarProducto(CStr(modGlobal.publicUserID).ToUpper(), _
                                            lblConteo.Text.ToUpper(), txtUbicacion.Text.ToUpper(), _
                                            lblCod_Producto.Text.ToUpper(), CDbl(txtCantidad.Text), sLotNumber, cboUnit.Text)
            cmdAceptar.Enabled = True
            ObtenerProducto()
            Refrescar_Detalle()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            cmdAceptar.Enabled = True
        End Try

    End Sub

    Private Sub TerminarProducto()
        Dim wsCount As New Conteos.Conteos

        cmdAceptar.Enabled = False

        If (MsgBox("Desea Finalizar el Conteo del Producto?", MsgBoxStyle.OKCancel, modGlobal.publicProject) = MsgBoxResult.OK) Then
            Try
                Call wsCount.TerminarProducto(CStr(modGlobal.publicUserID).ToUpper(), _
                                                lblConteo.Text.ToUpper(), lblCod_Producto.Text, lblUbicacion.Text)
                cmdAceptar.Enabled = True
                ObtenerProducto()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

            End Try
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub





    Private Sub txtCodigoBarras_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoBarras.GotFocus
        txtCodigoBarras.SelectAll()
    End Sub


    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        ContarProducto()
    End Sub

    Private Sub cmdTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminar.Click
        TerminarProducto()
    End Sub

    Private Sub txtCodigoBarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoBarras.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObtenerProducto()
    End Sub


    Public Sub Refrescar_Detalle()
        Dim wsCallCount As New Conteos.Conteos
        Dim dsData As DataSet

        If lblConteo.Text.Length > 0 And lblCod_Producto.Text.Length > 0 Then
            dsData = wsCallCount.ConsultarDetalleProducto(CLng(lblConteo.Text), lblCod_Producto.Text, lblUbicacion.Text)
            grdListado.DataSource = dsData.Tables(0)
        End If
        txtCodigoBarras.Focus()

    End Sub

    Private Sub cmdReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReiniciar.Click
        Dim wsCount As New Conteos.Conteos

        If (MsgBox("Desea Reiniciar Conteo de la Ubicacion?", MsgBoxStyle.OKCancel, modGlobal.publicProject) = MsgBoxResult.OK) Then
            Try
                Call wsCount.ReiniciarProducto(lblConteo.Text.ToUpper(), lblCod_Producto.Text.ToUpper(), lblUbicacion.Text)
                cmdAceptar.Enabled = True
                lblCod_Producto.Text = ""
                lblNombre_Producto.Text = ""
                txtCodigoBarras.Text = ""
                txtCantidad.Text = ""
                lblCantidad.Text = "Cantidad:"
                cmdAceptar.Enabled = True
                txtCodigoBarras.Focus()

                'Llenar el Grid de Detalle
                Refrescar_Detalle()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

            End Try
        End If
    End Sub


    Private Sub txtUbicacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUbicacion.TextChanged

    End Sub

    'Private Sub txtUbicacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUbicacion.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtCantidad.Focus()
    '        'MsgBox(lblUbicacion.Text)
    '    End If
    'End Sub

    Private Sub txtUbicacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUbicacion.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCantidad.Focus()
            'MsgBox(lblUbicacion.Text)
        End If

    End Sub



    Private Sub txtUbicacion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUbicacion.GotFocus
        txtUbicacion.SelectAll()
    End Sub



    'Private Sub txtCodigoBarras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoBarras.KeyDown
    '    Dim wsConsultas As New wsCommonServices.wsCommonServices
    '    Dim sCodProducto As String
    '    Dim sDescripcion As String
    '    Dim sUnit As String


    '    If e.KeyCode = Keys.Return Then
    '        Try
    '            'MsgBox(lblUbicacion.Text)
    '            If txtCodigoBarras.Text.Trim() = "" Then
    '                Exit Sub
    '            End If

    '            wsConsultas.ProcessBarcode(txtCodigoBarras.Text.Trim(), sCodProducto, sLotNumber, sDescripcion, "", "", "", "", sUnit)
    '            With cboUnit
    '                .Items.Clear()
    '                .Items.Add(sUnit)
    '                If sUnit.Trim = "CA" Then
    '                    .Items.Add("UN")
    '                End If
    '                .SelectedIndex = 0
    '            End With
    '            If sCodProducto <> sCodProducto Then
    '                MsgBox("Producto Invalido", MsgBoxStyle.Exclamation, publicProject)
    '                txtCodigoBarras.Text = ""
    '                txtCodigoBarras.Focus()
    '            Else
    '                txtUbicacion.Focus()
    '            End If

    '        Catch ex As Exception
    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '            txtCodigoBarras.Text = ""
    '            txtCodigoBarras.Focus()
    '        End Try
    '    End If
    'End Sub

    Private Sub txtCodigoBarras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        Dim wsConsultas As New wsCommonServices.wsCommonServices
        Dim sCodProducto As String
        Dim sDescripcion As String
        Dim sUnit As String


        If e.KeyChar = Chr(13) Then
            Try
                'MsgBox(lblUbicacion.Text)
                If txtCodigoBarras.Text.Trim() = "" Then
                    Exit Sub
                End If

                wsConsultas.ProcessBarcode(txtCodigoBarras.Text.Trim(), sCodProducto, sLotNumber, sDescripcion, "", "", "", "", sUnit, modGlobal.publicCurrentCountry)
                With cboUnit
                    .Items.Clear()
                    .Items.Add(sUnit)
                    If sUnit.Trim = "CA" Then
                        .Items.Add("UN")
                    End If
                    .SelectedIndex = 0
                End With
                If sCodProducto <> sCodProducto Then
                    MsgBox("Producto Invalido", MsgBoxStyle.Exclamation, publicProject)
                    txtCodigoBarras.Text = ""
                    txtCodigoBarras.Focus()
                Else
                    txtUbicacion.Focus()
                End If

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtCodigoBarras.Text = ""
                txtCodigoBarras.Focus()
            End Try
        End If
    End Sub

    'Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
    '    If e.KeyCode = 13 Then
    '        ContarProducto()
    '    End If
    'End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = Chr(13) Then
            ContarProducto()
        End If
    End Sub

    'Private Sub TxtPallet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Me.txtCantidad.Focus()
    '    End If
    'End Sub

    Private Sub TxtPallet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtCantidad.Focus()
        End If
    End Sub
End Class
