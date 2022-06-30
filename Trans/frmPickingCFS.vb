Public Class frmPickingCFS
    Inherits System.Windows.Forms.Form
    Friend WithEvents lblKgxItem As System.Windows.Forms.Label
    Friend WithEvents lblPackagexItem As System.Windows.Forms.Label
    Friend WithEvents lblEstilo As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label

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
    Friend WithEvents cboDetalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents bttnRegister As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFila As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPackages As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPickingCFS))
        Me.lblKgxItem = New System.Windows.Forms.Label
        Me.lblPackagexItem = New System.Windows.Forms.Label
        Me.lblEstilo = New System.Windows.Forms.Label
        Me.lblColor = New System.Windows.Forms.Label
        Me.lblIdentificacion = New System.Windows.Forms.Label
        Me.cboDetalle = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.picMain = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.bttnRegister = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFila = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPackages = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.bttnCancel = New System.Windows.Forms.Button
        '
        'lblKgxItem
        '
        Me.lblKgxItem.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblKgxItem.Location = New System.Drawing.Point(120, 143)
        Me.lblKgxItem.Size = New System.Drawing.Size(112, 16)
        '
        'lblPackagexItem
        '
        Me.lblPackagexItem.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblPackagexItem.Location = New System.Drawing.Point(8, 143)
        Me.lblPackagexItem.Size = New System.Drawing.Size(104, 16)
        '
        'lblEstilo
        '
        Me.lblEstilo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblEstilo.Location = New System.Drawing.Point(8, 127)
        Me.lblEstilo.Size = New System.Drawing.Size(104, 16)
        '
        'lblColor
        '
        Me.lblColor.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblColor.Location = New System.Drawing.Point(120, 127)
        Me.lblColor.Size = New System.Drawing.Size(112, 16)
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.lblIdentificacion.Location = New System.Drawing.Point(8, 111)
        Me.lblIdentificacion.Size = New System.Drawing.Size(224, 16)
        '
        'cboDetalle
        '
        Me.cboDetalle.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.cboDetalle.Location = New System.Drawing.Point(8, 88)
        Me.cboDetalle.Size = New System.Drawing.Size(224, 19)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.Text = "Detalle en Tarima"
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(16, 16)
        Me.picMain.Size = New System.Drawing.Size(32, 32)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(56, 16)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Picking - CFS"
        '
        'bttnRegister
        '
        Me.bttnRegister.Location = New System.Drawing.Point(144, 232)
        Me.bttnRegister.Size = New System.Drawing.Size(72, 24)
        Me.bttnRegister.Text = "Registrar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 168)
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.Text = "Fila"
        '
        'txtFila
        '
        Me.txtFila.Location = New System.Drawing.Point(128, 168)
        Me.txtFila.Size = New System.Drawing.Size(56, 22)
        Me.txtFila.Text = ""
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(128, 192)
        Me.txtCantidad.Size = New System.Drawing.Size(56, 22)
        Me.txtCantidad.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(48, 192)
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.Text = "Cantidad"
        '
        'lblPackages
        '
        Me.lblPackages.Location = New System.Drawing.Point(208, 192)
        Me.lblPackages.Size = New System.Drawing.Size(24, 20)
        Me.lblPackages.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(192, 192)
        Me.Label7.Size = New System.Drawing.Size(16, 20)
        Me.Label7.Text = "/"
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(32, 232)
        Me.bttnCancel.Text = "Cancelar"
        '
        'frmPickingCFS
        '
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.lblPackages)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFila)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnRegister)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDetalle)
        Me.Controls.Add(Me.lblKgxItem)
        Me.Controls.Add(Me.lblPackagexItem)
        Me.Controls.Add(Me.lblEstilo)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblIdentificacion)
        Me.Text = "Picking CFS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Public iPickingTaskNumber As String = ""

    Dim dsDataDetail As DataSet
    Dim iSelectedIndex As Integer = -1
    Dim myArrivalsCFS As New wsArrivalsCFS.wsArrivalsCFS

    Private Sub frmPickingCFS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        searchViajesDetail()

    End Sub

    Sub searchViajesDetail()
        Dim rsInfo As DataSet
        Dim sSQL As String
        Dim wsServ As New wsCommonServices.wsCommonServices

        Dim iDataFound As Boolean = False        

        Try
            Cursor.Current = Cursors.WaitCursor

            Me.cboDetalle.DataSource = Nothing
            Me.dsDataDetail = Nothing

            If iPickingTaskNumber <> "" Then
                dsDataDetail = myArrivalsCFS.getDetailsFromPicking(Me.iPickingTaskNumber)
                Me.cboDetalle.DataSource = dsDataDetail.Tables(0)
                Me.cboDetalle.DisplayMember = "DESCRIPTION"
                Me.cboDetalle.ValueMember = "ID_DETAIL"
            End If

            If dsDataDetail.Tables.Count > 0 Then
                If dsDataDetail.Tables(0).Rows.Count > 0 Then
                    iDataFound = True
                End If
            End If

            If Not iDataFound Then
                Me.Close()
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

            Me.txtCantidad.Text = ""
            'Me.txtFila.Text = ""

            If Me.cboDetalle.SelectedIndex >= 0 Then
                Me.lblPackages.Text = dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("CANTIDAD")
                Me.lblIdentificacion.Text = "Lote/# item/SKU: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("IDENTIFICACION")
                Me.lblColor.Text = "Color: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("COLOR")
                Me.lblEstilo.Text = "Estilo: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("ESTILO")
                Me.lblPackagexItem.Text = "Piezas x Item: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("PIEZAS_X_ITEM")
                Me.lblKgxItem.Text = "Kg x Item: " & dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("KILOS_X_ITEM")
            End If

        Catch ex As Exception
            MsgBox(FormatErrorMessage(ex.Message))
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub cboDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDetalle.SelectedIndexChanged
        detalleSelected()
    End Sub


    Private Sub txtFila_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFila.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCantidad.Focus()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.bttnRegister.Focus()
        End If
    End Sub

    Private Sub bttnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRegister.Click
        Dim iResult As String = ""

        Try
            If IsNumeric(Me.txtFila.Text) Then
                If CDbl(Me.txtFila.Text) <= 0 Then
                    MessageBox.Show("Numero de fila invalido")
                    Return
                End If
            Else
                MessageBox.Show("Numero de fila invalido")
                Return
            End If
            If IsNumeric(Me.txtCantidad.Text) Then
                If CDbl(Me.txtCantidad.Text) <= 0 Then
                    MessageBox.Show("Cantidad invalida")
                    Return
                End If
            Else
                MessageBox.Show("Cantidad invalida")
                Return
            End If

            iResult = Me.myArrivalsCFS.registerLoadDetail(dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("ID_VIAJE"), dsDataDetail.Tables(0).Rows(Me.cboDetalle.SelectedIndex)("ID_DETAIL"), Me.iPickingTaskNumber, Me.txtFila.Text, Me.txtCantidad.Text)
            searchViajesDetail()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub
End Class
