<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamReport.aspx.cs" ValidateRequest="false" Inherits="_default" %><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
<%--<script type="text/javascript" src="ckeditor/ckeditor.js"></script>--%>
   <style type="text/css">
      

body  {
	background-color: #888888;
	margin-top: 0px;
}
.wel_tab {
	background-image: url(images/wel_tab.gif);
	background-repeat: no-repeat;
	display: block;

</style>
   <link rel="stylesheet" type="text/css" href="style.css" />

<script type="text/javascript" src="ckeditor/ckeditor.js"></script>
    <link href="Js_css/themes/base/jquery.ui.all.css" rel="stylesheet" type="text/css" />
  
    <link href="Js_css/demos.css" rel="stylesheet" type="text/css" />
      <script src="Js_css/jquery-1.6.2.js" type="text/javascript"></script>
    <script src="Js_css/ui/jquery.ui.datepicker.js" type="text/javascript"></script>
    <script src="Js_css/ui/jquery.ui.widget.js" type="text/javascript"></script>
    <script src="Js_css/ui/jquery.ui.core.js" type="text/javascript"></script>

<script type="text/javascript">

    $(function () {
        $("#txtstartdate").datepicker({
            changeMonth: true,
            changeYear: true
        });
    });


    </script>
       
  

     <script type="text/javascript">

         $(function () {
             $("#txtenddate").datepicker({
                 changeMonth: true,
                 changeYear: true
             });
         });



     </script>

</head><body>
 <form id="form1" runat="server">

       <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" class="form_font">
  <tr>
    <td height="126" colspan="2" valign="bottom" class="headerbg"><table width="356" border="0" cellpadding="0" cellspacing="0" class="pad1">
      <tr>
        <td width="356" height="73" class="name" align="left"></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="70" colspan="2" align="right" valign="top" bgcolor="#FFFFFF"><table width="73" border="0" cellpadding="0" cellspacing="0" class="margin">
      <tr>
        <td height="28">
        
         <asp:ImageButton ID="ImageButton1" ImageUrl ="images/lod_out.gif"  runat="server" 
                onclick="ImageButton1_Click" />
                
        
        </td>
      </tr>
    </table>
       
      </td>
  </tr>
  <tr>
     <td width="290" height="404" align="center" valign="top" bgcolor="#FFFFFF"><p>&nbsp;</p>
    <table width="160" height="450" border="0" cellspacing="0" cellpadding="0">
       <tr>
   <%--  class="wel_tab"--%>
            <td align="left" valign="top" bgcolor="#f6f6f6" >
          <table width="160" height="400" border="0" cellspacing="0" cellpadding="0">
          <tr>
              <td height="30" align="left" class="wel"><a href="AddFunction.aspx"  class="wel">Add Function</a></td>
            </tr>
            <tr>
              <td height="30" align="left" class="wel"><a href="AddLevel.aspx" class="wel">Add Level</a></td>
            </tr>
       
             <tr>
              <td height="30" align="left" class="wel"><a href="Setting.aspx" class="wel">Title/Topic </a></td>
            </tr>
            
            <tr>
              <td height="30" align="left" class="wel"><a href="AddQuestion.aspx" class="wel">Add Question </a></td>
            </tr>
           
            <tr>
             <td height="30" align="left"  class="wel"><a href ="ListQuestion.aspx"  class="wel" >Questions List</a></td>
            </tr>
              
                 <tr>
              <td height="30" align="left" class="wel"><a href="SettingExam.aspx" class="wel">Settings Exam </a></td>
            </tr>

               <tr>
              <td height="30" align="left" class="wel"> <a href ="ListSetting.aspx" class="wel" >Settings List</a></td>
            </tr>
                   
              
            <tr>
              <td height="30" align="left" class="wel"> <a href ="ExamReport.aspx" class="wel" >Exam Report </a></td>
            </tr>   
            <tr>
              <td height="30" align="left" class="wel"> <a href ="UserList.aspx" class="wel" >Candidate List</a></td>
            </tr>  
                <tr>
              <td height="30" align="left" class="wel"> <a href ="UserReport.aspx" class="wel" >Candidate Report</a></td>
            </tr>
              <tr>
              <td height="30" align="left" class="wel"> <a href ="FunctionwiseReport.aspx" class="wel" >Function Report</a></td>
            </tr>
              <tr>
              <td height="30" align="left" class="wel"><a href="FileUpload.aspx" class="wel">Upload E-book</a></td>
            </tr>           
            <tr>
              <td height="30" align="left" class="wel"><a href="Emailaddressbook.aspx" class="wel">E-Mail</a></td>
            </tr>    
              <tr>
              <td height="30" align="left" class="wel"><a href="AddInterviewer.aspx" class="wel">Add Interview </a></td>
            </tr> 
             <tr>
              <td height="30" align="left" class="wel"><a href="ListSettingInterview.aspx" class="wel">Interview List </a></td>
            </tr>  
              <tr>
              <td height="30" align="left" class="wel"><a href="InterviewReport.aspx" class="wel">Interview Report </a></td>
            </tr>       
          
           <tr>
              <td height="34" align="left"> &nbsp;</td>
            </tr>

          </table>
          </td>
        
        </tr>

      </table>    
      
        </td>
    <td width="70%" align="left" valign="top" bgcolor="#FFFFFF">
    <%-- <table align="center" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="left" bgcolor="#FFFFFF" bordercolor="#5c5c5c" valign="top" 
                width="80%">--%>
                
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
                      <asp:Label ID="lbltitle" runat="server" Text="" ForeColor="Red" ></asp:Label></td></tr>
                      
                        
                     
                      
                  
                   
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
                        <td align="left"  colspan="2" valign="top">

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
                        </td>
                    </tr>
                </table>
           <%-- </td>
        </tr>
    </table>--%>
    
    
    
    
    </form>
</body>
</html>