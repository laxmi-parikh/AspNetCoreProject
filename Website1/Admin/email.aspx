<%@ Page Language="C#" AutoEventWireup="true" CodeFile="email.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0" cellpadding="0" cellspacing="0"  align="center" valign="top"  class="t-font">
<tr height="30px"><td width="10%"></td><td colspan="2" align="center" class="t-font"> 
    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label></td></tr>
    <tr height="30px"><td width="10%"></td>
    <td colspan="2" align="center" class="t-font" width="100%"> 
    
    <table border="0" cellpadding="0" cellspacing="0" width="100%" valign="top">
    <tr height="30px"><td width="60%" align="left">Email To  </td><td  align="left" >
        <asp:TextBox ID="lblEmail" runat="server" Text=""></asp:TextBox> </td>  </tr>
         <tr height="30px"><td  align="left">Subject </td><td  align="left">
       <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox> </td>  </tr>
       
        <tr height="30px"><td  align="left">Message </td><td  align="left">
       <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine" Columns="20" Rows="3"></asp:TextBox>
      
       
       
          </td>  </tr>
           <tr height="30px"><td  align="left"> </td><td  align="left">
     
      
               <asp:FileUpload ID="FileUpload1" runat="server" />
       
          </td>  </tr>
          
           <tr height="30px"><td  align="center" colspan="2">
               <asp:Button ID="btn_Submit" runat="server" Text="Send" 
                   onclick="btn_Submit_Click" style="height: 26px" />
          </td>  </tr>
        
    </table>
   </td></tr>
   
   
 

 
 
 </table> 
 
    </div>
    </form>
</body>
</html>
