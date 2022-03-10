<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Preview1.aspx.cs" Inherits="Default2" %>

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
var WindowObject = window.open("", "PrintWindow","width=750,height=650,top=50,left=50,toolbars=no,scrollbars=yes,status=no,resizable=yes");
WindowObject.document.writeln(DocumentContainer.innerHTML);
WindowObject.document.close();
WindowObject.focus();
WindowObject.print();
WindowObject.close();
}
</script>
</head>
<body>
    <form id="form1" runat="server">
  
    <table width="70%" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="404" align="center" valign="top" bgcolor="#FFFFFF">
     <div id="divtoprint">
    <table width="633" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="15" height="30" align="left" valign="middle"><img src="image/arrow.gif" width="8" height="9" /></td>
        <td width="618" align="left" valign="middle" class="pink_text1">Results</td>
      </tr>

      <tr>
        <td height="10" colspan="2" align="left" valign="top"><img src="image/big_line.gif" width="633" height="1" /></td>
      </tr>
      <tr>
        <td height="250" colspan="2" align="left" valign="top"><table width="633" border="1" cellpadding="0" cellspacing="0" bordercolor="#5c5c5c" bgcolor="#eeeeee">
          <tr>
            <td height="231" align="left" valign="top"><table width="633" height="231" border="0" cellspacing="0" cellpadding="0">
               <tr height="30px">
                <td width="25" class="top_pinktab"> <img src="image/arrow.gif" width="8" height="9" /></td>

                <td width="608" colspan="2" class="top_pinktab" valign="middle"><span class="white_hd" >Armstrong Training Test<br /> </span></td>
              </tr>
              <tr>
                <td height="40">&nbsp;</td>
                <td width="304" align="left" valign="bottom" colspan="2" >
                <table width="90%" border="0" cellspacing="0" cellpadding="0">
             
             <tr><td colspan="2">&nbsp;</td></tr>
               <tr>
                    <td width="173" class="font_text2">Name :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblName" runat="server" ></asp:Label>
                      </td>
                  </tr>
                 <tr><td colspan="2">&nbsp;</td></tr>
                <tr>
                    <td width="173" class="font_text2">Category :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblMainTitle" runat="server" ></asp:Label>
                      </td>
                  </tr>
                
                <tr><td colspan="2">&nbsp;</td></tr>
                <tr>
                    <td width="173" class="font_text2">Sub Category :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblSubTitle" runat="server" ></asp:Label>
                      </td>
                  </tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                  <tr>
                    <td width="173" class="font_text2">Exam Name :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblExam" runat="server" ></asp:Label>
                      </td>
                  </tr>
                  
                  <tr><td colspan="2">&nbsp;</td></tr>
                  <tr>
                    <td width="173" class="font_text2">Date :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblDate" runat="server" ></asp:Label>
                      </td>
                  </tr>
                     <tr><td colspan="2">&nbsp;</td></tr>
                  
                  <tr>
                    <td width="173" class="font_text2">Marks :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblSetmarks" runat="server" ></asp:Label>
                      </td>
                  </tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                   <tr>
                    <td width="173" class="font_text2">Total Questions :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lbltQuestion" runat="server" ></asp:Label>
                      </td>
                  </tr>
                     <tr><td colspan="2">&nbsp;</td></tr>
                   <tr>
                    <td width="173" class="font_text2">Total Attempt Questions :</td>
                    <td width="100" class="form_font">
                        <asp:Label ID="lblTtAQuestion" runat="server" ></asp:Label>
                      &nbsp;</td>
                  </tr>
                     <tr><td colspan="2">&nbsp;</td></tr>
                  <tr>
                    <td width="173" class="font_text2">Total Non-attempt Questions :</td>
                    <td width="100" class="form_font">
                        <asp:Label ID="lblNttlquestion" runat="server" ></asp:Label>
                      </td>
                  </tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                  <tr>
                    <td width="173" class="font_text2">Correct Answer :</td>
                    <td width="100" class="form_font">
                        <asp:Label ID="lblcorrectanswer" runat="server" ></asp:Label>
                      </td>
                  </tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                  
                  <tr>
                    <td width="173" class="font_text2">Percentage :</td>
                    <td width="100" class="form_font">
                        <asp:Label ID="lblPercentage" runat="server" ></asp:Label> %
                      </td>
                  </tr>
                     <tr><td colspan="2">&nbsp;</td></tr>
                  <tr>
                    <td width="173" class="font_text2">Grade :</td>
                    <td width="100" class="form_font">
                        <asp:Label ID="lblgrade" runat="server" ></asp:Label>
                      </td>
                  </tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                  <tr><td colspan="2">&nbsp;</td></tr>
                </table></td>
            
              </tr>
             
   
             
            </table></td>
          </tr>
        </table>
        
        
        
        </td>
      </tr>
   
    </table>      </div>  
    <p>&nbsp;</p>
        
        <p>&nbsp;</p></td>

  </tr>
  <tr><td > <asp:Button ID="Button1" runat="server" OnClientClick="PrintContent()" 
                    Text="Print" Width="73px" />
   </td></tr>
  
</table>
    
   
     
    </form>
</body>
</html>
