<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"  CodeFile="ExamTitleReport1.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript">
       
        
         function openurl1(obj,obj1) {
      
            //window.location.href = 'openurl.aspx?id=' + obj;
            window.open('Preview.aspx?id='+obj +'&SetId='+ obj1,'','scrollbars=no,menubar=no,height=300,width=500,resizable=yes,toolbar=no,location=no,status=no') ; 
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
                            <span class="que1">Exam Title</span>
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
                        <td colspan="2" height="235" valign="top">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="left" class="form_font" height="36" valign="middle">
                                  
                                    
                        <asp:GridView ID="gvMainTitle" runat="server" AutoGenerateColumns="False" 
                                 AllowPaging="True" onpageindexchanging="gvMainTitle_PageIndexChanging" 
                                            PageSize="20" onselectedindexchanged="gvMainTitle_SelectedIndexChanged" 
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
          <asp:Label ID="lblSettingId" runat="server" Text='<%#Eval("SettingId") %>' Visible="false"></asp:Label>
          <%--  <asp:Label ID="lblUser" runat="server" Text='<%#Eval("StudentId") %>' Visible="false" ></asp:Label>
              <asp:Label ID="lblQuestion" runat="server" Text='<%#Eval("TotalQuestion ") %>' Visible="false"></asp:Label>
                <asp:Label ID="lblanswer" runat="server" Text='<%#Eval("CorrectAnswer") %>' Visible="false"></asp:Label>--%>
                   <asp:Label ID="lblUserId" runat="server" Text='<%#Eval("UserId") %>' Visible="false" ></asp:Label>
                 <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("Users") %>' ></asp:Label>
          
            </ItemTemplate>
           
            </asp:TemplateField>
              <asp:TemplateField HeaderText = "Nos. of<br/> Attempted">
          
            <ItemTemplate>
             <asp:Label ID="lblAttempt" runat="server" Text='<%#Eval("Attempt") %>'></asp:Label>
          </ItemTemplate>
            
            </asp:TemplateField>
            
        <asp:TemplateField HeaderText = "Status">
          
            <ItemTemplate>
             <asp:Label ID="lblQulified" runat="server" Text='<%#Eval("Status") %>' ></asp:Label>
          </ItemTemplate>
            
            </asp:TemplateField>
             <asp:TemplateField HeaderText = "Pass Percentage">
          
            <ItemTemplate>
            <asp:Label ID="lblPassPercentage" runat="server"  Text='<%#Eval("Percentage") %>' ></asp:Label>
            </ItemTemplate>
            
            </asp:TemplateField>
             <asp:TemplateField HeaderText = "Print Preview" ShowHeader="false">
          
            
            <ItemTemplate>

            <asp:Panel ID="panel1" runat="server"> 

                <input type="button" name="val" value="Preview" onclick="openurl1('<%#Eval("UserId") %>','<%#Eval("SettingId") %>')" />
       </asp:Panel>
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
                               
               
                                                      
                        <asp:CommandField SelectText="Send Mail" ShowSelectButton="True"   
                                    ButtonType="Button"  />
                               
                               
                               
                                  
                                    
                                       
                                
                             
                                                            
                                                
                              
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
                
                

                
            </td>
        </tr>
         <tr height="30">
                        <td align="left"    colspan="2" valign="top">
                      
                     
                          
                        </td>
                    </tr>  
    </table>

</asp:Content>

