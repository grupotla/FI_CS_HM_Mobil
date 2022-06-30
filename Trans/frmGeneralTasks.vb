Public Class frmGeneralTasks
    Inherits System.Windows.Forms.Form
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents cmdFinish As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGeneralTasks))
        Me.picMain = New System.Windows.Forms.PictureBox
        Me.picClose = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.txtType = New System.Windows.Forms.TextBox
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdFinish = New System.Windows.Forms.Button
        '
        'picMain
        '
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(8, 0)
        Me.picMain.Size = New System.Drawing.Size(32, 32)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(48, 0)
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.Text = "Tarea -"
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.Location = New System.Drawing.Point(16, 56)
        Me.txtType.Size = New System.Drawing.Size(216, 22)
        Me.txtType.Text = ""
        '
        'txtComments
        '
        Me.txtComments.Enabled = False
        Me.txtComments.Location = New System.Drawing.Point(16, 104)
        Me.txtComments.Multiline = True
        Me.txtComments.Size = New System.Drawing.Size(216, 88)
        Me.txtComments.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Text = "Tipo Tarea:"
        '
        'cmdFinish
        '
        Me.cmdFinish.Location = New System.Drawing.Point(152, 200)
        Me.cmdFinish.Size = New System.Drawing.Size(80, 24)
        Me.cmdFinish.Text = "Finalizar"
        '
        'frmGeneralTasks
        '
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Text = "Tareas Bodega"

    End Sub

#End Region


    Private nTaskNumber As Integer

    Private Sub GetAssignedTask()
        Dim xTask As New wsGeneralTasks.wsGeneralTasks
        Dim sType As String
        Dim sComments As String

        Try
            Me.txtType.Text = ""
            Me.txtComments.Text = ""
            Call xTask.GetTaskData(publicUserID, nTaskNumber, sType, sComments)
            If nTaskNumber = -1 Then
                Me.Close()
            End If

            txtType.Text = sType
            txtComments.Text = sComments

        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmGeneralTasks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GetAssignedTask()

    End Sub

    Private Sub cmdFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinish.Click
        Dim xGeneral As New wsGeneralTasks.wsGeneralTasks

        Call xGeneral.UpdateTask(nTaskNumber, "1")
        GetAssignedTask()
    End Sub
End Class
