<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"  %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="style.css" rel="stylesheet" type="text/css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table width="1000px" height="600px" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td width="492" height="474" align="right" valign="top" bgcolor="#FFFFFF"><table width="200" border="0" cellpadding="0" cellspacing="0" class="pad">
          <tr>
            <td height="105">
            <a href ="Admin/ADMINLOGIN.aspx">
            <img src="image/admin_login.jpg" width="200" height="105" border="0"/></a>
            
            </td>

          </tr>
        </table></td>
        <td width="16" align="left" valign="top"><img src="image/middle_strip.gif" width="16" height="474" /></td>
        <td width="492" align="left" valign="top" bgcolor="#FFFFFF"><table width="200" border="0" cellpadding="0" cellspacing="0" class="pad3">
          <tr>
            <td height="105">
            <a href ="Login.aspx">
            <img src="image/user_login.jpg" width="201" height="107" border="0"  /></a>
            
            </td>
          </tr>
        </table></td>
      </tr>

</table>
    </td>
    <map name="Map2" id="Map2"><area shape="rect" coords="3,3,162,55" href="#" /></map>
<map name="Map" id="Map"><area shape="rect" coords="5,3,162,55" href="#" /></map>

</asp:Content>

