Public Class frmMain
    Dim intDissassemblyPage As Integer
    Dim VideoEnabled As Boolean
    Private bmpVideo As Bitmap
    Private VideoThread As System.Threading.Thread

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If Not System.IO.Directory.Exists("roms") Then System.IO.Directory.CreateDirectory("roms")

        Palette(0) = Color.FromArgb(0, 0, 0)
        Palette(1) = Color.FromArgb(255, 255, 255)
        Palette(2) = Color.FromArgb(136, 0, 0)
        Palette(3) = Color.FromArgb(170, 255, 238)
        Palette(4) = Color.FromArgb(204, 68, 204)
        Palette(5) = Color.FromArgb(0, 204, 85)
        Palette(6) = Color.FromArgb(0, 0, 170)
        Palette(7) = Color.FromArgb(238, 238, 119)
        Palette(8) = Color.FromArgb(221, 136, 85)
        Palette(9) = Color.FromArgb(102, 68, 0)
        Palette(10) = Color.FromArgb(255, 119, 119)
        Palette(11) = Color.FromArgb(51, 51, 51)
        Palette(12) = Color.FromArgb(119, 119, 119)
        Palette(13) = Color.FromArgb(170, 255, 102)
        Palette(14) = Color.FromArgb(0, 136, 255)
        Palette(15) = Color.FromArgb(187, 187, 187)

        Reset()
        'Dim start As Integer = 520
        'For temp = start To start + 519
        '    VIC.vBuffer(temp) = 1
        'Next
        StartVideo()
    End Sub
#Region "Update Debugging"
    Private Sub UpdateMonitor()
        If SYS.IRQ = True Then lblCPU_IRQ.BackColor = Color.LightGreen Else lblCPU_IRQ.BackColor = Color.White
        If SYS.NMI = True Then lblCPU_NMI.BackColor = Color.LightGreen Else lblCPU_NMI.BackColor = Color.White
        UpdateCPURegisters()
        UpdateMemory()
        UpdateDisassembly()
    End Sub
    Private Sub UpdateCPURegisters()
        lblCPU_Cycle.Text = "CPU Cycle: " & CPU.Cycle & "/" & CPU.Cycles
        lbl6500_PC.Text = Hexed(CPU.tempPC, 4)
        lbl6500_A.Text = Hexed(CPU.A, 2)
        lbl6500_X.Text = Hexed(CPU.X, 2)
        lbl6500_Y.Text = Hexed(CPU.Y, 2)
        lbl6500_SP.Text = Hexed(CPU.S, 2)
        lbl6500_FL.Text = Hexed(CPU.P, 2)
        lbl6500_FLBits.Text = BinaryString(Str(CPU.P), 8)
    End Sub
    Private Sub UpdateMemory()
        Dim bytTemp As Byte
        Dim strTemp As String = ""
        Dim intStartAddress As Integer
        Dim intAddress As Integer
        Dim strData As String
        Dim intLine As Integer = 0

        If cboMemory.SelectedIndex = -1 And cboMemory.Items.Count > 0 Then cboMemory.SelectedIndex = 0
        If cboMemorySec.SelectedIndex = -1 And cboMemorySec.Items.Count > 0 Then cboMemorySec.SelectedIndex = 0

        If cboMemory.SelectedIndex > -1 And cboMemorySec.SelectedIndex > -1 Then
            intStartAddress = 4096 * cboMemory.SelectedIndex
            intStartAddress += 256 * cboMemorySec.SelectedIndex
            If lstMemory.Items.Count Then
                For intAddress = intStartAddress To intStartAddress + 255 Step 16
                    strTemp = ""
                    strData = Hexed(intAddress, 4) & ":"
                    intLine += 1
                    For intTemp = 0 To 15
                        Select Case cboMemoryType.SelectedItem
                            Case "SYSTEM" : bytTemp = SYS.Data(intAddress + intTemp)
                            Case "RAM" : bytTemp = RAM.Data((intAddress + intTemp) And RAM.Data.Length - 1)
                            Case "KERNAL" : bytTemp = KERNAL.Data((intAddress + intTemp) And KERNAL.Data.Length - 1)
                            Case "BASIC" : bytTemp = BASIC.Data((intAddress + intTemp) And BASIC.Data.Length - 1)
                            Case "CHRGEN" : bytTemp = CHRGEN.Data((intAddress + intTemp) And CHRGEN.Data.Length - 1)
                            Case "VBUFFER" : bytTemp = VIC.vBuffer((intAddress + intTemp) And VIC.vBuffer.Length - 1)
                        End Select
                        strData = strData & " " & Hexed(bytTemp, 2)
                        Select Case bytTemp
                            Case &H1 To &H26 : strTemp = strTemp & Chr(bytTemp + &H40)
                            Case &H2A To &H7A : strTemp = strTemp & Chr(bytTemp)
                            Case Else : strTemp = strTemp & "-"
                        End Select
                    Next
                    lstMemory.Items.Item(intLine) = strData & " " & strTemp
                Next
            Else
                lstMemory.Items.Clear()
                lstMemory.Items.Add("      00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F")
                For intAddress = intStartAddress To intStartAddress + 255 Step 16
                    strTemp = ""
                    strData = Hexed(intAddress, 4) & ":"
                    For intTemp = 0 To 15
                        Select Case cboMemoryType.SelectedItem
                            Case "SYSTEM" : bytTemp = SYS.Data(intAddress + intTemp)
                            Case "RAM" : bytTemp = RAM.Data((intAddress + intTemp) And RAM.Data.Length - 1)
                            Case "KERNAL" : bytTemp = KERNAL.Data((intAddress + intTemp) And KERNAL.Data.Length - 1)
                            Case "BASIC" : bytTemp = BASIC.Data((intAddress + intTemp) And BASIC.Data.Length - 1)
                            Case "CHRGEN" : bytTemp = CHRGEN.Data((intAddress + intTemp) And CHRGEN.Data.Length - 1)
                            Case "VBUFFER" : bytTemp = VIC.vBuffer((intAddress + intTemp) And VIC.vBuffer.Length - 1)
                        End Select
                        strData = strData & " " & Hexed(bytTemp, 2)
                        Select Case bytTemp
                            Case &H1 To &H26 : strTemp = strTemp & Chr(bytTemp + &H40)
                            Case &H2A To &H7A : strTemp = strTemp & Chr(bytTemp)
                            Case Else : strTemp = strTemp & "-"
                        End Select
                    Next
                    lstMemory.Items.Add(strData & " " & strTemp)
                Next
            End If
        End If
    End Sub
    Private Sub SelectDisassembly()
        For intLine = 0 To lstDisassembly.Items.Count - 1
            If Hexed(CPU.tempPC, 4) = Microsoft.VisualBasic.Left(lstDisassembly.Items.Item(intLine), 4) Then
                lstDisassembly.SetSelected(intLine, True)
                Exit For
            End If
        Next
    End Sub
    Private Sub UpdateDisassembly()
        Dim NewScreen As Boolean = True
        Dim intInsAdr As Integer
        Dim tempAdr As Integer
        Dim strLine As String
        tempAdr = CPU.tempPC And &HFF00

        If intDissassemblyPage = tempAdr And lstDisassembly.Items.Count Then
            SelectDisassembly()
        Else
            lstDisassembly.Items.Clear()
            For intInsAdr = tempAdr To tempAdr + &HFF
                strLine = Hexed(intInsAdr And &HFFFF, 4) & ":"
                Select Case CPU.INS_ADR(SYS.Data(intInsAdr))
                    Case cls6502.ADR_ABS
                        strLine &= GetByteString(intInsAdr, 3)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= " $" & Hexed(SYS.Data(intInsAdr + 2), 2) & Hexed(SYS.Data(intInsAdr + 1), 2)
                        intInsAdr += 2
                    Case cls6502.ADR_ABSX
                        strLine &= GetByteString(intInsAdr, 3)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" $" & Hexed(SYS.Data(intInsAdr + 2), 2) & Hexed(SYS.Data(intInsAdr + 1), 2) & ",X").PadRight(10, " ")
                        intInsAdr += 2
                    Case cls6502.ADR_ABSY
                        strLine &= GetByteString(intInsAdr, 3)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" $" & Hexed(SYS.Data(intInsAdr + 2), 2) & Hexed(SYS.Data(intInsAdr + 1), 2) & ",Y").PadRight(10, " ")
                        intInsAdr += 2
                    Case cls6502.ADR_IMP
                        strLine &= GetByteString(intInsAdr, 1)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr)) & "          "
                    Case cls6502.ADR_IMM
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" #$" & Hexed(SYS.Data(intInsAdr + 1), 2)).PadRight(10, " ")
                        intInsAdr += 1
                    Case cls6502.ADR_INDABSX
                        strLine &= GetByteString(intInsAdr, 3)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" $" & Hexed(SYS.Data(intInsAdr + 2), 2) & Hexed(SYS.Data(intInsAdr + 1), 2) & ",X").PadRight(10, " ")
                        intInsAdr += 2
                    Case cls6502.ADR_IND
                        strLine &= GetByteString(intInsAdr, 3)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" ($" & Hexed(SYS.Data(intInsAdr + 2), 2) & Hexed(SYS.Data(intInsAdr + 1), 2) & ")").PadRight(10, " ")
                        intInsAdr += 2
                    Case cls6502.ADR_INDX
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" ($" & Hexed(SYS.Data(intInsAdr + 1), 2) & ",X)").PadRight(10, " ")
                        intInsAdr += 1
                    Case cls6502.ADR_INDY
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" ($" & Hexed(SYS.Data(intInsAdr + 1), 2) & "),Y").PadRight(10, " ")
                        intInsAdr += 1
                    Case cls6502.ADR_INDZP
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" $" & Hexed(SYS.Data(intInsAdr + 1), 2)).PadRight(10, " ")
                        intInsAdr += 1
                    Case cls6502.ADR_REL
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= " $" & Hexed(SYS.Data(intInsAdr + 1), 2)
                        If SYS.Data(intInsAdr + 1) And &H80 Then
                            strLine &= (" ($" & Hexed(intInsAdr + 2 + (SYS.Data(intInsAdr + 1) - &H100), 4) & ")").PadRight(10, " ")
                        Else
                            strLine &= (" ($" & Hexed(intInsAdr + 2 + SYS.Data(intInsAdr + 1), 4) & ")").PadRight(10, " ")
                        End If
                        intInsAdr += 1
                    Case cls6502.ADR_ZP
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" $" & Hexed(SYS.Data(intInsAdr + 1), 2)).PadRight(10, " ")
                        intInsAdr += 1
                    Case cls6502.ADR_ZPX
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" $" & Hexed(SYS.Data(intInsAdr + 1), 2) & ",X").PadRight(10, " ")
                        intInsAdr += 1
                    Case cls6502.ADR_ZPY
                        strLine &= GetByteString(intInsAdr, 2)
                        strLine &= CPU.INS_TEXT(SYS.Data(intInsAdr))
                        strLine &= (" $" & Hexed(SYS.Data(intInsAdr + 1), 2) & ",Y").PadRight(10, " ")
                        intInsAdr += 1
                End Select
                strLine = strLine.PadRight(29, " ")
                lstDisassembly.Items.Add(strLine)
            Next
            intDissassemblyPage = CPU.tempPC And &HFF00
            SelectDisassembly()
        End If
    End Sub
    Public Function GetByteString(Address As Integer, Bytes As Integer)
        GetByteString = ""
        For intTemp = 0 To Bytes - 1
            GetByteString &= Hexed(SYS.Data((Address + intTemp) And &HFFFF), 2).PadLeft(3, " ")
        Next
        GetByteString = GetByteString.padright(9, " ") & "  "
    End Function
#End Region

#Region "Button Functions"
#Region "   Commands"
    Private Sub btnPause_Click(sender As System.Object, e As System.EventArgs) Handles btnPause.Click
        If SYS.Running = True Then
            btnPause.Text = "Start"
            btnStepCPU.Enabled = True
            btnStepClock.Enabled = True
            btnStepCPUClk.Enabled = True
            btnSoftReset.Enabled = True
            btnHardReset.Enabled = True
            tmrSpeedControl.Enabled = False
            tmrSpeed.Enabled = False
            tmrMonitor.Enabled = False
            SYS.StopClock()
            UpdateMonitor()
            StopVideo()
        Else
            btnPause.Text = "Pause"
            btnStepCPU.Enabled = False
            btnStepClock.Enabled = False
            btnStepCPUClk.Enabled = False
            btnSoftReset.Enabled = False
            btnHardReset.Enabled = False
            tmrSpeedControl.Enabled = True
            tmrSpeed.Enabled = True
            tmrMonitor.Enabled = True
            SYS.MaxCPI = nudSpeed.Value * (1111111 / (1000 / tmrSpeedControl.Interval))
            SYS.StartClock()
            StartVideo()
        End If
    End Sub
    Private Sub btnStepClock_Click(sender As System.Object, e As System.EventArgs) Handles btnStepClock.Click
        SYS.Tick()
        UpdateMonitor()
    End Sub
    Private Sub btnStepCPUClk_Click(sender As System.Object, e As System.EventArgs) Handles btnStepCPUClk.Click
        SYS.CPUTick()
        UpdateMonitor()
    End Sub
    Private Sub btnStepCPU_Click(sender As System.Object, e As System.EventArgs) Handles btnStepCPU.Click
        SYS.CPUInst()
        UpdateMonitor()
    End Sub
    Private Sub btnSoftReset_Click(sender As System.Object, e As System.EventArgs) Handles btnSoftReset.Click
        CPU.Reset()
        UpdateMonitor()
    End Sub
    Private Sub btnHardReset_Click(sender As System.Object, e As System.EventArgs) Handles btnHardReset.Click
        Reset()
    End Sub
#End Region
#Region "   IRQs"
    Private Sub btnNMI_Click(sender As System.Object, e As System.EventArgs) Handles btnNMI.Click
        If SYS.NMI = True Then SYS.NMI = False Else SYS.NMI = True
        UpdateMonitor()
    End Sub
    Private Sub btnIRQ_Click(sender As System.Object, e As System.EventArgs) Handles btnIRQ.Click
        If SYS.IRQ = True Then SYS.IRQ = False Else SYS.IRQ = True
        UpdateMonitor()
    End Sub
#End Region
#End Region

#Region "Timer Functions"
    Private Sub tmrMonitor_Tick(sender As System.Object, e As System.EventArgs) Handles tmrMonitor.Tick
        UpdateMonitor()
    End Sub
    Private Sub tmrSpeed_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSpeed.Tick
        If SYS.Ticks < 1000 Then lblCyclesPerSecond.Text = SYS.Ticks & " Hz"
        If SYS.Ticks >= 1000 Then lblCyclesPerSecond.Text = Math.Round(SYS.Ticks / 1000, 4) & " KHz"
        If SYS.Ticks >= 1000000 Then lblCyclesPerSecond.Text = Math.Round(SYS.Ticks / 1000000, 4) & " MHz"
        SYS.Ticks = 0

        If Not IsNothing(CPU) Then
            If CPU.Ticks < 1000 Then lblCPUSpeed.Text = CPU.Ticks & " Hz"
            If CPU.Ticks >= 1000 Then lblCPUSpeed.Text = Math.Round(CPU.Ticks / 1000, 2) & " KHz"
            If CPU.Ticks >= 1000000 Then lblCPUSpeed.Text = Math.Round(CPU.Ticks / 1000000, 2) & " MHz"
            lblCPU_OPS.Text = CPU.OPs & " Op/s"
            CPU.Ticks = 0
            CPU.OPs = 0
        End If
    End Sub
    Private Sub tmrSpeedControl_Tick(sender As System.Object, e As System.EventArgs) Handles tmrSpeedControl.Tick
        SYS.Cycles = 0
    End Sub
#End Region
    Private Sub Reset()
        SYS.Reset()
        SYS.MaxCPI = nudSpeed.Value * (1111111 / (1000 / tmrSpeedControl.Interval))
        UpdateMonitor()
    End Sub
    Private Sub nudSpeed_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudSpeed.ValueChanged
        If nudSpeed.Value < 0.000001 Then nudSpeed.Value = 0.000001
        Select Case nudSpeed.Value
            Case 0.000001 To 0.000031 : nudSpeed.Increment = 0.000001
            Case 0.000032 To 0.000512 : nudSpeed.Increment = 0.000032
            Case 0.000513 To 0.001024 : nudSpeed.Increment = 0.000512
            Case 0.001024 To 0.01024 : nudSpeed.Increment = 0.001024
            Case 0.01025 To 0.1024 : nudSpeed.Increment = 0.01024
            Case 0.1025 To 1.024 : nudSpeed.Increment = 0.1024
            Case 1.025 To 10.24 : nudSpeed.Increment = 1.024
        End Select

        If Not IsNothing(SYS) Then SYS.MaxCPI = nudSpeed.Value * (1111111 / (1000 / tmrSpeedControl.Interval))
        LogText("CLK : Speed set to " & nudSpeed.Value)
    End Sub

    Private Sub cboMemory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMemory.SelectedIndexChanged
        If cboMemory.SelectedIndex >= 0 And cboMemorySec.SelectedIndex >= 0 And cboMemoryType.SelectedIndex >= 0 Then UpdateMemory()
    End Sub
    Private Sub cboMemorySec_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMemorySec.SelectedIndexChanged
        If cboMemory.SelectedIndex >= 0 And cboMemorySec.SelectedIndex >= 0 And cboMemoryType.SelectedIndex >= 0 Then UpdateMemory()
    End Sub
    Private Sub cboMemoryType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMemoryType.SelectedIndexChanged
        If cboMemory.SelectedIndex >= 0 And cboMemorySec.SelectedIndex >= 0 And cboMemoryType.SelectedIndex >= 0 Then UpdateMemory()
    End Sub

    Public Sub StartVideo()
        If VideoEnabled = False Then
            VideoEnabled = True
            VideoThread = New System.Threading.Thread(AddressOf UpdateVideo)
            VideoThread.IsBackground = True
            VideoThread.Start()
        End If
    End Sub
    Private Sub StopVideo()
        VideoEnabled = False
    End Sub
    Private Sub UpdateVideo()
        Do While VideoEnabled
            VIDEO_LINE()
            picScreen.Image = bmpVideo
        Loop
    End Sub
    Private Sub VIDEO_LINE()
        bmpVideo = New Bitmap(VIC.Pixels, VIC.Lines)
        Dim ShowGrid As Boolean = False
        Dim VideoLine As Integer
        Dim LinePixel As Integer
        For VideoLine = 0 To VIC.Lines - 1
            For LinePixel = 0 To VIC.Pixels - 1
                bmpVideo.SetPixel(LinePixel, VideoLine, Palette(VIC.vBuffer(VideoLine * VIC.Pixels + LinePixel)))
                If ShowGrid Then
                    If VideoLine Mod 8 = 0 Then bmpVideo.SetPixel(LinePixel, VideoLine, Color.White)
                    If LinePixel Mod 8 = 0 Then bmpVideo.SetPixel(LinePixel, VideoLine, Color.White)
                End If
            Next
        Next
    End Sub
End Class
