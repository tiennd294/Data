<%@LANGUAGE="VBSCRIPT" CODEPAGE="65001"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>
<!--#include file="../KETNOI/ketnoi.asp"-->

<% 
	Set cmd = Server.CreateObject("ADODB.Command")
	Set cmd.ActiveConnection=ketnoi
	cmd.CommandText = "spud_LayVattu"
    cmd.CommandType = adCmdStoredProc
	Set rs = cmd.Execute
%>
<body>
<table width="700" border="1">
  <tr>
    <th width="81" scope="col">Mã VT </th>
    <th width="256" scope="col">Tên Vật tư </th>
    <th width="148" scope="col">ĐVTính </th>
    <th width="187" scope="col">Phần trăm </th>
  </tr>
<%  Do While not rs.EOF %> 
  <tr>
    <td><%= rs("Mavtu").value %></td>
    <td><%= rs("TenVtu").value %></td>
    <td><%= rs("Dvtinh").value %></td>
    <td><%= rs("Phantram").value %></td>
  </tr>
  <% rs.MoveNext %>
<% Loop  %> 
</table>
</body>
</html>
