Public Class frmProductInv
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
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCod_Product As System.Windows.Forms.TextBox
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProductInv))
        Me.txtCod_Product = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblProductDescription = New System.Windows.Forms.Label
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        '
        'txtCod_Product
        '
        Me.txtCod_Product.Location = New System.Drawing.Point(112, 32)
        Me.txtCod_Product.Size = New System.Drawing.Size(120, 22)
        Me.txtCod_Product.Text = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(216, 8)
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(40, 8)
        Me.lblTitulo.Size = New System.Drawing.Size(176, 20)
        Me.lblTitulo.Text = "Inventario por Producto"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.Text = "Cod. Producto:"
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Location = New System.Drawing.Point(16, 80)
        Me.lblProductDescription.Size = New System.Drawing.Size(216, 16)
        '
        'grdData
        '
        Me.grdData.Location = New System.Drawing.Point(8, 104)
        Me.grdData.Size = New System.Drawing.Size(224, 168)
        Me.grdData.Text = "DataGrid1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.Text = "Cod. Barras:"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(112, 56)
        Me.txtBarcode.Size = New System.Drawing.Size(120, 22)
        Me.txtBarcode.Text = ""
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'frmProductInv
        '
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtCod_Product)
        Me.Text = "Inv por Producto"

    End Sub

#End Region


    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub frmProductInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtCod_Product.Focus()

    End Sub

    Private Sub txtCod_Product_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCod_Product.GotFocus
        txtCod_Product.SelectAll()
    End Sub


    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    

    Private Sub txtCod_Product_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod_Product.KeyPress
        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        Dim sSQL As String
        Dim sLotNumber As String
        Dim sProductDescription As String

        If e.KeyChar = Chr(13) Then
            Try
                Dim ts1 As New DataGridTableStyle
                Dim TextCol As New DataGridTextBoxColumn

                ts1.MappingName = "myTable"
                TextCol.MappingName = "Location"
                TextCol.HeaderText = "Ubicacion"
                TextCol.Width = 100
                ts1.GridColumnStyles.Add(TextCol)

                TextCol = New DataGridTextBoxColumn
                TextCol.MappingName = "Quantity"
                TextCol.HeaderText = "Cantidad"
                TextCol.Width = 60
                ts1.GridColumnStyles.Add(TextCol)

                TextCol = New DataGridTextBoxColumn
                TextCol.MappingName = "Unit"
                TextCol.HeaderText = "Unidad"
                TextCol.Width = 60
                ts1.GridColumnStyles.Add(TextCol) '

                TextCol = New DataGridTextBoxColumn
                TextCol.MappingName = "LotNumber"
                TextCol.HeaderText = "Lote"
                TextCol.Width = 60
                ts1.GridColumnStyles.Add(TextCol)
                TextCol = Nothing

                grdData.TableStyles.Clear()
                grdData.TableStyles.Add(ts1)

                wsServ.GetProductData(txtCod_Product.Text, sLotNumber, sProductDescription)
                lblProductDescription.Text = sProductDescription

                sSQL = "SELECT E.Description AS Location, A.Quantity, A.Unit, A.LotNumber " & _
                        " FROM WMS_STOCK_X_LOCATION A, DEF_LOCATIONS E " & _
                        " WHERE Cod_Product = '" & txtCod_Product.Text & "' " & _
                            " AND A.Location = E.Location " & _
                            " AND E.Cod_Warehouse IN (Select Cod_Warehouse FROM DEF_USERS_WAREHOUSES WHERE Cod_User = '" & publicUserID & "')"

                dsData = wsServ.GetDataSet(sSQL)
                If dsData.Tables(0).Rows.Count = 0 Then
                    MsgBox("No se encontro inventario del producto ingresado", MsgBoxStyle.Information, publicProject)
                End If
                grdData.DataSource = dsData.Tables(0)
                txtBarcode.SelectAll()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            End Try

        End If
    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        Dim sSQL As String
        Dim sLotNumber As String
        Dim sUnit As String
        Dim sProductDescription As String
        Dim sConversion As String

        If e.KeyChar = Chr(13) Then
            Try
                Dim ts1 As New DataGridTableStyle
                Dim TextCol As New DataGridTextBoxColumn

                ts1.MappingName = "myTable"
                TextCol.MappingName = "Location"
                TextCol.HeaderText = "Ubicacion"
                TextCol.Width = 100
                ts1.GridColumnStyles.Add(TextCol)

                TextCol = New DataGridTextBoxColumn
                TextCol.MappingName = "Quantity"
                TextCol.HeaderText = "Cantidad"
                TextCol.Width = 60
                ts1.GridColumnStyles.Add(TextCol)

                TextCol = New DataGridTextBoxColumn
                TextCol.MappingName = "Unit"
                TextCol.HeaderText = "Unidad"
                TextCol.Width = 60
                ts1.GridColumnStyles.Add(TextCol) '

                TextCol = New DataGridTextBoxColumn
                TextCol.MappingName = "LotNumber"
                TextCol.HeaderText = "Lote"
                TextCol.Width = 60
                ts1.GridColumnStyles.Add(TextCol)
                TextCol = Nothing

                grdData.TableStyles.Clear()
                grdData.TableStyles.Add(ts1)

                wsServ.ProcessBarcode(txtBarcode.Text, txtCod_Product.Text, "", lblProductDescription.Text, "", "", "", "", "", modGlobal.publicCurrentCountry)

                sSQL = "SELECT E.Description AS Location, A.Quantity, A.Unit, A.LotNumber " & _
                        " FROM WMS_STOCK_X_LOCATION A, DEF_LOCATIONS E " & _
                        " WHERE Cod_Product = '" & txtCod_Product.Text & "' " & _
                            " AND A.Location = E.Location " & _
                            " AND E.Cod_Warehouse IN (Select Cod_Warehouse FROM DEF_USERS_WAREHOUSES WHERE Cod_User = '" & publicUserID & "')"

                dsData = wsServ.GetDataSet(sSQL)
                If dsData.Tables(0).Rows.Count = 0 Then
                    MsgBox("No se encontro inventario del producto ingresado", MsgBoxStyle.Information, publicProject)
                End If
                grdData.DataSource = dsData.Tables(0)
                txtBarcode.SelectAll()

            Catch ex As Exception
                txtCod_Product.Text = ""
                lblProductDescription.Text = ""

                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            End Try

        End If

    End Sub
End Class
