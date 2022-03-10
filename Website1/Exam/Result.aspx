<%@ Page Language="C#" MasterPageFile="Exam.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="USER_Result"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            font-weight: normal;
            color: #a1215a;
            text-decoration: none;
            width: 158px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="JavaScript">
javascript:window.history.forward(1);
</script>
  
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
<tr><td align="right" height="70"> 
             <table border="0" cellpadding="0" cellspacing="0" width="10%" >
             <tr><td> <asp:ImageButton ID="ImageButton1" ImageUrl ="~/Images/home_btn.gif" 
                runat="server" onclick="ImageButton1_Click"  
                /> </td><td>&nbsp;</td><td> 
              
              <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" Visible="false"><img alt="img" border="0" src="../Images/history_btn.gif" /></asp:LinkButton>
             
           
         </td>
         <td>&nbsp;</td> 
         <td>              
              <asp:ImageButton ID="imgdownloadebook" ImageUrl ="~/USER/image/download_e-book.png" runat="server" onclick="imgdownloadebook_Click"  Visible="false"/>
                       
         </td>
         <td>&nbsp;</td> <td>  <asp:ImageButton ID="ImageButton21" ImageUrl ="~/Admin/images/lod_out.gif" 
                runat="server" onclick="ImageButton21_Click" 
                /> </td></tr>
             
             </table>   </td></tr>
  <tr>
    <td height="404" align="center" valign="top" bgcolor="#FFFFFF">
    
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
            <td height="231" align="left" valign="top">
            <div id="result">
            <table width="633"  height="231" border="0" cellspacing="0" cellpadding="0">
               <tr>
                <td width="25" class="top_pinktab" valign="middle"> <img src="image/arrow.gif" width="8" height="9" /></td>

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
             <%--   <tr>
                    <td width="173" class="font_text2">Category :</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblMainTitle" runat="server" ></asp:Label>
                      </td>
                  </tr>--%>
                
            <%--    <tr><td colspan="2">&nbsp;</td></tr>
                <tr>
                    <td width="173" class="font_text2">:</td>

                    <td width="100" class="form_font">
                        <asp:Label ID="lblSubTitle" runat="server" ></asp:Label>
                      </td>
                  </tr>--%>
                 <%-- <tr><td colspan="2">&nbsp;</td></tr>--%>
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
             
   
             
            </table>
            </div>
            </td>
          </tr>
        </table></td>
      </tr>
    </table>      
    <p>
        <asp:Button ID="cmdtryagain" runat="server" onclick="cmdtryagain_Click" 
            Text="Try Again" Visible="False" />
        </p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p></td>

  </tr>
  
</table>


</asp:Content>

