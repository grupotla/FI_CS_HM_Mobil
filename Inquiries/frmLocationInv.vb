Public Class frmLocationInv

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
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuCopy As System.Windows.Forms.MenuItem
    Friend WithEvents lblLocationDescription As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLocationInv))
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuCopy = New System.Windows.Forms.MenuItem
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.lblLocationDescription = New System.Windows.Forms.Label
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(112, 40)
        Me.txtLocation.Size = New System.Drawing.Size(120, 22)
        Me.txtLocation.Text = ""
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
        Me.lblTitulo.Text = "Inventario por Ubicacion"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.Text = "Ubicacion:"
        '
        'grdData
        '
        Me.grdData.ContextMenu = Me.ContextMenu1
        Me.grdData.Enabled = False
        Me.grdData.Location = New System.Drawing.Point(8, 96)
        Me.grdData.Size = New System.Drawing.Size(224, 176)
        Me.grdData.Text = "DataGrid1"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.Add(Me.mnuCopy)
        '
        'mnuCopy
        '
        Me.mnuCopy.Text = "Copiar Codigo de Producto"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'lblLocationDescription
        '
        Me.lblLocationDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationDescription.Location = New System.Drawing.Point(16, 72)
        Me.lblLocationDescription.Size = New System.Drawing.Size(208, 16)
        Me.lblLocationDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmLocationInv
        '
        Me.Controls.Add(Me.lblLocationDescription)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtLocation)
        Me.Text = "Inv por Ubicacion"

    End Sub

#End Region


    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub frmProductInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtLocation.Focus()

    End Sub

    Private Sub txtLocation_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLocation.GotFocus
        txtLocation.SelectAll()
    End Sub


    Private Sub grdData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdData.Click

    End Sub


    Private Sub txtLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocation.KeyPress
        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim xArrivals As New wsArrivals.wsArrivals
        Dim dsData As DataSet
        Dim sSQL As String
        Dim sLotNumber As String
        Dim sProductDescription As String

        If e.KeyChar = Chr(13) Then
            Try
                lblLocationDescription.Text = xArrivals.GetLocationDescriptionNew(txtLocation.Text, publicUserID, "12")

                Dim ts1 As New DataGridTableStyle
                Dim TextCol As New DataGridTextBoxColumn

                'ts1.MappingName = "myTable"
                'TextCol.MappingName = "Cod_Product"
                'TextCol.HeaderText = "Codigo"
                'TextCol.Width = 60
                'ts1.GridColumnStyles.Add(TextCol)
                'TextCol = New DataGridTextBoxColumn
                'TextCol.MappingName = "Quantity"
                'TextCol.HeaderText = "Cant U."
                'TextCol.Width = 60
                'ts1.GridColumnStyles.Add(TextCol)
                'TextCol = New DataGridTextBoxColumn
                'TextCol.MappingName = "Unit"
                'TextCol.HeaderText = "Unidad"
                'TextCol.Width = 60
                'ts1.GridColumnStyles.Add(TextCol)
                'TextCol = New DataGridTextBoxColumn
                'TextCol.MappingName = "LotNumber"
                'TextCol.HeaderText = "Lote"
                'TextCol.Width = 60
                'ts1.GridColumnStyles.Add(TextCol)
                'TextCol = New DataGridTextBoxColumn
                'TextCol.MappingName = "Descripcion"
                'TextCol.HeaderText = "Descripcion"
                'TextCol.Width = 300
                'ts1.GridColumnStyles.Add(TextCol)
                'TextCol = Nothing

                'grdData.TableStyles.Clear()
                'grdData.TableStyles.Add(ts1)

                sSQL = "SELECT " & _
                        "ifnull(C.BL, SL.COD_PRODUCT) AS BL, " & _
                        "SL.LOTNUMBER AS DA, " & _
                        "SL.QUANTITY AS CANT, " & _
                        "C.DESCRIPTION AS COMM, " & _
                        "L.DESCRIPTION AS UBIC " & _
                        "FROM WMS_STOCK_X_LOCATION SL LEFT JOIN DEF_COMMODITIES C ON C.COD_PRODUCT=SL.COD_PRODUCT,  " & _
                        "DEF_LOCATIONS L " & _
                        "WHERE L.LOCATION=SL.LOCATION AND " & _
                        "SL.LOCATION = '" & Me.txtLocation.Text & "' "


                dsData = wsServ.GetDataSet(sSQL)
                If dsData.Tables(0).Rows.Count = 0 Then
                    grdData.Enabled = False
                    MsgBox("No se encontro inventario en la ubicacion ingresada", MsgBoxStyle.Information, publicProject)
                Else
                    grdData.Enabled = True
                End If

                grdData.DataSource = dsData.Tables(0)
                txtLocation.SelectAll()

            Catch ex As Exception
                mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)
            End Try

        End If

    End Sub
End Class
