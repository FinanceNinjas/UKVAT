<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.VOLCATGrid = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.VATDASHGrid = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.VATDASH1Grid = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.VATDASH2Grid = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.VATDASH3Grid = New System.Windows.Forms.DataGridView()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.VATDASH4Grid = New System.Windows.Forms.DataGridView()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.DKDASH7Grid = New System.Windows.Forms.DataGridView()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.DKDASH71Grid = New System.Windows.Forms.DataGridView()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.DKDASH72CGrid = New System.Windows.Forms.DataGridView()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.DKDASH72FGrid = New System.Windows.Forms.DataGridView()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.TripsGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDSN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GetData = New System.Windows.Forms.Button()
        Me.BGGetInitialData = New System.ComponentModel.BackgroundWorker()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.BGGetSecondStepData = New System.ComponentModel.BackgroundWorker()
        Me.SecondStepData = New System.Windows.Forms.Button()
        Me.chkVATDASH = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.VOLCATGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.VATDASHGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.VATDASH1Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.VATDASH2Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.VATDASH3Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.VATDASH4Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.DKDASH7Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.DKDASH71Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage10.SuspendLayout()
        CType(Me.DKDASH72CGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        CType(Me.DKDASH72FGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage12.SuspendLayout()
        CType(Me.TripsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(731, 320)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.VOLCATGrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(723, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "VOLCAT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'VOLCATGrid
        '
        Me.VOLCATGrid.AllowUserToAddRows = False
        Me.VOLCATGrid.AllowUserToDeleteRows = False
        Me.VOLCATGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VOLCATGrid.Location = New System.Drawing.Point(3, 3)
        Me.VOLCATGrid.Name = "VOLCATGrid"
        Me.VOLCATGrid.ReadOnly = True
        Me.VOLCATGrid.Size = New System.Drawing.Size(713, 288)
        Me.VOLCATGrid.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(723, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VATDASH"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(10, 9)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(712, 284)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.VATDASHGrid)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(704, 258)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "VATDASH-0"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'VATDASHGrid
        '
        Me.VATDASHGrid.AllowUserToAddRows = False
        Me.VATDASHGrid.AllowUserToDeleteRows = False
        Me.VATDASHGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VATDASHGrid.Location = New System.Drawing.Point(3, 3)
        Me.VATDASHGrid.Name = "VATDASHGrid"
        Me.VATDASHGrid.ReadOnly = True
        Me.VATDASHGrid.Size = New System.Drawing.Size(300, 250)
        Me.VATDASHGrid.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.VATDASH1Grid)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(704, 258)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "VATDASH1"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'VATDASH1Grid
        '
        Me.VATDASH1Grid.AllowUserToAddRows = False
        Me.VATDASH1Grid.AllowUserToDeleteRows = False
        Me.VATDASH1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VATDASH1Grid.Location = New System.Drawing.Point(3, 3)
        Me.VATDASH1Grid.Name = "VATDASH1Grid"
        Me.VATDASH1Grid.ReadOnly = True
        Me.VATDASH1Grid.Size = New System.Drawing.Size(300, 250)
        Me.VATDASH1Grid.TabIndex = 2
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.VATDASH2Grid)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(704, 258)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "VATDASH2"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'VATDASH2Grid
        '
        Me.VATDASH2Grid.AllowUserToAddRows = False
        Me.VATDASH2Grid.AllowUserToDeleteRows = False
        Me.VATDASH2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VATDASH2Grid.Location = New System.Drawing.Point(3, 3)
        Me.VATDASH2Grid.Name = "VATDASH2Grid"
        Me.VATDASH2Grid.ReadOnly = True
        Me.VATDASH2Grid.Size = New System.Drawing.Size(300, 250)
        Me.VATDASH2Grid.TabIndex = 2
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.VATDASH3Grid)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(704, 258)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "VATDASH3"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'VATDASH3Grid
        '
        Me.VATDASH3Grid.AllowUserToAddRows = False
        Me.VATDASH3Grid.AllowUserToDeleteRows = False
        Me.VATDASH3Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VATDASH3Grid.Location = New System.Drawing.Point(3, 3)
        Me.VATDASH3Grid.Name = "VATDASH3Grid"
        Me.VATDASH3Grid.ReadOnly = True
        Me.VATDASH3Grid.Size = New System.Drawing.Size(300, 250)
        Me.VATDASH3Grid.TabIndex = 2
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.VATDASH4Grid)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(704, 258)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "VATDASH4"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'VATDASH4Grid
        '
        Me.VATDASH4Grid.AllowUserToAddRows = False
        Me.VATDASH4Grid.AllowUserToDeleteRows = False
        Me.VATDASH4Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VATDASH4Grid.Location = New System.Drawing.Point(3, 3)
        Me.VATDASH4Grid.Name = "VATDASH4Grid"
        Me.VATDASH4Grid.ReadOnly = True
        Me.VATDASH4Grid.Size = New System.Drawing.Size(300, 250)
        Me.VATDASH4Grid.TabIndex = 2
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.DKDASH7Grid)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(723, 294)
        Me.TabPage8.TabIndex = 2
        Me.TabPage8.Text = "DKDASH7"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'DKDASH7Grid
        '
        Me.DKDASH7Grid.AllowUserToAddRows = False
        Me.DKDASH7Grid.AllowUserToDeleteRows = False
        Me.DKDASH7Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DKDASH7Grid.Location = New System.Drawing.Point(3, 3)
        Me.DKDASH7Grid.Name = "DKDASH7Grid"
        Me.DKDASH7Grid.ReadOnly = True
        Me.DKDASH7Grid.Size = New System.Drawing.Size(713, 288)
        Me.DKDASH7Grid.TabIndex = 1
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.DKDASH71Grid)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(723, 294)
        Me.TabPage9.TabIndex = 3
        Me.TabPage9.Text = "DKDASH71"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'DKDASH71Grid
        '
        Me.DKDASH71Grid.AllowUserToAddRows = False
        Me.DKDASH71Grid.AllowUserToDeleteRows = False
        Me.DKDASH71Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DKDASH71Grid.Location = New System.Drawing.Point(3, 3)
        Me.DKDASH71Grid.Name = "DKDASH71Grid"
        Me.DKDASH71Grid.ReadOnly = True
        Me.DKDASH71Grid.Size = New System.Drawing.Size(713, 288)
        Me.DKDASH71Grid.TabIndex = 2
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.DKDASH72CGrid)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(723, 294)
        Me.TabPage10.TabIndex = 4
        Me.TabPage10.Text = "DKDASH72C"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'DKDASH72CGrid
        '
        Me.DKDASH72CGrid.AllowUserToAddRows = False
        Me.DKDASH72CGrid.AllowUserToDeleteRows = False
        Me.DKDASH72CGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DKDASH72CGrid.Location = New System.Drawing.Point(3, 3)
        Me.DKDASH72CGrid.Name = "DKDASH72CGrid"
        Me.DKDASH72CGrid.ReadOnly = True
        Me.DKDASH72CGrid.Size = New System.Drawing.Size(713, 288)
        Me.DKDASH72CGrid.TabIndex = 3
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.DKDASH72FGrid)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(723, 294)
        Me.TabPage11.TabIndex = 5
        Me.TabPage11.Text = "DKDASH72F"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'DKDASH72FGrid
        '
        Me.DKDASH72FGrid.AllowUserToAddRows = False
        Me.DKDASH72FGrid.AllowUserToDeleteRows = False
        Me.DKDASH72FGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DKDASH72FGrid.Location = New System.Drawing.Point(3, 3)
        Me.DKDASH72FGrid.Name = "DKDASH72FGrid"
        Me.DKDASH72FGrid.ReadOnly = True
        Me.DKDASH72FGrid.Size = New System.Drawing.Size(713, 288)
        Me.DKDASH72FGrid.TabIndex = 3
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.TripsGrid)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(723, 294)
        Me.TabPage12.TabIndex = 6
        Me.TabPage12.Text = "Trips"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'TripsGrid
        '
        Me.TripsGrid.AllowUserToAddRows = False
        Me.TripsGrid.AllowUserToDeleteRows = False
        Me.TripsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TripsGrid.Location = New System.Drawing.Point(5, 3)
        Me.TripsGrid.Name = "TripsGrid"
        Me.TripsGrid.ReadOnly = True
        Me.TripsGrid.Size = New System.Drawing.Size(713, 288)
        Me.TripsGrid.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdUpdate)
        Me.GroupBox4.Controls.Add(Me.txtPassword)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtUserID)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtDSN)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(216, 330)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 75)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "AS/400 DSN Characteristics"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(206, 12)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(98, 30)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(206, 46)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(98, 20)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(55, 46)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(96, 20)
        Me.txtUserID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User ID"
        '
        'txtDSN
        '
        Me.txtDSN.Location = New System.Drawing.Point(55, 21)
        Me.txtDSN.Name = "txtDSN"
        Me.txtDSN.Size = New System.Drawing.Size(124, 20)
        Me.txtDSN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DSN"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(738, 22)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(89, 17)
        Me.StatusLabel.Text = "Waiting for Input"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEndDate)
        Me.GroupBox1.Controls.Add(Me.txtStartDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 334)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 70)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Date Range"
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(97, 41)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(91, 20)
        Me.txtEndDate.TabIndex = 3
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(97, 17)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(91, 20)
        Me.txtStartDate.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Start Date"
        '
        'GetData
        '
        Me.GetData.Location = New System.Drawing.Point(4, 353)
        Me.GetData.Name = "GetData"
        Me.GetData.Size = New System.Drawing.Size(98, 65)
        Me.GetData.TabIndex = 27
        Me.GetData.Text = "Get Initial Data"
        Me.GetData.UseVisualStyleBackColor = True
        '
        'BGGetInitialData
        '
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "Data Source=RNCSQL003\PROD;Initial Catalog=UKVAT;Integrated Security=True"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'BGGetSecondStepData
        '
        '
        'SecondStepData
        '
        Me.SecondStepData.Location = New System.Drawing.Point(112, 353)
        Me.SecondStepData.Name = "SecondStepData"
        Me.SecondStepData.Size = New System.Drawing.Size(98, 65)
        Me.SecondStepData.TabIndex = 28
        Me.SecondStepData.Text = "Get 2nd Step Data"
        Me.SecondStepData.UseVisualStyleBackColor = True
        '
        'chkVATDASH
        '
        Me.chkVATDASH.AutoSize = True
        Me.chkVATDASH.Location = New System.Drawing.Point(8, 330)
        Me.chkVATDASH.Name = "chkVATDASH"
        Me.chkVATDASH.Size = New System.Drawing.Size(140, 17)
        Me.chkVATDASH.TabIndex = 29
        Me.chkVATDASH.Text = "Re-Pull VATDASH Data"
        Me.chkVATDASH.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 451)
        Me.Controls.Add(Me.chkVATDASH)
        Me.Controls.Add(Me.SecondStepData)
        Me.Controls.Add(Me.GetData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "UK VAT Data Import Utility"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.VOLCATGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.VATDASHGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.VATDASH1Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.VATDASH2Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.VATDASH3Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.VATDASH4Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.DKDASH7Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        CType(Me.DKDASH71Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage10.ResumeLayout(False)
        CType(Me.DKDASH72CGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        CType(Me.DKDASH72FGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage12.ResumeLayout(False)
        CType(Me.TripsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDSN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VOLCATGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GetData As System.Windows.Forms.Button
    Friend WithEvents VATDASHGrid As System.Windows.Forms.DataGridView
    Friend WithEvents VATDASH1Grid As System.Windows.Forms.DataGridView
    Friend WithEvents VATDASH2Grid As System.Windows.Forms.DataGridView
    Friend WithEvents VATDASH3Grid As System.Windows.Forms.DataGridView
    Friend WithEvents VATDASH4Grid As System.Windows.Forms.DataGridView
    Friend WithEvents BGGetInitialData As System.ComponentModel.BackgroundWorker
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents BGGetSecondStepData As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents DKDASH7Grid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents DKDASH71Grid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents DKDASH72CGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents DKDASH72FGrid As System.Windows.Forms.DataGridView
    Friend WithEvents SecondStepData As System.Windows.Forms.Button
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents TripsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents chkVATDASH As System.Windows.Forms.CheckBox

End Class
