Public Class frmMainMenu
    Inherits System.Windows.Forms.Form
    Friend WithEvents tabTasks As System.Windows.Forms.TabPage
    Friend WithEvents tabTrans As System.Windows.Forms.TabPage
    Friend WithEvents tabInquiries As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

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
    Friend WithEvents picPickingTasks As System.Windows.Forms.PictureBox
    Friend WithEvents cmdRelocationTasks As System.Windows.Forms.Button
    Friend WithEvents picRelocationTasks As System.Windows.Forms.PictureBox
    Friend WithEvents picCountTasks As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCountTasks As System.Windows.Forms.Button
    Friend WithEvents cmdPickingTasks As System.Windows.Forms.Button
    Friend WithEvents picMGOOI As System.Windows.Forms.PictureBox
    Friend WithEvents picMINGC As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdLocationInv As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents UpdateTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefresh As System.Windows.Forms.MenuItem
    Friend WithEvents cmdProductInv As System.Windows.Forms.Button
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdGeneral As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdTraslates As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdReturnInvoice As System.Windows.Forms.Button
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents picCancel As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Otros As System.Windows.Forms.TabPage
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdNonDelivery As System.Windows.Forms.Button
    Friend WithEvents cmdNonDelivery2 As System.Windows.Forms.Button
    Friend WithEvents cmdCheck As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents cmdArrivalManifest As System.Windows.Forms.Button
    Friend WithEvents cmdArrivalsCFS As System.Windows.Forms.Button
    Friend WithEvents cmdLabels As System.Windows.Forms.Button
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents bttnLabelsCFS As System.Windows.Forms.Button
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMnMain As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMnTareas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMnIngresos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMnDevoluciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMnConsultas As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMainMenu))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabTasks = New System.Windows.Forms.TabPage
        Me.picCancel = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.cmdGeneral = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.cmdCheck = New System.Windows.Forms.Button
        Me.picPickingTasks = New System.Windows.Forms.PictureBox
        Me.cmdRelocationTasks = New System.Windows.Forms.Button
        Me.picRelocationTasks = New System.Windows.Forms.PictureBox
        Me.picCountTasks = New System.Windows.Forms.PictureBox
        Me.cmdCountTasks = New System.Windows.Forms.Button
        Me.cmdPickingTasks = New System.Windows.Forms.Button
        Me.tabTrans = New System.Windows.Forms.TabPage
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.cmdTraslates = New System.Windows.Forms.Button
        Me.picMGOOI = New System.Windows.Forms.PictureBox
        Me.picMINGC = New System.Windows.Forms.PictureBox
        Me.cmdArrivalsCFS = New System.Windows.Forms.Button
        Me.cmdArrivalManifest = New System.Windows.Forms.Button
        Me.Otros = New System.Windows.Forms.TabPage
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.cmdNonDelivery2 = New System.Windows.Forms.Button
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.cmdNonDelivery = New System.Windows.Forms.Button
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.cmdReturn = New System.Windows.Forms.Button
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.cmdReturnInvoice = New System.Windows.Forms.Button
        Me.tabInquiries = New System.Windows.Forms.TabPage
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        Me.bttnLabelsCFS = New System.Windows.Forms.Button
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.cmdLabels = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.cmdLocationInv = New System.Windows.Forms.Button
        Me.cmdProductInv = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItemMnMain = New System.Windows.Forms.MenuItem
        Me.MenuItemMnTareas = New System.Windows.Forms.MenuItem
        Me.MenuItemMnIngresos = New System.Windows.Forms.MenuItem
        Me.MenuItemMnDevoluciones = New System.Windows.Forms.MenuItem
        Me.MenuItemMnConsultas = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.mnuInit = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuRefresh = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.UpdateTimer = New System.Windows.Forms.Timer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblVersion = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabTasks)
        Me.TabControl1.Controls.Add(Me.tabTrans)
        Me.TabControl1.Controls.Add(Me.Otros)
        Me.TabControl1.Controls.Add(Me.tabInquiries)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 288)
        '
        'tabTasks
        '
        Me.tabTasks.Controls.Add(Me.picCancel)
        Me.tabTasks.Controls.Add(Me.PictureBox7)
        Me.tabTasks.Controls.Add(Me.cmdGeneral)
        Me.tabTasks.Controls.Add(Me.PictureBox2)
        Me.tabTasks.Controls.Add(Me.cmdCheck)
        Me.tabTasks.Controls.Add(Me.picPickingTasks)
        Me.tabTasks.Controls.Add(Me.cmdRelocationTasks)
        Me.tabTasks.Controls.Add(Me.picRelocationTasks)
        Me.tabTasks.Controls.Add(Me.picCountTasks)
        Me.tabTasks.Controls.Add(Me.cmdCountTasks)
        Me.tabTasks.Controls.Add(Me.cmdPickingTasks)
        Me.tabTasks.Location = New System.Drawing.Point(4, 4)
        Me.tabTasks.Size = New System.Drawing.Size(332, 262)
        Me.tabTasks.Text = "Tareas"
        '
        'picCancel
        '
        Me.picCancel.Image = CType(resources.GetObject("picCancel.Image"), System.Drawing.Image)
        Me.picCancel.Location = New System.Drawing.Point(240, 16)
        Me.picCancel.Size = New System.Drawing.Size(20, 20)
        Me.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(16, 200)
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdGeneral
        '
        Me.cmdGeneral.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdGeneral.Location = New System.Drawing.Point(56, 206)
        Me.cmdGeneral.Size = New System.Drawing.Size(156, 26)
        Me.cmdGeneral.Text = "Generales"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 72)
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdCheck
        '
        Me.cmdCheck.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCheck.Location = New System.Drawing.Point(56, 142)
        Me.cmdCheck.Size = New System.Drawing.Size(156, 26)
        Me.cmdCheck.Text = "Chequeo"
        '
        'picPickingTasks
        '
        Me.picPickingTasks.Image = CType(resources.GetObject("picPickingTasks.Image"), System.Drawing.Image)
        Me.picPickingTasks.Location = New System.Drawing.Point(16, 144)
        Me.picPickingTasks.Size = New System.Drawing.Size(24, 24)
        Me.picPickingTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdRelocationTasks
        '
        Me.cmdRelocationTasks.Enabled = False
        Me.cmdRelocationTasks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdRelocationTasks.Location = New System.Drawing.Point(56, 110)
        Me.cmdRelocationTasks.Size = New System.Drawing.Size(156, 26)
        Me.cmdRelocationTasks.Text = "Reubicaciones"
        '
        'picRelocationTasks
        '
        Me.picRelocationTasks.Image = CType(resources.GetObject("picRelocationTasks.Image"), System.Drawing.Image)
        Me.picRelocationTasks.Location = New System.Drawing.Point(16, 104)
        Me.picRelocationTasks.Size = New System.Drawing.Size(32, 32)
        Me.picRelocationTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'picCountTasks
        '
        Me.picCountTasks.Image = CType(resources.GetObject("picCountTasks.Image"), System.Drawing.Image)
        Me.picCountTasks.Location = New System.Drawing.Point(16, 168)
        Me.picCountTasks.Size = New System.Drawing.Size(32, 32)
        Me.picCountTasks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdCountTasks
        '
        Me.cmdCountTasks.Enabled = False
        Me.cmdCountTasks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdCountTasks.Location = New System.Drawing.Point(56, 174)
        Me.cmdCountTasks.Size = New System.Drawing.Size(156, 26)
        Me.cmdCountTasks.Text = "Conteo Fisico"
        '
        'cmdPickingTasks
        '
        Me.cmdPickingTasks.Enabled = False
        Me.cmdPickingTasks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdPickingTasks.Location = New System.Drawing.Point(56, 78)
        Me.cmdPickingTasks.Size = New System.Drawing.Size(156, 26)
        Me.cmdPickingTasks.Text = "Picking"
        '
        'tabTrans
        '
        Me.tabTrans.Controls.Add(Me.PictureBox8)
        Me.tabTrans.Controls.Add(Me.cmdTraslates)
        Me.tabTrans.Controls.Add(Me.picMGOOI)
        Me.tabTrans.Controls.Add(Me.picMINGC)
        Me.tabTrans.Controls.Add(Me.cmdArrivalsCFS)
        Me.tabTrans.Controls.Add(Me.cmdArrivalManifest)
        Me.tabTrans.Location = New System.Drawing.Point(4, 4)
        Me.tabTrans.Size = New System.Drawing.Size(332, 246)
        Me.tabTrans.Text = "Ingresos"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(16, 152)
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdTraslates
        '
        Me.cmdTraslates.Enabled = False
        Me.cmdTraslates.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdTraslates.Location = New System.Drawing.Point(56, 160)
        Me.cmdTraslates.Size = New System.Drawing.Size(156, 26)
        Me.cmdTraslates.Text = "Ingreso Traslados"
        '
        'picMGOOI
        '
        Me.picMGOOI.Image = CType(resources.GetObject("picMGOOI.Image"), System.Drawing.Image)
        Me.picMGOOI.Location = New System.Drawing.Point(16, 120)
        Me.picMGOOI.Size = New System.Drawing.Size(32, 32)
        Me.picMGOOI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'picMINGC
        '
        Me.picMINGC.Image = CType(resources.GetObject("picMINGC.Image"), System.Drawing.Image)
        Me.picMINGC.Location = New System.Drawing.Point(16, 88)
        Me.picMINGC.Size = New System.Drawing.Size(32, 32)
        Me.picMINGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'cmdArrivalsCFS
        '
        Me.cmdArrivalsCFS.Enabled = False
        Me.cmdArrivalsCFS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdArrivalsCFS.Location = New System.Drawing.Point(56, 96)
        Me.cmdArrivalsCFS.Size = New System.Drawing.Size(156, 26)
        Me.cmdArrivalsCFS.Text = "Ingreso CFS"
        '
        'cmdArrivalManifest
        '
        Me.cmdArrivalManifest.Enabled = False
        Me.cmdArrivalManifest.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdArrivalManifest.Location = New System.Drawing.Point(56, 128)
        Me.cmdArrivalManifest.Size = New System.Drawing.Size(156, 26)
        Me.cmdArrivalManifest.Text = "Ingreso Manifiesto"
        '
        'Otros
        '
        Me.Otros.Controls.Add(Me.PictureBox12)
        Me.Otros.Controls.Add(Me.Button2)
        Me.Otros.Controls.Add(Me.PictureBox10)
        Me.Otros.Controls.Add(Me.cmdNonDelivery2)
        Me.Otros.Controls.Add(Me.PictureBox11)
        Me.Otros.Controls.Add(Me.cmdNonDelivery)
        Me.Otros.Controls.Add(Me.PictureBox6)
        Me.Otros.Controls.Add(Me.cmdReturn)
        Me.Otros.Controls.Add(Me.PictureBox5)
        Me.Otros.Controls.Add(Me.cmdReturnInvoice)
        Me.Otros.Location = New System.Drawing.Point(4, 4)
        Me.Otros.Size = New System.Drawing.Size(332, 246)
        Me.Otros.Text = "Devoluciones"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(18, 200)
        Me.PictureBox12.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(58, 208)
        Me.Button2.Size = New System.Drawing.Size(156, 26)
        Me.Button2.Text = "Devolucion - Ruta"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(16, 168)
        Me.PictureBox10.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdNonDelivery2
        '
        Me.cmdNonDelivery2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdNonDelivery2.Location = New System.Drawing.Point(56, 174)
        Me.cmdNonDelivery2.Size = New System.Drawing.Size(156, 26)
        Me.cmdNonDelivery2.Text = "Flete Falso - Anulación"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(16, 136)
        Me.PictureBox11.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdNonDelivery
        '
        Me.cmdNonDelivery.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdNonDelivery.Location = New System.Drawing.Point(56, 142)
        Me.cmdNonDelivery.Size = New System.Drawing.Size(156, 26)
        Me.cmdNonDelivery.Text = "Flete Falso"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(18, 104)
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdReturn
        '
        Me.cmdReturn.Enabled = False
        Me.cmdReturn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdReturn.Location = New System.Drawing.Point(56, 110)
        Me.cmdReturn.Size = New System.Drawing.Size(156, 26)
        Me.cmdReturn.Text = "Cambio Directo"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(18, 72)
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdReturnInvoice
        '
        Me.cmdReturnInvoice.Enabled = False
        Me.cmdReturnInvoice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdReturnInvoice.Location = New System.Drawing.Point(56, 78)
        Me.cmdReturnInvoice.Size = New System.Drawing.Size(156, 26)
        Me.cmdReturnInvoice.Text = "Devoluciones"
        '
        'tabInquiries
        '
        Me.tabInquiries.Controls.Add(Me.PictureBox13)
        Me.tabInquiries.Controls.Add(Me.bttnLabelsCFS)
        Me.tabInquiries.Controls.Add(Me.PictureBox9)
        Me.tabInquiries.Controls.Add(Me.cmdLabels)
        Me.tabInquiries.Controls.Add(Me.PictureBox3)
        Me.tabInquiries.Controls.Add(Me.PictureBox4)
        Me.tabInquiries.Controls.Add(Me.cmdLocationInv)
        Me.tabInquiries.Controls.Add(Me.cmdProductInv)
        Me.tabInquiries.Location = New System.Drawing.Point(4, 4)
        Me.tabInquiries.Size = New System.Drawing.Size(332, 246)
        Me.tabInquiries.Text = "Consultas"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(24, 176)
        Me.PictureBox13.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'bttnLabelsCFS
        '
        Me.bttnLabelsCFS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.bttnLabelsCFS.Location = New System.Drawing.Point(56, 176)
        Me.bttnLabelsCFS.Size = New System.Drawing.Size(156, 26)
        Me.bttnLabelsCFS.Text = "Etiquetas CFS"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(24, 144)
        Me.PictureBox9.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'cmdLabels
        '
        Me.cmdLabels.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdLabels.Location = New System.Drawing.Point(56, 144)
        Me.cmdLabels.Size = New System.Drawing.Size(156, 26)
        Me.cmdLabels.Text = "Etiquetas"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 72)
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(16, 104)
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'cmdLocationInv
        '
        Me.cmdLocationInv.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdLocationInv.Location = New System.Drawing.Point(56, 110)
        Me.cmdLocationInv.Size = New System.Drawing.Size(156, 26)
        Me.cmdLocationInv.Text = "Ubicacion"
        '
        'cmdProductInv
        '
        Me.cmdProductInv.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdProductInv.Location = New System.Drawing.Point(56, 78)
        Me.cmdProductInv.Size = New System.Drawing.Size(156, 26)
        Me.cmdProductInv.Text = "Producto"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItemMnMain)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.MenuItems.Add(Me.mnuRefresh)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem11)
        Me.MenuItem1.MenuItems.Add(Me.mnuExit)
        Me.MenuItem1.Text = "eWMS Mobile"
        '
        'MenuItemMnMain
        '
        Me.MenuItemMnMain.MenuItems.Add(Me.MenuItemMnTareas)
        Me.MenuItemMnMain.MenuItems.Add(Me.MenuItemMnIngresos)
        Me.MenuItemMnMain.MenuItems.Add(Me.MenuItemMnDevoluciones)
        Me.MenuItemMnMain.MenuItems.Add(Me.MenuItemMnConsultas)
        Me.MenuItemMnMain.Text = "Menu"
        '
        'MenuItemMnTareas
        '
        Me.MenuItemMnTareas.Text = "Mis Tareas"
        '
        'MenuItemMnIngresos
        '
        Me.MenuItemMnIngresos.Text = "Ingresos"
        '
        'MenuItemMnDevoluciones
        '
        Me.MenuItemMnDevoluciones.Text = "Devoluciones"
        '
        'MenuItemMnConsultas
        '
        Me.MenuItemMnConsultas.Text = "Consultas"
        '
        'MenuItem7
        '
        Me.MenuItem7.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem7.MenuItems.Add(Me.mnuInit)
        Me.MenuItem7.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem7.MenuItems.Add(Me.MenuItem10)
        Me.MenuItem7.Text = "Operaciones"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "-"
        '
        'mnuInit
        '
        Me.mnuInit.Text = "Inicializacion"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Text = "Picking CFS"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "-"
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Text = "Refrescar"
        '
        'MenuItem11
        '
        Me.MenuItem11.Text = "-"
        '
        'mnuExit
        '
        Me.mnuExit.Text = "Salir"
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Enabled = True
        Me.UpdateTimer.Interval = 30000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 0)
        Me.PictureBox1.Size = New System.Drawing.Size(64, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.Location = New System.Drawing.Point(80, 17)
        Me.lblVersion.Size = New System.Drawing.Size(128, 16)
        Me.lblVersion.Text = "Ver 201207A"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(80, 0)
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.Text = "AIMAR"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.Location = New System.Drawing.Point(8, 28)
        Me.lblUser.Size = New System.Drawing.Size(224, 16)
        Me.lblUser.Text = "ADMIN"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(8, 48)
        Me.lblTitle.Size = New System.Drawing.Size(224, 24)
        Me.lblTitle.Text = "Mis Tareas"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        '
        'frmMainMenu
        '
        Me.ClientSize = New System.Drawing.Size(340, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.MainMenu1
        Me.Text = "eWMS Mobile - Menu Principal"

    End Sub

#End Region

    Private Sub CheckSecurity()

        Dim xLogin As New wsLogin.wsLogin

        Try
            cmdPickingTasks.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MPICK") = "1")
            cmdRelocationTasks.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MREUBI") = "1")
            cmdCheck.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MCHECK") = "1")
            cmdCountTasks.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MCOUNT") = "1")
            cmdGeneral.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MGENTASKS") = "1")
            cmdArrivalsCFS.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MARRIVCFS") = "1")
            cmdArrivalManifest.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MARRIVAL") = "1")
            cmdTraslates.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MTRANSFER") = "1")
            cmdReturnInvoice.Enabled = False
            cmdReturn.Enabled = False
            cmdNonDelivery.Enabled = False
            cmdNonDelivery2.Enabled = False
            Button2.Enabled = False
            cmdProductInv.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MCPROD") = "1")
            cmdLocationInv.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MCLOC") = "1")
            cmdLabels.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MLABEL") = "1")
            bttnLabelsCFS.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MLABELCFS") = "1")


            mnuInit.Enabled = CBool(xLogin.IsUserInRole(publicUserID, "MINIT") = "1")
            
        Catch ex As Exception

            mSGeRRORS(ex.Message) 'MsgBox(FormatErrorMessage(ex.Message), MsgBoxStyle.Critical, publicProject)

        End Try

    End Sub

    Private Sub RefreshTasks()
        Dim xServ As New wsCommonServices.wsCommonServices
        Dim nPicking As Long
        Dim nRelocation As Long
        Dim nReplenishment As Long
        Dim nCounts As Long
        Dim nGeneral As Long

        Try
            Call xServ.GetAssignedTasks(publicUserID, nPicking, nRelocation, nReplenishment, nCounts, nGeneral)
            cmdPickingTasks.Text = "Picking - " & CStr(nPicking)
            cmdRelocationTasks.Text = "Reubicacion - " & CStr(nRelocation)
            cmdCountTasks.Text = "Conteos - " & CStr(nCounts)
            cmdGeneral.Text = "Generales - " & CStr(nGeneral)

        Catch ex As Exception
            cmdPickingTasks.Text = "Picking - ?"
            cmdRelocationTasks.Text = "Reubicacion - ?"
            cmdCountTasks.Text = "Conteos - ?"
        End Try

    End Sub


    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xFrm As New frmLogin
        Dim xLogin As New wsLogin.wsLogin

        'Dim xFrm1 As New frmSplash
        'xFrm1.ShowDialog()
        'xFrm1.Dispose()
        'xFrm1 = Nothing
        xFrm.ShowDialog()

        lblVersion.Text = "Ver. " & publicMobileVersion & " " & modGlobal.publicCurrentCountry.ToUpper

        If publicUserID = Nothing Then
            Application.Exit()
            Exit Sub
        End If
        If publicUserID.Trim.Length = 0 Then
            Application.Exit()
            Exit Sub
        End If
        xFrm.Dispose()
        xFrm = Nothing
        publicUserName = xLogin.GetUserName(publicUserID)
        lblUser.Text = publicUserID & " - " & publicUserName
        CheckSecurity()
        RefreshTasks()

    End Sub


    Private Sub cmdPickingTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickingTasks.Click

        Dim xFrm As New frmPicking
        xFrm.ShowDialog()
        xFrm = Nothing
        RefreshTasks()
    End Sub


    Private Sub picCancel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCancel.MouseDown
        Application.Exit()
    End Sub


    Private Sub cmdRelocationTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRelocationTasks.Click
        Dim xFrm As New frmRelocation
        xFrm.ShowDialog()
        xFrm = Nothing

    End Sub


    Private Sub cmdRelocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim xFrm As New frmRelocationDisc
        xFrm.ShowDialog()
        xFrm = Nothing

    End Sub



    Private Sub cmdProductInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProductInv.Click
        Dim xFrm As New frmProductInv
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub cmdLocationInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocationInv.Click
        Dim xfrm As New frmLocationInv
        xfrm.ShowDialog()
        xfrm = Nothing
    End Sub

    Private Sub cmdArrivals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArrivalsCFS.Click
        Dim xFrm As New frmArrivalsCFS
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub


    Private Sub cmdCountTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCountTasks.Click
        Dim xCount As New Conteos.Conteos
        Dim nLocation As Long
        Dim nProd As Long

        Call xCount.GetAssignedTasks(publicUserID, nLocation, nProd)
        If nProd > 0 Then
            Dim xFrm As New frmProductCount
            xFrm.ShowDialog()
            xFrm = Nothing

        Else
            If nLocation > 0 Then
                Dim xFrm2 As New frmContar
                xFrm2.ShowDialog()
                xFrm2 = Nothing

            Else
                MsgBox("No tiene tareas de Conteo Asignadas", MsgBoxStyle.Information, publicProject)
            End If
        End If


    End Sub

    Private Sub picCancel_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCancel.ParentChanged

    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuInit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInit.Click
        Dim xfrm As New frmIni
        xfrm.ShowDialog()
        xfrm = Nothing

    End Sub

    Private Sub mnuInvByLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xfrm As New frmLocationInv
        xfrm.ShowDialog()
        xfrm = Nothing
    End Sub

    Private Sub mnuInvByProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmProductInv
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub


    Private Sub UpdateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateTimer.Tick

        RefreshTasks()

    End Sub

    Private Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
        RefreshTasks()
    End Sub

    Private Sub mnuTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub mnuPickingTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        cmdPickingTasks_Click(sender, e)

    End Sub

    Private Sub mnuRelocationTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdRelocation_Click(sender, e)
    End Sub


    Private Sub mnuCountTasks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdCountTasks_Click(sender, e)
    End Sub

    Private Sub mnuArrivals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdArrivals_Click(sender, e)
    End Sub

    Private Sub mnuReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmArrivalReturn
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub



    Private Sub mnuFixPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmFixPurchase
        xFrm.ShowDialog()
        xFrm.Dispose()
    End Sub

    Private Sub mnuReturnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmArrivalsManifest
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub
    Private Sub cmdGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGeneral.Click
        Dim xFrm As New frmGeneralTasks
        xFrm.ShowDialog()
        xFrm = Nothing

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub



    Private Sub mnuArrivalonPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmArrivalsManifest
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub


    Private Sub cmdOfertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmArrivalsCombo
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub mnuArrivalsOfertas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmArrivalsCombo
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub



    Private Sub cmdReturnInvoice_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturnInvoice.Click
        Dim xFrm As New frmArrivalReturnHAME2
        publicReturnCode = "14"
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub cmdReturn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click
        Dim xFrm As New frmArrivalReturnHAME2
        publicReturnCode = "15"
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub cmdNonDeliver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNonDelivery.Click
        Dim xFrm As New frmArrivalReturnHAME
        publicReturnCode = "16"
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub


    Private Sub mnuReturnFlete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmArrivalReturnHAME
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub




    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                lblTitle.Text = "Mis Tareas"
            Case 1
                lblTitle.Text = "Ingresos"
            Case 2
                lblTitle.Text = "Devoluciones"
            Case 3
                lblTitle.Text = "Consultas"
        End Select
    End Sub

    Private Sub cmdTraslates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTraslates.Click
        Dim xFrm As New frmArrivalTransfer1
        xFrm.ShowDialog()
        xFrm.Dispose()
        xFrm = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim xFrm As New frmArrivalReturnRoute
        xFrm.ShowDialog()
        xFrm.Dispose()
        xFrm = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNonDelivery2.Click
        Dim xFrm As New frmArrivalReturnHAME
        publicReturnCode = "17"
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        Dim xFrm As New frmCheckPicking
        xFrm.ShowDialog()
        xFrm.Dispose()
        xFrm = Nothing
    End Sub


    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub tabTasks_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabTasks.EnabledChanged

    End Sub

    Private Sub cmdArrivalManifest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArrivalManifest.Click
        Dim xFrm As New frmArrivalsManifest
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub


    Private Sub cmdLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLabels.Click
        Dim xFrm As New frmLabels
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xFrm As New frmIni
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub bttnLabelsCFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnLabelsCFS.Click
        Dim xFrm As New frmLabelsCFS
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Dim xFrm As New frmStartPickingCFS
        xFrm.ShowDialog()
        xFrm = Nothing
    End Sub



    Private Sub MenuItemMnConsultas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemMnConsultas.Click
        Me.TabControl1.SelectedIndex = 3
    End Sub

    Private Sub MenuItemMnDevoluciones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemMnDevoluciones.Click
        Me.TabControl1.SelectedIndex = 2
    End Sub

    Private Sub MenuItemMnIngresos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemMnIngresos.Click
        Me.TabControl1.SelectedIndex = 1
    End Sub

    Private Sub MenuItemMnTareas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItemMnTareas.Click
        Me.TabControl1.SelectedIndex = 0
    End Sub
End Class
