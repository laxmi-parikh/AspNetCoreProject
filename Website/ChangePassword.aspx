<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ForgetPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet" type="text/css">
</link>
</head>
<body>
    <form id="form1" runat="server">
    
    <table border="0" cellpadding="0" cellspacing="0" width="70%" class="form_font"  align="left">
    <tr height="30px"><td></td><th align="left"> 
        <asp:Label ID="lblMsg" runat="server"  ForeColor="Red"  ></asp:Label> </th></tr>
    
     <tr height="30px"><th width="20%" align="right"> Email&nbsp;:&nbsp; </th> <td align="left">
     
         <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email Require" ControlToValidate="txtemail" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Invaild Email Address" ControlToValidate="txtemail" 
                        Display="Dynamic" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="vrg"></asp:RegularExpressionValidator>
     </td></tr>
     
      <tr height="30px"><th width="20%" align="right">Old Password&nbsp;:&nbsp; </th> <td align="left">
     
         <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Require" ControlToValidate="txtPassword" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>
       
     </td></tr>
     
      <tr height="30px"><th width="20%" align="right">New Password&nbsp;:&nbsp; </th> <td align="left">
     
         <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Password Require" ControlToValidate="txtNewPassword" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>
       
     </td></tr>
     
     
     
      <tr height="30px"><td ></td><td  align="left">
      
          <asp:Button ID="btn_Submit" runat="server" Text="Submit" ValidationGroup="vrg" onclick="btn_Submit_Click1" 
              />
        </td></tr>
    
    </table>
    
    </form>
</body>
</html>
