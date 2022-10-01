VERSION 5.00
Begin {C62A69F0-16DC-11CE-9E98-00AA00574A4F} frm_setting 
   Caption         =   "My Tools"
   ClientHeight    =   3540
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4725
   OleObjectBlob   =   "frm_setting.frx":0000
   StartUpPosition =   2  'CenterScreen
End
Attribute VB_Name = "frm_setting"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Dim MyClass          As New My_Class

Private Sub btn_default_Click()
    Call default
    Call get_data
End Sub

Private Sub btn_encoder_Click()
    Dim CMD5          As New MD5_CLASS
    lbl_infor = CMD5.EncodeBase64(txt_license)
    txt_license_value = lbl_infor
    Set CMD5 = Nothing
End Sub

Private Sub btn_decoder_Click()
    Dim CMD5          As New MD5_CLASS
    lbl_infor = CMD5.DecodeBase64(txt_license)
    txt_license_value = lbl_infor
    Set CMD5 = Nothing
End Sub

Private Sub btn_killer_save_Click()
    Call saving
    MsgBox "Successfuly!", vbInformation, "Setting"
End Sub

Private Sub btn_security_save_Click()
    Call saving
    MsgBox "Successfuly!", vbInformation, "Setting"
End Sub

Private Sub btn_tools_save_Click()
    Call saving
    MsgBox "Successfuly!", vbInformation, "Setting"
End Sub

Private Sub UserForm_Initialize()
    Call Init
End Sub

Sub Init()
    With cbb_security_apply
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
        .AddItem "ActiveSheet"
    End With
    With cbb_killer_name
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
    End With
    With cbb_killer_styles
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
    End With
    With cbb_killer_filter
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
        .AddItem "ActiveSheet"
    End With
    With cbb_killer_validation
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
        .AddItem "ActiveSheet"
    End With
    With cbb_killer_formats
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
        .AddItem "ActiveSheet"
    End With
    With cbb_tools_unhide_sheets
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
    End With
    With cbb_tools_unhide_rows_columns
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
        .AddItem "ActiveSheet"
    End With
    With cbb_tools_select_object
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
        .AddItem "ActiveSheet"
    End With
    With cbb_tools_resize_picture
        .AddItem "Multiple Workbooks"
        .AddItem "Workbook"
        .AddItem "ActiveSheet"
    End With
    
    txt_security_text1.text = "SAMSUNG CONFIDENTIAL"
    txt_security_text2.text = "SAMSUNG SECRET"
    txt_security_text3.text = "SAMSUNG TOP SECRET"
    cbb_security_apply.Value = "Workbook"
    cbb_killer_name.Value = "Workbook"
    cbb_killer_styles.Value = "Workbook"
    cbb_killer_filter.Value = "ActiveSheet"
    cbb_killer_validation.Value = "ActiveSheet"
    cbb_killer_formats.Value = "ActiveSheet"
    cbb_tools_unhide_sheets.Value = "Workbook"
    cbb_tools_unhide_rows_columns.Value = "ActiveSheet"
    cbb_tools_select_object.Value = "ActiveSheet"
    cbb_tools_resize_picture.Value = "ActiveSheet"
    Call get_data
    Call Get_Infor
End Sub

Private Sub saving()
    Dim CMD5          As New MD5_CLASS
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text1", CMD5.EncodeBase64(txt_security_text1.text)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text2", CMD5.EncodeBase64(txt_security_text2.text)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text3", CMD5.EncodeBase64(txt_security_text3.text)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Apply", CMD5.EncodeBase64(cbb_security_apply.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Name", CMD5.EncodeBase64(cbb_killer_name.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Styles", CMD5.EncodeBase64(cbb_killer_styles.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Filter", CMD5.EncodeBase64(cbb_killer_filter.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Validation", CMD5.EncodeBase64(cbb_killer_validation.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Formats", CMD5.EncodeBase64(cbb_killer_formats.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Unhide_Sheets", CMD5.EncodeBase64(cbb_tools_unhide_sheets.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Unhide_Rows_Columns", CMD5.EncodeBase64(cbb_tools_unhide_rows_columns.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Select_Object", CMD5.EncodeBase64(cbb_tools_select_object.Value)
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Resize_Picture", CMD5.EncodeBase64(cbb_tools_resize_picture.Value)
    Set CMD5 = Nothing
'    MsgBox "Successfuly!", vbInformation, "Default"
End Sub

Sub default()
    Dim CMD5          As New MD5_CLASS
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text1", CMD5.EncodeBase64("SAMSUNG CONFIDENTIAL")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text2", CMD5.EncodeBase64("SAMSUNG SECRET")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text3", CMD5.EncodeBase64("SAMSUNG TOP SECRET")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Apply", CMD5.EncodeBase64("Workbook")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Name", CMD5.EncodeBase64("Workbook")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Styles", CMD5.EncodeBase64("Workbook")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Filter", CMD5.EncodeBase64("ActiveSheet")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Validation", CMD5.EncodeBase64("ActiveSheet")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Formats", CMD5.EncodeBase64("ActiveSheet")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Unhide_Sheets", CMD5.EncodeBase64("Workbook")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Unhide_Rows_Columns", CMD5.EncodeBase64("ActiveSheet")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Select_Object", CMD5.EncodeBase64("ActiveSheet")
    CMD5.RegKeySave "HKCU\Software\OfficelTools\Resize_Picture", CMD5.EncodeBase64("ActiveSheet")
    Set CMD5 = Nothing
    MsgBox "Successfuly!", vbInformation, "Default"
End Sub

Sub get_data()
    Dim CMD5          As New MD5_CLASS
    
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text1") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text1", CMD5.EncodeBase64("SAMSUNG CONFIDENTIAL")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text2") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text2", CMD5.EncodeBase64("SAMSUNG SECRET")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text3") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Text3", CMD5.EncodeBase64("SAMSUNG TOP SECRET")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Apply") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Security_Apply", CMD5.EncodeBase64("Workbook")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Name") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Name", CMD5.EncodeBase64("Workbook")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Styles") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Styles", CMD5.EncodeBase64("Workbook")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Filter") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Filter", CMD5.EncodeBase64("ActiveSheet")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Validation") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Validation", CMD5.EncodeBase64("ActiveSheet")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Formats") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Killer_Formats", CMD5.EncodeBase64("ActiveSheet")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Unhide_Sheets") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Unhide_Sheets", CMD5.EncodeBase64("Workbook")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Unhide_Rows_Columns") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Unhide_Rows_Columns", CMD5.EncodeBase64("ActiveSheet")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Select_Object") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Select_Object", CMD5.EncodeBase64("ActiveSheet")
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Resize_Picture") = False Then
        CMD5.RegKeySave "HKCU\Software\OfficelTools\Resize_Picture", CMD5.EncodeBase64("ActiveSheet")
    End If
    
    '__________________________________________________________________________________________________________
    
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text1") = True Then
        txt_security_text1.text = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Text1"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text2") = True Then
        txt_security_text2.text = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Text2"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text3") = True Then
        txt_security_text3.text = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Text3"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Apply") = True Then
        cbb_security_apply.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Apply"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Name") = True Then
        cbb_killer_name.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Name"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Styles") = True Then
        cbb_killer_styles.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Styles"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Filter") = True Then
        cbb_killer_filter.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Filter"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Validation") = True Then
        cbb_killer_validation.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Validation"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Formats") = True Then
        cbb_killer_formats.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Formats"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Unhide_Sheets") = True Then
        cbb_tools_unhide_sheets.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Unhide_Sheets"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Unhide_Rows_Columns") = True Then
        cbb_tools_unhide_rows_columns.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Unhide_Rows_Columns"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Select_Object") = True Then
        cbb_tools_select_object.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Select_Object"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Resize_Picture") = True Then
        cbb_tools_resize_picture.Value = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Resize_Picture"))
    End If
    Set MyClass = Nothing
    '__________________________________________________________________________________________________________

    Set CMD5 = Nothing
End Sub

Sub Get_Infor()
On Error GoTo trycatch
    Dim CMD5          As New MD5_CLASS
    Dim myRegKey As String
    Dim myValue As String
    Dim myIP As String, IP As String, infor As String
    Dim myDate As String, getDate As String
    Dim get_value As Integer
    Dim Expiration As Integer

        myRegKey = CMD5.DecodeBase64("SEtDVVxTb2Z0d2FyZVxPZmZpY2VsVG9vbHNcU2VyaWFs")
        myIP = CMD5.EncodeBase64(CMD5.EncodeBase64(MD5Hash(Left(GetIPAddress, InStr(GetIPAddress, ",") - 1) & "tnd")))
        IP = Left(GetIPAddress, InStr(GetIPAddress, ",") - 1)
        If RegKeyExists(myRegKey) = True Then
            myValue = CMD5.DecodeBase64(RegKeyRead(myRegKey))
            myDate = CMD5.DecodeBase64(CMD5.DecodeBase64(CMD5.DecodeBase64(Replace(myValue, myIP, ""))))
            getDate = Mid(myDate, InStr(myDate, "e ") + 2, 10)
            Expiration = Format(Format(getDate, "dd/mm/yyyy"), 0) - Format(Date, 0)
            If Expiration <= 0 Or getDate = "" Then
                infor = ("Love_Novel" & vbCrLf & _
                        "Please Registry!" _
                        & vbCrLf & "IP: " & IP)
            Else: infor = ("Love_Novel" & vbCrLf & _
                        "The remaining usage time is " & Expiration & " days!" _
                        & vbCrLf & "Expiration Date: " & getDate _
                        & vbCrLf & "Hihe" & ": " & IP)
            End If
        Else: infor = ("Love_Novel" & vbCrLf & _
                        "Please Registry!" _
                        & vbCrLf & "IP: " & IP)
        End If
        lbl_infor = infor
        Set CMD5 = Nothing
    Exit Sub
trycatch:
'MsgBox "OK"
End Sub

'MD5
Public Function MD5Hash(ByVal strText As String) As String
Dim CMD5          As New MD5_CLASS
Dim strSignature  As String
    strSignature = CMD5.MD5(strText)
    MD5Hash = strSignature
    Set CMD5 = Nothing
End Function

'GetIPAddress
Function GetIPAddress()
    Const strComputer As String = "."   ' Computer name. Dot means local computer
    Dim objWMIService, IPConfigSet, IPConfig, IPAddress, i
    Dim strIPAddress As String
    ' Connect to the WMI service
    Set objWMIService = GetObject("winmgmts:" _
        & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
    ' Get all TCP/IP-enabled network adapters
    Set IPConfigSet = objWMIService.ExecQuery _
        ("Select * from Win32_NetworkAdapterConfiguration Where IPEnabled=TRUE")
    ' Get all IP addresses associated with these adapters
    For Each IPConfig In IPConfigSet
        IPAddress = IPConfig.IPAddress
        If Not IsNull(IPAddress) Then
            strIPAddress = strIPAddress & Join(IPAddress, ", ")
        End If
    Next
    GetIPAddress = strIPAddress
End Function
