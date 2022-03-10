<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AddSubTitle.aspx.cs" Inherits="Admin_AddSubTitle"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: 14px;
        color: #a1215a;
        font-weight: bold;
        padding-left: 15px;
        width: 367px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" border="0" cellpadding="0" cellspacing="0" class="form_font">
        <tr>
            <td align="left" bgcolor="#FFFFFF" valign="top" width="710">
                <table border="0" cellpadding="0" cellspacing="0" class="top_margin02"  width="80%">
                  <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Add Sub Title</span>
                        </td>
                    </tr>
                    <tr>
                        <td height="30"  align="center" colspan="2">
                           <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                                            </td>
                    </tr>
                    <tr>
                        <td width="10%">
                            <b>Main Title</b></td>
                        <td class="style1" height="30" width="90%">
                            <asp:DropDownList ID="ddlMainTitle" runat="server" 
                                onselectedindexchanged="ddlMainTitle_SelectedIndexChanged" Width="120px">
                            </asp:DropDownList> &nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  Display="Dynamic"
                                ErrorMessage="*" ControlToValidate="ddlMainTitle" ValidationGroup="vrg" ></asp:RequiredFieldValidator>
                                            </td>
                    </tr>
                    <tr>
                        <td >
                           <b> Sub Title</b></td>
                        <td class="style1" height="30" >
                            <asp:TextBox ID="txtSubTitle" runat="server" Width="120px"></asp:TextBox>
&nbsp;
                                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2"  Display="Dynamic" 
                                runat="server" ControlToValidate="txtSubTitle" ValidationGroup="vrg"
                                ErrorMessage="*"></asp:RequiredFieldValidator>
                                            &nbsp;<asp:Button ID="btnSubmit" runat="server" Height="23px" Text="Add" 
                                Width="56px" BackColor="#CCCCCC" onclick="btnSubmit_Click" ValidationGroup="vrg"/>
                                            </td>
                    </tr>
                    <tr>
                        <td class="form_font02" colspan="2" >
                            <img height="9" src="images/arrow.gif" width="8" alt="arrow" /><span class="pink_text">List Main Title</span>
                            </td>
                    </tr>
                    <tr>
                        <td colspan="2" height="10" valign="top">
                            <img height="1" src="images/llist_line.gif" width="412" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" height="235">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="left" class="form_font" height="36" valign="middle">
                                        <asp:GridView ID="gvSubTitle" runat="server" AllowPaging="True" 
                                            AutoGenerateColumns="False" onpageindexchanging="gvSubTitle_PageIndexChanging" 
                                            PageSize="5" Width="100%" CaptionAlign="Top" 
                                            onrowcommand="gvSubTitle_RowCommand" 
                                            onrowdeleting="gvSubTitle_RowDeleting">
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="Sr No" ItemStyle-Width="10%" ItemStyle-HorizontalAlign="Center">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Main Title" ItemStyle-HorizontalAlign="Center">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <table width="100%">
                                                            <tr>
                                                                <td bgcolor="#5c5c5c" height="31" width="170">
                                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                        <tr>
                                                                            <td width="25">
                                                                                <img class="m_img" height="13" src="images/2arrow.gif" width="11" /></td>
                                                                            <td class="white_font" width="141">
                                                                                <asp:Label ID="Label1" runat="server" Text='<% # Bind("Title") %>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Sub Title" ItemStyle-HorizontalAlign="Center">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                          <table width="100%">
                                                            <tr>
                                                                <td bgcolor="#5c5c5c" height="31" width="170">
                                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                        <tr>
                                                                            <td width="25">
                                                                                <img class="m_img" height="13" src="images/2arrow.gif" width="11" /></td>
                                                                            <td class="white_font" width="141">
                                                                                <asp:Label ID="Label2" runat="server" Text='<% # Bind("SubTitle") %>'></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                              <%--  <asp:TemplateField ShowHeader="False">
                                                    <EditItemTemplate>
                                                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                                                            CommandName="Update" Text="Update"></asp:LinkButton>
                                                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                                            CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                                                    </EditItemTemplate>
                                                    
                                                </asp:TemplateField>--%>
                                                <asp:TemplateField ShowHeader="False" ItemStyle-Width="10%">
                                                    <ItemTemplate>
                                                        <table width="100%">
                                                            <tr>
                                                                <td align="center"  width="121">
                                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                                        <tr>
                                                                            <td >
                                                                <asp:ImageButton id="LinkButton4" runat="server" CausesValidation="false" CommandArgument='<%#Eval("SubID")%>' CommandName="Delete" 
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

