<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>







<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <script language="javascript">

      function openurl() {


          //window.location.href = 'openurl.aspx?id=' + obj;
          window.open('ForgetPassword.aspx', '', 'scrollbars=no,menubar=no,height=600,width=800,resizable=yes,toolbar=no,location=no,status=no');
      }

      function openurl1() {


          //window.location.href = 'openurl.aspx?id=' + obj;
          window.open('ChangePassword.aspx', '', 'scrollbars=no,menubar=no,height=600,width=800,resizable=yes,toolbar=no,location=no,status=no');
      }
        
         </script>

<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="300" height="474" valign="top" bgcolor="#FFFFFF"><table width="200" border="0" cellpadding="0" cellspacing="0" class="mar">
      <tr>
        <td width="200" height="105"><img src="image/user_login.jpg" width="201" height="107" /></td>

      </tr>
    </table></td>
    <td width="350" valign="top" bgcolor="#FFFFFF">
        &nbsp;<table width="245px" height="208px" border="0" cellpadding="0" cellspacing="0" class="form_m_t">
      <tr>
        <td height="45" colspan="2" class="form_font">Use a valid username and password to 
            gain<br />
            access to the administration console.</td>
      </tr>
      <tr>

        <td height="2" colspan="2"><img src="images/line.gif" width="250" height="1" /></td>
      </tr>
      <tr>
        <td height="15" colspan="2">&nbsp;</td>
      </tr>
      <tr>
        <td width="80" height="35" align="left" valign="middle" class="form_font">Email </td>
        <td width="165" height="35" align="left" valign="middle">

            <label>&nbsp;</label>       
                                           <asp:TextBox ID="txtUserName" runat="server" 
                Width="150px"></asp:TextBox>
                                       </td>
      </tr>
      <tr>
        <td height="35" valign="middle" class="form_font">Password</td>
        <td width="165" height="35" align="left" valign="middle">

            <label>&nbsp;</label>       
                                           <asp:TextBox ID="txtPassword" runat="server" width="150px"
                TextMode="Password"></asp:TextBox>
                                       </td>
      </tr>
      <tr>
        <td height="15" colspan="2">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
          </td>
      </tr>

      <tr>
        <td height="28" colspan="2" align="right">
            <asp:ImageButton ID="iBtnSubmit" runat="server" ImageUrl ="images/login.gif" 
                onclick="iBtnSubmit_Click" />
            
            </td>
      </tr>
     <tr>
        <td height="25" colspan="2" align="right" class="form_font1">
        <a onclick="return openurl()"  class="password_1" target="_blank">Forgot password </a>
        
        </td>
      </tr>
       <tr>
        <td height="25" colspan="2" align="right" class="form_font1">
          <a onclick="return openurl1()"  class="password_1" target="_blank">Change password </a>
   
        
        </td>
      </tr>
      
    </table>
    <p class="user_mar"></td>

    <td width="16" valign="top" bgcolor="#FFFFFF"><img src="image/middle_strip.gif" width="16" height="474" /></td>
    <td width="334" align="center" valign="middle" bgcolor="#FFFFFF"><table width="166" border="0" cellspacing="0" cellpadding="0">
    <tr>
        <td height="55">
        <a href ="Register.aspx">
        <img src="image/reg_img.jpg" width="161" height="55" border="0"  /></a>
        
        </td>
      </tr>
    <tr>
        <td height="55">
        <a href ="Download.aspx">
        <img src="USER/image/download_e-book-icon.png" width="161" height="50" border="0"  /></a>
        
        </td>
      </tr>
      
    </table></td>
  </tr>
</table>


    


</asp:Content>

