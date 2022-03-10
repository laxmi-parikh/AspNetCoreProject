<%@ Page Language="C#" MasterPageFile="~/USER/USER.master" AutoEventWireup="true" CodeFile="Question.aspx.cs" Inherits="USER_Question"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%--<script type="text/javascript">

    Sys.Services.AuthenticationService.set_path('/Authentication_JSON_AppService.axd');

</script>--%>
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
    <asp:ScriptManager ID="ScriptManager1"  runat="server" />
   <tr>
    <td  align="center" valign="top" bgcolor="#FFFFFF">
    <table width="633" border="0" cellspacing="0" cellpadding="0">
        <tr>
        <td height="20"></td>
        </tr>
      <tr>
        <td height="230" valign="top">
        
        <table width="633" height="230" border="0" cellspacing="0" cellpadding="0" >
         <tr>
            <td width="25" height="30" align="center"><img src="image/arrow.gif" width="8" height="9" /></td>
            <td width="603" height="30" align="left" class="pink_text1">Question Set&nbsp;
               <%-- <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>--%>
                                                            </td>
          </tr>
          
          <tr>
          <td colspan="2">

              <asp:UpdatePanel ID ="uptimmer" runat ="server" >
        <ContentTemplate>
        <table width ="100%">
        <tr>
        <td align="left">
        
        <table  border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="90" align="center" class="font_text2">Set Time:</td>
                <td width="99" class="form_font"> <b> <asp:Label ID="lblTotalTime" runat="server" ></asp:Label></td></b>
             
                   </tr>
            </table> </td> 
            <td align="left">
            
             <table  border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="90" align="center" class="font_text2">Question :</td>
                <td width="99" class="form_font"> <b><asp:Label ID="lblRemainingQuestion" runat="server"></asp:Label></b></td>
             
                   </tr>
            </table>
             </td></tr>
         <tr>
        <td align="left">
        
        <table  border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="90" align="center" class="font_text2">Marks:</td>
                <td width="99" class="form_font"> <b> <asp:Label ID="lblMarks" runat="server" ></asp:Label></b></td>
             
                   </tr>
            </table> </td> 
            <td align="left">
            
             <table  border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="90" align="center" class="font_text2">Time left :</td>
                <td width="99" class="form_font"><b><asp:Label ID="LblTime" runat="server"
                           ></asp:Label></b><b> <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
                    </asp:Timer></b> </td>
             
                   </tr>
            </table>
             </td></tr>
          
      
                
        </table>
        </ContentTemplate>
        
        </asp:UpdatePanel>
    
          </td></tr>
          
          <tr>
<td colspan="2"  valign="top">

<asp:UpdatePanel ID="u1" runat="server">
<ContentTemplate>


<table  border="0" cellpadding="0" cellspacing="0" class="top_margin3" >
            <tr>
                <td  align="left" valign="top">
                    <asp:GridView ID ="GridView1" runat ="server" AutoGenerateColumns="False" 
                        AllowPaging="true" PageSize="1" ShowHeader="false" 
                         ShowFooter="false"   
                      onpageindexchanging="GridView1_PageIndexChanging" 
                onrowcommand="GridView1_RowCommand" onrowdatabound="GridView1_RowDataBound" >
                        <PagerSettings Visible="False" />
                        
                         <Columns >
                    <asp:TemplateField>
                    <ItemTemplate >
                    <table border="0" cellpadding="0"  cellspacing="0" width="100%">
                    <tr>
                <td height="30" align="left" valign="Middle" class="top_pinktab">
                <table width="80%" border="0" cellpadding="0" cellspacing="0" >
                  <tr>
                    <td  align="right">
                    <img src="image/arrow.gif" width="8" height="9" />
                    </td>
                    <td  class="white_hd">Question  <%#Container.DataItemIndex+1 %></td>
                     <asp:Label ID="Label2" runat="server" Text='<%#Eval("QuestionId") %>' 
                                Visible="false"></asp:Label>
                  </tr>
                  
                </table></td>
              </tr>
              <tr height"30">
              <td  align="left" valign="Middle" bgcolor="#eeeeee" colspan="2">
              <table  border="0" cellspacing="0" cellpadding="0" >
                      <tr height="30px">
                        <td width="17" >&nbsp;</td>
                        <td width="616" align="left" class="form_font">
                                <asp:Label ID="lblQuestionNo" runat="server" Visible ="False" 
                                                        CssClass="gridview" Font-Bold="True" Font-Size="Larger"  ></asp:Label>
                                                      <%--  <asp:Label ID="SubID" runat="server" Text ='<%# Eval("LevelId") %>' Visible ="false"></asp:Label>
                           <asp:Label ID="MainId" runat="server" Text ='<%# Eval("FunctionId") %>' Visible ="false"></asp:Label>--%>
                                                         <asp:Label ID="lblQuestionId" runat="server" Text='<%#Eval("QuestionId") %>' 
                                Visible="false"></asp:Label>
                                                   &nbsp;
                                                    <asp:Label ID="lblQuestion" runat="server" Text='<%# Eval("Question") %>' 
                                                        Font-Size="Medium"></asp:Label></a>
         
                        
                            
                             <asp:Label ID="lblCorrect" runat="server" Text ='<%# Eval("CorrectAnswer") %>' Visible ="false"></asp:Label>
                       
                        
                          <%--<asp:Label ID="SetId" runat="server" Text='<%#Eval("SubjectId") %>' Visible="false"></asp:Label>--%>
                                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("CorrectAnswer") %>' 
                                                        Visible="false"></asp:Label>
                        
                        </td>
                      </tr>
                      <tr>
                        <td>&nbsp;</td>
                        <td height="40" align="left" class="black_b">Ans:</td>
                      </tr>
                      <tr>
                        <td height="30" >&nbsp;</td>
                        <td align="left">
                        
                        <table width ="30%" >
                <tr height="30px" >
                <td width ="10%" >
                
                   
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="set" 

oncheckedchanged="RadioButton1_CheckedChanged"   />
                                                    
                </td>
                
                  <td width ="80%" >
                
                     <asp:Label ID="lblOption1" runat="server" Text='<%# Eval("Option1") %>' 
                                                        Font-Size="Medium"></asp:Label>
                
                </td>
                </tr>
                 <tr height="30px" >
                <td width ="20%" >
                
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="set"  

oncheckedchanged="RadioButton1_CheckedChanged"   />
                
                </td>
                
                  <td width ="80%" >
                
                      <asp:Label ID="lblOption2" runat="server" Text='<%# Eval("Option2") %>' 
                                                        Font-Size="Medium"></asp:Label>
                
                </td>
                </tr>
                 <tr height="30px" >
                <td width ="20%" >
                
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="set" 

oncheckedchanged="RadioButton1_CheckedChanged"   />
                
                </td>
                
                  <td width ="80%" >
                
                       <asp:Label ID="lblOption3" runat="server" Text='<%# Eval("Option3") %>' 
                                                        Font-Size="Medium"></asp:Label>
                </td>
                </tr>
                 <tr  height="30px">
                <td width ="20%" >
                
                     <asp:RadioButton ID="RadioButton4" runat="server" GroupName="set" 

oncheckedchanged="RadioButton1_CheckedChanged"  />
                   
                </td>
                
                  <td width ="80%" >
                
                      <asp:Label ID="lblOption4" runat="server" Text='<%# Eval("Option4") %>' 
                                                        Font-Size="Medium"></asp:Label>
                      
                
                </td>
                </tr>


                           <tr  height="30px">
                <td width ="20%" >
                
                     <asp:RadioButton ID="RadioButton5" runat="server" GroupName="set"

oncheckedchanged="RadioButton1_CheckedChanged"  />
                   
                </td>
                
                  <td width ="80%" >
                
                      <asp:Label ID="lblOption5" runat="server" Text='<%# Eval("Option5") %>' 
                                                        Font-Size="Medium"></asp:Label>
                      
                
                </td>
                </tr>


                           <tr  height="30px">
                <td width ="20%" >
                
                     <asp:RadioButton ID="RadioButton6" runat="server" GroupName="set" 

oncheckedchanged="RadioButton1_CheckedChanged"  />
                   
                </td>
                
                  <td width ="80%" >
                
                      <asp:Label ID="lblOption6" runat="server" Text='<%# Eval("Option6") %>' 
                                                        Font-Size="Medium"></asp:Label>
                      
                
                </td>
                </tr>

               
                 <tr height="30px">
                <td width ="20%" >
                
                </td>
                
                  <td width ="80%" > <asp:Label ID="lblHint" runat="server"  Text ='<%# Eval("Hint") %>' Visible="false"></asp:Label>
                
                </td>
                </tr>
                </table>
                        
                        
                        </td>
                       
                      </tr>
                                            
                    </table>
              </td>
              
              </tr>
                    </table>
                    </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
                    
                    </td>
              </tr>
              <tr height="30px">
               <td align="left">
    <asp:Label ID="lblGuid" runat="server" Visible="False"></asp:Label>
    </td> </tr><tr>
<td align ="center" >
    <%--<asp:ImageButton ID="iBtnPrevious" runat="server" EnableViewState="False" 
        ImageUrl ="~/USER/image/previous.jpg" onclick="iBtnPrevious_Click" 
        Visible="true" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="ibtnNext" runat="server" ImageUrl="~/USER/image/next.jpg" 
        onclick="ibtnNext_Click" />--%>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="iBtnFinish" runat="server"  
        ImageUrl="~/USER/image/next.jpg" onclick="iBtnFinish_Click" 
       />
    &nbsp; &nbsp; &nbsp;
    <asp:ImageButton ID="iBtnFinish0" runat="server"  Visible="false"
                                    ImageUrl="~/USER/image/finish.jpg" 
        onclick="iBtnFinish0_Click" />
    
    
    </td>

</tr>
</table>

<div ID="divExam" runat="server" visible="false">
                <table width="100%">
                    <tr>
                        <td align="center">
                            <h3>
                                <b>Exam Completed Successfully  </b>
                            </h3>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style1">
                            <b>
                             <center >
<asp:Label ID="lblMessage" runat="server" ></asp:Label>
  
   
                            
                                &nbsp;
                                <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                           
                           </center> </b>
                        </td>
                    </tr>
                </table>
    </div>
 
 </ContentTemplate>
</asp:UpdatePanel>
                  </td>
                </tr>

             
          
                

            </table>

 

 

</td>
</tr>
          
          
   
          </table>
         

    <br />
   
    </td>

</tr>
</table>
</asp:Content>

