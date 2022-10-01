VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "My_Class"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private security_text1_ As String
Private security_text2_ As String
Private security_text3_ As String
Private security_apply_ As String
Private killer_name_ As String
Private killer_styles_ As String
Private killer_filter_ As String
Private killer_validation_ As String
Private killer_formats_ As String
Private tools_unhide_sheets_ As String
Private tools_unhide_rows_columns_ As String
Private tools_select_object_ As String
Private tools_resize_picture_ As String



Public Property Let Security_Text1(ByVal vNewValue As Variant)
    security_text1_ = vNewValue
End Property

Public Property Get Security_Text1() As Variant
    Security_Text1 = security_text1_
End Property

Public Property Let Security_Text2(ByVal vNewValue As Variant)
    security_text2_ = vNewValue
End Property

Public Property Get Security_Text2() As Variant
    Security_Text2 = security_text2_
End Property

Public Property Let Security_Text3(ByVal vNewValue As Variant)
    security_text3_ = vNewValue
End Property

Public Property Get Security_Text3() As Variant
    Security_Text3 = security_text3_
End Property

Public Property Let Security_Apply(ByVal vNewValue As Variant)
    security_apply_ = vNewValue
End Property

Public Property Get Security_Apply() As Variant
    Security_Apply = security_apply_
End Property

Public Property Get Killer_Name() As Variant
    Killer_Name = killer_name_
End Property

Public Property Let Killer_Name(ByVal vNewValue As Variant)
    killer_name_ = vNewValue
End Property

Public Property Get Killer_Styles() As Variant
    Killer_Styles = killer_name_
End Property

Public Property Let Killer_Styles(ByVal vNewValue As Variant)
    killer_styles_ = vNewValue
End Property

Public Property Get Killer_Filter() As Variant
    Killer_Filter = killer_filter_
End Property

Public Property Let Killer_Filter(ByVal vNewValue As Variant)
    killer_filter_ = vNewValue
End Property

Public Property Get Killer_Validation() As Variant
    Killer_Validation = killer_validation_
End Property

Public Property Let Killer_Validation(ByVal vNewValue As Variant)
    killer_validation_ = vNewValue
End Property

Public Property Get Killer_Formats() As Variant
    Killer_Formats = killer_formats_
End Property

Public Property Let Killer_Formats(ByVal vNewValue As Variant)
    killer_formats_ = vNewValue
End Property

Public Property Get Tools_Unhide_Sheets() As Variant
    Tools_Unhide_Sheets = tools_unhide_sheets_
End Property

Public Property Let Tools_Unhide_Sheets(ByVal vNewValue As Variant)
    tools_unhide_sheets_ = vNewValue
End Property

Public Property Get Tools_Unhide_Rows_Columns() As Variant
    Tools_Unhide_Rows_Columns = tools_unhide_rows_columns_
End Property

Public Property Let Tools_Unhide_Rows_Columns(ByVal vNewValue As Variant)
    tools_unhide_rows_columns_ = vNewValue
End Property

Public Property Get Tools_Select_Object() As Variant
    Tools_Select_Object = tools_select_object_
End Property

Public Property Let Tools_Select_Object(ByVal vNewValue As Variant)
    tools_select_object_ = vNewValue
End Property

Public Property Get Tools_Resize_Picture() As Variant
    Tools_Resize_Picture = tools_resize_picture_
End Property

Public Property Let Tools_Resize_Picture(ByVal vNewValue As Variant)
    tools_resize_picture_ = vNewValue
End Property
