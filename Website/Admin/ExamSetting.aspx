<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ExamSetting.aspx.cs" Inherits="Admin_ExamSetting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<script type="text/javascript">

    $(function Start_Date(txtenddate) {
        $('#txtenddate').datepicker({ onSelect: function Start_Date(txtenddate, inst) {
            //alert(txtstartdate);
        }

        });
        $('#txtenddate').datepicker("close");
    }
     )
     </Script>
     <script language="javascript" type="text/javascript">

         function CheckNumericKeyCode(B) {
             var A;
             if (window.event) {
                 A = event.keyCode
             }
             else {
                 if (B.which) {
                     A = B.which
                 }
             }
             if ((A == 27 || A == 9 || A == 8 || A == 46 || A == 35 || A == 36 || A == 37 || A == 39) || (A >= 48 && A <= 57) || (A >= 96 && A <= 105)) {
                 return true
             }
             else {
                 return false
             }
         }
     

</Script>
    <table width="633" height="339" cellspacing="0" cellpadding="0" border="0" class="top_margin">
    
      <%--<tr>
        <td width="10"><img width="8" height="9" src="images/arrow.gif"></td>
        <td width="255" height="30" class="pink_text">Exam Settings </td>
      </tr>
      <tr>
        <td valign="top" height="10" colspan="2"><img width="633" height="1" src="images/big_line.gif"></td>
      </tr>--%>
    <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Exam Setting</span>
                        </td>
                    </tr>
        <td colspan="2" align="center"> 
            <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
           
        </td>
      </tr>
      <tr>
        <td height="37" colspan="2">
        <table width="633px" height="390" cellspacing="0" cellpadding="0" border="1" bgcolor="#eeeeee">
            
            <tr>
              <td valign="top" height="412" align="left">
              <table width="631" height="338px" cellspacing="0" cellpadding="0" border="0">
                  <tbody>
                  <br />
                      <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                      <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>Function </b></td>
                          <td width="516"  class="form_font">   
                          
                               <asp:DropDownList ID="ddlfunction" runat="server" 
                                 Width="120px" 
                                AutoPostBack="True" onselectedindexchanged="ddlfunction_SelectedIndexChanged">
                            </asp:DropDownList>
                                  
                          
                             </td>
                         
                        </tr>
                        <tr>
                      <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>Level </b></td>
                          <td width="516"  class="form_font">   
                          
                               <asp:DropDownList ID="ddlLevel" runat="server" 
                                 Width="120px" 
                                AutoPostBack="True" onselectedindexchanged="ddlLevel_SelectedIndexChanged">
                            </asp:DropDownList>
                                  
                          
                             </td>
                         
                        </tr>
                    </tbody></table></td>
                  </tr>
                  
                   
         
        
                   <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>
                          
                              <asp:Label ID="Label1" runat="server" Text="Main Title"></asp:Label>
                           </b></td>
                          <td width="516"  class="form_font">   
                           
                            <asp:DropDownList ID="ddlMainTitle" runat="server" AutoPostBack="True" 
                                                                        
                            onselectedindexchanged="ddlMainTitle_SelectedIndexChanged" 
                            Width="120px" >
                        </asp:DropDownList></td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                  
                  
                  <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>
                          
                          <asp:Label ID="Label2" runat="server" Text="Sub Title"></asp:Label>
                          </b></td>
                          <td width="516">
                          
                           
                           
                          <asp:DropDownList ID="DropDownList1" runat="server" Width="120px">
                        </asp:DropDownList></td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                
                  
                <%--  <tr>
                    <td class="style2">&nbsp;</td>
                    <td height="35" colspan="2">
                    <table width="80%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>--%>
                        
                        
                        
                        
                    <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>Start Date</b></td>
                          <td width="516">
                          
                           
                          
                           <asp:TextBox ID="txtstartdate" runat="server" Width="120px"></asp:TextBox>
                                  
                                  
                               &nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtstartdate" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                  
                  
                  <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>End Date</b></td>
                          <td width="516">
                          
                           
                          
                            <asp:TextBox ID="txtenddate" runat="server" Width="120px"></asp:TextBox> &nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtenddate" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                  
                  
                 
                  
                            <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>Exam Title</b></td>
                          <td width="516">
                          
                           
                          
                            <asp:TextBox ID="txtTitle" runat="server" Width="120px"></asp:TextBox>
                           
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtTitle" ErrorMessage="*"></asp:RequiredFieldValidator>
                              
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                  <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td height="50" class="style5">&nbsp;</td>
                          <td width="91" class="form_font"><b>Set Time</b></td>
                          <td width="516">
                          
                                                     
                              <asp:TextBox ID="txtsettime" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)"></asp:TextBox>
                            &nbsp;<b>Min.</b> &nbsp;<b>(Only digit values )</b>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"   Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtsettime" ErrorMessage="*"></asp:RequiredFieldValidator>
                              
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                  <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td height="50" class="style6">&nbsp;</td>
                          <td width="91" class="form_font"><b>Set Marks</b> </td>
                          <td width="516">
                              <label>
                             
                         <asp:TextBox ID="txtmarks" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)"></asp:TextBox>&nbsp;&nbsp;<b>(Only digit values)</b>
 
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtmarks" ErrorMessage="*"></asp:RequiredFieldValidator>
                                  </label>
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
               <%--   <tr>
                      <td height="50" colspan="3"><table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50"  width="25">&nbsp;</td>
                        
                      
                           <td width="91" class="form_font">No.Of Questions To Displayed </td>
                           <td width="516">
                               <label>
                               
                              <asp:DropDownList ID="ddlqset" runat="server" Height="19px" Width="120px">
                              <asp:ListItem Value="1">1</asp:ListItem>
                              <asp:ListItem Value="5">5</asp:ListItem>
                              <asp:ListItem Value="10">10</asp:ListItem>
                                                  
                          </asp:DropDownList>
 
                              
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                   ControlToValidate="ddlqset" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                          </label>  </td>
                    </tr>
                    </tbody></table></td>
                  </tr>--%>
                  
                                     <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50" class="style4">&nbsp;</td>
                        
                      
                           <td width="91" class="form_font"><b>Total No. of Question</b> </td>
                           <td width="516">
                               <label>
                               
                                   <asp:TextBox ID="txtTotalQuestion" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)"></asp:TextBox>
                                                  
                          
 
                              
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"  Display="Dynamic"
                                   ControlToValidate="txtTotalQuestion" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                          </label>  </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                  
                  
                  
                         <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td height="50" class="style7">&nbsp;</td>
                           <td width="91" class="form_font"><b>Set Test Passmark</b></td>
                           <td width="516">
                              <label><asp:TextBox ID="txtsetpercentage" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)"></asp:TextBox> <b>%</b>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic"
                                   ControlToValidate="txtsetpercentage" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                          </label></td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50" class="style4">&nbsp;</td>
                           <td width="91" class="form_font" valign="top"><b>Pass Score Message</b> </td>
                           <td width="516">
                          
                              <label>
                                  

                               <asp:TextBox ID="txtpassmsg" runat="server" TextMode="SingleLine" Width="120px"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic"
                                   ControlToValidate="txtpassmsg" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                             
                             
                               </label>
                            </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                  
               <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50" class="style4">&nbsp;</td>
                        
                           <td width="91" class="form_font" valign="top">
                               <b>Fail Score Message</b> </td>
                           <td width="516" >
                               <label><asp:TextBox ID="txtfailmsg" runat="server" TextMode="SingleLine" Width="120px"></asp:TextBox> &nbsp;</label><asp:RequiredFieldValidator ID="RequiredFieldValidator6" 
                                Display="Dynamic"   runat="server" ControlToValidate="txtfailmsg" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>&nbsp;&nbsp;
                            </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                  
                  <tr>
                      <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td width="25" height="50">&nbsp;</td>
                           <td width="91" class="form_font">
                               </td>
                           <td width="516">
                              <label>
                                  

                              <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="images/submit.gif" 
                                  onclick="ImageButton2_Click" ValidationGroup="vrg" />
                               </label>
                            </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
       
                  
<%--</tbody></td></tr></table>
</td></tr>--%>
</tbody></table>
                          
                                               
                                                
                                                    
                                                </td>
     
     
                                            </tr>
                                        </table>
                                        <br />
                                    </td>
                                </tr>
                            </table>
</asp:Content>

