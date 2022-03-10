<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Download.aspx.cs" Inherits="Download" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" width="80%" class="form_font" align="center">
    <tr>
            <td align="center" bgcolor="#ffffff" height="30" valign="top" >
              
                
                </td>
                </tr>
<tr>
            <td align="center" bgcolor="#ffffff" height="30" valign="top" class="wel_text" >
              
                
                Download E-Book&#39;s</td>
                </tr>
              <%--  <tr>
                
            <td align="center" bgcolor="#ffffff" height="30" valign="top">
              &nbsp;<br />
                </td>
                </tr>
                <tr>--%>
                
<tr><td align="left" valign="top">
<table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
        
              <%--  <tr height="30px">
               <td align="left" bgcolor="#ffffff" height="30" valign="top">
                   &nbsp;<b>Category:</b>&nbsp;                                     </td><td align="left" valign="top">
                                    <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" 
                          onselectedindexchanged="ddlCategory_SelectedIndexChanged" Width="120px">
                         
                      </asp:DropDownList>
                  
                                    </td>
        </tr>
        
         <tr height="30px">
               <td align="left" bgcolor="#ffffff" height="30" valign="top">
                 <b>Sub Category:</b>
                                    </td>
                                    <td align="left" valign="top">
                                     <asp:DropDownList ID="ddlMainTitle0" runat="server"  Width="120px">
                                                    </asp:DropDownList>
                  
                                    </td>
        </tr>--%>
          
         <%--  <tr height="30px">
           <td></td>
               <td align="left" bgcolor="#ffffff" height="30" valign="top" >
                   <asp:ImageButton ID="ImageButton1" runat="server"  
                       ImageUrl="~/image/submit.gif" onclick="ImageButton1_Click"/>
                  
                                    </td>
        </tr>--%>
          
        <tr>
            <td align="left" bgcolor="#ffffff" 
                valign="top" width="5%"  >
                              &nbsp;      </td>
                  <td  align="center" valign="top">
                  
                <asp:GridView ID="gvExam" runat="server" AutoGenerateColumns="False"  
                          RowStyle-HorizontalAlign="Center" Width="100%" 
                          
                          AllowPaging="True" AllowSorting="True" 
                           BackColor="#CCCCCC" 
                          BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
                          CellSpacing="2" ForeColor="Black" 
                          onpageindexchanging="gvExam_PageIndexChanging">
<RowStyle HorizontalAlign="Center" BackColor="White"></RowStyle>
                    <Columns>
                    <asp:TemplateField HeaderText="SrNo" ItemStyle-Width="10%">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Exam Title" ItemStyle-Width="30%" ItemStyle-HorizontalAlign="Left">
                          
                            <ItemTemplate>
                                   <%-- <table width ="100%" border="1"  cellpadding="0" cellspacing="0">
                                    <tr>
                                    <td bgcolor="#5c5c5c" height="20px">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                    
                                                        <tr>
                                                            <td class="white_font" width="141">--%>
                                                               <asp:Label ID="Label2" CssClass="gridviewdata"  runat="server" Text ='<% # Bind("FileTile") %>'></asp:Label>
                                           <%--                     </td>
                                                        </tr>
                                                    </table>
                                                  </td>
                                                 </tr>
                                    </table>--%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Function" ItemStyle-Width="30%" ItemStyle-HorizontalAlign="Left">
                          
                            <ItemTemplate>
                                    <%--<table width ="100%" border="1"  cellpadding="0" cellspacing="0">
                                    <tr>
                                    <td bgcolor="#5c5c5c" height="20px">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                    
                                                        <tr>
                                                            <td class="white_font" width="141">--%>
                                                               <asp:Label ID="Label2" CssClass="gridviewdata"  runat="server"  Text ='<% # Bind("Functionname") %>'></asp:Label>
                                                             <%--   </td>
                                                        </tr>
                                                    </table>
                                                  </td>
                                                 </tr>
                                    </table>--%>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Download" ItemStyle-Width="20%">
                            <ItemTemplate>
                                <a href='Ebook/<%#Eval("FileName")%>' target="_blank" class="form_font">Download</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <EmptyDataTemplate >
                     <%--   Please Select a Category--%>
                    
                    </EmptyDataTemplate>
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
                
                 <br />
                <br />
                
                </td>
                
                  <td width="5%">
                <br />
                <br />
                      
                
                </td>
                </tr>
                
               
                
            </table>
             <br />
                <br />

</td></tr>

</table>

</asp:Content>

