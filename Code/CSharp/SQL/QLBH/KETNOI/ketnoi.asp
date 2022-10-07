<%
adCmdUnspecified=-1 
adCmdText = 1 
adCmdTable = 2  
adCmdStoredProc = 4 
adCmdUnknown = 8  
adCmdFile = 256 
adCmdTableDirect = 512 


chuoiketnoi="Provider=SQLOLEDB.1; Data Source=BKAPTECH\MSSQLSERVER2008; Initial Catalog=QLBanHang; UID=sa; PWD=123456"
Set ketnoi=Server.CreateObject("ADODB.Connection")
ketnoi.Open chuoiketnoi
	
	
	
%>
