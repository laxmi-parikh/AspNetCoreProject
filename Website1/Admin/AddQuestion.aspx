<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddQuestion.aspx.cs" ValidateRequest="false" Inherits="_default" %><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
    <script src="Js_css/jquery-1.6.2.js" type="text/javascript"></script>
<script type="text/javascript">

    $(document).ready(function () {
        $("#btn").click(function () {
            $("#tab1").show("slow");
            $("#Div1").show("slow");
            $("#btn").hide();

        });
        $("#btn1").click(function () {
            $("#tab2").show("slow");
            $("#Div2").show("slow");
            $("#btn1").hide();



        });
        $("#btnhide").click(function () {
            $("#tab1").hide();
            $("#Div1").hide();
            $("#btn").show("slow");

            
        });
        $("#btnhide1").click(function () {
            $("#tab2").hide();
            $("#Div2").hide();
            $("#btn1").show("slow");

       

        });
    });
   
   
   
   </script>



</head>
<body>
    <form id="form1" runat="server">
    <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" class="form_font">
        <tr>
            <td height="126" colspan="2" valign="bottom" class="headerbg">
                <table width="356" border="0" cellpadding="0" cellspacing="0" class="pad1">
                    <tr>
                        <td width="356" height="73" class="name" align="left">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td height="70" colspan="2" align="right" valign="top" bgcolor="#FFFFFF">
                <table width="73" border="0" cellpadding="0" cellspacing="0" class="margin">
                    <tr>
                        <td height="28">
                            <asp:ImageButton ID="ImageButton1" ImageUrl="images/lod_out.gif" runat="server" OnClick="ImageButton1_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="290" height="404" align="center" valign="top" bgcolor="#FFFFFF">
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
                <table align="center" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="left" bgcolor="#FFFFFF" bordercolor="#5c5c5c" valign="top" width="80%">
                            <table border="0" cellpadding="0" cellspacing="0" class="top_margin" height="auto"
                                width="100%">
                                <tr height="30">
                                    <td align="left" class="top_pinktab" valign="middle" colspan="2">
                                        &nbsp;
                                        <img height="9" src="images/arrow.gif" />&nbsp; <span class="que1">Add Questions</span>
                                    </td>
                                </tr>
                                <tr height="30">
                                    <td colspan="2" align="center" bgcolor="#f5f5f5">
                                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" colspan="2" height="37" valign="top">
                                        <table align="left" bgcolor="#f5f5f5" border="1" bordercolor="#c7c7c7" cellpadding="0"
                                            cellspacing="0" height="auto" width="550">
                                            <tr>
                                                <td>
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                       
                                                        <tr>
                                                            <td class="style1" colspan="2">
                                                            </td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style4" height="40" valign="middle" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="70%">
                                                        <tr>
                                                            <td width="80px" align="left">
                                                                &nbsp;&nbsp;<b>Title/Topic</b>
                                                            </td>
                                                            <td width="7px">
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                <asp:DropDownList ID="ddlExamTitle" runat="server" Width="120px">
                                                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                     ControlToValidate="ddlMainTitle" ValidationGroup="G1" ErrorMessage="Please Select">
                                                    </asp:RequiredFieldValidator>--%>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style4" height="40" valign="middle" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="70%">
                                                        <tr>
                                                            <td width="80px" align="left">
                                                                &nbsp;&nbsp;<b>DownLoad </b>
                                                            </td>
                                                            <td width="7px">
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                <asp:Button ID="cmddownload" runat="server" Text="Download Excel file" OnClick="cmddownload_Click" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                     ControlToValidate="ddlMainTitle" ValidationGroup="G1" ErrorMessage="Please Select">
                                                    </asp:RequiredFieldValidator>--%>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="40" valign="middle" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                        <tr>
                                                            <td width="80px" align="left">
                                                                &nbsp;&nbsp;<b>File Upload </b>
                                                            </td>
                                                            <td width="7px">
                                                                &nbsp;
                                                            </td>
                                                            <td align="left">
                                                                <asp:FileUpload ID="fuexcel" runat="server" />
                                                                &nbsp;&nbsp;<asp:Button ID="imgcmdsubmit" ValidationGroup="vrg1" runat="server" Text="Upload"
                                                                    OnClick="imgcmdsubmit_Click" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                     ControlToValidate="ddlMainTitle" ValidationGroup="G1" ErrorMessage="Please Select">
                                                    </asp:RequiredFieldValidator>--%>
                                                </td>
                                            </tr>
                                            <tr><td><hr /> </td></tr>
                                            <tr>
                                                <td height="50" class="style6" colspan="2">
                                                    &nbsp;&nbsp; <b>Question &nbsp;&nbsp;:
                                                        <%--<asp:Label ID="lblMessage" runat="server" ForeColor="#FF3300"></asp:Label>--%>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="50" class="style6" colspan="2">
                                                    <label>
                                                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ValidationGroup="vrg"
                                                        ControlToValidate="txtQuestion" Display="Dynamic"  ErrorMessage="*"></asp:RequiredFieldValidator>--%>
                                                        &nbsp;&nbsp;
                                                        <asp:TextBox ID="txtQuestion" runat="server" Height="71px" TextMode="MultiLine" Width="357px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('txtQuestion', { toolbar: 'CodeDigestTool' });
                                                        </script>
                                                        &nbsp;&nbsp;
                                                    </label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="25" valign="top" class="style6" colspan="2">
                                                    <span class="black_b">Note :</span><span class="form_font"> Select the round button
                                                        to the correct answer</span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2" height="30" valign="middle" class="style6">
                                                    <table border="0" cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td>
                                                                &nbsp;<asp:RadioButton ID="rbtnAnswer1" runat="server" Text="Answer 1" Font-Bold="True"
                                                                    GroupName="Ans" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="50" valign="top" class="style6" colspan="2">
                                                    <label>
                                                        <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ValidationGroup="vrg"
                                                        ControlToValidate="txtAnswer1" Display="Dynamic"  ErrorMessage="Require"></asp:RequiredFieldValidator>
                                                        --%>
                                                        &nbsp;<asp:TextBox ID="txtAnswer1" runat="server" Height="71px" TextMode="MultiLine"
                                                            Width="357px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('txtAnswer1', { toolbar: 'CodeDigestTool' });
                                                        </script>
                                                        &nbsp;&nbsp;
                                                        <br />
                                                    </label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="30" class="style6" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td>
                                                                <asp:RadioButton ID="rbtnAnswer2" runat="server" Text="Answer 2" Font-Bold="True"
                                                                    ForeColor="Black" GroupName="Ans" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="50" class="style6" colspan="2">
                                                    <label>
                                                        <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ValidationGroup="vrg"
                                                        ControlToValidate="txtAnswer2" Display="Dynamic"  ErrorMessage="Require"></asp:RequiredFieldValidator>--%>
                                                        &nbsp;
                                                        <asp:TextBox ID="txtAnswer2" runat="server" Height="78px" TextMode="MultiLine" Width="361px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('txtAnswer2', { toolbar: 'CodeDigestTool' });</script>
                                                        &nbsp;&nbsp;
                                                    </label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="30" class="style6" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="30%">
                                                        <tr>
                                                            <td>
                                                                <label>
                                                                    &nbsp;<asp:RadioButton ID="rbtnAnswer3" runat="server" Text="Answer 3" Font-Bold="True"
                                                                        ForeColor="Black" GroupName="Ans" />
                                                                </label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="50" valign="top" class="style6" colspan="2">
                                                    <label>
                                                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ValidationGroup="vrg"
                                                        ControlToValidate="txtAnswer3" Display="Dynamic"  ErrorMessage="Require"></asp:RequiredFieldValidator>--%>
                                                        &nbsp;
                                                        <asp:TextBox ID="txtAnswer3" runat="server" Height="69px" TextMode="MultiLine" Width="361px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('txtAnswer3', { toolbar: 'CodeDigestTool' });</script>
                                                        &nbsp;&nbsp; &nbsp;</label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="30" valign="middle" class="style6" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 44%">
                                                        <tr>
                                                            <td>
                                                                <label>
                                                                    &nbsp;<asp:RadioButton ID="rbtnAnswer4" runat="server" Text="Answer 4" Font-Bold="True"
                                                                        ForeColor="Black" GroupName="Ans" />
                                                                </label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="50" valign="middle" class="style6" colspan="2">
                                                    <label>
                                                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ValidationGroup="vrg"
                                                        ControlToValidate="txtAnswer4" Display="Dynamic"  ErrorMessage="Require"></asp:RequiredFieldValidator>--%>
                                                        &nbsp;
                                                        <asp:TextBox ID="txtAnswer4" runat="server" Height="69px" TextMode="MultiLine" Width="361px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('txtAnswer4', { toolbar: 'CodeDigestTool' });</script>
                                                        &nbsp;&nbsp; &nbsp;</label>

                                                    <input type="button" id="btn" value="Add New Tab" name="btn" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="30" valign="middle" class="style6" colspan="2">
                                                    <div id="tab1" style="display: none">
                                                        <table border="0" cellpadding="0" cellspacing="0" style="width: 44%">
                                                            <tr>
                                                                <td>
                                                                    <label>
                                                                        &nbsp;<asp:RadioButton ID="rbtnAnswer5" runat="server" Text="Answer 5" Font-Bold="True"
                                                                            ForeColor="Black" GroupName="Ans" />
                                                                    </label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="50" valign="middle" class="style6" colspan="2">
                                                      <div id="Div1" style="display: none">
                                                        <label>
                                                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ValidationGroup="vrg"
                                                        ControlToValidate="txtAnswer4" Display="Dynamic"  ErrorMessage="Require"></asp:RequiredFieldValidator>--%>
                                                            &nbsp;
                                                            <asp:TextBox ID="txtAnswer5" runat="server" Height="69px" TextMode="MultiLine" Width="361px"></asp:TextBox>
                                                            <script type="text/javascript">
                                                                CKEDITOR.replace('txtAnswer5', { toolbar: 'CodeDigestTool' });</script>
                                                            &nbsp;&nbsp; &nbsp;</label>

                                                              <input type="button" id="btn1" value="Add New Tab" name="btn" />
                                                               <input type="button" id="btnhide" value="Hide New Tab" name="btn" />
                                                            </div>
                                                   
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="30" valign="middle" class="style6" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 44%">
                                                        <tr>
                                                            <td>  <div id="tab2" style="display: none">
                                                                <label>
                                                                    &nbsp;<asp:RadioButton ID="rbtnAnswer6" runat="server" Text="Answer 6" Font-Bold="True"
                                                                        ForeColor="Black" GroupName="Ans" />
                                                                </label></div>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" height="50" valign="middle" class="style6" colspan="2">
                                                     <div id="Div2" style="display: none"><label>
                                                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ValidationGroup="vrg"
                                                        ControlToValidate="txtAnswer4" Display="Dynamic"  ErrorMessage="Require"></asp:RequiredFieldValidator>--%>
                                                        &nbsp;
                                                        <asp:TextBox ID="txtAnswer6" runat="server" Height="69px" TextMode="MultiLine" Width="361px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('txtAnswer6', { toolbar: 'CodeDigestTool' });</script>
                                                        &nbsp;&nbsp; &nbsp;</label> 
                                                        
                                                        
                                                        <input type="button" id="btnhide1" value="Hide New Tab" name="btn" />
                                                        </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="30" class="style6" colspan="2" valign="middle">
                                                    &nbsp;&nbsp;<%--ValidationGroup="vrg"--%>
                                                    <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" BackColor="#CCCCCC" />
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