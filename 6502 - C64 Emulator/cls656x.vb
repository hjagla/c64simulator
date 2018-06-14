Public Class cls656x
    Public Enabled As Boolean = False

    Public Cycle As Integer = 1
    Public Cycles As Integer = 8

    Private Model As String = "6567R8"

    Private Line As Integer = 0
    Public Lines As Integer = 263
    Private VisibleLines As Integer = 235
    Private CyclesPerLine As Integer = 65
    Private VisiblePixelsPerLine As Integer = 418

    Private Pixel As Integer = 0
    Public Pixels As Integer = CyclesPerLine * 8

    Public vBuffer(Lines * Pixels) As Byte

    Public IRQ As Boolean = False

#Region "Registers"
    Public M0X As Byte : Public M0Y As Byte : Public M1X As Byte : Public M1Y As Byte
    Public M2X As Byte : Public M2Y As Byte : Public M3X As Byte : Public M3Y As Byte
    Public M4X As Byte : Public M4Y As Byte : Public M5X As Byte : Public M5Y As Byte
    Public M6X As Byte : Public M6Y As Byte : Public M7X As Byte : Public M7Y As Byte
    Public MSB As Byte : Public CR1 As Byte : Public RAS As Byte : Public LPX As Byte
    Public LPY As Byte : Public SPE As Byte : Public CR2 As Byte : Public SPY As Byte
    Public MEM As Byte : Public INT As Byte : Public INE As Byte : Public SDP As Byte
    Public SPM As Byte : Public SPX As Byte : Public SSP As Byte : Public SDC As Byte
    Public BOC As Byte : Public BC0 As Byte : Public BC1 As Byte : Public BC2 As Byte
    Public BC3 As Byte : Public MM0 As Byte : Public MM1 As Byte : Public CP0 As Byte
    Public CP1 As Byte : Public CP2 As Byte : Public CP3 As Byte : Public CP4 As Byte
    Public CP5 As Byte : Public CP6 As Byte : Public CP7 As Byte
#End Region

    Public Sub New()
        'Model = "6569"
        LogText("VIC " & Model & ": Initialized")
    End Sub
    Public Sub Reset()
        Select Case Model
            Case "6567R56A"
                Lines = 262
                Pixels = 64 * 8
            Case "6567R8"
                Lines = 263
                Pixels = 65 * 8
            Case "6569"
                Lines = 312
                Pixels = 63 * 8
        End Select

        ReDim vBuffer(Lines * Pixels)

        Pixel = 0
        Line = 0

        M0X = &H0 : M0Y = &H0 : M1X = &H0 : M1Y = &H0 : M2X = &H0 : M2Y = &H0 : M3X = &H0 : M3Y = &H0 : M4X = &H0 : M4Y = &H0
        M5X = &H0 : M5Y = &H0 : M6X = &H0 : M6Y = &H0 : M7X = &H0 : M7Y = &H0 : MSB = &H0 : CR1 = &H0 : RAS = &H0 : LPX = &H0
        LPY = &H0 : SPE = &H0 : CR2 = &HC0 : SPY = &H0 : MEM = &H1 : INT = &H1 : INE = &H70 : SDP = &HF0 : SPM = &H0 : SPX = &H0
        SSP = &H0 : SSP = &H0 : SDC = &H0
        BOC = &HF0 : BC0 = &HF0 : BC1 = &HF0 : BC2 = &HF0 : BC3 = &HF0 : MM0 = &HF0 : MM1 = &HF0
        CP0 = &HF0 : CP1 = &HF0 : CP2 = &HF0 : CP3 = &HF0 : CP4 = &HF0 : CP5 = &HF0 : CP6 = &HF0 : CP7 = &HF0

        LogText("VIC " & Model & ": Reset")


    End Sub
    Public Sub Tick()
        If SYS.Running = False Then LogText("VIC " & Model & " Cycle: " & Cycle & "/" & Cycles)
        Dim PixelOffset As Integer = 0
        Dim VLineOffset As Integer = 0
        'If (Pixel < PixelOffset) Or (Line < VLineOffset) Or (Pixel >= 40 * 8 + PixelOffset) Or (Line >= 25 * 8 + VLineOffset) Then vBuffer((Line * Pixels) + Pixel) = SYS.Read(&HD020) And &HF
        If (Pixel >= PixelOffset And Pixel < 40 * 8 + PixelOffset) And (Line >= VLineOffset And Line < 25 * 8 + VLineOffset) Then
            Dim xoffset = Pixel - PixelOffset
            Dim yoffset = Line - VLineOffset

            ' Expanded for Debugging
            Dim LineOffset As Integer = (yoffset \ 8) * 40
            Dim ByteOffset As Integer = xoffset \ 8
            Dim MemOffset As Integer = &H400 + LineOffset + ByteOffset
            Dim MemByte As Byte = RAM.Data(MemOffset)
            'Debug.Print("Line: " & yoffset & " Pixel: " & xoffset & " Line Offset: " & LineOffset & " Byte Offset: " & ByteOffset & " Mem Offset: " & Hexed(MemOffset, 4) & " Mem Byte: " & Hexed(MemByte, 2))

            Dim CHROffset As Integer = MemByte * 8
            Dim CHRLineOffset As Integer = yoffset Mod 8
            Dim CHRByteOffset As Integer = CHROffset + CHRLineOffset
            Dim CHRByte As Byte = CHRGEN.Data(CHRByteOffset)
            'Debug.Print("CHR Offset: " & CHROffset & " CHR Line: " & CHRLineOffset & " Mem Offset: " & CHRByteOffset & " CHR Byte: " & Hexed(CHRByte, 2))

            Dim Background As Byte = SYS.Read(&HD021) And &HF
            Dim Foreground As Byte = SYS.Read(&HD800 + (LineOffset) + ByteOffset) And &HF

            ' This is messy... fix later.
            Select Case (xoffset Mod 8)
                Case 0 : If CHRByte And &H80 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
                Case 1 : If CHRByte And &H40 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
                Case 2 : If CHRByte And &H20 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
                Case 3 : If CHRByte And &H10 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
                Case 4 : If CHRByte And &H8 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
                Case 5 : If CHRByte And &H4 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
                Case 6 : If CHRByte And &H2 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
                Case 7 : If CHRByte And &H1 Then vBuffer((Line * Pixels) + Pixel) = Foreground Else vBuffer((Line * Pixels) + Pixel) = Background
            End Select
        End If

        ' Increment Pixel/Line
        If Pixel = Pixels - 1 Then
            Pixel = 0
            If Line = Lines - 1 Then Line = 0 Else Line += 1
        Else
            Pixel += 1
        End If

        RAS = Line And &HFF : If Line And &H100 Then CR1 = CR1 Or &H80 Else CR1 = CR1 And Not &H80

        ' Once VIC is done do 02 Clock?
        If Cycle = Cycles Then
            CPU.Tick()
            CIA1.Tick()
            CIA2.Tick()
            SID.Tick()
            Cycle = 0
        End If
        Cycle += 1

    End Sub
#Region "Memory"
    Public Function Read(Address As Integer, Optional Debug As Boolean = False) As Byte
        Read = 0
        Dim Offset As Integer = Address And &H3F
        If SYS.Running = False And Debug = False Then LogText("VIC " & Model & ": Read " & Hexed(Offset, 2))
        Select Case Offset
            Case &H0 : Read = M0X
            Case &H1 : Read = M0Y
            Case &H2 : Read = M1X
            Case &H3 : Read = M1Y
            Case &H4 : Read = M2X
            Case &H5 : Read = M2Y
            Case &H6 : Read = M3X
            Case &H7 : Read = M3Y
            Case &H8 : Read = M4X
            Case &H9 : Read = M4Y
            Case &HA : Read = M5X
            Case &HB : Read = M5Y
            Case &HC : Read = M6X
            Case &HD : Read = M6Y
            Case &HE : Read = M7X
            Case &HF : Read = M7Y
            Case &H10 : Read = MSB
            Case &H11 : Read = CR1
            Case &H12 : Read = RAS
            Case &H13 : Read = LPX
            Case &H14 : Read = LPY
            Case &H15 : Read = SPE
            Case &H16 : Read = CR2 Or &HC0
            Case &H17 : Read = SPY
            Case &H18 : Read = MEM Or &H1
            Case &H19 : Read = INT Or &H70
            Case &H1A : Read = INE Or &HF0
            Case &H1B : Read = SDP
            Case &H1C : Read = SPM
            Case &H1D : Read = SPX
            Case &H1E : Read = SSP : If Debug = False Then SSP = &H0
            Case &H1F : Read = SDC : If Debug = False Then SDC = &H0
            Case &H20 : Read = BOC Or &HF0
            Case &H21 : Read = BC0 Or &HF0
            Case &H22 : Read = BC1 Or &HF0
            Case &H23 : Read = BC2 Or &HF0
            Case &H24 : Read = BC3 Or &HF0
            Case &H25 : Read = MM0 Or &HF0
            Case &H26 : Read = MM1 Or &HF0
            Case &H27 : Read = CP0 Or &HF0
            Case &H28 : Read = CP1 Or &HF0
            Case &H29 : Read = CP2 Or &HF0
            Case &H2A : Read = CP3 Or &HF0
            Case &H2B : Read = CP4 Or &HF0
            Case &H2C : Read = CP5 Or &HF0
            Case &H2D : Read = CP6 Or &HF0
            Case &H2E : Read = CP7 Or &HF0
            Case &H2F : Read = &HFF
            Case &H30 To &H3F : Read = &HFF
        End Select
    End Function
    Public Sub Write(Address As Integer, Value As Byte)
        Dim Offset As Integer = Address And &H3F
        If SYS.Running = False Then LogText("VIC " & Model & ": Write " & Hexed(Offset, 2) & " Value: " & Hexed(Value, 2))
        Select Case Offset
            Case &H0 : M0X = Value
            Case &H1 : M0Y = Value
            Case &H2 : M1X = Value
            Case &H3 : M1Y = Value
            Case &H4 : M2X = Value
            Case &H5 : M2Y = Value
            Case &H6 : M3X = Value
            Case &H7 : M3Y = Value
            Case &H8 : M4X = Value
            Case &H9 : M4Y = Value
            Case &HA : M5X = Value
            Case &HB : M5Y = Value
            Case &HC : M6X = Value
            Case &HD : M6Y = Value
            Case &HE : M7X = Value
            Case &HF : M7Y = Value
            Case &H10 : MSB = Value
            Case &H11 : CR1 = Value
            Case &H12 : RAS = Value
            Case &H13 : LPX = Value
            Case &H14 : LPY = Value
            Case &H15 : SPE = Value
            Case &H16 : CR2 = Value Or &HC0
            Case &H17 : SPY = Value
            Case &H18 : MEM = Value Or &H1
            Case &H19 : INT = Value Or &H70
            Case &H1A : INE = Value Or &HF0
            Case &H1B : SDP = Value
            Case &H1C : SPM = Value
            Case &H1D : SPX = Value
                'Case &H1E : SSP = Value
                'Case &H1F : SDC = Value
            Case &H20 : BOC = Value Or &HF0
            Case &H21 : BC0 = Value Or &HF0
            Case &H22 : BC1 = Value Or &HF0
            Case &H23 : BC2 = Value Or &HF0
            Case &H24 : BC3 = Value Or &HF0
            Case &H25 : MM0 = Value Or &HF0
            Case &H26 : MM1 = Value Or &HF0
            Case &H27 : CP0 = Value Or &HF0
            Case &H28 : CP1 = Value Or &HF0
            Case &H29 : CP2 = Value Or &HF0
            Case &H2A : CP3 = Value Or &HF0
            Case &H2B : CP4 = Value Or &HF0
            Case &H2C : CP5 = Value Or &HF0
            Case &H2D : CP6 = Value Or &HF0
            Case &H2E : CP7 = Value Or &HF0
        End Select
    End Sub
#End Region
End Class
