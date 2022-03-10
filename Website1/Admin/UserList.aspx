<%@ Page Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="Admin_AddMainTitle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" border="0" cellpadding="0" cellspacing="0" class="form_font02 " >
        <tr>
            <td align="left" bgcolor="#FFFFFF" valign="top" width="80%">
                <table border="0" cellpadding="0" cellspacing="0" class="top_margin02 " height="277">
                       <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">User List</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="r"> 
                      <asp:Label ID="lbltitle" runat="server" Text="" ForeColor="Red" ></asp:Label></td></tr>
                      
                        
                     
                  
                        <td colspan="2" height="10" valign="top">
                            <img height="1" src="images/llist_line.gif" width="100%" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" height="235">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="left"  height="36" valign="middle">
                        <asp:GridView ID="gvMainTitle" runat="server" AutoGenerateColumns="False" 
                                Width="100%" AllowPaging="True" onpageindexchanging="gvMainTitle_PageIndexChanging" 
                                            PageSize="20" onselectedindexchanged="gvMainTitle_SelectedIndexChanged" 
                                            onrowcommand="gvMainTitle_RowCommand" onrowdeleting="gvMainTitle_RowDeleting">
                                            <HeaderStyle Height="25" />
                            <Columns>
                            
                                                   
                            
                           
                                <asp:TemplateField HeaderText="SrNo">
                                   
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="Employee Code">
                                   
                                    <ItemTemplate>
                                     <%#Eval("EmployeeCode")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="User Name">
                                    
                                    <ItemTemplate>
                                    <table >
                                    <tr>
                                    
                                   
                                    <td bgcolor="#5c5c5c" height="31" width="170">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                        <tr>
                                                            <td width="25">
                                                                <img class="m_img" height="13" src="images/2arrow.gif" width="11" /></td>
                                                            <td class="white_font" width="141">
                                                             <asp:Label ID="Label2" runat="server" Text ='<% # Bind("UserID") %>' Visible="false"></asp:Label> 
                                                             <a href='Userrecord.aspx?UserId=<%#Eval("UserId") %>' class="white_font" > <%#Eval("FirstName" )%>&nbsp;<%#Eval("LastName") %></a>
                                                             </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                 </tr>
                                    </table>
                                       
                                    </ItemTemplate>
                                </asp:TemplateField>
                              
                                  <asp:TemplateField HeaderText="Technical">
                                   
                                    <ItemTemplate>
                                     <%#Eval("Technical")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Email Id">
                                   
                                    <ItemTemplate>
                                     <%#Eval("EmailId")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Mobile No">
                                   
                                    <ItemTemplate>
                                     <%#Eval("MoblieNumber")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                    
                                    <table width ="100%" >
                                    <tr>
                                       <td align="center"  width="21">
                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                        <tr>
                                                            <td class="R_font">
                                                            <%-- <a class="r" href="#">Delete</a>--%>
                                                              </td>
                                                            <td class="R_font">
                                                              <asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" 
                                            CommandName="Delete"  CommandArgument='<%#Eval("UserId")%>' >
                                           
                                                                <img height="14" src="images/delete001.gif" width="14" border ="0"/>
                                                                </asp:LinkButton>
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                    </tr>
                                    
                                    </table>
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Edit">
                                   
                                    <ItemTemplate>
                                     <a href='EditUserList.aspx?UserId=<%#Eval("UserId") %>' class="font_text2" >Edit</a>
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

