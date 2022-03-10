<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Preview.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  
  <link href="../style.css" rel="stylesheet" type="text/css" />

<script language="JavaScript">
javascript:window.history.forward(1);
</script>
  <script type ="text/javascript" >
function PrintContent()
{
var DocumentContainer = document.getElementById('divtoprint');
var WindowObject = window.open("", "PrintWindow","width=850,height=850,top=50,left=50,toolbars=no,scrollbars=yes,status=no,resizable=yes");
WindowObject.document.writeln(DocumentContainer.innerHTML);
WindowObject.document.close();
WindowObject.focus();
WindowObject.print();
WindowObject.close();
}
</script>


<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<style type="text/css">
<!--
.txt01 {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 24px;
	font-weight: normal;
	color: #000000;
}
.txt02 {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 16px;
	font-weight: bold;
	color: #000000;
}
.txt03 {
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size: 13px;
	font-weight: bold;
	color: #000000;
}
.bg {
	background-image: url(images/certificate_02.jpg);
	background-repeat: repeat-y;
	width: 8px;
}
.bg1 {
	background-image: url(images/certificate_04.jpg);
	background-repeat: repeat-y;
	width: 8px;
}
-->
</style>
</head>
<body bgcolor="#FFFFFF" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Print"  OnClientClick="PrintContent()"/>
        <br />
  <div id="divtoprint"> 
<table width="673" height="736" border="0" align="center" cellpadding="0" cellspacing="0" id="Table1">
<tr>
		<td colspan="7">
			<img src="../Admin/images/certificate_01.jpg" width="690" height="7" alt=""></td>
	</tr>
	<tr>
		<td rowspan="14" valign="top"> <img src="../Admin/images/certificate_02.jpg"  width="8px"  height='800'  alt=""></td>

		<td colspan="5" align="right">
        <br />
           
        <img src="../Admin/images/logo.jpg" alt="" style="height: 40px; width: 41%"> &nbsp;&nbsp;&nbsp;
			<%--<img src="images/certificate_03.jpg" width="654" height="20" alt="">--%></td>
		<td rowspan="14" > <img src="../Admin/images/certificate_04.jpg"  width="8px"  height='800'  alt=""></td>
	</tr>

 <%--   <tr><td rowspan='15'><img src=cid:Image8 width='8' height='800' alt=''></td><td colspan='5' align='right' valign='bottom'><br/><img src=cid:Image10 width='20%'  alt=''></td><td rowspan='15' align='right'><img src=cid:Image9 width='8' height='800' alt=''></td></tr>
--%>

<%--<tr>
		
		<td colspan="7" align="right">
			
		
			<img src="images/logo.jpg" alt="" style="height: 40px; width: 41%"> &nbsp;&nbsp;</td>
	</tr>--%>

	<tr>
		<td rowspan="13">
			<img src="../Admin/images/certificate_05.jpg" width="46" height="648" alt=""></td> 
		<td colspan="3">
			<img src="../Admin/images/certificate_06.jpg" width="565" height="116" alt=""></td>
		<td rowspan="13">
			<img src="../Admin/images/certificate_07.jpg" width="46" height="648" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="../Admin/images/certificate_08.jpg" width="565" height="30" alt=""></td>
	</tr>
	<tr>
		<td height="39" colspan="3" align="center" valign="middle" class="txt01">
            <asp:Label ID="lblName" runat="server" ></asp:Label></td>
  </tr>
	<tr>
		<td colspan="3">
			<img src="../Admin/images/certificate_10.jpg" width="565" height="17" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="../Admin/images/certificate_11.jpg" width="565" height="21" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="../Admin/images/certificate_12.jpg" width="565" height="17" alt=""></td>
	</tr>
	<tr>
		<td height="27" colspan="3" align="center" valign="middle" class="txt02">
            <asp:Label ID="lblExamTitle" runat="server" ></asp:Label></td>
  </tr>
	<tr>
		<td height="23" colspan="3" align="center" valign="middle" class="txt02">Grade:<asp:Label ID="lblgrade" runat="server" ></asp:Label> %</td>
  </tr>
	<tr>
		<td colspan="3">
			<img src="../Admin/images/certificate_15.jpg" width="565" height="161" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="../Admin/images/certificate_16.jpg" width="342" height="15" alt=""></td>
		<td height="20" align="left" valign="middle" class="txt03">
            <asp:Label ID="lbldate" runat="server" ></asp:Label></td>
<td>
			<img src="../Admin/images/certificate_18.jpg" width="63" height="15" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="../Admin/images/certificate_19.jpg" width="342" height="22" alt=""></td>
		<td>
			<img src="../Admin/images/certificate_20.jpg" width="160" height="22" alt=""></td>
		<td>
			<img src="../Admin/images/certificate_21.jpg" width="63" height="22" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="../Admin/images/certificate_22.jpg" width="565" height="137" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="../Admin/images/certificate_23.gif" width="565" height="23" alt=""></td>
	</tr>
	<tr>
		<td colspan="7">
			<img src="../Admin/images/certificate_24.jpg" width="690" height="8" alt=""></td>
	</tr>
</table>




    </div>


   
     
    </form>
</body>
</html>
