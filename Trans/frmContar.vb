Public Class frmContar
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
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocationDescription As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContar))
        Me.lblConteo = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.lblUnit = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdReiniciar = New System.Windows.Forms.Button
        Me.lblNo_Tarea = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.picMenu = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblUbicacion = New System.Windows.Forms.Label
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
        Me.lblLocationDescription = New System.Windows.Forms.Label
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
        Me.TabPage1.Controls.Add(Me.lblLocationDescription)
        Me.TabPage1.Controls.Add(Me.cboUnit)
        Me.TabPage1.Controls.Add(Me.lblUnit)
        Me.TabPage1.Controls.Add(Me.lblLotNumber)
        Me.TabPage1.Controls.Add(Me.txtLocation)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmdReiniciar)
        Me.TabPage1.Controls.Add(Me.lblNo_Tarea)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.picMenu)
        Me.TabPage1.Controls.Add(Me.lblTitulo)
        Me.TabPage1.Controls.Add(Me.lblUbicacion)
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
        Me.cboUnit.Location = New System.Drawing.Point(72, 184)
        Me.cboUnit.Size = New System.Drawing.Size(48, 22)
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(120, 156)
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Location = New System.Drawing.Point(8, 156)
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(80, 64)
        Me.txtLocation.Size = New System.Drawing.Size(144, 22)
        Me.txtLocation.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.Text = "Ubicacion:"
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
        Me.lblNo_Tarea.Location = New System.Drawing.Point(176, 8)
        Me.lblNo_Tarea.Size = New System.Drawing.Size(24, 16)
        Me.lblNo_Tarea.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.lblTitulo.Size = New System.Drawing.Size(120, 20)
        Me.lblTitulo.Text = "Inventario Físico"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUbicacion.Location = New System.Drawing.Point(208, 40)
        Me.lblUbicacion.Size = New System.Drawing.Size(16, 16)
        Me.lblUbicacion.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 38)
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.Text = "Ubicacion:"
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(160, 216)
        Me.cmdTerminar.Size = New System.Drawing.Size(72, 24)
        Me.cmdTerminar.Text = "Finalizar"
        '
        'lblCod_Producto
        '
        Me.lblCod_Producto.Location = New System.Drawing.Point(80, 118)
        Me.lblCod_Producto.Size = New System.Drawing.Size(144, 16)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 120)
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.Text = "Producto:"
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(8, 184)
        Me.lblCantidad.Size = New System.Drawing.Size(64, 20)
        Me.lblCantidad.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.Text = "Cod. Barras:"
        '
        'lblNombre_Producto
        '
        Me.lblNombre_Producto.Location = New System.Drawing.Point(8, 136)
        Me.lblNombre_Producto.Size = New System.Drawing.Size(216, 16)
        Me.lblNombre_Producto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Location = New System.Drawing.Point(80, 88)
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
        Me.txtCantidad.Location = New System.Drawing.Point(120, 184)
        Me.txtCantidad.Size = New System.Drawing.Size(104, 22)
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
        'lblLocationDescription
        '
        Me.lblLocationDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationDescription.Location = New System.Drawing.Point(80, 40)
        Me.lblLocationDescription.Size = New System.Drawing.Size(136, 16)
        Me.lblLocationDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmContar
        '
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblConteo)

    End Sub

#End Region


    Private Sub frmContar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObtenerUbicacion()

    End Sub

    Private Sub ObtenerUbicacion()

        Dim wsCallCount As New Conteos.Conteos
        Dim sResult As String
        Dim sDatos(1) As Object
        Dim dsData As DataSet

        Try
            lblConteo.Text = ""
            lblCod_Producto.Text = ""
            lblNombre_Producto.Text = ""
            lblUbicacion.Text = ""
            txtCodigoBarras.Text = ""
            txtCantidad.Text = ""
            txtLocation.Text = ""
            lblLocationDescription.Text = ""
            lblUnit.Text = ""
            lblLotNumber.Text = ""
            lblCantidad.Text = "Cantidad:"

            sResult = wsCallCount.BuscarUbicacionContar(modGlobal.publicUserID)

            If Trim(sResult) = "|" Then
                MsgBox("No se encontraron Tareas de Conteo asignadas", MsgBoxStyle.Information, modGlobal.publicProject)
                Me.Close()
                Exit Sub
            Else
                sDatos = Split(sResult, "|")
                lblConteo.Text = sDatos(1)
                lblUbicacion.Text = sDatos(0)
                lblLocationDescription.Text = sDatos(2)
                txtLocation.Focus()
                lblNo_Tarea.Text = lblConteo.Text
            End If

            'Llenar el Grid de Detalle
            Refrescar_Detalle()

        Catch ex As Exception
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            Me.Close()
        End Try

    End Sub


    Private Sub ContarUbicacion()
        Dim wsCount As New Conteos.Conteos
        Dim append As Boolean

        cmdAceptar.Enabled = False
        append = True

        If txtLocation.Text <> lblUbicacion.Text Then
            MsgBox("Ubicación inválida", MsgBoxStyle.Exclamation, publicProject)
            txtLocation.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If

        If txtCodigoBarras.Text.Trim() = "" Then
            MsgBox("Ingrese un Código de Barras válido", MsgBoxStyle.Exclamation, publicProject)
            txtCodigoBarras.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If

        If Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Cantidad ingresada inválida", MsgBoxStyle.Exclamation, publicProject)
            txtCantidad.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If

        If CDbl(txtCantidad.Text) <= 0 Then
            MsgBox("Cantidad Ingresada debe ser Mayor que Cero", MsgBoxStyle.Exclamation, publicProject)
            txtCantidad.Focus()
            cmdAceptar.Enabled = True
            Exit Sub
        End If

        If (MsgBox("Desea Confirmar la Ejecucion del Conteo?", MsgBoxStyle.OKCancel, modGlobal.publicProject) = MsgBoxResult.OK) Then
            Try

                Call wsCount.ContarUbicacion(CStr(modGlobal.publicUserID).ToUpper(), _
                                                lblConteo.Text.ToUpper(), lblUbicacion.Text.ToUpper(), _
                                                lblCod_Producto.Text.ToUpper(), CDbl(txtCantidad.Text), cboUnit.Text, lblLotNumber.Text)
                cmdAceptar.Enabled = True
                lblCod_Producto.Text = ""
                lblNombre_Producto.Text = ""
                txtLocation.Text = ""
                lblUnit.Text = ""
                lblLotNumber.Text = ""
                txtCodigoBarras.Text = ""
                txtCantidad.Text = ""
                lblCantidad.Text = "Cantidad:"
                cmdAceptar.Enabled = True

                'Llenar el Grid de Detalle
                Refrescar_Detalle()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                cmdAceptar.Enabled = True
            End Try
        Else
            cmdAceptar.Enabled = True
        End If

    End Sub

    Private Sub TerminarProducto()
        Dim wsCount As New Conteos.Conteos

        cmdAceptar.Enabled = False

        If (MsgBox("Desea Terminar el Conteo de la Ubicacion?", MsgBoxStyle.OKCancel, modGlobal.publicProject) = MsgBoxResult.OK) Then
            Try
                Call wsCount.TerminarUbicacion(CStr(modGlobal.publicUserID).ToUpper(), _
                                                lblConteo.Text.ToUpper(), lblUbicacion.Text.ToUpper())
                cmdAceptar.Enabled = True
                ObtenerUbicacion()

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


    


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        ContarUbicacion()
    End Sub

    Private Sub cmdTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminar.Click
        TerminarProducto()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObtenerUbicacion()
    End Sub


    Public Sub Refrescar_Detalle()
        Dim wsCallCount As New Conteos.Conteos
        Dim dsData As DataSet

        If lblConteo.Text.Length > 0 And lblUbicacion.Text.Length > 0 Then
            dsData = wsCallCount.ConsultarDetalleConteo(CLng(lblConteo.Text), lblUbicacion.Text)
            grdListado.DataSource = dsData.Tables(0)
        End If
        txtLocation.Focus()

    End Sub

    Private Sub cmdReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReiniciar.Click
        Dim wsCount As New Conteos.Conteos

        If (MsgBox("Desea Reiniciar Conteo de la Ubicacion?", MsgBoxStyle.OKCancel, modGlobal.publicProject) = MsgBoxResult.OK) Then
            Try
                Call wsCount.ReiniciarUbicacion(lblConteo.Text.ToUpper(), lblUbicacion.Text.ToUpper())
                cmdAceptar.Enabled = True
                lblCod_Producto.Text = ""
                lblNombre_Producto.Text = ""
                txtLocation.Text = ""
                txtCodigoBarras.Text = ""
                txtCantidad.Text = ""
                lblCantidad.Text = "Cantidad:"
                cmdAceptar.Enabled = True
                txtLocation.Focus()

                'Llenar el Grid de Detalle
                Refrescar_Detalle()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

            End Try
        End If
    End Sub


    


    Private Sub TabPage1_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.EnabledChanged

    End Sub

    Private Sub txtCodigoBarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoBarras.TextChanged

    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub


    'Private Sub txtCodigoBarras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoBarras.KeyDown
    '    Dim wsConsultas As New wsCommonServices.wsCommonServices
    '    Dim sUnit As String

    '    If e.KeyCode = Keys.Return Then
    '        Try
    '            If txtCodigoBarras.Text.Trim() = "" Then
    '                Exit Sub
    '            End If
    '            Cursor.Current = Cursors.WaitCursor
    '            wsConsultas.ProcessBarcode2(txtCodigoBarras.Text.Trim(), lblCod_Producto.Text, lblLotNumber.Text, lblNombre_Producto.Text, sUnit)
    '            With cboUnit
    '                .Items.Clear()
    '                .Items.Add(sUnit)
    '                If sUnit.Trim = "CA" Then
    '                    .Items.Add("UN")
    '                End If
    '                .SelectedIndex = 0
    '            End With

    '            lblCantidad.Text = "Cantidad:"
    '            Cursor.Current = Cursors.Default
    '            txtCantidad.Focus()
    '            If lblNombre_Producto.Text = "" Then
    '                MsgBox("El Producto no existe verifique por favor", vbInformation + vbOKOnly, "Producto")
    '                txtCodigoBarras.Text = ""
    '            End If

    '        Catch ex As Exception
    '            Cursor.Current = Cursors.Default
    '            lblCod_Producto.Text = ""
    '            lblLotNumber.Text = ""
    '            lblNombre_Producto.Text = ""
    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '            txtCodigoBarras.Focus()
    '        End Try
    '    End If
    'End Sub

    Private Sub txtCodigoBarras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        Dim wsConsultas As New wsCommonServices.wsCommonServices
        Dim sUnit As String

        If e.KeyChar = Chr(13) Then
            Try
                If txtCodigoBarras.Text.Trim() = "" Then
                    Exit Sub
                End If
                Cursor.Current = Cursors.WaitCursor
                wsConsultas.ProcessBarcode2(txtCodigoBarras.Text.Trim(), lblCod_Producto.Text, lblLotNumber.Text, lblNombre_Producto.Text, sUnit, modGlobal.publicCurrentCountry)
                With cboUnit
                    .Items.Clear()
                    .Items.Add(sUnit)
                    If sUnit.Trim = "CA" Then
                        .Items.Add("UN")
                    End If
                    .SelectedIndex = 0
                End With

                lblCantidad.Text = "Cantidad:"
                Cursor.Current = Cursors.Default
                txtCantidad.Focus()
                If lblNombre_Producto.Text = "" Then
                    MsgBox("El Producto no existe verifique por favor", vbInformation + vbOKOnly, "Producto")
                    txtCodigoBarras.Text = ""
                End If

            Catch ex As Exception
                Cursor.Current = Cursors.Default
                lblCod_Producto.Text = ""
                lblLotNumber.Text = ""
                lblNombre_Producto.Text = ""
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                txtCodigoBarras.Focus()
            End Try
        End If
    End Sub

    'Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
    '    If e.KeyCode = 13 Then
    '        ContarUbicacion()
    '    End If
    'End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = Chr(13) Then
            ContarUbicacion()
        End If
    End Sub

    'Private Sub txtLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLocation.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txtCodigoBarras.Focus()
    '    End If
    'End Sub

    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCodigoBarras.Focus()
        End If
    End Sub
End Class
