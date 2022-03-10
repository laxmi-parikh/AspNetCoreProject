<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADMINLOGIN.aspx.cs" Inherits="Admin_ADMINLOGIN" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style type="text/css">

body {
	background-color: #888888;
	margin-top: 0px;
}

</style>
<link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
    <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="126" colspan="2" valign="bottom" class="headerbg"><table width="356" border="0" cellpadding="0" cellspacing="0" class="pad1">
      <tr>
        <td width="356" height="73" class="name"></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="70" colspan="2" align="right" valign="top" bgcolor="#FFFFFF"><table width="73" border="0" cellpadding="0" cellspacing="0" class="margin">
      <tr>
        <td height="28">
        
            &nbsp;</td>
      </tr>
    </table>
       
      </td>
  </tr>
  <tr>
    <td width="290" height="404" align="center" valign="top" bgcolor="#FFFFFF"><p>&nbsp;</p>
                </td>
    <td width="710" align="left" valign="top" bgcolor="#FFFFFF">
    <%--#EFF3FB--%>
                         <table width ="50%" >
                         <tr >
                         <td>
                             <asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate" 
                                 BackColor="#EBECE4" BorderColor="#000000" BorderPadding="4" BorderStyle="Solid" 
                                 BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" 
                                 Width="342px" Height="196px">
                                 <TextBoxStyle Font-Size="0.8em" Width="120px" />
                                 <LoginButtonStyle BackColor="White" BorderColor="#000000" BorderStyle="Solid" 
                                     BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                                 <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                                 <TitleTextStyle BackColor="#000000" Font-Bold="True" Font-Size="0.9em" 
                                     ForeColor="White" />
                             </asp:Login>
                         </td>
                         </tr>
                         </table>
    
   </td>
  </tr>
</table>
    <div>
    <table width="965" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td>
            &nbsp;</td>
      </tr>
    </table></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
