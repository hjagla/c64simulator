Public Class cls6526
    Private IRQ As Boolean
    Private SYSIRQ As Boolean ' False = SYS IRQ Line, True = SYS NMI Line

#Region "Registers"
    Public PRA As Byte
    Public PRB As Byte
    Public DDRA As Byte
    Public DDRB As Byte
    Public TALO As Byte
    Public TAHI As Byte
    Public TBLO As Byte
    Public TBHI As Byte
    Public TOD1 As Byte
    Public TOD2 As Byte
    Public TOD3 As Byte
    Public TOD4 As Byte
    Public SDR As Byte
    Public ICR_DATA As Byte
    Public ICR_MASK As Byte
    Public CRA As Byte
    Public CRB As Byte
#End Region
#Region "Latches"
    Public LATCH_TAHI As Byte
    Public LATCH_TALO As Byte
    Public LATCH_TBHI As Byte
    Public LATCH_TBLO As Byte
#End Region

    Public Sub New(IRQ As Boolean)
        SYSIRQ = IRQ
        If SYSIRQ = False Then
            LogText("CIA 6526 (IRQ): Initialized")
        Else
            LogText("CIA 6526 (NMI): Initialized")
        End If
    End Sub
    Public Sub Reset()
        PRA = 0 : PRB = 0 : DDRA = 0 : DDRB = 0 : TALO = 0 : TAHI = 0 : TBLO = 0 : TBHI = 0
        TOD1 = 0 : TOD2 = 0 : TOD3 = 0 : TOD4 = 0 : SDR = 0 : ICR_DATA = 0 : ICR_MASK = 0 : CRA = 0 : CRB = 0
        LATCH_TAHI = 0 : LATCH_TALO = 0 : LATCH_TBHI = 0 : LATCH_TBLO = 0
        IRQ = False
        LogText("CIA 6526: Reset")
    End Sub
    Public Sub Tick()
        If SYS.Running = False Then LogText("CIA 6526: Tick")
        CIA_CRA()
        CIA_CRB()

        If SYSIRQ = False Then If IRQ = True Then SYS.IRQ = True Else If IRQ = True Then SYS.NMI = True
    End Sub
    Private Sub CIA_CRA()
        ' A control bit allows the timer to the be started or stopped by the microprocessor at any time.
        ' 0 = Stop Timer, 1 - Start Timer.
        ' This bit is automatically reset when underflow occurs during one-shot mode.
        If CRA And &H1 Then
            If TALO = 0 Then
                TALO = 255
                If TAHI = 0 Then
                    TALO = LATCH_TALO
                    TAHI = LATCH_TAHI
                    If ICR_MASK And &H1 Then
                        ICR_DATA = ICR_DATA Or &H81
                        IRQ = True
                    Else
                        ICR_DATA = ICR_DATA Or &H1
                    End If
                    ' Stop timer if in one shot mode
                    If CRA And &H8 Then CRA = CRA And &HFE
                Else
                    TAHI -= 1
                End If
            Else
                TALO -= 1
            End If
        End If
    End Sub
    Private Sub CIA_CRB()
        ' A control bit allows the timer to the be started or stopped by the microprocessor at any time.
        ' 0 = Stop Timer, 1 - Start Timer.
        ' This bit is automatically reset when underflow occurs during one-shot mode.
        If CRB And &H1 Then
            If TBLO = 0 Then
                TBLO = 255
                If TBHI = 0 Then
                    TBLO = LATCH_TBLO
                    TBHI = LATCH_TBHI
                    If ICR_MASK And &H2 Then
                        ICR_DATA = ICR_DATA Or &H82
                        IRQ = True
                    Else
                        ICR_DATA = ICR_DATA Or &H2
                    End If
                    ' Stop timer if in one shot mode
                    If CRA And &H8 Then CRA = CRA And &HFE
                Else
                    TBHI -= 1
                End If
            Else
                TBLO -= 1
            End If
        End If
    End Sub

#Region "Memory"
    Public Function Data(Address As Integer) As Byte
        Dim Offset As Integer = Address And &HF
        Select Case Offset
            Case &H0 : Data = PRA
            Case &H1 : Data = PRB
            Case &H2 : Data = DDRA
            Case &H3 : Data = DDRB
            Case &H4 : Data = TALO
            Case &H5 : Data = TAHI
            Case &H6 : Data = TBLO
            Case &H7 : Data = TBHI
            Case &H8 : Data = TOD1
            Case &H9 : Data = TOD2
            Case &HA : Data = TOD3
            Case &HB : Data = TOD4
            Case &HC : Data = SDR
            Case &HD : Data = ICR_DATA
            Case &HE : Data = CRA
            Case &HF : Data = CRB
            Case Else : Data = 0
        End Select
    End Function
    Public Function Read(Address As Integer) As Byte
        Read = 0
        Dim Offset As Integer = Address And &HF

        Select Case Offset
            Case &HD : Read = ICR_DATA : ICR_DATA = 0 : IRQ = False
        End Select

        If SYS.Running = False Then LogText("CIA 6526: Read " & Hexed(Offset, 2))
    End Function
    Public Sub Write(Address As Integer, Value As Byte)
        Dim Offset As Integer = Address And &HF
        If SYS.Running = False Then LogText("CIA 6526: Write " & Hexed(Offset, 2) & " Value: " & Hexed(Value, 2))
        Select Case Offset
            Case &H0 : PRA = Value
            Case &H1 : PRB = Value
            Case &H2 : DDRA = Value
            Case &H3 : DDRB = Value
            Case &H4 : LATCH_TALO = Value
            Case &H5
                LATCH_TAHI = Value
                If CRA And &H8 Then
                    TALO = LATCH_TALO : TAHI = LATCH_TAHI
                Else
                    If CRA And &H1 Then
                    Else
                        TALO = LATCH_TALO : TAHI = LATCH_TAHI
                    End If
                    CRA = CRA Or &H1
                End If
            Case &H6 : LATCH_TBLO = Value
            Case &H7
                LATCH_TBHI = Value
                If CRA And &H8 Then
                    TALO = LATCH_TALO : TBHI = LATCH_TBHI
                Else
                    If CRA And &H1 Then
                    Else
                        TALO = LATCH_TALO : TBHI = LATCH_TBHI
                    End If
                End If
            Case &H8 : TOD1 = Value
            Case &H9 : TOD2 = Value
            Case &HA : TOD3 = Value
            Case &HB : TOD4 = Value
            Case &HC : SDR = Value
            Case &HD
                ' Bit 7 = 0: Any bits written with a 1 will be cleared, others are unaffected.
                ' Bit 7 = 1: Any bits written with a 1 will be set, others are unaffected.
                If (Value And &H80) Then
                    ICR_MASK = ICR_MASK Or (Value And &H7F)
                Else
                    ICR_MASK = ICR_MASK And Value
                End If
            Case &HE : CRA = Value
            Case &HF : CRB = Value
        End Select
    End Sub
#End Region

End Class
