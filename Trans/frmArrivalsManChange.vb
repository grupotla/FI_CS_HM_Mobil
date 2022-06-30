Public Class frmArrivalsManChange
    Inherits System.Windows.Forms.Form
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblActual As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBultos As System.Windows.Forms.TextBox
    Friend WithEvents bttnAccept As System.Windows.Forms.Button
    Friend WithEvents bttnCancel As System.Windows.Forms.Button

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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArrivalsManChange))
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblActual = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBultos = New System.Windows.Forms.TextBox
        Me.bttnAccept = New System.Windows.Forms.Button
        Me.bttnCancel = New System.Windows.Forms.Button
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(8, 8)
        Me.picMINGC.Size = New System.Drawing.Size(32, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(56, 16)
        Me.lblTitle.Size = New System.Drawing.Size(168, 20)
        Me.lblTitle.Text = "Ingreso por Manifiesto"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 104)
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.Text = "Bultos Actuales"
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescription.Location = New System.Drawing.Point(16, 56)
        Me.lblDescription.Size = New System.Drawing.Size(208, 32)
        '
        'lblActual
        '
        Me.lblActual.Location = New System.Drawing.Point(120, 104)
        Me.lblActual.Size = New System.Drawing.Size(80, 20)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 136)
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.Text = "Bultos Reales"
        '
        'txtBultos
        '
        Me.txtBultos.Location = New System.Drawing.Point(112, 136)
        Me.txtBultos.Size = New System.Drawing.Size(96, 22)
        Me.txtBultos.Text = ""
        '
        'bttnAccept
        '
        Me.bttnAccept.Location = New System.Drawing.Point(72, 200)
        Me.bttnAccept.Size = New System.Drawing.Size(72, 24)
        Me.bttnAccept.Text = "Actualizar"
        '
        'bttnCancel
        '
        Me.bttnCancel.Location = New System.Drawing.Point(152, 200)
        Me.bttnCancel.Size = New System.Drawing.Size(72, 24)
        Me.bttnCancel.Text = "Cancelar"
        '
        'frmArrivalsManChange
        '
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.bttnAccept)
        Me.Controls.Add(Me.txtBultos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblActual)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picMINGC)
        Me.Controls.Add(Me.lblTitle)
        Me.Text = "frmArrivalsManChange"

    End Sub

#End Region

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmArrivalsManChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblDescription.Text = sSelectedDescription

        Dim wsServ As New wsCommonServices.wsCommonServices
        Dim iData As System.Data.DataSet

        Dim iBultos As String = ""
        Dim sSql As String = ""
        sSql = "select PACKAGES from DEF_COMMODITIES WHERE COD_PRODUCT = '" & sSelectedProduct & "'"

        iData = wsServ.GetDataSet(sSql)

        If iData.Tables.Count > 0 Then
            If iData.Tables(0).Rows.Count > 0 Then
                iBultos = CStr(iData.Tables(0).Rows(0).Item(0))
            End If
        End If

        If iBultos = "" Then
            MessageBox.Show("No se encontro el BL Especificado")
            Me.Close()
            Exit Sub
        End If

        Me.lblActual.Text = iBultos

        Me.txtBultos.Focus()
    End Sub

    Private Sub bttnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAccept.Click
        Try

        
            Dim wsArrival As New wsManifestArrival.wsManifestArrival
            Dim iResult As String = ""

            If Me.txtBultos.Text = "" Then
                MessageBox.Show("Numero de bultos invalido")
                Me.txtBultos.Focus()
            End If

            If Not IsNumeric(Me.txtBultos.Text) Then
                MessageBox.Show("Numero de bultos invalido")
                Me.txtBultos.Focus()
            End If

            If CDbl(Me.txtBultos.Text) = 0 Then
                MessageBox.Show("Numero de bultos invalido")
                Me.txtBultos.Focus()
            End If

            iResult = wsArrival.updatePackages(publicUserID, sSelectedProduct, sSelectedProduct.Split("||")(0), Me.txtBultos.Text)

            If iResult.Substring(0, 3) <> "[0]" Then
                MessageBox.Show(iResult)
            Else
                MessageBox.Show("Bl Actualizado")
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
