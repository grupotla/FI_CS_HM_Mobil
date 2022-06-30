Public Class frmProductsList
    Inherits System.Windows.Forms.Form
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

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
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtSearchData As System.Windows.Forms.TextBox
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProductsList))
        Me.txtSearchData = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.cmdAccept = New System.Windows.Forms.Button
        '
        'txtSearchData
        '
        Me.txtSearchData.Location = New System.Drawing.Point(88, 40)
        Me.txtSearchData.Size = New System.Drawing.Size(136, 22)
        Me.txtSearchData.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 40)
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.Text = "Buscar:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 0)
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(216, 8)
        Me.picClose.Size = New System.Drawing.Size(16, 16)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(32, 8)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Busqueda de Productos"
        '
        'grdData
        '
        Me.grdData.Location = New System.Drawing.Point(8, 72)
        Me.grdData.Size = New System.Drawing.Size(224, 160)
        Me.grdData.Text = "DataGrid1"
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(64, 240)
        Me.cmdAccept.Size = New System.Drawing.Size(112, 24)
        Me.cmdAccept.Text = "Aceptar"
        '
        'frmProductsList
        '
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSearchData)
        Me.Controls.Add(Me.Label10)
        Me.Text = "Busqueda Productos"

    End Sub

#End Region

    Private Sub SearchProducts()
        Dim xServ As New wsCommonServices.wsCommonServices
        Dim sSQL As String
        Dim dsData As DataSet

        Try
            Cursor.Current = Cursors.WaitCursor
            Dim ts1 As New DataGridTableStyle
            Dim TextCol As New DataGridTextBoxColumn

            ts1.MappingName = "myTable"
            TextCol.MappingName = "Cod_Product"
            TextCol.HeaderText = "Codigo"
            TextCol.Width = 100
            ts1.GridColumnStyles.Add(TextCol)
            TextCol = Nothing

            TextCol = New DataGridTextBoxColumn
            TextCol.MappingName = "Description"
            TextCol.HeaderText = "Descripcion"
            TextCol.Width = 300
            ts1.GridColumnStyles.Add(TextCol)

            grdData.TableStyles.Clear()
            grdData.TableStyles.Add(ts1)

            sSQL = "SELECT Cod_Product, Description " & _
                    " FROM VW_SBO_Products " & _
                    " WHERE Cod_Product LIKE '%" & txtSearchData.Text & "%' " & _
                        " OR Description LIKE '%" & txtSearchData.Text & "%' "
            dsData = xServ.GetDataSet(sSQL)

            grdData.DataSource = dsData.Tables(0)
            Cursor.Current = Cursors.Default
            If dsData.Tables(0).Rows.Count = 0 Then
                MsgBox("No se encontraron Productos de acuerdo al parametro ingresado", MsgBoxStyle.Information, publicProject)
            End If
            txtSearchData.Focus()


        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Exclamation, publicProject)
            txtSearchData.Focus()
        End Try
    End Sub

    Private Sub picClose_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.ParentChanged

    End Sub

    Private Sub picClose_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picClose.MouseDown
        publicReturnCode = ""
        publicReturnDesc = ""
        Me.Close()
    End Sub

    Private Sub frmProductsList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearchData.Focus()
    End Sub

    Private Sub txtSearchData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchData.TextChanged

    End Sub

    Private Sub txtSearchData_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchData.GotFocus
        txtSearchData.SelectAll()
    End Sub

    


    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click

        Try
            publicReturnCode = grdData.Item(grdData.CurrentRowIndex, 0)
            publicReturnDesc = grdData.Item(grdData.CurrentRowIndex, 1)
            Me.Close()
        Catch ex As Exception

        End Try
        

    End Sub

    'Private Sub txtSearchData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchData.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If txtSearchData.Text.Trim.Length > 0 Then

    '            SearchProducts()
    '        End If
    '    End If

    'End Sub

    Private Sub txtSearchData_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchData.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSearchData.Text.Trim.Length > 0 Then

                SearchProducts()
            End If
        End If
    End Sub
End Class
