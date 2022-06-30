Public Class frmLabels
    Inherits System.Windows.Forms.Form
    Friend WithEvents txtDA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    'Datatable que se usa para almacenar si la impresora es local o remota
    Dim dtDatos As New DataTable
    Dim iBl_short As String
    Dim iCompany As String = ""
    Dim strDALabel As String = ""
    Dim iNoResa As String = ""

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.txtDA.Focus()
        GetPrinterPorts()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbBL As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtConsignee As System.Windows.Forms.TextBox
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents txtAgent As System.Windows.Forms.TextBox
    Friend WithEvents txtDateEnter As System.Windows.Forms.TextBox
    Friend WithEvents txtNPackages As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPackages As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetData As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPAD As System.Windows.Forms.TextBox
    Friend WithEvents txtBL As System.Windows.Forms.TextBox
    Friend WithEvents cboPrinter As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLabels))
        Me.txtDA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmbBL = New System.Windows.Forms.ComboBox
        Me.cmdGetData = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtConsignee = New System.Windows.Forms.TextBox
        Me.txtContainer = New System.Windows.Forms.TextBox
        Me.txtAgent = New System.Windows.Forms.TextBox
        Me.txtDateEnter = New System.Windows.Forms.TextBox
        Me.txtNPackages = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPackages = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPAD = New System.Windows.Forms.TextBox
        Me.txtBL = New System.Windows.Forms.TextBox
        Me.cboPrinter = New System.Windows.Forms.ComboBox
        '
        'txtDA
        '
        Me.txtDA.Location = New System.Drawing.Point(120, 20)
        Me.txtDA.Size = New System.Drawing.Size(112, 22)
        Me.txtDA.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 24)
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.Text = "DA:"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(152, 232)
        Me.cmdPrint.Size = New System.Drawing.Size(72, 24)
        Me.cmdPrint.Text = "Imprimir"
        '
        'cmbBL
        '
        Me.cmbBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular)
        Me.cmbBL.Location = New System.Drawing.Point(56, 43)
        Me.cmbBL.Size = New System.Drawing.Size(176, 21)
        '
        'cmdGetData
        '
        Me.cmdGetData.Location = New System.Drawing.Point(112, 72)
        Me.cmdGetData.Size = New System.Drawing.Size(116, 24)
        Me.cmdGetData.Text = "Obtener Datos"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.Text = "BL:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.Text = "Consignatario:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 128)
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.Text = "Contenedor:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 152)
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.Text = "Agente:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 176)
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.Text = "Fecha Ingreso:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 200)
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.Text = "Bultos:"
        '
        'txtConsignee
        '
        Me.txtConsignee.Location = New System.Drawing.Point(96, 100)
        Me.txtConsignee.Size = New System.Drawing.Size(136, 22)
        Me.txtConsignee.Text = ""
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(96, 124)
        Me.txtContainer.Size = New System.Drawing.Size(136, 22)
        Me.txtContainer.Text = ""
        '
        'txtAgent
        '
        Me.txtAgent.Location = New System.Drawing.Point(96, 148)
        Me.txtAgent.Size = New System.Drawing.Size(136, 22)
        Me.txtAgent.Text = ""
        '
        'txtDateEnter
        '
        Me.txtDateEnter.Location = New System.Drawing.Point(96, 172)
        Me.txtDateEnter.Size = New System.Drawing.Size(136, 22)
        Me.txtDateEnter.Text = ""
        '
        'txtNPackages
        '
        Me.txtNPackages.Location = New System.Drawing.Point(96, 196)
        Me.txtNPackages.Size = New System.Drawing.Size(56, 22)
        Me.txtNPackages.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(152, 200)
        Me.Label8.Size = New System.Drawing.Size(8, 16)
        Me.Label8.Text = "/"
        '
        'txtPackages
        '
        Me.txtPackages.Location = New System.Drawing.Point(160, 196)
        Me.txtPackages.Size = New System.Drawing.Size(56, 22)
        Me.txtPackages.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 24)
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.Text = "PAD:"
        '
        'txtPAD
        '
        Me.txtPAD.Location = New System.Drawing.Point(56, 20)
        Me.txtPAD.Size = New System.Drawing.Size(32, 22)
        Me.txtPAD.Text = ""
        '
        'txtBL
        '
        Me.txtBL.Location = New System.Drawing.Point(56, 44)
        Me.txtBL.Size = New System.Drawing.Size(176, 22)
        Me.txtBL.Text = ""
        Me.txtBL.Visible = False
        '
        'cboPrinter
        '
        Me.cboPrinter.Location = New System.Drawing.Point(16, 235)
        Me.cboPrinter.Size = New System.Drawing.Size(128, 22)
        '
        'frmLabels
        '
        Me.Controls.Add(Me.cboPrinter)
        Me.Controls.Add(Me.txtBL)
        Me.Controls.Add(Me.txtDA)
        Me.Controls.Add(Me.txtPAD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
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
        Me.Controls.Add(Me.cmdGetData)
        Me.Controls.Add(Me.cmbBL)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label1)
        Me.Text = "Impresion de Etiquetas"

    End Sub

#End Region

    Public Sub GetCommodities()
        Dim xCommon As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        Try
            Cursor.Current = Cursors.WaitCursor



            dsData = xCommon.GetCommoditiesFromDA(Me.txtPAD.Text + "-" + txtDA.Text, modGlobal.publicCurrentCountry)

            If dsData.Tables(0).Rows.Count > 0 Then
                cmbBL.DataSource = dsData.Tables(0)
                cmbBL.DisplayMember = "info"
                cmbBL.ValueMember = "bl"
                cmbBL.SelectedIndex = 0
            Else
                Cursor.Current = Cursors.Default
                MsgBox("No se encontró documento")
                Me.cmbBL.Visible = False
                Me.txtBL.Visible = True
                Me.txtBL.Focus()

                Me.cmdGetData.Enabled = False


            End If
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("No se encontró documento " & ex.Message)
            Me.cmbBL.Visible = False
            Me.txtBL.Visible = True
            Me.txtBL.Focus()

            Me.cmdGetData.Enabled = False

        Finally
            Cursor.Current = Cursors.Default

        End Try


    End Sub



    Private Sub cmdGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetData.Click
        Dim xCommon As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet


        Dim strDA As String = txtDA.Text
        Dim strBL As String = cmbBL.SelectedValue


        Try

            dsData = xCommon.GetCommodityData(Me.txtPAD.Text & "-" & strDA, strBL, modGlobal.publicCurrentCountry)
            Cursor.Current = Cursors.WaitCursor

            If dsData.Tables(0).Rows.Count > 0 Then
                Me.txtConsignee.Text = dsData.Tables(0).Rows(0)("consignee")
                Me.txtContainer.Text = dsData.Tables(0).Rows(0)("contenedor")
                Me.txtAgent.Text = dsData.Tables(0).Rows(0)("shipper")
                Me.txtDateEnter.Text = dsData.Tables(0).Rows(0)("date")
                Me.txtNPackages.Text = dsData.Tables(0).Rows(0)("packages")
                Me.txtPackages.Text = dsData.Tables(0).Rows(0)("packages")
                Me.iBl_short = dsData.Tables(0).Rows(0)("bl_short")
                Me.iCompany = dsData.Tables(0).Rows(0)("company_name")
                iNoResa = dsData.Tables(0).Rows(0)("NO_RESA")
            Else
                Cursor.Current = Cursors.Default
                MsgBox("No se encontraron datos")

            End If

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox("No se encontraron datos")

        Finally
            Cursor.Current = Cursors.Default

        End Try


    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim wsCommon As New wsCommonServices.wsCommonServices
        Dim strBl As String
        Dim strPrinterPort As String = Me.cboPrinter.SelectedValue

        If (Me.cmdGetData.Enabled) Then
            strBl = cmbBL.SelectedValue
        Else
            strBl = Me.txtBL.Text
        End If

        Dim strResult As String

        'strResult = wsCommon.PrintLabelCommodity(Me.txtPAD.Text, Me.txtDA.Text, strBl, Me.txtConsignee.Text, Me.txtContainer.Text, Me.txtAgent.Text, Me.txtDateEnter.Text, Me.txtNPackages.Text, Me.txtPackages.Text, strPrinterPort)
        Try
            'PrintLocalLabel(Me.txtPAD.Text, Me.txtDA.Text, strBl, Me.txtConsignee.Text, Me.txtContainer.Text, Me.txtAgent.Text, Me.txtDateEnter.Text, Me.txtNPackages.Text, Me.txtPackages.Text)
            If dtDatos.Rows(Me.cboPrinter.SelectedIndex)(3) = "LOCAL" Then
                strResult = PrintLocalManifestLabel(Me.txtPAD.Text, Me.txtDA.Text, strBl, Me.txtConsignee.Text, Me.txtContainer.Text, Me.txtAgent.Text, Me.txtDateEnter.Text, Me.txtNPackages.Text, Me.txtPackages.Text, iBl_short, iCompany, strDALabel, iNoResa)
                'strResult = PrintLocalCFSLabel("IDV12345", "IDDet54321", "Deta", "Cliente", "Fabrica", "Consignatario", "24/10/2008", "2", "3")
            Else
                strResult = wsCommon.PrintLabelCommodity(Me.txtPAD.Text, Me.txtDA.Text, strBl, Me.txtConsignee.Text, Me.txtContainer.Text, Me.txtAgent.Text, Me.txtDateEnter.Text, Me.txtNPackages.Text, Me.txtPackages.Text, strPrinterPort, iBl_short, iCompany, strDALabel, iNoResa)
            End If



        Catch ex As Exception
            MsgBox("Error al imprimir: " & ex.ToString)
        End Try


        MsgBox(strResult)


    End Sub


    Private Sub GetPrinterPorts()
        Dim xCommon As New wsCommonServices.wsCommonServices
        Dim dsData As DataSet
        Dim strPAD As String = ""
        Dim UserID As String = publicUserID
        'xCommon.GetDomain("PAD", "AIMAR", strPAD, "", "", "", "") 2018-01-10
        xCommon.GetDomainNew("PAD", publicCurrentCountry, strPAD, UserID, "", "", "")        
        Me.txtPAD.Text = strPAD

        Try
            dsData = xCommon.GetPrinterPorts(publicUserID)
            dtDatos = dsData.Tables(0)

            If dsData.Tables(0).Rows.Count > 0 Then

                'cboPrinter.DataSource = dsData.Tables(0)
                cboPrinter.DataSource = dtDatos
                cboPrinter.DisplayMember = "MEANING"
                'cboPrinter.DisplayMember = "MPC03"
                cboPrinter.ValueMember = "MPC01"
                cboPrinter.SelectedIndex = 0



            Else
                Cursor.Current = Cursors.Default
                MsgBox("No se encontraron impresoras")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub txtDA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDA.KeyPress
        Try

            If e.KeyChar = Chr(13) Then
                Dim xCommon As New wsCommonServices.wsCommonServices
                Dim strPAD As String = ""
                Dim UserID As String = publicUserID
                Dim txtPAD As String = Me.txtPAD.Text
                'xCommon.GetDomain("PAD", "AIMAR", strPAD, "", "", "", "") 2018-01-10
                xCommon.GetDomainNew("PAD", publicCurrentCountry, strPAD, UserID, txtPAD, "", "")
                If Me.txtPAD.Text = strPAD Then
                    Me.cmbBL.Visible = True
                    Me.txtBL.Visible = False
                    Me.cmdGetData.Enabled = True
                    GetCommodities()
                    Me.txtConsignee.Text = ""
                    Me.txtContainer.Text = ""
                    Me.txtAgent.Text = ""
                    Me.txtDateEnter.Text = ""
                    Me.txtNPackages.Text = ""
                    Me.txtPackages.Text = ""
                Else
                    Me.cmbBL.Visible = False
                    Me.txtBL.Visible = True
                    Me.cmdGetData.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub frmLabels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If modGlobal.publicCurrentCountry.ToLower = "ni" Then
            Me.strDALabel = "DTI"
        Else
            Me.strDALabel = "D.A."
        End If
    End Sub


End Class


