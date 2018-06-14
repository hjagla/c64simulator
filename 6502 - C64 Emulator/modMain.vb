Module modMain
#Region "Project Information"
    Public strProgramTitle As String = "C64 Simulator"
    Public strRegistryPath As String = "Software\C64 Simulator"
#End Region

#Region "Simulation Items"
    Public SYS As New clsC64
    Public PLA As New clsPLA
    Public CPU As New cls6502
    Public VIC As New cls656x
    Public SID As New cls6581
    Public CIA1 As New cls6526(False)
    Public CIA2 As New cls6526(True)

    Public RAM As New clsMemory(65536, True)
    Public KERNAL As New clsMemory(8192, False)
    Public BASIC As New clsMemory(8192, False)
    Public CHRGEN As New clsMemory(4096, False)
#End Region
    Public Palette(15) As Color

#Region "Custom Functions"
    Public Function Hexed(Value As Long, Length As Integer) As String
        ' A little code to display Padded Hex Values...
        Return Hex(Value).PadLeft(Length, "0")
    End Function
    Public Function BinaryString(Dec As Long, maxpower As Integer) As String
        BinaryString = ""
        If Dec > 2 ^ maxpower Then
            MsgBox("Number must be no larger than " & Str$(2 ^ maxpower))
            End
        End If
        Dim m
        For m = maxpower - 1 To 0 Step -1
            If Dec And (2 ^ m) Then   ' Use the logical "AND" operator.
                BinaryString &= "1"
            Else
                BinaryString &= "0"
            End If
        Next
    End Function
    Public Sub LogText(Text As String)
        Debug.Print(Text)
    End Sub
#End Region
End Module
