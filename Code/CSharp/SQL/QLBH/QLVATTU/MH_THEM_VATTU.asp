<%@LANGUAGE="VBSCRIPT" CODEPAGE="65001"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>
<!--#include file="../KETNOI/ketnoi.asp"-->
<% 
hanhdong=Request.Form("hanhdong")
If hanhdong<>"" Then
	mavtu=Request.Form("txtMavtu")
	tenvtu=Request.Form("txtTenvtu")
	dvtinh=Request.Form("txtDvtinh")
	phantram=Request.Form("txtPhantram")
	
	Set cmd = Server.CreateObject("ADODB.Command")
	Set cmd.ActiveConnection=ketnoi
	cmd.CommandText = "spud_ThemVattu"
    cmd.CommandType = adCmdStoredProc
	
	Set parA = cmd.CreateParameter("mavtu", adChar, adParamInput, 4)
    cmd.Parameters.Append parA
    parA.Value = mavtu
    
    Set parB = cmd.CreateParameter("tenvtu", adVarWChar, adParamInput, 100)
    cmd.Parameters.Append parB
    parB.Value = tenvtu
    
    Set parB = cmd.CreateParameter("dvtinh", adVarWChar, adParamInput, 10)
    cmd.Parameters.Append parB
    parB.Value = dvtinh
    
    Set parB = cmd.CreateParameter("phantram", adSingle, adParamInput)
    cmd.Parameters.Append parB
    parB.Value = phantram
	cmd.Execute
End If
%>
<body>
<form id="form1" name="form1" method="post" action="">
  <table width="447" height="170" border="1">
    <tr>
      <td width="128" scope="col">Mã vật tư </td>
      <td width="303" scope="col"><input name="txtMavtu" type="text" id="txtMavtu" /></td>
    </tr>
    <tr>
      <td>Tên vật tư </td>
      <td><input name="txtTenvtu" type="text" id="txtTenvtu" /></td>
    </tr>
    <tr>
      <td>Đơn vị tính </td>
      <td><input name="txtDvtinh" type="text" id="txtDvtinh" /></td>
    </tr>
    <tr>
      <td>Phần trăm </td>
      <td><input name="txtPhantram" type="text" id="txtPhantram" /></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
      <td><input type="submit" name="Submit" value="Ghi" />
      <input type="reset" name="Submit2" value="Hủy" /></td>
    </tr>
  </table>
  <input name="hanhdong" type="hidden" value="themmoi" />
</form>
</body>
</html>
