Public Class frmArrivalsCombo
    Inherits System.Windows.Forms.Form
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cmdOk = New System.Windows.Forms.Button
        '
        'DataGrid1
        '
        Me.DataGrid1.Location = New System.Drawing.Point(0, 40)
        Me.DataGrid1.Size = New System.Drawing.Size(240, 192)
        Me.DataGrid1.Text = "DataGrid1"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(152, 240)
        Me.cmdOk.Size = New System.Drawing.Size(80, 24)
        Me.cmdOk.Text = "Ok"
        '
        'frmArrivalsCombo
        '
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.DataGrid1)
        Me.Text = "Products in Combo"

    End Sub

#End Region

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Close()

    End Sub
End Class
