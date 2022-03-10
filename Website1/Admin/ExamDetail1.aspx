<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"  CodeFile="ExamDetail1.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript">
       
        
         function openurl1(obj) {
      
            //window.location.href = 'openurl.aspx?id=' + obj;
            window.open('ExamTitleReport.aspx?id='+obj,'','scrollbars=no,menubar=no,height=300,width=500,resizable=yes,toolbar=no,location=no,status=no') ; 
            
            
             
            
        }
        
       
        
    </script>
     <script type="text/javascript">
        function fixform() {
            if (opener.document.getElementById("aspnetForm").target != "_blank") return;

            opener.document.getElementById("aspnetForm").target = "";
            opener.document.getElementById("aspnetForm").action = opener.location.href;
            }
</script>
 <table align="center" border="0" cellpadding="0" cellspacing="0" >
        <tr>
            <td align="left" bgcolor="#FFFFFF" valign="top" width="710">
           
                <table border="0" cellpadding="0" cellspacing="0" class="top_margin" width="80%"  
                    height="277">
                       <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Exam Detail</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="r"> 
                      <asp:Label ID="lbltitle" runat="server" Text="" ForeColor="Red" ></asp:Label></td></tr>
                      
                        
                     
                      
                  
                   
                   <tr>
                        <td colspan="2" height="30"  valign="top" class="font_text" >
                         
                         Exam Title &nbsp;:&nbsp;<asp:Label ID="lblExamTitle" runat="server" ></asp:Label>


                           
                           </td>
                    </tr>
                     
                   <tr>
                        <td colspan="2" height="30"  valign="top" class="font_text" >
                         
                         Candidate &nbsp;:&nbsp;<asp:Label ID="lblName" runat="server" ></asp:Label>


                           
                           </td>
                    </tr>
                    <tr>
                        <td colspan="2" height="235" valign="top"  width="95%">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="left" class="form_font" height="36" valign="middle">
                                        <asp:GridView ID="gvMainTitle" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                                            OnPageIndexChanging="gvMainTitle_PageIndexChanging" PageSize="20" OnRowCommand="gvMainTitle_RowCommand"
                                            OnRowDeleting="gvMainTitle_RowDeleting" OnRowDataBound="gvMainTitle_RowDataBound"
                                            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
                                            CellPadding="2" CellSpacing="2" ForeColor="Black">
                                            <RowStyle BackColor="White" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="SrNo" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Top">
                                                    <ItemTemplate>
                                                        <%#Container.DataItemIndex+1 %>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Questions" ItemStyle-Width="100%">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td width="5%">
                                                                    Id :
                                                                </td>
                                                                <td>
                                                                    <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("ExamId") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>
                                                                    Q :
                                                                </td>
                                                                <td>
                                                                    <asp:Label ID="lblAttempt" runat="server" Text='<%#Eval("Question") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="2" align="left" width="100%">

                                                                
                                                                  <%--  <ol>--%>
                                                                        <asp:Panel ID="Panel_1" runat="server">
                                                                           <%-- <li>--%>
                                                                           <table border="0" cellpadding="0" cellspacing="0"> 
                                                                <tr><td width="3">1.&nbsp;</td><td><asp:Label ID="lbloption1" runat="server" Text='<%#Eval("option1") %>'></asp:Label> </td></tr>
                                                                           </table>
                                                                           <%-- </li>--%>
                                                                        </asp:Panel>
                                                                        <asp:Panel ID="Panel2" runat="server">
                                                                           <%-- <li>--%>
                                                                             <table border="0" cellpadding="0" cellspacing="0"> 
                                                                <tr><td width="3">2.&nbsp;</td><td><asp:Label ID="lbloption2" runat="server" Text='<%#Eval("option2") %>'></asp:Label><%--</li>--%>
                                                                </td></tr>
                                                                           </table>
                                                                        </asp:Panel>
                                                                        <asp:Panel ID="Panel3" runat="server">
                                                                           <%-- <li>--%>
                                                                             <table border="0" cellpadding="0" cellspacing="0"> 
                                                                <tr><td width="3">3.&nbsp;</td><td><asp:Label ID="lbloption3" runat="server" Text='<%#Eval("option3") %>'></asp:Label><%--</li>--%>
                                                                </td></tr>
                                                                           </table>
                                                                        </asp:Panel>
                                                                        <asp:Panel ID="Panel4" runat="server">
                                                                          <%--  <li>--%>
                                                                           <table border="0" cellpadding="0" cellspacing="0"> 
                                                                <tr><td width="3">4.&nbsp;</td><td><asp:Label ID="lbloption4" runat="server" Text='<%#Eval("option4") %>'></asp:Label><%--</li>--%>
                                                                </td></tr>
                                                                           </table>
                                                                        </asp:Panel>
                                                                        <asp:Panel ID="Panel5" runat="server">
                                                                           <%-- <li>--%>
                                                                            <table border="0" cellpadding="0" cellspacing="0"> 
                                                                <tr><td width="3">5.&nbsp;</td><td>  <asp:Label ID="lbloption5" runat="server" Text='<%#Eval("option5") %>'></asp:Label><%--</li>--%>
                                                                </td></tr>
                                                                           </table>
                                                                        </asp:Panel>
                                                                        <asp:Panel ID="Panel6" runat="server">
                                                                           <%-- <li>--%>
                                                                              <table border="0" cellpadding="0" cellspacing="0"> 
                                                                <tr><td width="3">6.&nbsp;</td><td><asp:Label ID="lbloption6" runat="server" Text='<%#Eval("option6") %>'></asp:Label><%--</li>--%>
                                                                </td></tr>
                                                                           </table>
                                                                        </asp:Panel>
                                                                   <%-- </ol>--%>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="2">
                                                                    Correct Answer :
                                                                    <asp:Label ID="lblPassPercentage9" runat="server" Text='<%#Eval("CorrectAnswer") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="2">
                                                                    Candidate Answer :
                                                                    <asp:Label ID="lblPassPercentage10" runat="server" Text='<%#Eval("StudentAnswer") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                            <FooterStyle BackColor="#CCCCCC" />
                                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                
              
                
                <asp:Button ID="btnExport" runat="server"

Text="Export to PDF" onclick="btnExport_Click"  OnClientClick="aspnetForm.target ='_blank';" Visible="false"/> &nbsp;<asp:Button ID="Button1" runat="server"

Text="Export to Excel" onclick="Button1_Click" Visible="false"  /> 
&nbsp; <asp:Button ID="btn_Mail" runat="server"

Text="SendMail" onclick="btn_Mail_Click1" Visible="false" /> 
<asp:Button ID="Button2" runat="server"

Text="View " onclick="Button2_Click" Visible="false"  />

<br />
                
            </td>
        </tr>
         <tr height="30">
                        <td align="left"    colspan="2" valign="top">
                        <asp:Panel ID="panel1" runat="server" Visible="false">
                        <table border="0" cellpadding="0" cellspacing="0" class="form_font"  width="100%">
                        <tr><th height="30px">
                            <asp:Label ID="lblMailto" runat="server" Text="Mail To"></asp:Label> &nbsp;:&nbsp; </th>
                            
                            <td> 
                                <asp:TextBox ID="txtMailto" runat="server"></asp:TextBox>
                                 <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator3" runat="server" ValidationGroup="vrg1" ControlToValidate="txtMailto" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                   
                                
                                </td>
                            </tr>
                              <tr><th height="30px">
                            <asp:Label ID="lblSubject" runat="server" Text="Subject"></asp:Label> &nbsp;:&nbsp; </th>
                            
                            <td height="30px"> 
                                <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                                 <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator1" runat="server" ValidationGroup="vrg1" ControlToValidate="txtSubject" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                  
                                </td>
                            </tr>
                          <tr>
                            
                            <td align="center" colspan="2" height="30px"> 
                             <asp:Button ID="btn_send" runat="server" Text="Send" onclick="btn_send_Click"  ValidationGroup="vrg1"/>
                                
                                </td>
                            </tr>
                        
                        
                        </table>
                        
                        </asp:Panel>
                     
                          
                        </td>
                    </tr>  
    </table>

</asp:Content>

