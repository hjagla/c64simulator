Public Class cls6581
    Public Enabled As Boolean = False

    Public V1_FLO As Byte : Public V1_FHI As Byte : Public V1_PLO As Byte
    Public V1_PHI As Byte : Public V1_REG As Byte : Public V1_DLY As Byte
    Public V1_REL As Byte : Public V2_FLO As Byte : Public V2_FHI As Byte
    Public V2_PLO As Byte : Public V2_PHI As Byte : Public V2_REG As Byte
    Public V2_DLY As Byte : Public V2_REL As Byte : Public V3_FLO As Byte
    Public V3_FHI As Byte : Public V3_PLO As Byte : Public V3_PHI As Byte
    Public V3_REG As Byte : Public V3_DLY As Byte : Public V3_REL As Byte
    Public FC_LO As Byte : Public FC_HI As Byte : Public FC_RF As Byte : Public FC_MOD As Byte
    Public POTX As Byte : Public POTY As Byte
    Public OSC3 As Byte : Public ENV3 As Byte

    Public Sub New()
        LogText("SID 6581: Initialized")
    End Sub
    Public Sub Reset()
        V1_FLO = &H0 : V1_FHI = &H0 : V1_PLO = &H0 : V1_PHI = &H0 : V1_REG = &H0 : V1_DLY = &H0 : V1_REL = &H0
        V2_FLO = &H0 : V2_FHI = &H0 : V2_PLO = &H0 : V2_PHI = &H0 : V2_REG = &H0 : V2_DLY = &H0 : V2_REL = &H0
        V3_FLO = &H0 : V3_FHI = &H0 : V3_PLO = &H0 : V3_PHI = &H0 : V3_REG = &H0 : V3_DLY = &H0 : V3_REL = &H0
        FC_LO = &H0 : FC_HI = &H0 : FC_RF = &H0 : FC_MOD = &H0 : POTX = &H0 : POTY = &H0 : OSC3 = &H0 : ENV3 = &H0
        Enabled = True
        LogText("SID 6581: Reset")
    End Sub
    Public Sub Tick()
    End Sub

#Region "Memory"
    Public Function Data(Address As Integer) As Byte
        Dim Offset As Integer = Address And &H1F
        Select Case Offset
            Case &H0 : Data = V1_FLO
            Case &H1 : Data = V1_FHI
            Case &H2 : Data = V1_PLO
            Case &H3 : Data = V1_PHI
            Case &H4 : Data = V1_REG
            Case &H5 : Data = V1_DLY
            Case &H6 : Data = V1_REL
            Case &H7 : Data = V2_FLO
            Case &H8 : Data = V2_FHI
            Case &H9 : Data = V2_PLO
            Case &HA : Data = V2_PHI
            Case &HB : Data = V2_REG
            Case &HC : Data = V2_DLY
            Case &HD : Data = V2_REL
            Case &HE : Data = V3_FLO
            Case &HF : Data = V3_FHI
            Case &H10 : Data = V3_PLO
            Case &H11 : Data = V3_PHI
            Case &H12 : Data = V3_REG
            Case &H13 : Data = V3_DLY
            Case &H14 : Data = V3_REL
            Case &H15 : Data = FC_LO
            Case &H16 : Data = FC_HI
            Case &H17 : Data = FC_RF
            Case &H18 : Data = FC_MOD
            Case &H19 : Data = POTX
            Case &H1A : Data = POTY
            Case &H1B : Data = OSC3
            Case &H1C : Data = ENV3
            Case &H1D : Data = &H0
            Case &H1E : Data = &H0
            Case &H1F : Data = &H0
            Case Else : Data = &H0
        End Select
    End Function
    Public Function Read(Address As Integer) As Byte
        If SYS.Running = False Then LogText("SID 6581: Read " & Hexed(Address, 2))
        Dim Offset As Integer = Address And &H1F
        Select Case Offset
            Case &H0 : Read = V1_FLO
            Case &H1 : Read = V1_FHI
            Case &H2 : Read = V1_PLO
            Case &H3 : Read = V1_PHI
            Case &H4 : Read = V1_REG
            Case &H5 : Read = V1_DLY
            Case &H6 : Read = V1_REL
            Case &H7 : Read = V2_FLO
            Case &H8 : Read = V2_FHI
            Case &H9 : Read = V2_PLO
            Case &HA : Read = V2_PHI
            Case &HB : Read = V2_REG
            Case &HC : Read = V2_DLY
            Case &HD : Read = V2_REL
            Case &HE : Read = V3_FLO
            Case &HF : Read = V3_FHI
            Case &H10 : Read = V3_PLO
            Case &H11 : Read = V3_PHI
            Case &H12 : Read = V3_REG
            Case &H13 : Read = V3_DLY
            Case &H14 : Read = V3_REL
            Case &H15 : Read = FC_LO
            Case &H16 : Read = FC_HI
            Case &H17 : Read = FC_RF
            Case &H18 : Read = FC_MOD
            Case &H19 : Read = POTX
            Case &H1A : Read = POTY
            Case &H1B : Read = OSC3
            Case &H1C : Read = ENV3
            Case &H1D : Read = &H0
            Case &H1E : Read = &H0
            Case &H1F : Read = &H0
            Case Else : Read = &H0
        End Select
    End Function
    Public Sub Write(Address As Integer, Value As Byte)
        If SYS.Running = False Then LogText("SID 6581: Write " & Hexed(Address, 2) & " Value: " & Hexed(Value, 2))
        Dim Offset As Integer = Address And &H1F
        Select Case Offset
            Case &H0 : V1_FLO = Value
            Case &H1 : V1_FHI = Value
            Case &H2 : V1_PLO = Value
            Case &H3 : V1_PHI = Value
            Case &H4 : V1_REG = Value
            Case &H5 : V1_DLY = Value
            Case &H6 : V1_REL = Value
            Case &H7 : V2_FLO = Value
            Case &H8 : V2_FHI = Value
            Case &H9 : V2_PLO = Value
            Case &HA : V2_PHI = Value
            Case &HB : V2_REG = Value
            Case &HC : V2_DLY = Value
            Case &HD : V2_REL = Value
            Case &HE : V3_FLO = Value
            Case &HF : V3_FHI = Value
            Case &H10 : V3_PLO = Value
            Case &H11 : V3_PHI = Value
            Case &H12 : V3_REG = Value
            Case &H13 : V3_DLY = Value
            Case &H14 : V3_REL = Value
            Case &H15 : FC_LO = Value
            Case &H16 : FC_HI = Value
            Case &H17 : FC_RF = Value
            Case &H18 : FC_MOD = Value
        End Select
    End Sub
#End Region
End Class
