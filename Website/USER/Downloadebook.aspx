<%@ Page Title="" Language="C#" MasterPageFile="~/USER/USER.master" AutoEventWireup="true" CodeFile="Downloadebook.aspx.cs" Inherits="USER_Downloadebook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
    
    <tr>
    <td height="70" valign="top">
    <table border="0" cellpadding="0" cellspacing="0" width="30%" align="right" class="margin" >
             <tr><td > <asp:ImageButton ID="ImageButton1" ImageUrl ="~/Images/home_btn.gif" 
                runat="server" onclick="ImageButton1_Click"  
                /> </td><td>&nbsp;</td><td> 
              
              <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click"><img alt="img" border="0" src="../Images/history_btn.gif" /></asp:LinkButton>
             
           
         </td><td>&nbsp;</td><td>
                 <asp:ImageButton ID="imgdownloadebook" ImageUrl ="~/USER/image/download_e-book.png" runat="server" onclick="imgdownloadebook_Click" />
                </td><td>&nbsp;</td><td>  <asp:ImageButton ID="ImageButton21" ImageUrl ="~/Admin/images/lod_out.gif" runat="server" onclick="ImageButton21_Click" /> </td></tr>
             </table>
    </td>
    </tr>
   <tr>
    <td  align="center" valign="top" bgcolor="#FFFFFF">
    <table border="0" cellpadding="0" cellspacing="0" width="80%" class="form_font">
<tr>
            <td align="center" bgcolor="#ffffff" height="30" valign="top" >
              <strong>  Welcome &nbsp;<asp:Label ID="lblUsername" runat="server"></asp:Label> </strong>
                
                </td>

                </tr>
                <tr>
                
            <td align="center" bgcolor="#ffffff" height="15" valign="top">
              &nbsp;<br />
                </td>
                </tr>
                
<tr><td align="left" valign="top">
<table align="center" border="0" cellpadding="0" cellspacing="0" width="80%">
        
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
                          PageSize="10" AllowPaging="True" AllowSorting="True" BackColor="#CCCCCC" 
                          BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
                          CellSpacing="2" ForeColor="Black" 
                          onpageindexchanging="gvExam_PageIndexChanging">
<RowStyle HorizontalAlign="Center" BackColor="White"></RowStyle>
                    <Columns>
                    <asp:TemplateField HeaderText="SrNo" ItemStyle-Width="5%">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Exam Title" ItemStyle-Width="75%">
                          
                            <ItemTemplate>
                                    <table width ="100%" border="1"  cellpadding="0" cellspacing="0">
                                    <tr>
                                    <td bgcolor="#5c5c5c" height="20px">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                    
                                                        <tr>
                                                            <td class="white_font" width="141">
                                                               <asp:Label ID="Label2" CssClass="white_font gridviewdata"  runat="server" class="white_font" Text ='<% # Bind("FileTile") %>'></asp:Label>
                                                                </td>
                                                        </tr>
                                                    </table>
                                                  </td>
                                                 </tr>
                                    </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Download" ItemStyle-Width="20%">
                            <ItemTemplate>
                                <a href='../Ebook/<%#Eval("FileName")%>' target="_blank" class="form_font">Download</a>
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
         

    <br />
   
    </td>

</tr>
</table>

    
</asp:Content>

