Public Class clsC64
    Public Running As Boolean
    Private Thread As System.Threading.Thread

    Public Ticks As Long

    Public MaxCPI As Long
    Public Cycles As Long = 0

    Public IRQ As Boolean
    Public NMI As Boolean
    Public Sub New()
        LogText("C64: Initialized")
    End Sub
    Public Sub Reset()
        KERNAL.Reset()
        BASIC.Reset()
        CHRGEN.Reset()
        KERNAL.Load("roms/kernal.bin", &H0)
        BASIC.Load("roms/basic.bin", &H0)
        CHRGEN.Load("roms/characters.bin", &H0)
        PLA.Reset()
        RAM.Reset()
        VIC.Reset()
        SID.Reset()
        CIA1.Reset()
        CIA2.Reset()
        CPU.Reset()
    End Sub
#Region "Tick Functions"
    Public Sub Tick()
        VIC.Tick()
        Ticks += 1
    End Sub
    Public Sub CPUTick()
        Dim CLKCycle As Integer
        Tick()
        Do Until CLKCycle = 1
            CLKCycle = VIC.Cycle
            Tick()
        Loop
    End Sub
    Public Sub CPUInst()
        CPUTick()
        Do Until CPU.Cycle = 1
            CPUTick()
        Loop
    End Sub
#End Region
#Region "Memory Functions"
    Public Function Data(Address As Integer) As Byte
        Data = PLA.Data(Address)
    End Function
    Public Function Read(Address As Integer) As Byte
        Read = PLA.Read(Address)
    End Function
    Public Sub Write(Address As Integer, Value As Byte)
        PLA.Write(Address, Value)
    End Sub
#End Region
#Region "Threading Functions"
    Public Sub StartClock()
        Running = True
        Thread = New System.Threading.Thread(AddressOf Run)
        Thread.IsBackground = True
        LogText("CLK: Thread Created")
        Thread.Start()
    End Sub
    Public Sub StopClock()
        Running = False
    End Sub
    Private Sub Run()
        LogText("CLK: Thread Started")
        Do While Running
            If Cycles < MaxCPI Then
                Tick()
                Cycles += 1
            Else
                My.Application.DoEvents()
            End If
        Loop
        LogText("CLK: Thread Stopped")
    End Sub
#End Region
End Class
