Public Class frmArrivalsCombo
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTargetBar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblLotNumber As System.Windows.Forms.Label
    Friend WithEvents lblExpDate As System.Windows.Forms.Label
    Friend WithEvents lblLocationDescription As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCodProduct As System.Windows.Forms.Label
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalsCombo))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.lblLocationDescription = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtTargetBar = New System.Windows.Forms.TextBox
        Me.lblProductDescription = New System.Windows.Forms.Label
        Me.lblLotNumber = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.lblExpDate = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCodProduct = New System.Windows.Forms.Label
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(64, 8)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Ingreso Ofertas"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(11, 184)
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.Text = "Cantidad:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(104, 184)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Size = New System.Drawing.Size(128, 22)
        Me.txtQty.Text = ""
        '
        'lblLocationDescription
        '
        Me.lblLocationDescription.Location = New System.Drawing.Point(11, 240)
        Me.lblLocationDescription.Size = New System.Drawing.Size(220, 16)
        Me.lblLocationDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(11, 208)
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.Text = "Destino:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(158, 264)
        Me.btnOK.Text = "Aceptar"
        '
        'txtTargetBar
        '
        Me.txtTargetBar.Location = New System.Drawing.Point(104, 208)
        Me.txtTargetBar.MaxLength = 20
        Me.txtTargetBar.Size = New System.Drawing.Size(128, 22)
        Me.txtTargetBar.Text = ""
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblProductDescription.Location = New System.Drawing.Point(12, 80)
        Me.lblProductDescription.Size = New System.Drawing.Size(220, 28)
        '
        'lblLotNumber
        '
        Me.lblLotNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblLotNumber.Location = New System.Drawing.Point(112, 136)
        Me.lblLotNumber.Size = New System.Drawing.Size(120, 16)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.Text = "Codigo de Barras"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(8, 56)
        Me.txtBarcode.Size = New System.Drawing.Size(224, 22)
        Me.txtBarcode.Text = ""
        '
        'lblExpDate
        '
        Me.lblExpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblExpDate.Location = New System.Drawing.Point(112, 160)
        Me.lblExpDate.Size = New System.Drawing.Size(120, 18)
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.Location = New System.Drawing.Point(11, 136)
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.Text = "Lote:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(11, 160)
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.Text = "Vence en:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(11, 112)
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.Text = "SKU:"
        '
        'lblCodProduct
        '
        Me.lblCodProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblCodProduct.Location = New System.Drawing.Point(112, 112)
        Me.lblCodProduct.Size = New System.Drawing.Size(120, 16)
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(224, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'frmArrivalsCombo
        '
        Me.ClientSize = New System.Drawing.Size(242, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCodProduct)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblExpDate)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblLotNumber)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.txtTargetBar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblLocationDescription)
        Me.Text = "Ingreso por Producción"

    End Sub

#End Region

    Private nArrivals_Task As Long
    Private sBarcode As String
    Private nConversionFactor As String
    Private sERP_Document As String
    Private sCompany As String
    Private sUnit As String
    Dim Graphics As Graphics
    Dim Pen As New Pen(Color.Black)
    Dim bIsLoading As Boolean = False

    Private Sub ClearFields()
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim nQTY_Task As Double
        Dim nQTY_Pending As Double
        Dim nQTY As Double
        Dim sResult As String

        Try
            lblLotNumber.Text = ""
            lblCodProduct.Text = ""
            txtQty.Text = ""
            lblProductDescription.Text = ""
            lblExpDate.Text = ""
            lblLotNumber.Text = ""
            txtBarcode.Text = ""
            txtBarcode.Focus()

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

            If txtBarcode.Text.Trim.Length = 0 Then
                MsgBox("Producto invalido", MsgBoxStyle.Exclamation, publicProject)
                txtBarcode.Text = ""
                txtBarcode.Focus()
                Exit Sub
            End If


            If Not IsNumeric(txtQty.Text) Then
                MsgBox("Cantidad ingresada invalida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Text = ""
                txtQty.Focus()
                Exit Sub
            End If
            If CDbl(txtQty.Text) <= 0 Then
                MsgBox("Cantidad ingresada invalida", MsgBoxStyle.Exclamation, publicProject)
                txtQty.Text = ""
                txtQty.Focus()
                Exit Sub
            End If
            If txtTargetBar.Text.Trim.Length = 0 Then
                MsgBox("Ubicacion invalida", MsgBoxStyle.Exclamation, publicProject)
                txtTargetBar.Text = ""
                txtTargetBar.Focus()
                Exit Sub
            End If

            Cursor.Current = Cursors.WaitCursor
            sResult = xArrivals.ArrivalCombo(modGlobal.publicUserID, lblCodProduct.Text, lblLotNumber.Text, _
                                            CDbl(txtQty.Text), txtTargetBar.Text, sCompany, sUnit, lblExpDate.Text)


            Cursor.Current = Cursors.Default
            MsgBox("Transaccion ejecutada exitosamente", MsgBoxStyle.Information, publicProject)

            ClearFields()
            txtBarcode.Focus()

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
            bIsLoading = False
            txtBarcode.Focus()

        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(modGlobal.FormatErrorMessage(ex.Message), MsgBoxStyle.Critical)
            bIsLoading = False
            Cursor.Current = Cursors.Default
            Me.Close()


        End Try
    End Sub

    Private Sub picClose_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        UpdateTask()

    End Sub

    



    

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        UpdateTask()
    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        Dim xCS As New wsCommonServices.wsCommonServices
        txtQty.SelectAll()

    End Sub


    

    Private Sub Label5_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.ParentChanged

    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub Label2_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblProductDescription_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProductDescription.ParentChanged

    End Sub

    Private Sub txtTargetBar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTargetBar.TextChanged

    End Sub



    Private Sub picClose_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.ParentChanged

    End Sub

    Private Sub picClose_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        Me.Close()
    End Sub

    'Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
    '    Dim xArrivals As New wsArrivals.wsArrivals

    '    If e.KeyCode = Keys.Enter Then
    '        If IsNumeric(txtQty.Text) Then
    '            If CDbl(txtQty.Text) > 0 Then
    '                'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboCompany.SelectedValue)
    '                txtTargetBar.Focus()
    '            Else
    '                txtQty.Text = ""
    '                MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
    '            End If
    '        Else
    '            txtQty.Text = ""
    '            MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
    '        End If
    '        txtTargetBar.Focus()
    '    End If

    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim xArrivals As New wsArrivals.wsArrivals

        If e.KeyChar = Chr(13) Then
            If IsNumeric(txtQty.Text) Then
                If CDbl(txtQty.Text) > 0 Then
                    'lblLocationTarget.Text = xArrivals.AssistedPutaway(lblCod_Product.Text, CDbl(txtQty.Text), cboCom.SelectedValue, cboCompany.SelectedValue)
                    txtTargetBar.Focus()
                Else
                    txtQty.Text = ""
                    MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
                End If
            Else
                txtQty.Text = ""
                MsgBox("Cantidad Ingresada Invalida", MsgBoxStyle.Exclamation, publicProject)
            End If
            txtTargetBar.Focus()
        End If

    End Sub

    'Private Sub txtTarget_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTargetBar.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Try
    '            Dim xsarrivals As New wsArrivals.wsArrivals
    '            Cursor.Current = Cursors.WaitCursor
    '            lblLocationDescription.Text = xsarrivals.GetLocationDescription (txtTargetBar.Text)
    '            Cursor.Current = Cursors.Default
    '            UpdateTask()
    '        Catch ex As Exception
    '            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '            Cursor.Current = Cursors.Default
    '            txtTargetBar.Text = ""
    '            txtTargetBar.Focus()
    '        End Try
    '    End If
    'End Sub

    Private Sub txtTargetBar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTargetBar.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Dim xsarrivals As New wsArrivals.wsArrivals
                Cursor.Current = Cursors.WaitCursor
                lblLocationDescription.Text = xsarrivals.GetLocationDescriptionNew(txtTargetBar.Text, publicUserID, "05")
                Cursor.Current = Cursors.Default
                UpdateTask()
            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
                Cursor.Current = Cursors.Default
                txtTargetBar.Text = ""
                txtTargetBar.Focus()
            End Try
        End If
    End Sub

    'Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
    '    Try
    '        Dim xServ As New wsCommonServices.wsCommonServices
    '        If e.KeyCode = Keys.Enter Then
    '            Cursor.Current = Cursors.WaitCursor
    '            Call xServ.ProcessBarcode(txtBarcode.Text, lblCodProduct.Text, lblLotNumber.Text, lblProductDescription.Text, txtQty.Text, "", lblExpDate.Text, sCompany, sUnit)
    '            Cursor.Current = Cursors.Default
    '            txtQty.Focus()
    '        End If
    '    Catch ex As Exception
    '        Cursor.Current = Cursors.Default
    '        lblCodProduct.Text = ""
    '        lblLotNumber.Text = ""
    '        lblProductDescription.Text = ""
    '        sCompany = ""
    '        sUnit = ""
    '        mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
    '        txtBarcode.Text = ""
    '        txtBarcode.Focus()
    '    End Try

    'End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Try
            Dim xServ As New wsCommonServices.wsCommonServices
            If e.KeyChar = Chr(13) Then
                Cursor.Current = Cursors.WaitCursor
                Call xServ.ProcessBarcode(txtBarcode.Text, lblCodProduct.Text, lblLotNumber.Text, lblProductDescription.Text, txtQty.Text, "", lblExpDate.Text, sCompany, sUnit, modGlobal.publicCurrentCountry)
                Cursor.Current = Cursors.Default
                txtQty.Focus()
            End If
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            lblCodProduct.Text = ""
            lblLotNumber.Text = ""
            lblProductDescription.Text = ""
            sCompany = ""
            sUnit = ""
            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            txtBarcode.Text = ""
            txtBarcode.Focus()
        End Try

    End Sub
End Class
