<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AddInterviewer.aspx.cs" Inherits="Admin_AddFunction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" width="100%" cellpadding="0" cellspacing="0" class="form_font" >
        <tr>
            <td bgcolor="#FFFFFF" valign="top" align="left" >
                <table border="0" cellpadding="0" cellspacing="0"  width="90%"  class="top_margin02">
                       <tr height="30">
                        <td align="left" class="top_pinktab"   colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Add Interviewer/Induction</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="form_font"> 
                      <asp:Label ID="lbltitle" runat="server" Text=""  ForeColor="Red"></asp:Label></td></tr>
                      
                      <tr>
                        <td width="10%" class="form_font02">
                           Interview/Induction
                        </td>
                        <td class="pink_text" height="30" width="90%">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="Interview" Value="1"> </asp:ListItem>
                            <asp:ListItem Text="Induction" Value="2"> </asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="txtPassword" ErrorMessage="*" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>

                       
                            
                        </td>
                    </tr   
                      
                    <tr>
                        <td width="10%" class="form_font02">
                            Name
                        </td>
                        <td class="pink_text" height="30" width="90%">
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtName" ErrorMessage="*" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>

                         
                            
                        </td>
                    </tr>
                       <tr>
                        <td width="10%" class="form_font02">
                            Position
                        </td>
                        <td class="pink_text" height="30" width="90%">
                            <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtPosition" ErrorMessage="*" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>

                       
                            
                        </td>
                    </tr>

                      <tr>
                        <td width="10%" class="form_font02">
                            UserName
                        </td>
                        <td class="pink_text" height="30" width="90%">
                            <asp:TextBox ID="txtuserName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtuserName" ErrorMessage="*" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>

                       
                            
                        </td>
                    </tr

                    <tr>
                        <td width="10%" class="form_font02">
                            Password
                        </td>
                        <td class="pink_text" height="30" width="90%">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="txtPassword" ErrorMessage="*" Display="Dynamic" ValidationGroup="vrg"></asp:RequiredFieldValidator>

                       
                            
                        </td>
                    </tr>

                     <tr>
                        <td width="10%" class="form_font02">
                            
                        </td>
                        <td class="pink_text" height="30" width="90%">
                              <asp:Button ID="btnSubmit" runat="server" Height="23px" 
                                onclick="btnSubmit_Click" Text="Add" Width="56px" BackColor="#CCCCCC" ValidationGroup="vrg" />
                        &nbsp;&nbsp;
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="form_font02" colspan="2" >
                            <img height="9" src="images/arrow.gif" width="8" alt="arrow" /><span class="pink_text">List Interview/Induction</span>
                            </td>
                                                    
                    </tr>
                    <tr>
                        <td colspan="2" height="10" valign="top">
                            <img height="1" src="images/llist_line.gif" width="100%" alt="line" /></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="left" class="form_font" height="36" valign="middle">
                        <asp:GridView ID="gvFunction" runat="server" AutoGenerateColumns="False" 
                                Width="100%" AllowPaging="True" PageSize="20" 
                                            onpageindexchanging="gvFunction_PageIndexChanging" 
                                            onrowcommand="gvFunction_RowCommand" 
                                            onrowdeleting="gvFunction_RowDeleting" 
                                            onselectedindexchanged="gvFunction_SelectedIndexChanged" 
                                            onrowdatabound="gvFunction_RowDataBound">
                                            <HeaderStyle Height="25" />
                            <Columns>
                            
                                                   
                            
                           
                                <asp:TemplateField HeaderText="SrNo" ItemStyle-Width="10%">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Name" >
                                    <EditItemTemplate>
                                        <asp:Label ID="TextBox1" runat="server" ></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                    <table width="100%" >
                                    <tr>
                                    <td bgcolor="#5c5c5c" height="31">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                        <tr>
                                                            <td width="5%">
                                                                <img class="m_img" height="13" src="images/2arrow.gif" width="11" />
                                                                </td>
                                                            <td class="white_font" width="95%" align="left">
                                                             <asp:Label ID="Label2" runat="server" Text ='<% # Bind("InterviewId") %>' Visible="false"></asp:Label> 
                                                               <asp:Label ID="Label1" runat="server" Text ='<% # Bind("Name") %>'></asp:Label>  
                                                                
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                 </tr>
                                    </table>
                                       
                                    </ItemTemplate>
                                </asp:TemplateField>


                                  <asp:TemplateField HeaderText="Apply For Position" >
                                    <EditItemTemplate>
                                       
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                  
                                                             <asp:Label ID="lblInterview" runat="server" Text ='<% # Bind("Interview") %>' Visible="false"></asp:Label> 
                                                            <%#Eval("ApplyForPosition") %>
                                                                
                                                               
                                       
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Interview/Induction" >
                                   
                                    <ItemTemplate>
                                   
                                                             <asp:Label ID="lblInterviewer" runat="server" ></asp:Label> 
                                                          
                                                                
                                                           
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="UserName" >
                                   
                                    <ItemTemplate>
                                   
                                                  <%#Eval("UserName") %>          
                                                          
                                                    
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Password" >
                                   
                                    <ItemTemplate>
                                   
                                                  <%#Eval("Password")%>          
                                                          
                                                
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <%--<asp:TemplateField ShowHeader="False">
                                    <EditItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                                            CommandName="Update" Text="Update"></asp:LinkButton>
                                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                            CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                                    </EditItemTemplate>
                                    <ItemTemplate>--%>
                                   <%-- <table >
                                    
                                    <tr >
                                    <td align="center" bgcolor="#eeeeee" >
                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                        <tr>
                                                            <td class="G_font">
                                                                <a class="g" href="#">Edit</a></td>
                                                            <td>
                                                             <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" 
                                            CommandName="Edit" >
                                                                <img height="19" src="images/G_pencil.gif" width="18" border ="0" />
                                                                </asp:LinkButton>
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                    </tr>
                                    </table>--%>
                                    
                                       
                                 <%--  </ItemTemplate>
                                </asp:TemplateField>--%>
                                <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                    
                                    <table width ="100%" >
                                    <tr>
                                       <td align="center"  width="121">
                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                        <tr>
                                                            <td >
                                                                <asp:ImageButton id="LinkButton4" runat="server" CausesValidation="false" CommandArgument='<%#Eval("InterviewId")%>' CommandName="Delete" 
                                                            ImageUrl="images/delete001.gif" />
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                    </tr>
                                   
                                    </table>
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%--<asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("test") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("test") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                            </Columns>
                        </asp:GridView>
                        <br />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

