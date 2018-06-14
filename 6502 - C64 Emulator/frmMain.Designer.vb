<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.grpDebug = New System.Windows.Forms.GroupBox()
        Me.tbcDebug = New System.Windows.Forms.TabControl()
        Me.tabCPU = New System.Windows.Forms.TabPage()
        Me.lstDisassembly = New System.Windows.Forms.ListBox()
        Me.grp6502 = New System.Windows.Forms.GroupBox()
        Me.lblCPU_OPS = New System.Windows.Forms.Label()
        Me.lblCPU_IRQ = New System.Windows.Forms.Label()
        Me.lblCPU_NMI = New System.Windows.Forms.Label()
        Me.lblCPU_Cycle = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl6500_FLBits = New System.Windows.Forms.Label()
        Me.lbl6500_FL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl6500_PC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl6500_SP = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl6500_Y = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl6500_X = New System.Windows.Forms.Label()
        Me.lbl6500_A = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabMemory = New System.Windows.Forms.TabPage()
        Me.grpMemory = New System.Windows.Forms.GroupBox()
        Me.cboMemoryType = New System.Windows.Forms.ComboBox()
        Me.cboMemory = New System.Windows.Forms.ComboBox()
        Me.cboMemorySec = New System.Windows.Forms.ComboBox()
        Me.lstMemory = New System.Windows.Forms.ListBox()
        Me.tabVideo = New System.Windows.Forms.TabPage()
        Me.lblPalette15 = New System.Windows.Forms.Label()
        Me.lblPalette14 = New System.Windows.Forms.Label()
        Me.lblPalette13 = New System.Windows.Forms.Label()
        Me.lblPalette12 = New System.Windows.Forms.Label()
        Me.lblPalette11 = New System.Windows.Forms.Label()
        Me.lblPalette10 = New System.Windows.Forms.Label()
        Me.lblPalette9 = New System.Windows.Forms.Label()
        Me.lblPalette8 = New System.Windows.Forms.Label()
        Me.lblPalette7 = New System.Windows.Forms.Label()
        Me.lblPalette6 = New System.Windows.Forms.Label()
        Me.lblPalette5 = New System.Windows.Forms.Label()
        Me.lblPalette4 = New System.Windows.Forms.Label()
        Me.lblPalette3 = New System.Windows.Forms.Label()
        Me.lblPalette2 = New System.Windows.Forms.Label()
        Me.lblPalette1 = New System.Windows.Forms.Label()
        Me.lblPalette0 = New System.Windows.Forms.Label()
        Me.picScreen = New System.Windows.Forms.PictureBox()
        Me.tmrMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.boxCommands = New System.Windows.Forms.GroupBox()
        Me.btnSoftReset = New System.Windows.Forms.Button()
        Me.btnHardReset = New System.Windows.Forms.Button()
        Me.btnStepCPUClk = New System.Windows.Forms.Button()
        Me.btnStepClock = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStepCPU = New System.Windows.Forms.Button()
        Me.grpIRQ = New System.Windows.Forms.GroupBox()
        Me.btnIRQ = New System.Windows.Forms.Button()
        Me.btnNMI = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCPUSpeed = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudSpeed = New System.Windows.Forms.NumericUpDown()
        Me.lblCyclesPerSecond = New System.Windows.Forms.Label()
        Me.tmrSpeedControl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.grpDebug.SuspendLayout()
        Me.tbcDebug.SuspendLayout()
        Me.tabCPU.SuspendLayout()
        Me.grp6502.SuspendLayout()
        Me.tabMemory.SuspendLayout()
        Me.grpMemory.SuspendLayout()
        Me.tabVideo.SuspendLayout()
        CType(Me.picScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxCommands.SuspendLayout()
        Me.grpIRQ.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDebug
        '
        Me.grpDebug.Controls.Add(Me.tbcDebug)
        Me.grpDebug.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDebug.Location = New System.Drawing.Point(148, 12)
        Me.grpDebug.Name = "grpDebug"
        Me.grpDebug.Size = New System.Drawing.Size(668, 570)
        Me.grpDebug.TabIndex = 81
        Me.grpDebug.TabStop = False
        Me.grpDebug.Text = "Debug"
        '
        'tbcDebug
        '
        Me.tbcDebug.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcDebug.Controls.Add(Me.tabCPU)
        Me.tbcDebug.Controls.Add(Me.tabMemory)
        Me.tbcDebug.Controls.Add(Me.tabVideo)
        Me.tbcDebug.Location = New System.Drawing.Point(6, 21)
        Me.tbcDebug.Name = "tbcDebug"
        Me.tbcDebug.SelectedIndex = 0
        Me.tbcDebug.Size = New System.Drawing.Size(656, 543)
        Me.tbcDebug.TabIndex = 78
        '
        'tabCPU
        '
        Me.tabCPU.Controls.Add(Me.lstDisassembly)
        Me.tabCPU.Controls.Add(Me.grp6502)
        Me.tabCPU.Location = New System.Drawing.Point(4, 25)
        Me.tabCPU.Name = "tabCPU"
        Me.tabCPU.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCPU.Size = New System.Drawing.Size(648, 514)
        Me.tabCPU.TabIndex = 0
        Me.tabCPU.Text = "CPU"
        Me.tabCPU.UseVisualStyleBackColor = True
        '
        'lstDisassembly
        '
        Me.lstDisassembly.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstDisassembly.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisassembly.FormattingEnabled = True
        Me.lstDisassembly.ItemHeight = 14
        Me.lstDisassembly.Location = New System.Drawing.Point(6, 91)
        Me.lstDisassembly.Name = "lstDisassembly"
        Me.lstDisassembly.Size = New System.Drawing.Size(286, 396)
        Me.lstDisassembly.TabIndex = 76
        '
        'grp6502
        '
        Me.grp6502.Controls.Add(Me.lblCPU_OPS)
        Me.grp6502.Controls.Add(Me.lblCPU_IRQ)
        Me.grp6502.Controls.Add(Me.lblCPU_NMI)
        Me.grp6502.Controls.Add(Me.lblCPU_Cycle)
        Me.grp6502.Controls.Add(Me.Label4)
        Me.grp6502.Controls.Add(Me.lbl6500_FLBits)
        Me.grp6502.Controls.Add(Me.lbl6500_FL)
        Me.grp6502.Controls.Add(Me.Label1)
        Me.grp6502.Controls.Add(Me.lbl6500_PC)
        Me.grp6502.Controls.Add(Me.Label2)
        Me.grp6502.Controls.Add(Me.lbl6500_SP)
        Me.grp6502.Controls.Add(Me.Label3)
        Me.grp6502.Controls.Add(Me.lbl6500_Y)
        Me.grp6502.Controls.Add(Me.Label5)
        Me.grp6502.Controls.Add(Me.lbl6500_X)
        Me.grp6502.Controls.Add(Me.lbl6500_A)
        Me.grp6502.Controls.Add(Me.Label9)
        Me.grp6502.Controls.Add(Me.Label8)
        Me.grp6502.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp6502.Location = New System.Drawing.Point(6, 6)
        Me.grp6502.Name = "grp6502"
        Me.grp6502.Size = New System.Drawing.Size(286, 79)
        Me.grp6502.TabIndex = 75
        Me.grp6502.TabStop = False
        Me.grp6502.Text = "6502"
        '
        'lblCPU_OPS
        '
        Me.lblCPU_OPS.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPU_OPS.Location = New System.Drawing.Point(137, 52)
        Me.lblCPU_OPS.Name = "lblCPU_OPS"
        Me.lblCPU_OPS.Size = New System.Drawing.Size(143, 20)
        Me.lblCPU_OPS.TabIndex = 76
        Me.lblCPU_OPS.Text = "0 Op/s"
        Me.lblCPU_OPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCPU_IRQ
        '
        Me.lblCPU_IRQ.BackColor = System.Drawing.Color.White
        Me.lblCPU_IRQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCPU_IRQ.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPU_IRQ.Location = New System.Drawing.Point(241, 18)
        Me.lblCPU_IRQ.Name = "lblCPU_IRQ"
        Me.lblCPU_IRQ.Size = New System.Drawing.Size(39, 17)
        Me.lblCPU_IRQ.TabIndex = 76
        Me.lblCPU_IRQ.Text = "IRQ"
        Me.lblCPU_IRQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCPU_NMI
        '
        Me.lblCPU_NMI.BackColor = System.Drawing.Color.White
        Me.lblCPU_NMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCPU_NMI.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPU_NMI.Location = New System.Drawing.Point(241, 35)
        Me.lblCPU_NMI.Name = "lblCPU_NMI"
        Me.lblCPU_NMI.Size = New System.Drawing.Size(39, 17)
        Me.lblCPU_NMI.TabIndex = 77
        Me.lblCPU_NMI.Text = "NMI"
        Me.lblCPU_NMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCPU_Cycle
        '
        Me.lblCPU_Cycle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPU_Cycle.Location = New System.Drawing.Point(6, 52)
        Me.lblCPU_Cycle.Name = "lblCPU_Cycle"
        Me.lblCPU_Cycle.Size = New System.Drawing.Size(125, 20)
        Me.lblCPU_Cycle.TabIndex = 78
        Me.lblCPU_Cycle.Text = "CPU Cycle: 0/0"
        Me.lblCPU_Cycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "YR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6500_FLBits
        '
        Me.lbl6500_FLBits.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6500_FLBits.Location = New System.Drawing.Point(160, 35)
        Me.lbl6500_FLBits.Name = "lbl6500_FLBits"
        Me.lbl6500_FLBits.Size = New System.Drawing.Size(72, 17)
        Me.lbl6500_FLBits.TabIndex = 17
        Me.lbl6500_FLBits.Text = "00000000"
        Me.lbl6500_FLBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6500_FL
        '
        Me.lbl6500_FL.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6500_FL.Location = New System.Drawing.Point(137, 35)
        Me.lbl6500_FL.Name = "lbl6500_FL"
        Me.lbl6500_FL.Size = New System.Drawing.Size(24, 17)
        Me.lbl6500_FL.TabIndex = 16
        Me.lbl6500_FL.Text = "00"
        Me.lbl6500_FL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PC"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6500_PC
        '
        Me.lbl6500_PC.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6500_PC.Location = New System.Drawing.Point(6, 35)
        Me.lbl6500_PC.Name = "lbl6500_PC"
        Me.lbl6500_PC.Size = New System.Drawing.Size(40, 17)
        Me.lbl6500_PC.TabIndex = 1
        Me.lbl6500_PC.Text = "0000"
        Me.lbl6500_PC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6500_SP
        '
        Me.lbl6500_SP.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6500_SP.Location = New System.Drawing.Point(114, 35)
        Me.lbl6500_SP.Name = "lbl6500_SP"
        Me.lbl6500_SP.Size = New System.Drawing.Size(24, 17)
        Me.lbl6500_SP.TabIndex = 13
        Me.lbl6500_SP.Text = "00"
        Me.lbl6500_SP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "XR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6500_Y
        '
        Me.lbl6500_Y.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6500_Y.Location = New System.Drawing.Point(91, 35)
        Me.lbl6500_Y.Name = "lbl6500_Y"
        Me.lbl6500_Y.Size = New System.Drawing.Size(24, 17)
        Me.lbl6500_Y.TabIndex = 12
        Me.lbl6500_Y.Text = "00"
        Me.lbl6500_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SP"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6500_X
        '
        Me.lbl6500_X.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6500_X.Location = New System.Drawing.Point(68, 35)
        Me.lbl6500_X.Name = "lbl6500_X"
        Me.lbl6500_X.Size = New System.Drawing.Size(24, 17)
        Me.lbl6500_X.TabIndex = 11
        Me.lbl6500_X.Text = "00"
        Me.lbl6500_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6500_A
        '
        Me.lbl6500_A.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6500_A.Location = New System.Drawing.Point(45, 35)
        Me.lbl6500_A.Name = "lbl6500_A"
        Me.lbl6500_A.Size = New System.Drawing.Size(24, 17)
        Me.lbl6500_A.TabIndex = 10
        Me.lbl6500_A.Text = "00"
        Me.lbl6500_A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "NV-BDIZC"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(137, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "FL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabMemory
        '
        Me.tabMemory.Controls.Add(Me.grpMemory)
        Me.tabMemory.Location = New System.Drawing.Point(4, 25)
        Me.tabMemory.Name = "tabMemory"
        Me.tabMemory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMemory.Size = New System.Drawing.Size(648, 514)
        Me.tabMemory.TabIndex = 1
        Me.tabMemory.Text = "Memory"
        Me.tabMemory.UseVisualStyleBackColor = True
        '
        'grpMemory
        '
        Me.grpMemory.Controls.Add(Me.cboMemoryType)
        Me.grpMemory.Controls.Add(Me.cboMemory)
        Me.grpMemory.Controls.Add(Me.cboMemorySec)
        Me.grpMemory.Controls.Add(Me.lstMemory)
        Me.grpMemory.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMemory.Location = New System.Drawing.Point(6, 6)
        Me.grpMemory.Name = "grpMemory"
        Me.grpMemory.Size = New System.Drawing.Size(514, 298)
        Me.grpMemory.TabIndex = 76
        Me.grpMemory.TabStop = False
        Me.grpMemory.Text = "Memory"
        '
        'cboMemoryType
        '
        Me.cboMemoryType.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemoryType.FormattingEnabled = True
        Me.cboMemoryType.Items.AddRange(New Object() {"SYSTEM", "RAM", "KERNAL", "BASIC", "CHRGEN", "VBUFFER"})
        Me.cboMemoryType.Location = New System.Drawing.Point(218, 19)
        Me.cboMemoryType.Name = "cboMemoryType"
        Me.cboMemoryType.Size = New System.Drawing.Size(77, 24)
        Me.cboMemoryType.TabIndex = 60
        Me.cboMemoryType.Text = "SYSTEM"
        '
        'cboMemory
        '
        Me.cboMemory.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemory.FormattingEnabled = True
        Me.cboMemory.Items.AddRange(New Object() {"0x00-0xFF", "1x00-1xFF", "2x00-2xFF", "3x00-3xFF", "4x00-4xFF", "5x00-5xFF", "6x00-6xFF", "7x00-7xFF", "8x00-8xFF", "9x00-9xFF", "Ax00-AxFF", "Bx00-BxFF", "Cx00-CxFF", "Dx00-DxFF", "E000-EFFF", "F000-FFFF"})
        Me.cboMemory.Location = New System.Drawing.Point(6, 19)
        Me.cboMemory.Name = "cboMemory"
        Me.cboMemory.Size = New System.Drawing.Size(100, 24)
        Me.cboMemory.TabIndex = 58
        Me.cboMemory.Text = "0x00-0xFF"
        '
        'cboMemorySec
        '
        Me.cboMemorySec.DisplayMember = "0"
        Me.cboMemorySec.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemorySec.FormattingEnabled = True
        Me.cboMemorySec.Items.AddRange(New Object() {"x000-x0FF", "x100-x1FF", "x200-x2FF", "x300-x3FF", "x400-x4FF", "x500-x5FF", "x600-x6FF", "x700-x7FF", "x800-x8FF", "x900-x9FF", "xA00-xAFF", "xB00-xBFF", "xC00-xCFF", "xD00-xDFF", "xE00-xEFF", "xF00-xFFF"})
        Me.cboMemorySec.Location = New System.Drawing.Point(112, 19)
        Me.cboMemorySec.Name = "cboMemorySec"
        Me.cboMemorySec.Size = New System.Drawing.Size(100, 24)
        Me.cboMemorySec.TabIndex = 59
        Me.cboMemorySec.Text = "x000-x0FF"
        '
        'lstMemory
        '
        Me.lstMemory.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMemory.FormattingEnabled = True
        Me.lstMemory.ItemHeight = 14
        Me.lstMemory.Location = New System.Drawing.Point(6, 49)
        Me.lstMemory.Name = "lstMemory"
        Me.lstMemory.Size = New System.Drawing.Size(499, 242)
        Me.lstMemory.TabIndex = 57
        '
        'tabVideo
        '
        Me.tabVideo.Controls.Add(Me.lblPalette15)
        Me.tabVideo.Controls.Add(Me.lblPalette14)
        Me.tabVideo.Controls.Add(Me.lblPalette13)
        Me.tabVideo.Controls.Add(Me.lblPalette12)
        Me.tabVideo.Controls.Add(Me.lblPalette11)
        Me.tabVideo.Controls.Add(Me.lblPalette10)
        Me.tabVideo.Controls.Add(Me.lblPalette9)
        Me.tabVideo.Controls.Add(Me.lblPalette8)
        Me.tabVideo.Controls.Add(Me.lblPalette7)
        Me.tabVideo.Controls.Add(Me.lblPalette6)
        Me.tabVideo.Controls.Add(Me.lblPalette5)
        Me.tabVideo.Controls.Add(Me.lblPalette4)
        Me.tabVideo.Controls.Add(Me.lblPalette3)
        Me.tabVideo.Controls.Add(Me.lblPalette2)
        Me.tabVideo.Controls.Add(Me.lblPalette1)
        Me.tabVideo.Controls.Add(Me.lblPalette0)
        Me.tabVideo.Controls.Add(Me.picScreen)
        Me.tabVideo.Location = New System.Drawing.Point(4, 25)
        Me.tabVideo.Name = "tabVideo"
        Me.tabVideo.Size = New System.Drawing.Size(648, 514)
        Me.tabVideo.TabIndex = 2
        Me.tabVideo.Text = "Video"
        Me.tabVideo.UseVisualStyleBackColor = True
        '
        'lblPalette15
        '
        Me.lblPalette15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette15.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette15.Location = New System.Drawing.Point(303, 406)
        Me.lblPalette15.Name = "lblPalette15"
        Me.lblPalette15.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette15.TabIndex = 100
        Me.lblPalette15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette14
        '
        Me.lblPalette14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette14.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette14.Location = New System.Drawing.Point(283, 406)
        Me.lblPalette14.Name = "lblPalette14"
        Me.lblPalette14.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette14.TabIndex = 99
        Me.lblPalette14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette13
        '
        Me.lblPalette13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette13.Location = New System.Drawing.Point(263, 406)
        Me.lblPalette13.Name = "lblPalette13"
        Me.lblPalette13.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette13.TabIndex = 98
        Me.lblPalette13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette12
        '
        Me.lblPalette12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette12.Location = New System.Drawing.Point(243, 406)
        Me.lblPalette12.Name = "lblPalette12"
        Me.lblPalette12.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette12.TabIndex = 97
        Me.lblPalette12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette11
        '
        Me.lblPalette11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette11.Location = New System.Drawing.Point(223, 406)
        Me.lblPalette11.Name = "lblPalette11"
        Me.lblPalette11.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette11.TabIndex = 96
        Me.lblPalette11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette10
        '
        Me.lblPalette10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette10.Location = New System.Drawing.Point(203, 406)
        Me.lblPalette10.Name = "lblPalette10"
        Me.lblPalette10.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette10.TabIndex = 95
        Me.lblPalette10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette9
        '
        Me.lblPalette9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette9.Location = New System.Drawing.Point(183, 406)
        Me.lblPalette9.Name = "lblPalette9"
        Me.lblPalette9.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette9.TabIndex = 94
        Me.lblPalette9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette8
        '
        Me.lblPalette8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette8.Location = New System.Drawing.Point(163, 406)
        Me.lblPalette8.Name = "lblPalette8"
        Me.lblPalette8.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette8.TabIndex = 93
        Me.lblPalette8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette7
        '
        Me.lblPalette7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette7.Location = New System.Drawing.Point(143, 406)
        Me.lblPalette7.Name = "lblPalette7"
        Me.lblPalette7.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette7.TabIndex = 92
        Me.lblPalette7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette6
        '
        Me.lblPalette6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette6.Location = New System.Drawing.Point(123, 406)
        Me.lblPalette6.Name = "lblPalette6"
        Me.lblPalette6.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette6.TabIndex = 91
        Me.lblPalette6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette5
        '
        Me.lblPalette5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette5.Location = New System.Drawing.Point(103, 406)
        Me.lblPalette5.Name = "lblPalette5"
        Me.lblPalette5.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette5.TabIndex = 90
        Me.lblPalette5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette4
        '
        Me.lblPalette4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette4.Location = New System.Drawing.Point(83, 406)
        Me.lblPalette4.Name = "lblPalette4"
        Me.lblPalette4.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette4.TabIndex = 89
        Me.lblPalette4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette3
        '
        Me.lblPalette3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette3.Location = New System.Drawing.Point(63, 406)
        Me.lblPalette3.Name = "lblPalette3"
        Me.lblPalette3.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette3.TabIndex = 88
        Me.lblPalette3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette2
        '
        Me.lblPalette2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette2.Location = New System.Drawing.Point(43, 406)
        Me.lblPalette2.Name = "lblPalette2"
        Me.lblPalette2.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette2.TabIndex = 87
        Me.lblPalette2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette1
        '
        Me.lblPalette1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette1.Location = New System.Drawing.Point(23, 406)
        Me.lblPalette1.Name = "lblPalette1"
        Me.lblPalette1.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette1.TabIndex = 86
        Me.lblPalette1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPalette0
        '
        Me.lblPalette0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPalette0.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPalette0.Location = New System.Drawing.Point(3, 406)
        Me.lblPalette0.Name = "lblPalette0"
        Me.lblPalette0.Size = New System.Drawing.Size(20, 20)
        Me.lblPalette0.TabIndex = 85
        Me.lblPalette0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picScreen
        '
        Me.picScreen.BackColor = System.Drawing.Color.White
        Me.picScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picScreen.Location = New System.Drawing.Point(3, 3)
        Me.picScreen.Name = "picScreen"
        Me.picScreen.Size = New System.Drawing.Size(640, 400)
        Me.picScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScreen.TabIndex = 1
        Me.picScreen.TabStop = False
        '
        'tmrMonitor
        '
        Me.tmrMonitor.Interval = 10
        '
        'boxCommands
        '
        Me.boxCommands.Controls.Add(Me.btnSoftReset)
        Me.boxCommands.Controls.Add(Me.btnHardReset)
        Me.boxCommands.Controls.Add(Me.btnStepCPUClk)
        Me.boxCommands.Controls.Add(Me.btnStepClock)
        Me.boxCommands.Controls.Add(Me.btnPause)
        Me.boxCommands.Controls.Add(Me.btnStepCPU)
        Me.boxCommands.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxCommands.Location = New System.Drawing.Point(12, 12)
        Me.boxCommands.Name = "boxCommands"
        Me.boxCommands.Size = New System.Drawing.Size(130, 198)
        Me.boxCommands.TabIndex = 76
        Me.boxCommands.TabStop = False
        Me.boxCommands.Text = "Commands"
        '
        'btnSoftReset
        '
        Me.btnSoftReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSoftReset.Location = New System.Drawing.Point(6, 135)
        Me.btnSoftReset.Name = "btnSoftReset"
        Me.btnSoftReset.Size = New System.Drawing.Size(118, 23)
        Me.btnSoftReset.TabIndex = 60
        Me.btnSoftReset.Text = "Soft Reset"
        Me.btnSoftReset.UseVisualStyleBackColor = True
        '
        'btnHardReset
        '
        Me.btnHardReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHardReset.Location = New System.Drawing.Point(6, 164)
        Me.btnHardReset.Name = "btnHardReset"
        Me.btnHardReset.Size = New System.Drawing.Size(118, 23)
        Me.btnHardReset.TabIndex = 4
        Me.btnHardReset.Text = "Hard Reset"
        Me.btnHardReset.UseVisualStyleBackColor = True
        '
        'btnStepCPUClk
        '
        Me.btnStepCPUClk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStepCPUClk.Location = New System.Drawing.Point(6, 77)
        Me.btnStepCPUClk.Name = "btnStepCPUClk"
        Me.btnStepCPUClk.Size = New System.Drawing.Size(118, 23)
        Me.btnStepCPUClk.TabIndex = 7
        Me.btnStepCPUClk.Text = "&Step CPU Clk"
        Me.btnStepCPUClk.UseVisualStyleBackColor = True
        '
        'btnStepClock
        '
        Me.btnStepClock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStepClock.Location = New System.Drawing.Point(6, 48)
        Me.btnStepClock.Name = "btnStepClock"
        Me.btnStepClock.Size = New System.Drawing.Size(118, 23)
        Me.btnStepClock.TabIndex = 5
        Me.btnStepClock.Text = "Step Clock"
        Me.btnStepClock.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPause.Location = New System.Drawing.Point(6, 19)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(118, 23)
        Me.btnPause.TabIndex = 0
        Me.btnPause.Text = "Start"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStepCPU
        '
        Me.btnStepCPU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStepCPU.Location = New System.Drawing.Point(6, 106)
        Me.btnStepCPU.Name = "btnStepCPU"
        Me.btnStepCPU.Size = New System.Drawing.Size(118, 23)
        Me.btnStepCPU.TabIndex = 1
        Me.btnStepCPU.Text = "S&tep CPU Ins"
        Me.btnStepCPU.UseVisualStyleBackColor = True
        '
        'grpIRQ
        '
        Me.grpIRQ.Controls.Add(Me.btnIRQ)
        Me.grpIRQ.Controls.Add(Me.btnNMI)
        Me.grpIRQ.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIRQ.Location = New System.Drawing.Point(12, 216)
        Me.grpIRQ.Name = "grpIRQ"
        Me.grpIRQ.Size = New System.Drawing.Size(130, 80)
        Me.grpIRQ.TabIndex = 82
        Me.grpIRQ.TabStop = False
        Me.grpIRQ.Text = "IRQ Control"
        '
        'btnIRQ
        '
        Me.btnIRQ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIRQ.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIRQ.Location = New System.Drawing.Point(6, 19)
        Me.btnIRQ.Name = "btnIRQ"
        Me.btnIRQ.Size = New System.Drawing.Size(118, 23)
        Me.btnIRQ.TabIndex = 58
        Me.btnIRQ.Text = "Toggle IRQ"
        Me.btnIRQ.UseVisualStyleBackColor = True
        '
        'btnNMI
        '
        Me.btnNMI.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNMI.Location = New System.Drawing.Point(6, 48)
        Me.btnNMI.Name = "btnNMI"
        Me.btnNMI.Size = New System.Drawing.Size(118, 23)
        Me.btnNMI.TabIndex = 59
        Me.btnNMI.Text = "Toggle NMI"
        Me.btnNMI.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblCPUSpeed)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.nudSpeed)
        Me.GroupBox2.Controls.Add(Me.lblCyclesPerSecond)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 143)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Speed"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "CPU Speed"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCPUSpeed
        '
        Me.lblCPUSpeed.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUSpeed.Location = New System.Drawing.Point(6, 119)
        Me.lblCPUSpeed.Name = "lblCPUSpeed"
        Me.lblCPUSpeed.Size = New System.Drawing.Size(108, 17)
        Me.lblCPUSpeed.TabIndex = 24
        Me.lblCPUSpeed.Text = "0 Hz"
        Me.lblCPUSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Clock Speed"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Clock Speed"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudSpeed
        '
        Me.nudSpeed.DecimalPlaces = 6
        Me.nudSpeed.Increment = New Decimal(New Integer() {1024, 0, 0, 262144})
        Me.nudSpeed.InterceptArrowKeys = False
        Me.nudSpeed.Location = New System.Drawing.Point(6, 39)
        Me.nudSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.nudSpeed.Name = "nudSpeed"
        Me.nudSpeed.Size = New System.Drawing.Size(108, 22)
        Me.nudSpeed.TabIndex = 20
        Me.nudSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudSpeed.Value = New Decimal(New Integer() {818, 0, 0, 131072})
        '
        'lblCyclesPerSecond
        '
        Me.lblCyclesPerSecond.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCyclesPerSecond.Location = New System.Drawing.Point(6, 82)
        Me.lblCyclesPerSecond.Name = "lblCyclesPerSecond"
        Me.lblCyclesPerSecond.Size = New System.Drawing.Size(108, 17)
        Me.lblCyclesPerSecond.TabIndex = 19
        Me.lblCyclesPerSecond.Text = "0 Hz"
        Me.lblCyclesPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrSpeedControl
        '
        '
        'tmrSpeed
        '
        Me.tmrSpeed.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 619)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpIRQ)
        Me.Controls.Add(Me.boxCommands)
        Me.Controls.Add(Me.grpDebug)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C64 Simulator"
        Me.grpDebug.ResumeLayout(False)
        Me.tbcDebug.ResumeLayout(False)
        Me.tabCPU.ResumeLayout(False)
        Me.grp6502.ResumeLayout(False)
        Me.tabMemory.ResumeLayout(False)
        Me.grpMemory.ResumeLayout(False)
        Me.tabVideo.ResumeLayout(False)
        CType(Me.picScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxCommands.ResumeLayout(False)
        Me.grpIRQ.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDebug As System.Windows.Forms.GroupBox
    Friend WithEvents tbcDebug As System.Windows.Forms.TabControl
    Friend WithEvents tabCPU As System.Windows.Forms.TabPage
    Friend WithEvents grp6502 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCPU_Cycle As System.Windows.Forms.Label
    Friend WithEvents lblCPU_IRQ As System.Windows.Forms.Label
    Friend WithEvents lblCPU_NMI As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl6500_FLBits As System.Windows.Forms.Label
    Friend WithEvents lbl6500_FL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl6500_PC As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl6500_SP As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl6500_Y As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl6500_X As System.Windows.Forms.Label
    Friend WithEvents lbl6500_A As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tabMemory As System.Windows.Forms.TabPage
    Friend WithEvents grpMemory As System.Windows.Forms.GroupBox
    Friend WithEvents cboMemoryType As System.Windows.Forms.ComboBox
    Friend WithEvents cboMemory As System.Windows.Forms.ComboBox
    Friend WithEvents cboMemorySec As System.Windows.Forms.ComboBox
    Friend WithEvents lstMemory As System.Windows.Forms.ListBox
    Friend WithEvents tmrMonitor As System.Windows.Forms.Timer
    Friend WithEvents boxCommands As System.Windows.Forms.GroupBox
    Friend WithEvents btnSoftReset As System.Windows.Forms.Button
    Friend WithEvents btnHardReset As System.Windows.Forms.Button
    Friend WithEvents btnStepCPUClk As System.Windows.Forms.Button
    Friend WithEvents btnStepClock As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnStepCPU As System.Windows.Forms.Button
    Friend WithEvents grpIRQ As System.Windows.Forms.GroupBox
    Friend WithEvents btnIRQ As System.Windows.Forms.Button
    Friend WithEvents btnNMI As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCPUSpeed As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nudSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCyclesPerSecond As System.Windows.Forms.Label
    Friend WithEvents tmrSpeedControl As System.Windows.Forms.Timer
    Friend WithEvents tmrSpeed As System.Windows.Forms.Timer
    Friend WithEvents lblCPU_OPS As System.Windows.Forms.Label
    Friend WithEvents lstDisassembly As System.Windows.Forms.ListBox
    Friend WithEvents tabVideo As System.Windows.Forms.TabPage
    Friend WithEvents picScreen As System.Windows.Forms.PictureBox
    Friend WithEvents lblPalette15 As System.Windows.Forms.Label
    Friend WithEvents lblPalette14 As System.Windows.Forms.Label
    Friend WithEvents lblPalette13 As System.Windows.Forms.Label
    Friend WithEvents lblPalette12 As System.Windows.Forms.Label
    Friend WithEvents lblPalette11 As System.Windows.Forms.Label
    Friend WithEvents lblPalette10 As System.Windows.Forms.Label
    Friend WithEvents lblPalette9 As System.Windows.Forms.Label
    Friend WithEvents lblPalette8 As System.Windows.Forms.Label
    Friend WithEvents lblPalette7 As System.Windows.Forms.Label
    Friend WithEvents lblPalette6 As System.Windows.Forms.Label
    Friend WithEvents lblPalette5 As System.Windows.Forms.Label
    Friend WithEvents lblPalette4 As System.Windows.Forms.Label
    Friend WithEvents lblPalette3 As System.Windows.Forms.Label
    Friend WithEvents lblPalette2 As System.Windows.Forms.Label
    Friend WithEvents lblPalette1 As System.Windows.Forms.Label
    Friend WithEvents lblPalette0 As System.Windows.Forms.Label

End Class
