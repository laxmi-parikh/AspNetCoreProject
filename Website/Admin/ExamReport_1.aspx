<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true"  EnableEventValidation="false" CodeFile="ExamReport_1.aspx.cs" Inherits="Admin_Default2"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%--<script language="javascript">
       
        
         function openurl(obj) {
      
            //window.location.href = 'openurl.aspx?id=' + obj;
            window.open('email.aspx?obj='+obj,'','scrollbars=no,menubar=no,height=300,width=500,resizable=yes,toolbar=no,location=no,status=no') ; 
            
                   
            
        }
    </script>
    <script type="text/javascript">
        function fixform() {
            if (opener.document.getElementById("aspnetForm").target != "_blank") return;

            opener.document.getElementById("aspnetForm").target = "";
            opener.document.getElementById("aspnetForm").action = opener.location.href;
            }
</script>--%>
<script type="text/javascript" src="js/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="js/jquery-ui-1.8.4.custom.min.js">
</script>

    <link href="css/ui-lightness/jquery-ui-1.8.4.custom.css" rel="stylesheet" type="text/css" />
    
    

<script type="text/javascript">
     $(function Start_Date1(txtstartdate)
     {
         $('#ctl00_ContentPlaceHolder1_txtstartdate').datepicker({ onSelect: function Start_Date1(txtstartdate, inst)
     
     {
      //alert(txtstartdate);
      }

 });

 $('#ctl00_ContentPlaceHolder1_txtstartdate').datepicker("close"); 
     }
     )
     </script>
     
    <script type="text/javascript" src="js/jquery-1.4.2.min.js"></script>
     <script type="text/javascript" src="js/jquery-ui-1.8.4.custom.min.js"></script>
     <script type="text/javascript">
     
     $(function Start_Date(txtenddate)
     {
     $('#ctl00_ContentPlaceHolder1_txtenddate').datepicker({ onSelect:function Start_Date(txtenddate,inst)
     
     {
      //alert(txtstartdate);
      }
      
     });
     $('#ctl00_ContentPlaceHolder1_txtenddate').datepicker("close"); 
     }
     )
     </script>
 
 <table align="center" border="0" cellpadding="0" cellspacing="0"  width="80%">
        <tr>
            <td align="left" bgcolor="#FFFFFF" valign="top" width="100%">
                <table border="0" cellpadding="0" cellspacing="0" class="top_margin" width="100%"  
                    height="277">
                       <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Exam Report</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="r"> 
                      <asp:Label ID="lbltitle" runat="server" Text="" ForeColor="Red" ></asp:Label></td>
                      </tr>
                      
                        
                     
                      
                  
                   
                    <tr>
                        <td colspan="2"  valign="top" align="right" >
                    <%--  <a href="email.aspx"> <img  src="images/Email.jpg" width="30" height="30" border="0" /></a>
                            <input type="image" ID="lkbtn" img="img"  src='images/Email.jpg' width='50' height='40' border='0' onclick='return openurl();'/>
         --%>
               
                         
                           </td>
                    </tr>
                    <tr>
                        <td colspan="2" height="235">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                <tr>
                                    <td align="left" class="form_font" height="36" valign="middle">
                            
                                 
                        <asp:GridView ID="gvMainTitle" runat="server" AutoGenerateColumns="False" 
                                Width="413px" AllowPaging="True" onpageindexchanging="gvMainTitle_PageIndexChanging" onselectedindexchanged="gvMainTitle_SelectedIndexChanged" 
                                            onrowcommand="gvMainTitle_RowCommand" 
                                            onrowdeleting="gvMainTitle_RowDeleting" 
                                            onrowdatabound="gvMainTitle_RowDataBound" BackColor="White" 
                                            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                                            ForeColor="Black" GridLines="Both"                                      
                                            >
                            <Columns>
                            
                                                   
                            
                           
                                <asp:TemplateField HeaderText="SrNo">
                                 
                                    <ItemTemplate>
                                    <%--<asp:Label ID ="lblSettingId" runat = "server" Text = '<%#Eval("SetId") %>'></asp:Label>--%>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText=" Exam Title">
            <ItemTemplate>
         
            <asp:Label ID ="lblSettingId" runat = "server" Text = '<%#Eval("SetId") %>' Visible="false"></asp:Label>
            <a href='ExamTitleReport.aspx?SettingId=<%#Eval("SetId") %>'> 
           <asp:Label ID="lblQuestion" runat="server" Text='<%#Eval("ExamTitle") %>' ></asp:Label></a>
            </ItemTemplate>
           
            </asp:TemplateField>
            
                                <asp:TemplateField HeaderText = "Start Date">
          
            <ItemTemplate>
            <asp:Label ID ="lblstartdate" runat = "server"  Text=' <%#Eval("StartDate","{0:dd/MM/yyyy}")%>' ></asp:Label>
      <%--  <%#Bind("Start_Date","{0:MM/dd/yyyy}")%>--%>
            
          </ItemTemplate>
            
            </asp:TemplateField>
             <asp:TemplateField HeaderText = "End Date">
          
            <ItemTemplate>
          <asp:Label ID ="lblenddate" runat = "server" Text = '<%#Eval("EndDate","{0:dd/MM/yyyy}")%>'></asp:Label>
   <%--    Text = '<%#Eval("End_Date","{0:MM/dd/yyyy}") %>'--%>
            </ItemTemplate>
            
            </asp:TemplateField>
                                
                                
                                 <asp:TemplateField HeaderText="No.of user Attempted" ItemStyle-HorizontalAlign="Center">
                                    <EditItemTemplate>
                                      
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                 <%-- <asp:Label ID="lblUserRegister1" runat="server" Visible="false" ></asp:Label> --%>
                                    <asp:Label ID="lblUserAttempt" runat="server"  Text='<%#Eval("Attempts") %>' ></asp:Label>
                                    <%--<asp:Label ID="lblUserAttempt" runat="server" Visible="true"  ></asp:Label>--%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="No. of user not attempted" ItemStyle-HorizontalAlign="Center">
                                    <EditItemTemplate>
                                      
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                     <asp:Label ID="lblUserNotAttempt" runat="server" Text='<%#Eval("NotAttempts") %>'  ></asp:Label>
                                     <%--<asp:Label ID="lblUserNotAttempt" runat="server" ></asp:Label>--%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               
                               
                               
                              
                                    
                                       
                                
                             
                                                            
                                                
                              
                            </Columns>
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
                        
                        
                       <%--  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />--%>
        <br />
       
      <%--  <asp:Label ID="Label1" runat="server" Text="Label"  Visible="false"></asp:Label>--%>
                        
                       
                       
 <asp:Button ID="btnExport" runat="server" Width="90"

Text="Export to PDF" onclick="btnExport_Click"  OnClientClick="aspnetForm.target ='_blank';" Visible="false"/>&nbsp;&nbsp;

<asp:Button ID="btnexportExcel" runat="server" Width="100"

Text="Export to Excel"  onclick="btnexportExcel_Click"/> &nbsp;&nbsp;

<asp:Button ID="btnSend" runat="server" Width="80"

Text="Send Mail" onclick="btnSend_Click"  />


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
                                    ID="RequiredFieldValidator2" runat="server" ValidationGroup="vrg" ControlToValidate="txtMailto" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                   
                                
                                </td>
                            </tr>
                              <tr><th height="30px">
                            <asp:Label ID="lblSubject" runat="server" Text="Subject"></asp:Label> &nbsp;:&nbsp; </th>
                            
                            <td height="30px"> 
                                <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator1" runat="server" ValidationGroup="vrg" ControlToValidate="txtSubject" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                            </tr>
                          <tr>
                            
                            <td align="center" colspan="2" height="30px"> 
                             <asp:Button ID="btn_send" runat="server" Text="Send" onclick="btn_send_Click" ValidationGroup="vrg"/>
                                
                                </td>
                            </tr>
                        
                        
                        </table>
                        
                        </asp:Panel>
                         <asp:Panel ID="panel2" runat="server" Visible="false">
                        <table border="0" cellpadding="0" cellspacing="0" class="form_font"  width="100%">
                        <tr><th height="30px">
                           Start Date &nbsp;:&nbsp; </th>
                            
                            <td> 
                                <asp:TextBox ID="txtstartdate" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator3" runat="server" ValidationGroup="vrg1" ControlToValidate="txtstartdate" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                     (MM/dd/yyyy)
                                
                                
                                </td>
                            </tr>
                              
                              
                              <tr><th height="30px">
                           End Date &nbsp;:&nbsp; </th>
                            
                            <td> 
                                <asp:TextBox ID="txtenddate" runat="server"></asp:TextBox> 
                                 <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator4" runat="server" ValidationGroup="vrg1" ControlToValidate="txtenddate" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                              
                                </td>
                            </tr>
                          <tr>
                            
                            <td align="center" colspan="2" height="30px"> 
                               <asp:Button ID="btn_Export" runat="server" Text="Export Excel" ValidationGroup="vrg1"
                                    onclick="btn_Export_Click"  />
                                
                                
                                </td>
                            </tr>
                        
                        
                        </table>
                        
                        </asp:Panel>
                          
                          
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

