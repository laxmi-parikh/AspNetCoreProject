<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Setting.aspx.cs" ValidateRequest="false" Inherits="_default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">



     <link type="text/css" rel="Stylesheet" href="css/ui-lightness/jquery-ui-1.8.4.custom.css" />
     

       <script type="text/javascript" src="ckeditor/ckeditor.js"></script>
   


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
    
     
    <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Set Topic/Title For Questions Set</span>
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
              <table width="631" height="200px" cellspacing="0" cellpadding="0" border="0">
                  <tbody>
                 
             
                  
                  
                 
                  
                            <tr>
                    <td height="50" colspan="3">
                    <table width="100%" cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                        <tr>
                          <td height="50" class="style4">&nbsp;</td>
                          <td width="91" class="form_font"><b>Title/Topic</b></td>
                          <td width="516">
                          
                           
                          
                            <asp:TextBox ID="txtTitle" runat="server" Width="120px"></asp:TextBox>
                           
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"  Display="Dynamic" ValidationGroup="vrg" 
                                  ControlToValidate="txtTitle" ErrorMessage="*"></asp:RequiredFieldValidator>
                              
                            </td>
                        </tr>
                    </tbody></table>
                    </td>
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