<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SettingExam.aspx.cs" ValidateRequest="false" Inherits="_default" %><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">



     <link type="text/css" rel="Stylesheet" href="css/ui-lightness/jquery-ui-1.8.4.custom.css" />
     
 
       <script type="text/javascript" src="ckeditor/ckeditor.js"></script>
   <script type="text/javascript">

       $(document).ready(function () {

           $("#rbtn_Manual").change(function () {
               var test = $(this).val();
               $("#").hide();
               $("#desc").show();
           });

           $("#rbtn_random").change(function () {
               var test = $(this).val();
               $("#desc").hide();
               $("#").show();
           });

       });
   
   
   
   </script>



     <script language="javascript" type="text/javascript">
     
function CheckNumericKeyCode(B)
    {
    var A;
    if(window.event)
    {
        A=event.keyCode
    }
    else
    {
        if(B.which)
        {
            A=B.which
        }
    }
    if((A==27||A==9||A==8||A==46||A==35||A==36||A==37||A==39)||(A>=48&&A<=57)||(A>=96&&A<=105))
    {
        return true
    }
    else
    {
        return false
    }
}




</Script>
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
  
  <script type="text/javascript">

      $(function () {
          $("#RadioButton1").change(function () {
               var test = $(this).val();
                  $('#Logindiv').hide();
                  $('#Div1').hide();
                  $('#Div2').show();
              });
          });
          $("#RadioButton2").change(function () {
               var test = $(this).val();
                $('#Logindiv').show();
                  $('#Div1').show();
                  $('#Div2').hide();
              });
          });
      });

</script>




</head><body><p>
&nbsp;</p>
 <form id="form1" runat="server">
    
    
   
    <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="126" colspan="2" valign="bottom" class="headerbg"><table width="356" border="0" cellpadding="0" cellspacing="0" class="pad1">
      <tr>
        <td width="356" height="73" class="name" align="left"></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="70" colspan="2" align="right" valign="top" bgcolor="#FFFFFF">
    <table width="73" border="0" cellpadding="0" cellspacing="0" class="margin">
      <tr>
        <td height="28">
        
         <asp:ImageButton ID="ImageButton1" ImageUrl ="images/lod_out.gif" runat="server" onclick="ImageButton1_Click1" 
                 />
         
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
    <td width="80%" align="left" valign="top" bgcolor="#FFFFFF">
     
                                              
                                                  <table width="633" height="339" cellspacing="0" cellpadding="0" border="0" class="top_margin">
    
      <%--<tr>
        <td width="10"><img width="8" height="9" src="images/arrow.gif"></td>
        <td width="255" height="30" class="pink_text">Exam Settings </td>
      </tr>
      <tr>
        <td valign="top" height="10" colspan="2"><img width="633" height="1" src="images/big_line.gif"></td>
      </tr>--%>
    <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Exam Setting</span>
                        </td>
                    </tr>
        <td colspan="2" align="center" height="30px"> 
            <asp:Label ID="lblMsg" runat="server"  CssClass="form_font" Text="" ForeColor="Red"></asp:Label>
           
        </td>
      </tr>
      <tr>
        <td height="37" colspan="2">
        <table width="633px" height="390" cellspacing="0" cellpadding="0" border="1" bgcolor="#eeeeee">
            <tbody><tr>
              <td valign="top" height="412" align="left">
              <table width="631" height="338px" cellspacing="0" cellpadding="0" border="0">
                  <tbody>
                  <br />
                     
                   <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>Title/Topic </b></td>
                          <td width="516">
                          
                             <asp:DropDownList ID="ddlQuestionSetTitle" runat="server" Width="120px"  AutoPostBack="true">
                        </asp:DropDownList>
                          
                          <%--  <asp:TextBox ID="txtTitle" runat="server" Width="120px"></asp:TextBox>--%>
                           
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtTitle" ErrorMessage="*"></asp:RequiredFieldValidator>
                              
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>

                   <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>Set </b></td>
                          <td width="516">
                          
                             
                          <b>
                              <asp:RadioButton ID="rbtn_random" runat="server" GroupName="set1" Checked="true" 
                                  Text="Random" oncheckedchanged="rbtn_random_CheckedChanged" AutoPostBack="true" />
                           
                             <asp:RadioButton ID="rbtn_Manual" runat="server" GroupName="set1"  Text="Manual"  AutoPostBack="true"
                                  oncheckedchanged="rbtn_Manual_CheckedChanged" />
                              </b>
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>

                   <tr>
                    <td  colspan="3">
                    
                    <asp:Panel ID="panel1" runat="server" >  
                    <table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font">
                         <b> Checkbox to Add Question to Set :</b>
                          <br />
                           <br />
<asp:GridView ID="gvQuestion" runat="server"  AllowPaging="True" 
        AutoGenerateColumns="False" onpageindexchanging="GridView1_PageIndexChanging" 
        Width="100%" onrowcommand="gvQuestion_RowCommand"  GridLines="Both"
        onrowdeleting="gvQuestion_RowDeleting"  RowStyle-HorizontalAlign="Left"
        onrowdatabound="gvQuestion_RowDataBound" PageSize="5">
        <Columns>
            <asp:TemplateField HeaderText="Sr No">
                <EditItemTemplate>
                      <%#Container.DataItemIndex+1 %>
                </EditItemTemplate>
                <ItemTemplate>
                    <%#Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Question">
            <ItemTemplate>
           <asp:Label ID="lblQuestion" runat="server" Text='<%#Eval("QuestionId") %>' Visible="false" ></asp:Label>
              <asp:Label ID="Label3" runat="server" Text='<%#Eval("Question") %>' ></asp:Label>
          
              <%--  <table width ="200Px" ><tr>
                <td>
                
               
                <asp:Literal ID="Label1"   runat="server"    
                        
                        Text='<%# System.Web.HttpUtility.HtmlDecode((string)Eval("question")) %>' />
         
                   </td>
                </tr>
                </table>--%>
                
       <%--     </ItemTemplate>
           
                <EditItemTemplate>--%>
                 <%--  <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("QuestionId") %>'></asp:TextBox>      --%>
               <%-- </EditItemTemplate>
                <ItemTemplate>--%>
            
               <%-- <table width ="200Px" ><tr>
                <td>
                
               
                <asp:Literal ID="Label1"   runat="server"    Text='<%# System.Web.HttpUtility.HtmlDecode((string)Eval("question")) %>' />
              
                   </td>
                </tr>
                </table>--%>
                </ItemTemplate>
            </asp:TemplateField>
            
         
        
            
         
            
            <asp:TemplateField HeaderText = "Option1">
            <EditItemTemplate>
           
            <table width = "100Px"></table>
            </EditItemTemplate>
            <ItemTemplate>
             <asp:Label ID ="Option1" runat = "server" Text = '<%#Bind("Option1") %>'></asp:Label>
             <asp:Image ID="Image2"  runat="server" Visible="false"></asp:Image>
            </ItemTemplate>
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText = "Option2">
            <EditItemTemplate>
            
            <table width = "100Px"></table>
            </EditItemTemplate>
            <ItemTemplate>
            <asp:Label ID ="Option2" runat = "server" Text = '<%#Bind("Option2") %>'></asp:Label>
            <asp:Image ID="Image3"  runat="server" Visible="false"></asp:Image>
            </ItemTemplate>
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText = "Option3">
            <EditItemTemplate>
            
            <table width = "100Px"></table>
            </EditItemTemplate>
            <ItemTemplate>
            <asp:Label ID ="Option3" runat = "server" Text = '<%#Bind("Option3") %>'></asp:Label>
            <asp:Image ID="Image4"  runat="server" Visible="false"></asp:Image>
            </ItemTemplate>
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText = "Option4">
            <EditItemTemplate>
           
            <table width = "100Px"></table>
            </EditItemTemplate>
            <ItemTemplate>
             <asp:Label ID ="Option4" runat = "server" Text = '<%#Bind("Option4") %>'></asp:Label>
             <asp:Image ID="Image5"  runat="server" Visible="false"></asp:Image>
            </ItemTemplate>
            
            </asp:TemplateField>
             <asp:TemplateField HeaderText = "Option5">
            <EditItemTemplate>
           
            <table width = "100Px"></table>
            </EditItemTemplate>
            <ItemTemplate>
             <asp:Label ID ="Option5" runat = "server" Text = '<%#Bind("Option5") %>'></asp:Label>
             <asp:Image ID="Image6"  runat="server" Visible="false"></asp:Image>
            </ItemTemplate>
            
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText = "Option6">
            <EditItemTemplate>
           
            <table width = "100Px"></table>
            </EditItemTemplate>
            <ItemTemplate>
             <asp:Label ID ="Option6" runat = "server" Text = '<%#Bind("Option6") %>'></asp:Label>
             <asp:Image ID="Image7"  runat="server" Visible="false"></asp:Image>
            </ItemTemplate>
            
            </asp:TemplateField>
            
            
           
             <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                 <table >
                                    <tr >
                                    <td align="center" bgcolor="#eeeeee" width="121">
                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                        <tr>
                                                            <td class="G_font">
                                                            
                                                               <%-- <a class="g" href='EditQUestion.aspx?QuestionId=<%# Eval("QuestionId") %>'  >Edit</a>--%>
                                                             <asp:CheckBox ID="CheckBox1" runat="server" 
                                  oncheckedchanged="CheckBox1_CheckedChanged" AutoPostBack="true" />
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                    </tr>
                                    </table>
                </ItemTemplate>
            </asp:TemplateField>
         
        </Columns>
    </asp:GridView>


                             
                            </td>
                        </tr>
                    </tbody>
                    
                    
                    </table>


                    </asp:Panel>
                    </td>
                  </tr>

                   
             <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>Exam </b></td>
                          <td width="516">
                          
                             
                          <b>
                              <asp:RadioButton ID="rbtn_common" runat="server" GroupName="set"  Text="Common" Checked="true" />
                           
                             <asp:RadioButton ID="rbtn_notcommon" runat="server" GroupName="set"  Text="Not Common" />
                              </b>
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
        
     <%--    <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>Exam Type  </b></td>
                          <td width="516">
                          
                             
                          <b>
                              <asp:RadioButton ID="RadioButton1" runat="server" GroupName="set3"  Text="Interview" />
                           
                             <asp:RadioButton ID="RadioButton2" runat="server" GroupName="set3"  Text="General" />
                              </b>
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>--%>



                   <tr>
                    <td height="50" colspan="3">
                    <div id="Logindiv"  > 
                    <table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>
                          
                              <asp:Label ID="Label1" runat="server" Text="Function"></asp:Label>
                           </b></td>
                          <td width="516"  class="form_font">   
                           
                            <asp:DropDownList ID="ddlMainTitle" runat="server" AutoPostBack="True" 
                                                                        
                            onselectedindexchanged="ddlMainTitle_SelectedIndexChanged" 
                            Width="120px" >
                        </asp:DropDownList></td>
                        </tr>
                    </tbody></table>
                    
                    </div>
                    
                    </td>
                  </tr>
                  
                  
                  <tr>
                    <td height="50" colspan="3">
                     <div id="Div1"  > 
                    <table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>
                          
                          <asp:Label ID="Label2" runat="server" Text="Level"></asp:Label>
                          </b></td>
                          <td width="516">
                          
                           
                           
                          <asp:DropDownList ID="DropDownList1" runat="server" Width="120px" 
                                 >
                        </asp:DropDownList></td>
                        </tr>
                    </tbody></table>
                    
                    </div>
                    </td>
                  </tr>
                
                  

                    <tr>
                    <td height="50" colspan="3">
                     <div id="Div2"  > 
                    <table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td  class="form_font" width="91"><b>
                          
                          <asp:Label ID="Label4" runat="server" Text="Interview"></asp:Label>
                           
                          </b></td>
                          <td width="516">
                        <asp:DropDownList ID="DropDownList2" runat="server">
                          <asp:ListItem Text="Select" Value="0"> </asp:ListItem>
                            <asp:ListItem Text="Interview" Value="1"> </asp:ListItem>
                            <asp:ListItem Text="Induction" Value="2"> </asp:ListItem>
                            </asp:DropDownList></td>
                        </tr>
                    </tbody></table>
                    </div>
                    </td>
                  </tr>


               
                        
                        
                        
                
                  
                 
                  
                            <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>Exam Title</b></td>
                          <td width="516">
                          
                             <asp:TextBox ID="txtTitle" runat="server" Width="120px" ></asp:TextBox>
                                   
                        
                          <%--  <asp:TextBox ID="txtTitle" runat="server" Width="120px"></asp:TextBox>--%>
                           
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtTitle" ErrorMessage="*"></asp:RequiredFieldValidator>
                              
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                  <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td height="50" class="style5">&nbsp;</td>
                          <td width="91" class="form_font"><b>Set Time</b></td>
                          <td width="516">
                          
                                                     
                              <asp:TextBox ID="txtsettime" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)"></asp:TextBox>
                            &nbsp;<b>Min.</b> &nbsp;<b>(Only digit values )</b>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"   Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtsettime" ErrorMessage="*"></asp:RequiredFieldValidator>
                              
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                  <tr>
                    <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td height="50" class="style6">&nbsp;</td>
                          <td width="91" class="form_font"><b>Set Marks</b> </td>
                          <td width="516">
                              <label>
                             
                         <asp:TextBox ID="txtmarks" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)"></asp:TextBox>&nbsp;&nbsp;<b>(Only digit values)</b>
 
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtmarks" ErrorMessage="*"></asp:RequiredFieldValidator>
                                  </label>
                            </td>
                        </tr>
                    </tbody></table></td>
                  </tr>
                <%--  <tr>
                      <td height="50" colspan="3"><table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50"  width="25">&nbsp;</td>
                        
                      
                           <td width="91" class="form_font">No.Of Questions To Displayed </td>
                           <td width="516">
                               <label>
                               
                              <asp:DropDownList ID="ddlqset" runat="server" Height="19px" Width="120px">
                              <asp:ListItem Value="1">1</asp:ListItem>
                              <asp:ListItem Value="5">5</asp:ListItem>
                              <asp:ListItem Value="10">10</asp:ListItem>
                                                  
                          </asp:DropDownList>
 
                              
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                   ControlToValidate="ddlqset" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                          </label>  </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                  --%>
                                     <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50" class="style4">&nbsp;</td>
                        
                      
                           <td width="91" class="form_font"><b>Total No. of Question</b> </td>
                           <td width="516">
                               <label>
                               
                                   <asp:TextBox ID="txtTotalQuestion" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)"></asp:TextBox>
                                                  
                          
 
                              
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"  Display="Dynamic"
                                   ControlToValidate="txtTotalQuestion" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                          </label>  </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                  
                  
                  
                         <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td height="50" class="style7">&nbsp;</td>
                           <td width="91" class="form_font"><b>Set Test Passmark</b></td>
                           <td width="516">
                              <label><asp:TextBox ID="txtsetpercentage" runat="server" Width="120px" onkeydown="return CheckNumericKeyCode(event)">80</asp:TextBox> <b>%</b>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic"
                                   ControlToValidate="txtsetpercentage" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                          </label></td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50" class="style4">&nbsp;</td>
                           <td width="91" class="form_font" valign="top"><b>Pass Score Message</b> </td>
                           <td width="516">
                          
                              <label>
                                  

                               <asp:TextBox ID="txtpassmsg" runat="server" TextMode="SingleLine" Width="120px"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic"
                                   ControlToValidate="txtpassmsg" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>
                             
                             
                               </label>
                            </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                  
               <tr>
                      <td height="50" colspan="3">
                      <table width="100%" cellspacing="1" cellpadding="0" border="0">
                        <tbody><tr>
                       <td height="50" class="style4">&nbsp;</td>
                        
                           <td width="91" class="form_font" valign="top">
                               <b>Fail Score Message</b> </td>
                           <td width="516" >
                               <label><asp:TextBox ID="txtfailmsg" runat="server" TextMode="SingleLine" Width="120px"></asp:TextBox> &nbsp;</label><asp:RequiredFieldValidator ID="RequiredFieldValidator6" 
                                Display="Dynamic"   runat="server" ControlToValidate="txtfailmsg" ErrorMessage="*" ValidationGroup="vrg"></asp:RequiredFieldValidator>&nbsp;&nbsp;
                            </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
                  
                  <tr>
                      <td height="50" colspan="3"><table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody><tr>
                          <td width="25" height="50">&nbsp;</td>
                           <td width="91" class="form_font">
                               </td>
                           <td width="516">
                              <label>
                                  

                              <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="images/submit.gif" 
                                  onclick="ImageButton2_Click" ValidationGroup="vrg" />
                               </label>
                            </td>
                    </tr>
                    </tbody></table></td>
                  </tr>
       
                  
<%--</tbody></td></tr></table>
</td></tr>--%>
</tbody></table>
                          
                                               
                                                
                                                    
                                                </td>
     
     
                                            </tr>
                                        </table>
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
    
    
    
    
    </form>
</body>
</html>