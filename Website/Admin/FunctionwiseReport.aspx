<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="FunctionwiseReport.aspx.cs" Inherits="Admin_UserReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" width="100%" cellpadding="0" cellspacing="0" class="form_font02" >
        <tr>
            <td bgcolor="#FFFFFF" valign="top" align="left" >
                <table border="0" cellpadding="0" cellspacing="0" width="90%" class="top_margin02">
                       <tr height="30">
                        <td align="left" class="top_pinktab"   colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Functional Wise Report</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="form_font"> 
                      <asp:Label ID="lbltitle" runat="server" Text=""  ForeColor="Red"></asp:Label></td></tr>
                      
                        
                      
                    <tr>
                        <td width="10%" class="form_font02">
                            <b>Function</b>
                        </td>
                        <td height="30" width="90%">
                            <asp:DropDownList ID="ddlusername" runat="server" >

                                </asp:DropDownList>

                             &nbsp;&nbsp;
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" BackColor="#CCCCCC" 
                                ValidationGroup="vrg" onclick="btnSubmit_Click" />


                            
                        </td>
                    </tr>
                   <%-- <tr>
                        <td width="20%" class="form_font02">
                            <b>Technical</b>
                        </td>
                        <td height="30" width="100%">
                            <asp:Label ID="lbltechnical" runat="server" CssClass="form_font"></asp:Label>
                            
                        </td>
                    </tr>--%>
                    <tr>
                        <td class="form_font02" colspan="2" >
                            <img height="9" src="images/arrow.gif" width="8" alt="arrow" /><span class="pink_text">List Of Level</span>
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
                                Width="80%" AllowPaging="True" PageSize="20" 
                                            onpageindexchanging="gvFunction_PageIndexChanging" AllowSorting="True" 
                                            onrowdatabound="gvFunction_RowDataBound">
                                            <HeaderStyle Height="25" />
                            <Columns>
                                <asp:TemplateField HeaderText="SrNo" ItemStyle-Width="10%" ItemStyle-CssClass="gridviewdata">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="User Name" ItemStyle-Width="20%" ItemStyle-CssClass="gridviewdata">
                                    <EditItemTemplate>
                                        <asp:Label ID="TextBox1" runat="server" ></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                    <asp:Label ID="lblUserId" runat="server" Text ='<% # Bind("UserId") %>' Visible="false"></asp:Label> 
                                        <asp:Label ID="Label1" runat="server" Text ='<% # Bind("FirstName") %>'></asp:Label>  
                                         <asp:Label ID="Label2" runat="server" Text ='<% # Bind("LastName") %>'></asp:Label> 
                                    </ItemTemplate>
                                </asp:TemplateField>
                               <asp:TemplateField HeaderText="Detail" ItemStyle-Width="25%"  ItemStyle-HorizontalAlign="Center" ItemStyle-CssClass="gridviewdata">
                                    <EditItemTemplate>
                                      
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                      
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                                        <Columns>
                                        <asp:TemplateField HeaderText="Level">
                                         <ItemTemplate>
                                         
                                             <asp:Label ID="lblLevel" runat="server" Text='<%#Eval("Level") %>'></asp:Label>
                                         </ItemTemplate>
                                        
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Status">
                                         <ItemTemplate>
                                         
                                             <asp:Label ID="lblLevel" runat="server" Text='<%#Eval("Status") %>'></asp:Label>
                                         </ItemTemplate>
                                        
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="Percentage(%)">
                                         <ItemTemplate>
                                         
                                             <asp:Label ID="lblLevel" runat="server" Text='<%#Eval("Percentage") %>'></asp:Label>
                                         </ItemTemplate>
                                        
                                        </asp:TemplateField>
                                        </Columns>
                                        
                                        </asp:GridView>

                                    </ItemTemplate>
                                </asp:TemplateField>
                                <%-- <asp:TemplateField HeaderText="Percentage" ItemStyle-Width="10%" ItemStyle-CssClass="gridviewdata">
                                    <EditItemTemplate>
                                        <asp:Label ID="TextBox1" runat="server" ></asp:Label>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text ='<% # Bind("Percentage") %>'></asp:Label>  
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
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

                    <tr><td>   <asp:Button ID="btn_Excel" runat="server" Text="Export to Excel" 
                            BackColor="#CCCCCC" onclick="btn_Excel_Click" 
                                /> 
                                <br /></td></tr>
                </table>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

