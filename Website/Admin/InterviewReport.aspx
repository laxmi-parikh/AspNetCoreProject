<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"  CodeFile="InterviewReport.aspx.cs" Inherits="Admin_Default2" %>

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
                            <span class="que1">Interview Report</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="r"> 
                      <asp:Label ID="lbltitle" runat="server" Text="" ForeColor="Red" ></asp:Label></td></tr>
                      
                        
                       <tr height="30px">
                   
                    <td class="form_font" valign="top">&nbsp;<b>Interview </b></td>
                    <td  align="left" valign="top"><label>
                      <asp:DropDownList ID="DropDownList2" runat="server">
                          <asp:ListItem Text="Select" Value="0"> </asp:ListItem>
                            <asp:ListItem Text="Interview" Value="1"> </asp:ListItem>
                            <asp:ListItem Text="Induction" Value="2"> </asp:ListItem>
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
                  
                      
                  
                   
                   <tr>
                        <td colspan="2" height="30"  valign="top" class="font_text" >
                         
                        <asp:Label ID="lblExamTitle" runat="server" ></asp:Label>
                           
                           </td>
                    </tr>
                    <tr>
                        <td colspan="2" height="235" valign="top">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="left" class="form_font" height="36" valign="middle">
                                  
                                    
                        <asp:GridView ID="gvMainTitle" runat="server" AutoGenerateColumns="False" 
                                 AllowPaging="True" onpageindexchanging="gvMainTitle_PageIndexChanging" 
                                            PageSize="20" 
                                            onrowcommand="gvMainTitle_RowCommand" 
                                            onrowdeleting="gvMainTitle_RowDeleting" 
                                            onrowdatabound="gvMainTitle_RowDataBound" BackColor="#CCCCCC" 
                                            BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="2" 
                                            CellSpacing="2" ForeColor="Black">
                            <RowStyle BackColor="White" />
                            <Columns>
                            
                                                   
                            
                           
                                <asp:TemplateField HeaderText="SrNo">
                                    
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText=" User Name">
            <ItemTemplate>
      <%--    <asp:Label ID="lblSettingId" runat="server" Text='<%#Eval("SetID") %>' Visible="false"></asp:Label>
            <asp:Label ID="lblUser" runat="server" Text='<%#Eval("StudentId") %>' Visible="false" ></asp:Label>
              <asp:Label ID="lblQuestion" runat="server" Text='<%#Eval("TotalQuestion ") %>' Visible="false"></asp:Label>
                <asp:Label ID="lblanswer" runat="server" Text='<%#Eval("CorrectAnswer") %>' Visible="false"></asp:Label>
  --%>             <a href="ExamDetail.aspx?UserId=<%#Eval("UserId") %> &SetId=<%#Eval("SettingId") %>" style="text-decoration:none;"  >
     <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("Users") %>'  ></asp:Label> </a>
          
            </ItemTemplate>
           
            </asp:TemplateField>

             <asp:TemplateField HeaderText = "Exam Title">
          
            <ItemTemplate>
             <asp:Label ID="lblAttempt" runat="server" Text='<%#Eval("Exam_Title") %>'></asp:Label>
          </ItemTemplate>
            
            </asp:TemplateField>

            
               <asp:TemplateField HeaderText = "Nos. of<br/> Attempted">
          
            <ItemTemplate>
             <asp:Label ID="lblAttempt" runat="server" Text='<%#Eval("Attempt") %>'></asp:Label>
          </ItemTemplate>
            
            </asp:TemplateField>

            
        <asp:TemplateField HeaderText = "Status">
          
            <ItemTemplate>
             <asp:Label ID="lblQulified" runat="server" Text='<%#Eval("Status") %>'></asp:Label>
          </ItemTemplate>
            
            </asp:TemplateField>
             <asp:TemplateField HeaderText = "Percentage Achieved">
          
            <ItemTemplate>
            <asp:Label ID="lblPassPercentage" runat="server" Text='<%#Eval("Percentage") %>' ></asp:Label>
            </ItemTemplate>
            
            </asp:TemplateField>
        <%-- <asp:TemplateField HeaderText = "Email">
          
            <ItemTemplate>
             
             
             
             <input type="button" name="val" value="Send Mail" onclick="openurl1('<%#Eval("StudentId") %>')" />--%>
             
             
         <%--   <input type="radio" name="bookingid" value="<%#Eval("StudentId") %>" />--%>
              <%--     <input type="checkbox" name="chk" ID="lkbtn" onchecked='return openurl1("<%#Eval("RegisterId") %>","<%#Eval("BookingId") %>");' />
    --%>
         
  <%-- <asp:CheckBox ID="CheckBox1" runat="server" 
                    oncheckedchanged="CheckBox1_CheckedChanged"  AutoPostBack="true"/>--%>
                    
                   
              <%--      </ItemTemplate>
            
            </asp:TemplateField>
                                --%>
                               
                               
                 
                                                
                              
                          <%-- <asp:CommandField SelectText="Send Mail" ShowSelectButton="True"  
                                    ButtonType="Button" />--%>
                               
                               
                               
                               
                                  
                                    
                                       
                                
                             
                                                            
                                                
                              
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

Text="Export to Excel" onclick="Button1_Click"   /> 
&nbsp; <asp:Button ID="btn_Mail" runat="server"

Text="SendMail" onclick="btn_Mail_Click1"  /> 
<asp:Button ID="Button2" runat="server"

Text="View " onclick="Button2_Click"  Visible="false"  />

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

