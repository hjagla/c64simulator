Public Class clsPLA
    Public Sub New()
        LogText("PLA: Initialized")
    End Sub
    Public Sub Reset()
        LogText("PLA: Reset")
    End Sub
    Public Function Data(Address As Integer) As Byte
        Data = 0
        Select Case Address
            Case &HA000 To &HBFFF
                If (CPU.IO And &H1) Then
                    If (CPU.IO And &H2) Then
                        Data = BASIC.Data(Address And BASIC.Data.Length - 1)
                    Else
                        Data = RAM.Data(Address And RAM.Data.Length - 1)
                    End If
                Else
                    Data = RAM.Data(Address And RAM.Data.Length - 1)
                End If
                'Case &HD000 To &HD3FF : Data = VIC.Read(Address)
            Case &HD400 To &HD7FF : Data = SID.Read(Address)
            Case &HDC00 To &HDCFF : Data = CIA1.Data(Address)
            Case &HDD00 To &HDDFF : Data = CIA2.Data(Address)
            Case &HE000 To &HFFFF : If (CPU.IO And &H2) Then Data = KERNAL.Data(Address And KERNAL.Data.Length - 1) Else Data = RAM.Data(Address And RAM.Data.Length - 1)
            Case Else : Data = RAM.Data(Address And RAM.Data.Length - 1)
        End Select
    End Function
    Public Function Read(Address As Integer) As Byte
        Read = 0
        Select Case Address
            Case &HA000 To &HBFFF
                If (CPU.IO And &H1) Then
                    If (CPU.IO And &H2) Then
                        Read = BASIC.Read(Address)
                    Else
                        Read = RAM.Read(Address)
                    End If
                Else
                    Read = RAM.Read(Address)
                End If
            Case &HD000 To &HD3FF : Read = VIC.Read(Address)
            Case &HD400 To &HD7FF : Read = SID.Read(Address)
            Case &HDC00 To &HDCFF : Read = CIA1.Read(Address)
            Case &HDD00 To &HDDFF : Read = CIA2.Read(Address)
            Case &HE000 To &HFFFF : If (CPU.IO And &H2) Then Read = KERNAL.Read(Address) Else Read = RAM.Read(Address)
            Case Else : Read = RAM.Read(Address)
        End Select
    End Function
    Public Sub Write(Address As Integer, Value As Byte)
        Select Case Address
            Case &HD000 To &HD3FF : VIC.Write(Address, Value) ' VIC-II
            Case &HD400 To &HD7FF : SID.Write(Address, Value) ' SID
            Case &HDB00 To &HDBFF : RAM.Write(Address, Value) ' Color Ram
            Case &HDC00 To &HDCFF : CIA1.Write(Address, Value) ' CIA 1
            Case &HDD00 To &HDDFF : CIA2.Write(Address, Value) ' CIA 2
            Case &HDE00 To &HDEFF : RAM.Write(Address, Value) ' Future I/O
            Case &HDF00 To &HDFFF : RAM.Write(Address, Value) ' Future I/O
            Case Else : RAM.Write(Address, Value)
        End Select
    End Sub
End Class
