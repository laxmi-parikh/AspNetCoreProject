<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ListSetting.aspx.cs" Inherits="Admin_ListQuestion"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <table width="90%" valign="top"  class="top_margin02"  ><tbody>  
     
      <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1" >List Of Setting</span>
                        </td>
                    </tr>
      <tr height="30px">
        <td colspan="2" align="center" class="form_font"> 
            <b><asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label></b>
           
        </td>
      </tr>
      
      <tr height="30px">
        <td colspan="2" align="center" class="form_font"> 
          Exam Time Table for this month and next month .To send mail
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true"
                oncheckedchanged="CheckBox1_CheckedChanged" /> 
           
        </td>
      </tr>
      
      
      
         <tr height="30px">
                    
                    <td class="form_font" valign="top" width="10%">&nbsp;<b>Function</b></td>
                    <td align="left" valign="top" width="90%">
                        <asp:DropDownList ID="ddlMainTitle" runat="server" AutoPostBack="True"  width="120px" 
                                                                        
                            onselectedindexchanged="ddlMainTitle_SelectedIndexChanged" 
                             >
                        </asp:DropDownList>
                      </td>
                  </tr>
                  <tr height="30px">
                   
                    <td class="form_font" valign="top">&nbsp;<b>Level</b></td>
                    <td  align="left" valign="top"><label>
                        <asp:DropDownList ID="ddlSubTitle" runat="server" width="120px" >
                        </asp:DropDownList>
                        
</label></td>
                  </tr>
                   <tr height="30px">
                   <td></td valign="top">
                    <td  class="form_font"  align="Left">
                     <asp:ImageButton ID="btn_Submit" runat="server"  ImageUrl="~/image/submit.gif" 
                            onclick="btn_Submit_Click"></asp:ImageButton>
                    
                    </td>
                  </tr>
                  
                  
                  
    
<tr height="30px">
<td colspan="2" valign="top" width="100%">
    <asp:GridView ID="gvQuestion" runat="server"  AllowPaging="True" 
        AutoGenerateColumns="False" onpageindexchanging="GridView1_PageIndexChanging" 
         onrowcommand="gvQuestion_RowCommand"  CssClass="form_font"
        onrowdeleting="gvQuestion_RowDeleting" 
        onrowdatabound="gvQuestion_RowDataBound" 
        onselectedindexchanged="gvQuestion_SelectedIndexChanged" PageSize="5">
        <Columns>
            <asp:TemplateField HeaderText="Sr No">
                
                <ItemTemplate>
                    <%#Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            
          
  
           
            <asp:TemplateField HeaderText=" Exam Title">
            <ItemTemplate>
            <%--<asp:Label ID="lblSettingId" runat="server" Text='<%#Bind("SettingId") %>' Visible="false"></asp:Label>--%>
            <asp:Label ID ="lblSettingId" runat = "server" Text = '<%#Bind("SettingId") %>' Visible="false"></asp:Label>
           <asp:Label ID="lblQuestion" runat="server" Text='<%#Bind("TitleForExam") %>' ></asp:Label>
            </ItemTemplate>
           
            </asp:TemplateField>
            
                 
            <asp:TemplateField HeaderText = "Total Question">
         
            <ItemTemplate>
             <asp:Label ID ="lblQuestionset" runat = "server" Text = '<%#Bind("QuestionSet") %>'></asp:Label>
            
            </ItemTemplate>
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText = "Marks">
            
            <ItemTemplate>
            <asp:Label ID ="lblMarks" runat = "server" Text = '<%#Bind("Setmarks") %>'></asp:Label>
            
            </ItemTemplate>
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText = "Time(Min)">
            
            <ItemTemplate>
            <asp:Label ID ="lblTimeLimit" runat = "server" Text = '<%#Bind("Timelimit") %>'></asp:Label>
            
            </ItemTemplate>
            </asp:TemplateField>
            
           <%--  <asp:TemplateField HeaderText = "No. of Questions To Display">
          
            <ItemTemplate>
             <asp:Label ID ="lblNoQuestion" runat = "server" Text = '<%#Bind("NumberofQuestionperpage") %>'></asp:Label>
            
            </ItemTemplate>
            
            </asp:TemplateField>--%>
           
           
             <asp:TemplateField HeaderText = "Pass Score(%)">
          
            <ItemTemplate>
             <asp:Label ID ="lblPassScore" runat = "server" Text = '<%#Bind("PassScore") %>'></asp:Label>
            
            </ItemTemplate>
            
            </asp:TemplateField>
             <asp:TemplateField HeaderText = "Pass Score Massage">
          
            <ItemTemplate>
             <asp:Label ID ="lblPassScoreMsg" runat = "server" Text = '<%#Bind("PassScoreMsg") %>'></asp:Label>
            
            </ItemTemplate>
            
            </asp:TemplateField>
             <asp:TemplateField HeaderText = "Fail Score Massage">
          
            <ItemTemplate>
             <asp:Label ID ="lblFailScoreMsg" runat = "server" Text = '<%#Bind("FailScoreMsg") %>'></asp:Label>
            
            </ItemTemplate>
            
            </asp:TemplateField>
       
       
            
            
            <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                    
                                    <table width ="100%" >
                                    <tr>
                                       <td align="center" bgcolor="#eeeeee" width="121">
                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                        <tr>
                                                            <td class="R_font">
                                                            <%-- <a class="r" href="#">Delete</a>--%>
                                                              </td>
                                                            <td class="R_font">
                                                              <asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" 
                                            CommandName="Delete"  CommandArgument='<%#Eval("SettingId")%>' >
                                           
                                                                <img height="14" src="images/R_cross.gif" width="14" border ="0"/>
                                                                </asp:LinkButton>
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
    <br />
    <br />
</td>
</tr>
</tbody>
</table>
</asp:Content>

