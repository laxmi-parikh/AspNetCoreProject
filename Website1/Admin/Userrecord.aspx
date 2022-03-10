<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Userrecord.aspx.cs" Inherits="Admin_Userrecord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table border="0" width="100%" cellpadding="0" cellspacing="0" class="form_font02" >
        <tr>
            <td bgcolor="#FFFFFF" valign="top" align="left" >
                <table border="0" cellpadding="0" cellspacing="0"  class="top_margin02">
                       <tr height="30">
                        <td align="left" class="top_pinktab"   colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">User Record</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="form_font"> 
                      <asp:Label ID="lbltitle" runat="server" Text=""  ForeColor="Red"></asp:Label></td></tr>
                      
                        
                      
                    <tr>
                        <td width="20%" class="form_font02">
                            <b>User Name</b>
                        </td>
                        <td height="30" width="100%">
                            <asp:Label ID="lblfullname" runat="server" CssClass="form_font"></asp:Label>
                            
                        </td>
                    </tr>
                    <tr>
                        <td width="20%" class="form_font02">
                            <b>Technical</b>
                        </td>
                        <td height="30" width="100%">
                            <asp:Label ID="lbltechnical" runat="server" CssClass="form_font"></asp:Label>
                            
                        </td>
                    </tr>
                    <tr>
                        <td class="form_font02" colspan="2" >
                            <img height="9" src="images/arrow.gif" width="8" alt="arrow" /><span class="pink_text">List Of Level attempted</span>
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
                                Width="100%" AllowPaging="True" PageSize="10" 
                                            onpageindexchanging="gvFunction_PageIndexChanging" 
                                             onrowdeleting="gvFunction_RowDeleting" >
                            <Columns>
                                <asp:TemplateField HeaderText="SrNo" ItemStyle-Width="10%" ItemStyle-CssClass="gridviewdata">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Level" ItemStyle-Width="45%" ItemStyle-CssClass="gridviewdata">
                                    <EditItemTemplate>
                                        <asp:Label ID="TextBox1" runat="server" ></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text ='<% # Bind("TitleForExam") %>'></asp:Label>  
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Number of attempt" ItemStyle-Width="45%" ItemStyle-CssClass="gridviewdata">
                                    <EditItemTemplate>
                                        <asp:Label ID="TextBox1" runat="server" ></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text ='<% # Bind("SettingId") %>'></asp:Label>  
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
                                <%--<asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                    
                                    <table width ="100%" >
                                    <tr>
                                       <td align="center"  width="121">
                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                        <tr>
                                                            <td >
                                                                <asp:ImageButton id="LinkButton4" runat="server" CausesValidation="false" CommandArgument='<%#Eval("Functionid")%>' CommandName="Delete" 
                                                            ImageUrl="images/delete001.gif" />
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                    </tr>
                                   
                                    </table>
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
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

