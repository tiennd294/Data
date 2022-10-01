Attribute VB_Name = "My_Tools"
Option Explicit
Dim MyClass          As New My_Class
Dim SDV As String
Dim npicture As Integer, nbegin As Integer, nend As Integer
Dim Killer_Styles As String
Dim Killer_Name As String
Dim time_bg As Date

'*************************************************SETTING*************************************************
Sub My_Seting()
    If Get_Actives Then
        frm_setting.Show vbModeless
    End If
End Sub
'*************************************************SETTING*************************************************


'***************************************************SDV***************************************************
Sub SDV_CONFIDENTIAL()
    Call get_data
    SDV = "SAMSUNG CONFIDENTIAL"
    If MyClass.Security_Text1 <> "" Then SDV = MyClass.Security_Text1
    Call SDV_Securitys(SDV)
End Sub

Sub SDV_SECRET()
    If Get_Actives Then
        Call get_data
        SDV = "SAMSUNG SECRET"
        If MyClass.Security_Text2 <> "" Then SDV = MyClass.Security_Text2
        Call SDV_Securitys(SDV)
    End If
End Sub

Sub SDV_TOP_SECRET()
    If Get_Actives Then
        Call get_data
        SDV = "SAMSUNG TOP SECRET"
        If MyClass.Security_Text3 <> "" Then SDV = MyClass.Security_Text3
        Call SDV_Securitys(SDV)
    End If
End Sub

Sub SDV_DELETE()
'    If Get_Actives Then
        Call SDV_Killer
'    End If
End Sub

Function SDV_Securitys(txt As String)
On Error GoTo trycatch
    Call SDV_Killer
    Dim wb As Workbook
    Dim ws As Worksheet
    If MyClass.Security_Apply <> "Workbook" And MyClass.Security_Apply <> "Multiple Workbooks" Then
        If ActiveSheet.ProtectContents = False Then Call SDV_Security(txt, ActiveSheet.Name, "")
    End If
    If MyClass.Security_Apply = "Workbook" Then
        For Each ws In ActiveWorkbook.Worksheets
            If ws.ProtectContents = False Then Call SDV_Security(txt, ws.Name, "")
        Next ws
    End If
    If MyClass.Security_Apply = "Multiple Workbooks" Then
        For Each wb In Workbooks
            For Each ws In wb.Worksheets
                If ws.ProtectContents = False Then Call SDV_Security(txt, ws.Name, wb.Name)
            Next ws
        Next wb
    End If
trycatch:
End Function

Function SDV_Security(txt As String, nsheet As String, nbook As String)
On Error GoTo trycatch
    Dim sh As Shape
    If nbook = "" Then Set sh = Worksheets(nsheet).Shapes.AddShape(1, 5, 5, 200, 24)
    If nbook <> "" Then Set sh = Workbooks(nbook).Worksheets(nsheet).Shapes.AddShape(1, 5, 5, 200, 24)
    sh.TextFrame.Characters.text = txt
    sh.TextFrame.Characters.Font.Bold = True
    sh.TextFrame.Characters.Font.Color = RGB(255, 0, 0)
    sh.TextFrame.Characters.Font.Size = 16
    sh.TextFrame.Characters.Font.Name = "Calibri"
    sh.Fill.Transparency = 1
    sh.Line.ForeColor.RGB = RGB(255, 0, 0)
    sh.Line.Weight = 2
    sh.TextFrame.AutoSize = msoAutoSizeShapeToFitText
    sh.Name = txt
trycatch:
End Function

Function SDV_Killer()
    Call get_data
    Dim wb As Workbook
    Dim ws As Worksheet
    If MyClass.Security_Apply <> "Workbook" And MyClass.Security_Apply <> "Multiple Workbooks" Then
        If ActiveSheet.ProtectContents = False Then Call SDV_Kill(ActiveSheet.Shapes)
    End If
    If MyClass.Security_Apply = "Workbook" Then
        For Each ws In ActiveWorkbook.Worksheets
            If ws.ProtectContents = False Then Call SDV_Kill(ws.Shapes)
        Next ws
    End If
    If MyClass.Security_Apply = "Multiple Workbooks" Then
        For Each wb In Workbooks
            For Each ws In wb.Worksheets
                If ws.ProtectContents = False Then Call SDV_Kill(ws.Shapes)
            Next ws
        Next wb
    End If
End Function

Function SDV_Kill(shp As Shapes)
    Dim sh As Shape
    For Each sh In shp
        If InStr(1, sh.Name, "SAMSUNG") Or InStr(1, sh.Name, "Rectangle") Then
            With sh.TextFrame.Characters
                If .text = MyClass.Security_Text1 Or _
                .text = MyClass.Security_Text2 Or _
                .text = MyClass.Security_Text3 Or _
                .text = "SAMSUNG CONFIDENTIAL" Or _
                .text = "SAMSUNG SECRET" Or _
                .text = "SAMSUNG TOP SECRET" Then sh.Delete
            End With
        End If
    Next sh
End Function

'***************************************************SDV***************************************************


'***********************************************Unhide-Sheets*********************************************
Sub Unhide_Multiple_Sheets()
On Error Resume Next
    If Get_Actives Then
        Call get_data
        Dim wb As Workbook
        Dim ws As Worksheet
        If MyClass.Tools_Unhide_Sheets = "Multiple Workbooks" Then
            For Each wb In Workbooks
                For Each ws In wb.Worksheets
                    ws.Visible = xlSheetVisible
                Next ws
            Next wb
        Else
            For Each ws In ActiveWorkbook.Worksheets
                ws.Visible = xlSheetVisible
            Next ws
        End If
    End If
On Error GoTo 0
End Sub

'***********************************************Unhide-Sheets*********************************************

'********************************************Unhide-Rows-Columns******************************************
Sub Unhide_All_Rows_Columns()
On Error Resume Next
    If Get_Actives Then
        Call get_data
        Dim wb As Workbook
        Dim ws As Worksheet
        If MyClass.Tools_Unhide_Rows_Columns <> "Workbook" And MyClass.Tools_Unhide_Rows_Columns <> "Multiple Workbooks" Then
            Columns.EntireColumn.Hidden = False
            Rows.EntireRow.Hidden = False
        End If
        If MyClass.Tools_Unhide_Rows_Columns = "Workbook" Then
            For Each ws In Worksheets
                ws.Columns.EntireColumn.Hidden = False
                ws.Rows.EntireRow.Hidden = False
            Next ws
        End If
        If MyClass.Tools_Unhide_Rows_Columns = "Multiple Workbooks" Then
            For Each wb In Workbooks
                For Each ws In wb.Worksheets
                    ws.Columns.EntireColumn.Hidden = False
                    ws.Rows.EntireRow.Hidden = False
                Next ws
            Next wb
        End If
    End If
On Error GoTo 0
End Sub

'********************************************Unhide-Rows-Columns******************************************

'***********************************************Select-Object*********************************************
Public Sub Select_Object()
On Error GoTo trycatch
    If Get_Actives Then
        Call get_data
        If MyClass.Tools_Select_Object = "Multiple Workbooks" Then Call Select_Object_in_Workbooks
        If MyClass.Tools_Select_Object = "Workbook" Then Call Select_Object_in_Workbook
        If MyClass.Tools_Select_Object <> "Workbook" And MyClass.Tools_Select_Object <> "Multiple Workbooks" Then Call Select_Object_in_Sheet
    End If
    Exit Sub
trycatch:
End Sub

Function Select_Object_in_Sheet()
On Error Resume Next
    If TypeName(Selection) = "Range" Then
        If Selection.Rows.Count * Selection.Columns.Count > 1 Then
            Dim str_range As String
            str_range = Trim(Replace(Selection.Address, "$", ""))
            Call Type_Object("", str_range)
        Else
            Call Type_Object("", "")
        End If
    Else
        If Selection.ShapeRange.Count > 1 Then
            Call Type_Object("", "")
        Else
            Dim str_name As String
            str_name = Trim(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Selection.Name, "0", ""), "1", ""), "2", ""), "3", ""), "4", ""), "5", ""), "6", ""), "7", ""), "8", ""), "9", ""))
            Call Type_Object(str_name, "")
        End If
    End If
On Error GoTo 0
End Function

Function Type_Object(str_obj As String, str_range As String)
On Error Resume Next
    Dim myobject As String
    If str_obj <> "" Then
        myobject = InputBox("Select Object", "Object", str_obj)
    Else
        If str_range <> "" Then myobject = InputBox("Select Object", "Object", "Select All")
        If str_range = "" Then myobject = InputBox("Select Object", "Object", "Picture")
    End If
    If myobject <> "" Then
        Application.ScreenUpdating = False
        Dim tp As Shape
        For Each tp In ActiveSheet.Shapes
            If str_range <> "" Then
                If Not Intersect(Range(str_range), tp.TopLeftCell) Is Nothing Then
                    If myobject <> "Select All" Then
                        If InStr(1, tp.Name, myobject) Then tp.Select False
                    Else
                        tp.Select False
                    End If
                End If
            Else
                If InStr(1, tp.Name, myobject) Then tp.Select False
            End If
        Next
        Application.ScreenUpdating = True
    End If
On Error GoTo 0
End Function


Function Select_Object_in_Workbook()
On Error Resume Next
    Dim myobject As String
    Dim str_name As String
    str_name = "Picture"
    If TypeName(Selection) <> "Range" Then
        If Selection.ShapeRange.Count = 1 Then str_name = Trim(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Selection.Name, "0", ""), "1", ""), "2", ""), "3", ""), "4", ""), "5", ""), "6", ""), "7", ""), "8", ""), "9", ""))
    End If
    myobject = InputBox("Select Object", "Object", str_name)
    If myobject <> "" Then
        Application.ScreenUpdating = False
        Dim ws As Worksheet
        Dim tp As Shape
        For Each ws In Worksheets
            For Each tp In ws.Shapes
                If InStr(1, tp.Name, myobject) Then tp.Select False
            Next tp
        Next ws
        Application.ScreenUpdating = True
    End If
On Error GoTo 0
End Function

Function Select_Object_in_Workbooks()
On Error Resume Next
    Dim myobject As String
    Dim str_name As String
    str_name = "Picture"
    If TypeName(Selection) <> "Range" Then
        If Selection.ShapeRange.Count = 1 Then str_name = Trim(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Selection.Name, "0", ""), "1", ""), "2", ""), "3", ""), "4", ""), "5", ""), "6", ""), "7", ""), "8", ""), "9", ""))
    End If
    myobject = InputBox("Select Object", "Object", str_name)
    If myobject <> "" Then
        Application.ScreenUpdating = False
        Dim wb As Workbook
        Dim ws As Worksheet
        Dim tp As Shape
        For Each wb In Workbooks
            For Each ws In wb.Worksheets
                For Each tp In ws.Shapes
                    If InStr(1, tp.Name, myobject) Then tp.Select False
                Next tp
            Next ws
        Next wb
        Application.ScreenUpdating = True
    End If
On Error GoTo 0
End Function
'***********************************************Select-Object*********************************************


'************************************************Resize-Picture*******************************************

'*****************************************************Basic***********************************************
Function ResizePicture()
On Error GoTo trycatch
'    Call get_data
'    MsgBox MyClass.Tools_Resize_Picture
    If Get_Actives = True Then
    Dim tp As Shape, C As Range
    Dim total As Integer, s1 As Integer
    total = 0
'    MsgBox Get_Actives
        For Each tp In ActiveSheet.Shapes
            If tp.Type = msoPicture Then total = total + 1 'get Total Picture
        Next
        If total > 0 Then s1 = msg_resize_basic(total, "Pictures")
        If total <= 0 Then MsgBox "No Pictures!", vbInformation, "Resize Picture False!"
        Call MovePicture(s1, total)
    End If
    Exit Function
trycatch: Application.ScreenUpdating = True
End Function

Function MovePicture(customs As Integer, total As Integer)
    Dim a1 As Integer, s1 As Integer
    Dim p As Shape, C As Range
    time_bg = Now
    If customs = vbYes Then
        a1 = 0
        s1 = Application.InputBox("Enter Number Picture", "Total Images Resize", "10", Type:=1)
        time_bg = Now
        For Each p In ActiveSheet.Shapes
            If p.Type = msoPicture And p.Rotation > 0 And a1 < s1 Then
            Application.ScreenUpdating = False
                Set C = p.TopLeftCell
                p.Placement = xlMoveAndSize
                p.LockAspectRatio = msoFalse
                If p.Rotation > 0 Then
                    p.Cut
                    Range(C.Address).PasteSpecial
                    Application.CutCopyMode = False
                End If
'                Call MovePictureDefault
                a1 = a1 + 1
            Application.ScreenUpdating = True
            End If
        Next
        Call MovePictureDefault
'        MsgBox "Resize " & a1 & " Picture Successfuly!", vbInformation, "Resize Picture"
    End If
    If customs = vbNo Then
        Call MovePictureDefault
    End If
'    If customs = vbNo Or customs = vbYes Then
'        MsgBox "Resize " & a1 & " Picture Successfuly!", vbInformation, "Resize Picture"
'    End If
End Function

Function MovePictureDefault()
    Dim a1 As Integer, s1 As Integer
    Dim p As Shape, C As Range
        a1 = 0
        Application.ScreenUpdating = False
        For Each p In ActiveSheet.Shapes
            If p.Type = msoPicture Then
                Set C = p.TopLeftCell
                'MsgBox p.Name
                p.LockAspectRatio = msoFalse
                p.Placement = xlMoveAndSize
                p.Height = C.Height
                p.Width = C.Width
                If p.Rotation = 0 Then
                    p.Left = C.Left
                    p.Top = C.Top
                End If
                If p.Rotation > 0 And p.Height <> C.Width Then
                    p.Left = C.Left
                    p.Top = C.Top
                    p.Height = C.Width
                    p.Width = C.Height
                End If
                a1 = a1 + 1
            End If
        Next
        Application.ScreenUpdating = True
    MsgBox "Resize " & a1 & " Picture Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Resize Picture"
End Function

'*****************************************************Basic***********************************************
Function msg_resize_basic(number As Integer, title As String)
    Dim get_value As Integer
    Dim total As Integer
    Dim tp As Shape
    For Each tp In ActiveSheet.Shapes
        If tp.Rotation > 0 And tp.Type = msoPicture Then total = total + 1 'get Total Picture
    Next
    get_value = MsgBox(number & " " & title & "!" & vbCrLf & vbCrLf & _
            "Do you want to custom Resize " & number & " " & title & "?" _
            & vbCrLf & "- If you want to resize a " & total & " Photos Rotation => Click Yes" _
            & vbCrLf & "- If you want to resize all images => Click No" _
            & vbCrLf & "- If you don't want to resize the image => Click Cancel", _
            vbQuestion + vbYesNoCancel + vbDefaultButton2, "Resize " & title & "!")
    msg_resize_basic = get_value
End Function

'****************************************************Advand***********************************************
Sub Resize_Pictures_PR()
    Call Resize_Picture("nprocess")
End Sub

Sub Resize_Pictures_PNR()
    Call Resize_PictureNR("nprocess")
End Sub

Sub Resize_Pictures_NPR()
    Call Resize_Picture("")
End Sub

Sub Resize_Pictures_NPNR()
    Call Resize_PictureNR("")
End Sub

Function Resize_Picture(nprocess As String)
On Error GoTo trycatch
    If Get_Actives = True Then
        Dim p As Shape, C As Range
        Dim total As Integer, nRotation As Integer, s1 As Integer, a1 As Integer
        Dim wb As Workbook
        Dim ws As Worksheet
        Dim tp As Shape
        
        total = 0
        npicture = 0
        nRotation = 0
        Call get_data
        If MyClass.Tools_Resize_Picture <> "Workbook" And MyClass.Tools_Resize_Picture <> "Multiple Workbooks" Then
            For Each tp In ActiveSheet.Shapes
                If tp.Type = msoPicture Then total = total + 1 'get Total Picture
                If tp.Rotation > 0 And tp.Type = msoPicture Then nRotation = nRotation + 1 'get Total Picture Rotation
            Next
            If total > 0 Then s1 = msg_resize(total, nRotation, "Pictures")
            If total <= 0 Then MsgBox "No Pictures!", vbInformation, "Unfinished!"
            
            If s1 = vbNo Or s1 = vbYes Then
                time_bg = Now
                FrmResizePicture.Caption = "Resize Pictures"
                If s1 = vbYes Then Call Move_Picture(ActiveSheet.Shapes, total, nRotation, ActiveSheet.Name, nprocess)
                If s1 = vbNo Then Call Move_Picture_Default(ActiveSheet.Shapes, total, nprocess)
                MsgBox "Resize " & total & " Pictures Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Resize Pictures"
            End If
        End If
        If MyClass.Tools_Resize_Picture = "Workbook" Then
            For Each ws In ActiveWorkbook.Worksheets
                For Each tp In ws.Shapes
                    If tp.Type = msoPicture Then total = total + 1
                    If tp.Rotation > 0 And tp.Type = msoPicture Then nRotation = nRotation + 1 'get Total Picture Rotation
                Next tp
            Next ws
            If total > 0 Then s1 = msg_resize(total, nRotation, "Pictures")
            If total <= 0 Then MsgBox "No Pictures!", vbInformation, "Unfinished!"
            If s1 = vbNo Or s1 = vbYes Then
                time_bg = Now
                FrmResizePicture.Caption = "Resize Pictures"
                If s1 = vbYes Then
                    For Each ws In ActiveWorkbook.Worksheets
                        ws.Activate
                        Call Move_Picture_Rotation(ws.Shapes, total, nRotation, ws.Name, "", nprocess)
                    Next ws
                    npicture = 0
                End If
                For Each ws In ActiveWorkbook.Worksheets
                    ws.Activate
                    Call Move_Picture_Default(ws.Shapes, total, nprocess)
                Next ws
                MsgBox "Resize " & total & " Pictures Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Resize Pictures"
            End If
        End If
        If MyClass.Tools_Resize_Picture = "Multiple Workbooks" Then
            For Each wb In Workbooks
                For Each ws In wb.Worksheets
                    For Each tp In ws.Shapes
                        If tp.Type = msoPicture Then total = total + 1
                        If tp.Rotation > 0 And tp.Type = msoPicture Then nRotation = nRotation + 1 'get Total Picture Rotation
                    Next tp
                Next ws
            Next wb
            If total > 0 Then s1 = msg_resize(total, nRotation, "Pictures")
            If total <= 0 Then MsgBox "No Pictures!", vbInformation, "Unfinished!"
            If s1 = vbNo Or s1 = vbYes Then
                time_bg = Now
                FrmResizePicture.Caption = "Resize Pictures"
                If s1 = vbYes Then
                    For Each wb In Workbooks
                        wb.Activate
                        For Each ws In wb.Worksheets
                            ws.Activate
                            Call Move_Picture_Rotation(ws.Shapes, total, nRotation, ws.Name, wb.Name, nprocess)
                        Next ws
                    Next wb
                    npicture = 0
                End If
                
                For Each wb In Workbooks
                    wb.Activate
                    For Each ws In wb.Worksheets
                        ws.Activate
                        Call Move_Picture_Default(ws.Shapes, total, nprocess)
                    Next ws
                Next wb
                MsgBox "Resize " & total & " Pictures Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Resize Pictures"
            End If
        End If
        If IsLoaded("FrmResizePicture") Then Unload FrmResizePicture
    End If
    Exit Function
trycatch:
Unload FrmResizePicture
Application.ScreenUpdating = True
MsgBox "Unfinished Resizing" & vbCrLf & "Successfuly " & npicture & " Pictures!" & vbCrLf & Err.Description, vbExclamation
End Function

Function Resize_PictureNR(nprocess As String)
On Error GoTo trycatch
    If Get_Actives = True Then
        Dim p As Shape, C As Range
        Dim total As Integer, nRotation As Integer, s1 As Integer, a1 As Integer
        Dim wb As Workbook
        Dim ws As Worksheet
        Dim tp As Shape
        
        total = 0
        npicture = 0
        nRotation = 0
        Call get_data
        If MyClass.Tools_Resize_Picture <> "Workbook" And MyClass.Tools_Resize_Picture <> "Multiple Workbooks" Then
            For Each tp In ActiveSheet.Shapes
                If tp.Type = msoPicture Then total = total + 1 'get Total Picture
                If tp.Rotation > 0 And tp.Type = msoPicture Then nRotation = nRotation + 1 'get Total Picture Rotation
            Next
            If total > 0 Then s1 = msg_resize_NR(total, nRotation, "Pictures")
            If total <= 0 Then MsgBox "No Pictures!", vbInformation, "Unfinished!"
            
            If s1 = vbYes And total > 0 Then
                time_bg = Now
                FrmResizePicture.Caption = "Resize Pictures"
                Call Move_Picture(ActiveSheet.Shapes, total, nRotation, ActiveSheet.Name, nprocess)
                MsgBox "Resize " & total & " Pictures Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Resize Pictures"
            End If
        End If
        If MyClass.Tools_Resize_Picture = "Workbook" Then
            For Each ws In ActiveWorkbook.Worksheets
                For Each tp In ws.Shapes
                    If tp.Type = msoPicture Then total = total + 1
                    If tp.Rotation > 0 And tp.Type = msoPicture Then nRotation = nRotation + 1 'get Total Picture Rotation
                Next tp
            Next ws
            If total > 0 Then s1 = msg_resize_NR(total, nRotation, "Pictures")
            If total <= 0 Then MsgBox "No Pictures!", vbInformation, "Unfinished!"
            If s1 = vbYes And total > 0 Then
                time_bg = Now
                FrmResizePicture.Caption = "Resize Pictures"
                For Each ws In ActiveWorkbook.Worksheets
                    ws.Activate
                    Call Move_Picture_Rotation(ws.Shapes, total, nRotation, ws.Name, "", nprocess)
                Next ws
                npicture = 0
                For Each ws In ActiveWorkbook.Worksheets
                    ws.Activate
                    Call Move_Picture_Default(ws.Shapes, total, nprocess)
                Next ws
                MsgBox "Resize " & total & " Pictures Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Resize Pictures"
            End If
        End If
        If MyClass.Tools_Resize_Picture = "Multiple Workbooks" Then
            For Each wb In Workbooks
                For Each ws In wb.Worksheets
                    For Each tp In ws.Shapes
                        If tp.Type = msoPicture Then total = total + 1
                        If tp.Rotation > 0 And tp.Type = msoPicture Then nRotation = nRotation + 1 'get Total Picture Rotation
                    Next tp
                Next ws
            Next wb
            If total > 0 Then s1 = msg_resize_NR(total, nRotation, "Pictures")
            If total <= 0 Then MsgBox "No Pictures!", vbInformation, "Unfinished!"
            If s1 = vbYes And total > 0 Then
                time_bg = Now
                FrmResizePicture.Caption = "Resize Pictures"
                For Each wb In Workbooks
                    wb.Activate
                    For Each ws In wb.Worksheets
                        ws.Activate
                        Call Move_Picture_Rotation(ws.Shapes, total, nRotation, ws.Name, wb.Name, nprocess)
                    Next ws
                Next wb
                npicture = 0
                For Each wb In Workbooks
                    wb.Activate
                    For Each ws In wb.Worksheets
                        ws.Activate
                        Call Move_Picture_Default(ws.Shapes, total, nprocess)
                    Next ws
                Next wb
                MsgBox "Resize " & total & " Pictures Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Resize Pictures"
            End If
        End If
        If IsLoaded("FrmResizePicture") Then Unload FrmResizePicture
    End If
    Exit Function
trycatch:
Unload FrmResizePicture
Application.ScreenUpdating = True
MsgBox "Unfinished Resizing" & vbCrLf & "Successfuly " & npicture & " Pictures!" & vbCrLf & Err.Description, vbExclamation
End Function

Function Move_Picture(sh As Shapes, total As Integer, nRotation As Integer, nWorksheet As String, nprocess As String)
    Call Move_Picture_Rotation(sh, total, nRotation, nWorksheet, "", nprocess)
    npicture = 0
    Call Move_Picture_Default(sh, total, nprocess)
End Function

Function Move_Picture_Rotation(sh As Shapes, total As Integer, nRotation As Integer, nWorksheet As String, nWorkbook As String, nprocess As String)
On Error Resume Next
    If nRotation > 0 Then
        Dim p As Shape, C As Range
        If nprocess <> "" Then FrmResizePicture.Show vbModeless
        Application.ScreenUpdating = False
        For Each p In sh
            If p.Type = msoPicture And p.Rotation > 0 And npicture < nRotation Then
                Set C = p.TopLeftCell
                p.Placement = xlMoveAndSize
                p.LockAspectRatio = msoFalse
                If p.Rotation > 0 Then
                    p.Copy
                    ActiveWorkbook.ActiveSheet.Range(C.Address).PasteSpecial
                    If Selection.Name = "" Then
                        ActiveWorkbook.ActiveSheet.Range(C.Address).Interior.ColorIndex = 4
                        ActiveWorkbook.ActiveSheet.Range(C.Address).Value = "Error Rotation!"
                    Else
                        p.Delete
                        ActiveWorkbook.ActiveSheet.Range(C.Address).Interior.ColorIndex = 0
                        ActiveWorkbook.ActiveSheet.Range(C.Address).Value = ""
                    End If
                End If
                npicture = npicture + 1
                If nprocess <> "" Then Call ProcessRisize(npicture, nRotation)
            End If
        Next
        Application.ScreenUpdating = True
    End If
On Error GoTo 0
End Function

Function Move_Picture_Default(sh As Shapes, total As Integer, nprocess As String)
On Error Resume Next
    Dim p As Shape, C As Range
    If total > 0 Then
        If nprocess <> "" Then FrmResizePicture.Show vbModeless
        Application.ScreenUpdating = False
        For Each p In sh
            If p.Type = msoPicture Then
                Set C = p.TopLeftCell
                p.LockAspectRatio = msoFalse
                p.Placement = xlMoveAndSize
                p.Height = C.Height
                p.Width = C.Width
                If p.Rotation = 0 Then
                    p.Left = C.Left
                    p.Top = C.Top
                End If
                If p.Rotation > 0 Then
                    If p.Rotation > 0 And p.Height <> C.Width Then
                        p.Left = C.Left
                        p.Top = C.Top
                        If (p.Rotation > 260 Or p.Rotation < 10) Or (p.Rotation < 190 And p.Rotation > 170) Then
                            p.Height = C.Height
                            p.Width = C.Width
                        Else
                            p.Height = C.Width
                            p.Width = C.Height
                        End If
                    End If
                    If p.Rotation > 0 And p.Height = C.Width Then
                        If (p.Rotation > 260 Or p.Rotation < 10) Or (p.Rotation < 190 And p.Rotation > 170) Then
                            p.Height = C.Height
                            p.Width = C.Width
                        Else
                            p.Height = C.Width
                            p.Width = C.Height
                        End If
                        p.Left = C.Left
                        p.Top = C.Top
                    End If
                        p.Copy
                        ActiveWorkbook.ActiveSheet.Range(C.Address).PasteSpecial
                        If Selection.Name = "" Then
                            ActiveWorkbook.ActiveSheet.Range(C.Address).Interior.ColorIndex = 3
                            ActiveWorkbook.ActiveSheet.Range(C.Address).Value = "Error Default!"
                        Else
                            p.Delete
                            ActiveWorkbook.ActiveSheet.Range(C.Address).Interior.ColorIndex = 0
                            ActiveWorkbook.ActiveSheet.Range(C.Address).Value = ""
                        End If
                End If
                npicture = npicture + 1
'                ActiveWorkbook.ActiveSheet.Range("A" & npicture).Value = "Picture " & npicture
                If nprocess <> "" Then Call ProcessRisize(npicture, total)
            End If
        Next
        Application.ScreenUpdating = True
    End If
On Error GoTo 0
End Function

Function ProcessRisize(nfirst As Integer, nlast As Integer)
    Dim iwidth As Integer
    iwidth = ((nfirst / nlast) * 400 / 100) * 100
    FrmResizePicture.grb_process.Caption = Format(nfirst / nlast, "0%") & "(" & nfirst & "/" & nlast & ")"
    FrmResizePicture.lbl_process.Width = iwidth
    DoEvents
    If nfirst = nlast Then Unload FrmResizePicture
End Function

Function msg_resize(number As Integer, nRotation As Integer, title As String)
    Dim get_value As Integer
    Dim tp As Shape
    get_value = MsgBox(number & " " & title & "!" & vbCrLf & vbCrLf & _
            "Do you want to custom Resize " & number & " " & title & "?" _
            & vbCrLf & "- If you want to resize a " & nRotation & " Rotation Photos => Click Yes" _
            & vbCrLf & "- If you want to resize all images => Click No" _
            & vbCrLf & "- If you don't want to resize the images => Click Cancel", _
            vbQuestion + vbYesNoCancel + vbDefaultButton1, "Resize " & title & "!")
    msg_resize = get_value
End Function

Function msg_resize_NR(number As Integer, nRotation As Integer, title As String)
    Dim get_value As Integer
    Dim tp As Shape
    get_value = MsgBox(number & " " & title & "!" & vbCrLf & vbCrLf & _
            "Do you want to custom Resize " & number & " " & title & "?" _
            & vbCrLf & "There are " & nRotation & " rotation photos!" _
            & vbCrLf & "- If you want to resize all images => Click Yes" _
            & vbCrLf & "- If you don't want to resize the images => Click No", _
            vbQuestion + vbYesNo + vbDefaultButton1, "Resize " & title & "!")
    msg_resize_NR = get_value
End Function

Function IsLoaded(formName As String) As Boolean
    Dim frm As Object
    For Each frm In VBA.UserForms
        If frm.Name = formName Then
            IsLoaded = True
            Exit Function
        End If
    Next frm
    IsLoaded = False
End Function
'****************************************************Advand***********************************************

'************************************************Resize-Picture*******************************************



'********************************************Killer-Defined-Names*****************************************
Sub Killer_Defined_Names()
    Call Killer_Defined_Name("nProcess")
End Sub

Function Killer_Defined_Name(nprocess As String)
On Error GoTo trycatch
    If Get_Actives = True Then
        Dim wb As Workbook
        Dim ws As Worksheet
        Call get_data
        Dim dName As Name
        nbegin = 0
        nend = 0
        If Killer_Name <> "Multiple Workbooks" Then nend = ActiveWorkbook.Names.Count
        If Killer_Name = "Multiple Workbooks" Then
            For Each wb In Workbooks
                If wb.Names.Count > 0 Then nend = nend + 1
            Next wb
        End If
        If nend > 0 Then
            If my_msg(nend, "Defined names") = vbYes Then
                FrmResizePicture.Caption = "Killer Defined Names"
                If nprocess <> "" Then FrmResizePicture.Show vbModeless
                time_bg = Now
                Application.ScreenUpdating = False
                On Error Resume Next
                If Killer_Name = "Multiple Workbooks" Then
                    For Each wb In Workbooks
                        For Each dName In wb.Names
                            dName.Delete
                            nbegin = nbegin + 1
                            If nprocess <> "" Then Call ProcessRisize(nbegin, nend)
                        Next
                    Next wb
                Else
                    For Each dName In ActiveWorkbook.Names
                        dName.Delete
                        nbegin = nbegin + 1
                        If nprocess <> "" Then Call ProcessRisize(nbegin, nend)
                    Next
                End If
                On Error GoTo 0
                Application.ScreenUpdating = True
                MsgBox "Delete" & nend & " Defined Names Successfuly!" & vbCrLf & "Completion time is " & Format(Now - time_bg, "hh:nn:ss") & vbCrLf & Now - time_bg, vbInformation, "Defined names"
            End If
        Else: MsgBox "Defined Names not working!", vbExclamation, "Defined Names"
        End If
    End If
    Exit Function
trycatch:
Application.ScreenUpdating = True
MsgBox "Unfinished Delete Defined Names" & vbCrLf & "Delete Successfuly " & nbegin & " Defined Names!" & vbCrLf & Err.Description, vbExclamation
End Function

'********************************************Killer-Defined-Names*****************************************

'************************************************Killer-Style*********************************************
Sub Killer_Style()
    Call Killer_myStyle("nProcess")
End Sub

Function Killer_myStyle(nprocess As String)
On Error GoTo trycatch
    If Get_Actives = True Then
        Dim wb As Workbook
        Dim ws As Worksheet
        Call get_data
        Dim st As Style
        nbegin = 0
        nend = 0
        If Killer_Styles <> "Multiple Workbooks" Then
            For Each st In ActiveWorkbook.Styles
                If Not st.BuiltIn Then nend = nend + 1
            Next st
        End If
        If Killer_Styles = "Multiple Workbooks" Then
            For Each wb In Workbooks
                For Each st In wb.Styles
                    If Not st.BuiltIn Then nend = nend + 1
                Next st
            Next wb
        End If
        
        If nend > 0 Then
            If my_msg(nend, "Styles") = vbYes Then
                FrmResizePicture.Caption = "Killer Styles"
                If nprocess <> "" Then FrmResizePicture.Show vbModeless
                time_bg = Now
                Application.ScreenUpdating = False
                On Error Resume Next
                If Killer_Styles = "Multiple Workbooks" Then
                    For Each wb In Workbooks
                        For Each st In wb.Styles
                            If Not st.BuiltIn Then
                                st.Delete
                                nbegin = nbegin + 1
                                If nprocess <> "" Then Call ProcessRisize(nbegin, nend)
                            End If
                        Next
                    Next wb
                Else
                    For Each st In ActiveWorkbook.Styles
                        If Not st.BuiltIn Then
                            st.Delete
                            nbegin = nbegin + 1
                            If nprocess <> "" Then Call ProcessRisize(nbegin, nend)
                        End If
                    Next
                End If
                On Error GoTo 0
                Application.ScreenUpdating = True
                MsgBox "Delete Styles Successfuly!", vbInformation, "Styles"
            End If
        Else: MsgBox "New Styles not working!", vbExclamation, "Styles"
        End If
    End If
 Exit Function
trycatch:
Application.ScreenUpdating = True
MsgBox "Unfinished Delete Styles" & vbCrLf & "Delete Successfuly " & nbegin & " Styles!" & vbCrLf & Err.Description, vbExclamation
End Function

'************************************************Killer-Style*********************************************


'***********************************************Killer-Filter*********************************************
Public Sub Killer_Filter()
    If Get_Actives Then
        Call get_data
        If MyClass.Killer_Filter = "Multiple Workbooks" Then Call Killer_Filter_Workbooks
        If MyClass.Killer_Filter = "Workbook" Then Call Killer_Filter_Workbook
        If MyClass.Killer_Filter <> "Workbook" And MyClass.Killer_Filter <> "Multiple Workbooks" Then Call Killer_Filter_Sheet
    End If
End Sub

Function Killer_Filter_Sheet()
    If ActiveSheet.AutoFilterMode Then
        ActiveSheet.AutoFilterMode = False
        MsgBox "Delete Filter Successfuly!", vbInformation, "Filter"
    Else
        MsgBox "Filter not working!", vbExclamation, "Filter"
    End If
End Function

Function Killer_Filter_Workbook()
    Dim ws As Worksheet
    Dim flag As Boolean
    For Each ws In Worksheets
        If ws.AutoFilterMode Then
           ws.AutoFilterMode = False
           flag = True
        End If
    Next ws
    If flag Then
        MsgBox "Delete Filter Successfuly!", vbInformation, "Filter"
    Else: MsgBox "Filter not working!", vbExclamation, "Filter"
    End If
End Function

Function Killer_Filter_Workbooks()
    Dim flag As Boolean
    Dim wb As Workbook
    Dim ws As Worksheet
    For Each wb In Workbooks
        For Each ws In wb.Worksheets
            If ws.AutoFilterMode Then
               ws.AutoFilterMode = False
               flag = True
            End If
        Next ws
    Next wb
    If flag Then
        MsgBox "Delete Filter Successfuly!", vbInformation, "Filter"
    Else: MsgBox "Filter not working!", vbExclamation, "Filter"
    End If
End Function
'***********************************************Killer-Filter*********************************************

'*********************************************Killer-Validation*******************************************
Sub Killer_Validation()
    If Get_Actives Then
        Call get_data
        If MyClass.Killer_Validation = "Multiple Workbooks" Then Call Killer_Validation_in_Workbooks
        If MyClass.Killer_Validation = "Workbook" Then Call Killer_Validation_in_Workbook
        If MyClass.Killer_Validation <> "Workbook" And MyClass.Killer_Validation <> "Multiple Workbooks" Then Call Killer_Validation_in_Sheet
    End If
End Sub

Function Killer_Validation_in_Sheet()
    ActiveSheet.Cells.Validation.Delete
    MsgBox "Delete Data Validation Successfuly!", vbInformation, "Data Validation"
End Function

Function Killer_Validation_in_Workbook()
    Dim wsh As Worksheet
    For Each wsh In ActiveWorkbook.Worksheets
      wsh.Cells.Validation.Delete
    Next wsh
    MsgBox "Delete Data Validation Successfuly!", vbInformation, "Data Validation"
End Function

Function Killer_Validation_in_Workbooks()
    Dim wb As Workbook
    Dim ws As Worksheet
    For Each wb In Workbooks
        For Each ws In wb.Worksheets
            ws.Cells.Validation.Delete
        Next ws
    Next wb
    MsgBox "Delete Data Validation Successfuly!", vbInformation, "Data Validation"
End Function
'*********************************************Killer-Validation*******************************************

'**********************************************Killer-Formats*********************************************
Sub Killer_Formats()
    If Get_Actives Then
        Call get_data
        If MyClass.Killer_Formats = "Multiple Workbooks" Then Call Killer_Formats_in_Workbooks
        If MyClass.Killer_Formats = "Workbook" Then Call Killer_Formats_in_Workbook
        If MyClass.Killer_Formats <> "Workbook" And MyClass.Killer_Formats <> "Multiple Workbooks" Then Call Killer_Formats_in_Sheet
    End If
End Sub

Function Killer_Formats_in_Sheet()
    ActiveSheet.Cells.ClearFormats
    MsgBox "Clear Formats Successfuly!", vbInformation, "Formats"
End Function

Function Killer_Formats_in_Workbook()
    Dim wsh As Worksheet
    For Each wsh In ActiveWorkbook.Worksheets
      wsh.Cells.ClearFormats
    Next wsh
    MsgBox "Clear Formats Successfuly!", vbInformation, "Formats"
End Function

Function Killer_Formats_in_Workbooks()
    Dim wb As Workbook
    Dim ws As Worksheet
    For Each wb In Workbooks
        For Each ws In wb.Worksheets
            ws.Cells.ClearFormats
        Next ws
    Next wb
    MsgBox "Clear Formats Successfuly!", vbInformation, "Formats"
End Function
'**********************************************Killer-Formats*********************************************


'********************************************Messger-box-Killer*******************************************
Function my_msg(number As Integer, title As String)
    Dim get_value As Integer
    get_value = MsgBox(number & " " & title & "!" & vbCrLf & vbCrLf & _
            "Do you want to remove " & number & " " & title & "?", _
            vbQuestion + vbYesNo + vbDefaultButton1, "Delete " & title & "!")
    my_msg = get_value
End Function
'********************************************Messger-box-Killer*******************************************











Function Paste_Images()
    ActiveSheet.Pictures.Paste.Select
    With Selection
        .ShapeRange.LockAspectRatio = msoFalse
        .Top = .TopLeftCell.Top
        .Left = .TopLeftCell.Left
        .Width = .TopLeftCell.Width
        .Height = .TopLeftCell.Height
    End With
End Function

Function Paste_Images_1()
'    ActiveSheet.Pictures.Paste.Select
    ActiveSheet.Paste
    Set rng = Selection.TopLeftCell.MergeArea
    With Selection
        .ShapeRange.LockAspectRatio = msoFalse
        .Placement = xlMoveAndSize
        .Top = rng.Top
        .Left = rng.Left
        .Width = rng.Width
        .Height = rng.Height
    End With
    rng.Offset(, 1).Select
End Function

Function Paste_Images_2()
    ActiveSheet.Paste
    Set pic = Selection
    Set rng = pic.TopLeftCell.MergeArea
    With Selection
        .ShapeRange.LockAspectRatio = msoFalse
        .Left = rng.Left
        .Top = rng.Top
        .Height = rng.Height
        .Width = rng.Width
        Selection.Placement = xlMoveAndSize
    End With
    rng.Offset(, 1).Select
End Function

Sub Create_Defined_Name()
    Dim wb As Workbook, ws As Worksheet
    Dim RangeName As String
    Dim Reference As String
    FrmResizePicture.Show vbModeless
    Dim i As Integer
    For i = 1 To 2000
        RangeName = "_get_Part" & i
        Reference = "=IF(ISNUMBER(SEARCH(Sheet1!$G1,Sheet1!$E1)),Sheet1!$E1," & "" & ")"
        Range("B4").Select
        ActiveWorkbook.Names.Add Name:=RangeName, RefersTo:=Reference
        Call ProcessRisize(i, 2000)
    Next
'    RangeName = "_get_Part"
'    Reference = "=IF(ISNUMBER(SEARCH(Sheet1!$G1,Sheet1!$E1)),Sheet1!$E1," & "" & ")"
'    Range("B4").Select
'    ActiveWorkbook.Names.Add Name:=RangeName, RefersTo:=Reference
    'ActiveWorkbook.Names("_get_Part").Delete
End Sub

Public Function TEXTJOIN(delimiter As String, Ignore_Empty As Boolean, ParamArray Text1() As Variant) As String
Dim Cell As Range
    For Each RangeArea In Text1
        If TypeName(RangeArea) = "Range" Then
            For Each Cell In RangeArea
                If Len(Cell.Value) <> 0 Or Ignore_Empty = False Then
                    TEXTJOIN = TEXTJOIN & delimiter & Cell.Value
                End If
            Next Cell
        Else
            If Len(RangeArea) <> 0 Or Ignore_Empty = False Then
                TEXTJOIN = TEXTJOIN & delimiter & RangeArea
            End If
        End If
    Next
TEXTJOIN = Mid(TEXTJOIN, Len(delimiter) + 1)
End Function

Public Function CONCAT(ParamArray Text1() As Variant) As String
Dim Cell As Range
    For Each RangeArea In Text1
        If TypeName(RangeArea) = "Range" Then
            For Each Cell In RangeArea
                If Len(Cell.Value) <> 0 Then
                    CONCAT = CONCAT & Cell.Value
                End If
            Next Cell
        Else
            CONCAT = CONCAT & RangeArea
        End If
    Next RangeArea
End Function

Function CONCATIF(delimiter As String, ConcateRange As Range, CriteriaRange As Range, Criteria As Variant) As String
    Dim rng As Range
    On Error Resume Next
    CONCATIF = ""
        For Each rng In CriteriaRange
            If WorksheetFunction.CountIf(rng, Criteria) Then
                CONCATIF = CONCATIF & delimiter & rng.Offset(0, ConcateRange.Column - CriteriaRange.Column)
            End If
        Next
    CONCATIF = Mid(CONCATIF, Len(delimiter) + 1, Len(CONCATIF))
End Function

Public Sub Killer_Filter_Validation()
If Get_Actives = True Then
  If ActiveSheet.AutoFilterMode Then
     ActiveSheet.AutoFilterMode = False
  End If
  ActiveSheet.Cells.Validation.Delete
  MsgBox "Killer Data Validation Successfuly!", vbInformation, " Data Validation"
End If
End Sub


































'V1dwSk5VMUhXWGRhYWxGNFdtcHNhRnB0UlhkWk1sa3dUVlJCZVUxdFZtdE5WRmw2VFZkSmVVMVVZejA9VjJ0a1IwMUdjRlJSV0d4T1pWUm9NMVJ0YXpSbFZURkZWbFJGUFE9PQ==
'V1dwSk5VMUhXWGRhYWxGNFdtcHNhRnB0UlhkWk1sa3dUVlJCZVUxdFZtdE5WRmw2VFZkSmVVMVVZejA9VjJ0a1IwMUdjRlJSV0hCT1VYcG9NMVJ1YXpSbFZURkZVMWhyUFE9PQ==

Function Get_Infor()
On Error GoTo trycatch
    Dim myRegKey As String
    Dim myValue As String
    Dim myIP As String, IP As String
    Dim myDate As String, getDate As String
    Dim get_value As Integer
    Dim Expiration As Integer

        myRegKey = DecodeBase64("SEtDVVxTb2Z0d2FyZVxPZmZpY2VsVG9vbHNcU2VyaWFs")
        myIP = EncodeBase64(EncodeBase64(MD5Hash(Left(GetIPAddress, InStr(GetIPAddress, ",") - 1) & "tnd")))
        IP = Left(GetIPAddress, InStr(GetIPAddress, ",") - 1)
        If RegKeyExists(myRegKey) = True Then
            myValue = DecodeBase64(RegKeyRead(myRegKey))
            myDate = DecodeBase64(DecodeBase64(DecodeBase64(Replace(myValue, myIP, ""))))
            getDate = Mid(myDate, InStr(myDate, "e ") + 2, 10)
            Expiration = Format(Format(getDate, "dd/mm/yyyy"), 0) - Format(Date, 0)
            If Expiration <= 0 Or getDate = "" Then
                get_value = MsgBox("Love_Novel" & vbCrLf & vbCrLf & _
                        "Please Registry!" _
                        & vbCrLf & "- IP: " & IP, _
                        vbInformation, " Information!")
            Else: get_value = MsgBox("Love_Novel" & vbCrLf & vbCrLf & _
                        "The remaining usage time is " & Expiration & " days!" _
                        & vbCrLf & "- Expiration Date: " & getDate _
                        & vbCrLf & "- Hihe", _
                        vbInformation, " Information!")
            End If
        Else: get_value = MsgBox("Love_Novel" & vbCrLf & vbCrLf & _
                        "Please Registry!" _
                        & vbCrLf & "- IP: " & IP, _
                        vbInformation, " Information!")
        End If
        
    Exit Function
trycatch:
  get_value = MsgBox("Love_Novel" & vbCrLf & vbCrLf & _
                        "Please Registry!" _
                        & vbCrLf & "- IP: " & IP, _
                        vbInformation, " Information!")
End Function


Sub Restart_Serial_Key()
On Error GoTo trycatch
    RegKeyDelete (DecodeBase64("SEtDVVxTb2Z0d2FyZVxPZmZpY2VsVG9vbHNcU2VyaWFs"))
    Exit Sub
trycatch:
    MsgBox "Serial False!"
End Sub

Sub Create_Serial_Key()
On Error GoTo trycatch
    Dim myIP As String
    Dim setTime As String
    Dim myDate As String
    Dim pw As String
    pw = InputBox("Get Serial Key!", "hihe")
    If pw = "25241325" Then
        setTime = InputBox("Get Serial Key!", "hihe2")
        myIP = EncodeBase64(EncodeBase64(MD5Hash(Left(setTime, InStr(setTime, " ") - 1) & "tnd")))
        myDate = EncodeBase64(EncodeBase64(EncodeBase64(Mid(setTime, InStr(setTime, "date "), 15))))
        setTime = InputBox("Get Serial Key!", "hihe", EncodeBase64(myIP & myDate))
    End If
    
    Exit Sub
trycatch:
    MsgBox "Serial False!"
End Sub

Function Get_Actives() As Boolean
On Error GoTo trycatch
    Dim myRegKey As String
    Dim myValue As String
    Dim myIP As String, IP As String
    Dim myDate As String, getDate As String

        myRegKey = DecodeBase64("SEtDVVxTb2Z0d2FyZVxPZmZpY2VsVG9vbHNcU2VyaWFs")
        myIP = EncodeBase64(EncodeBase64(MD5Hash(Left(GetIPAddress, InStr(GetIPAddress, ",") - 1) & "tnd")))
        IP = Left(GetIPAddress, InStr(GetIPAddress, ",") - 1)
        If RegKeyExists(myRegKey) = True Then
            myValue = DecodeBase64(RegKeyRead(myRegKey))
            myDate = DecodeBase64(DecodeBase64(DecodeBase64(Replace(myValue, myIP, ""))))
            getDate = Mid(myDate, InStr(myDate, "e ") + 2, 10)
            If Format(Date, 0) > Format(Format(getDate, "dd/mm/yyyy"), 0) Or getDate = "" Then
                myValue = InputBox("Please enter Serial:", "Please Registry!", IP)
                If myValue <> "" Then RegKeySave myRegKey, myValue
            End If
        End If
        If RegKeyExists(myRegKey) = False Then
            myValue = InputBox("Please enter Serial:", "Please Registry!", IP)
            If myValue <> "" Then RegKeySave myRegKey, myValue
        End If
            myValue = DecodeBase64(RegKeyRead(myRegKey))
            myDate = DecodeBase64(DecodeBase64(DecodeBase64(Replace(myValue, myIP, ""))))
            getDate = Mid(myDate, InStr(myDate, "e ") + 2, 10)
            If Format(Date, 0) < Format(Format(getDate, "dd/mm/yyyy"), 0) And getDate <> "" Then
                Get_Actives = True
'                myValue = InputBox("demo", "haha", myIP & myDate)
'                MsgBox Format(Format(getDate, "dd/mm/yyyy"), 0) & vbCrLf & Format(Date, 0)
            End If
    Exit Function
trycatch:
  MsgBox "Please registry!"
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

'Registry
Function RegKeyRead(i_RegKey As String) As String
Dim myWS As Object
  On Error Resume Next
  Set myWS = CreateObject("WScript.Shell")
  RegKeyRead = myWS.RegRead(i_RegKey)
End Function

Function RegKeyExists(i_RegKey As String) As Boolean
Dim myWS As Object
  On Error GoTo ErrorHandler
  Set myWS = CreateObject("WScript.Shell")
  myWS.RegRead i_RegKey
  RegKeyExists = True
  Exit Function
ErrorHandler:
  RegKeyExists = False
End Function

Sub RegKeySave(i_RegKey As String, _
               i_Value As String, _
      Optional i_Type As String = "REG_SZ")
Dim myWS As Object
  Set myWS = CreateObject("WScript.Shell")
  myWS.RegWrite i_RegKey, i_Value, i_Type
End Sub

Function RegKeyDelete(i_RegKey As String) As Boolean
Dim myWS As Object
  On Error GoTo ErrorHandler
  Set myWS = CreateObject("WScript.Shell")
  myWS.RegDelete i_RegKey
  RegKeyDelete = True
  Exit Function
ErrorHandler:
  RegKeyDelete = False
End Function

'Base64
Function EncodeBase64(text$)
On Error GoTo trycatch
    Dim b
    With CreateObject("ADODB.Stream")
        .Open: .Type = 2: .Charset = "utf-8"
        .WriteText text: .Position = 0: .Type = 1: b = .Read
        With CreateObject("Microsoft.XMLDOM").createElement("b64")
            .DataType = "bin.base64": .nodeTypedValue = b
            EncodeBase64 = Replace(Mid(.text, 5), vbLf, "")
        End With
        .Close
    End With
    Exit Function
trycatch:
    MsgBox "EncodeBase64 False!"
End Function

Function DecodeBase64(b64$)
On Error GoTo trycatch
    Dim b
    With CreateObject("Microsoft.XMLDOM").createElement("b64")
        .DataType = "bin.base64": .text = b64
        b = .nodeTypedValue
        With CreateObject("ADODB.Stream")
            .Open: .Type = 1: .Write b: .Position = 0: .Type = 2: .Charset = "utf-8"
            DecodeBase64 = .ReadText
            .Close
        End With
    End With
    Exit Function
trycatch:

End Function

'MD5
Public Function MD5Hash(ByVal strText As String) As String
Dim CMD5          As New MD5_CLASS
Dim strSignature  As String
    strSignature = CMD5.MD5(strText)
    MD5Hash = strSignature
    Set CMD5 = Nothing
End Function


Function get_data()
On Error GoTo trycatch
    Dim CMD5          As New MD5_CLASS
'    Dim MyClass          As New My_Class
    '__________________________________________________________________________________________________________
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text1") = True Then
        MyClass.Security_Text1 = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Text1"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text2") = True Then
        MyClass.Security_Text2 = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Text2"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Text3") = True Then
        MyClass.Security_Text3 = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Text3"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Security_Apply") = True Then
        MyClass.Security_Apply = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Security_Apply"))
    End If
    '______________________________GET-DATA-FALSE___________________________________
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Name") = True Then
        Killer_Name = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Name"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Styles") = True Then
        Killer_Styles = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Styles"))
    End If
    '______________________________GET-DATA-FALSE___________________________________
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Filter") = True Then
        MyClass.Killer_Filter = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Filter"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Validation") = True Then
        MyClass.Killer_Validation = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Validation"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Killer_Formats") = True Then
        MyClass.Killer_Formats = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Killer_Formats"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Unhide_Sheets") = True Then
        MyClass.Tools_Unhide_Sheets = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Unhide_Sheets"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Unhide_Rows_Columns") = True Then
        MyClass.Tools_Unhide_Rows_Columns = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Unhide_Rows_Columns"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Select_Object") = True Then
        MyClass.Tools_Select_Object = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Select_Object"))
    End If
    If CMD5.RegKeyExists("HKCU\Software\OfficelTools\Resize_Picture") = True Then
        MyClass.Tools_Resize_Picture = CMD5.DecodeBase64(RegKeyRead("HKCU\Software\OfficelTools\Resize_Picture"))
    End If
    
'    Set MyClass = Nothing
    '__________________________________________________________________________________________________________

    Set CMD5 = Nothing
trycatch:
End Function

