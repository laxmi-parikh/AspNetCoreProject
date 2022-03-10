<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Questions.aspx.cs" Inherits="Admin_Questions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script type="text/javascript" src="ckeditor/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table align="center" border="0" cellpadding="0" cellspacing="0" width="100%" class="form_font">
        <tr>
            <td align="left" bgcolor="#FFFFFF" bordercolor="#5c5c5c" valign="top" width="80%">
                
                <table border="0" cellpadding="0" cellspacing="0" class="top_margin02" height="auto" width="80%" >
                   <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">Add Questions</span>
                        </td>
                    </tr>
                    
                    <tr height="30">
                                                <td colspan="2" align="center" bgcolor="#f5f5f5">
                                                                      <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                                                                    </td>
                                            </tr>
                    <tr>
                        <td align="left" colspan="2" height="37" valign="top">
                            <table align="left" bgcolor="#f5f5f5" border="1" bordercolor="#c7c7c7" cellpadding="0" cellspacing="0" height="auto" width="100%">
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                        
                                        
                                            <tr>
                                              
                                                <td align="left" class="style4" height="40" valign="middle" colspan="2">
                                                  &nbsp;&nbsp;  <b>Main Title</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:DropDownList ID="ddlMainTitle" runat="server" width="120px"
                                                        onselectedindexchanged="ddlMainTitle_SelectedIndexChanged" AutoPostBack="true">
                                                        <%--<asp:ListItem Value="0">Select</asp:ListItem>--%>
                                                    </asp:DropDownList>
                                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                     ControlToValidate="ddlMainTitle" ValidationGroup="G1" ErrorMessage="Please Select">
                                                    </asp:RequiredFieldValidator>--%>
                                                                    </td>
                                                                    
                                            </tr>
                                            
                                            <tr>
                                                <td class="style3" colspan="2">
                                                    </td>
                                                
                                            </tr>
                                            <tr>
                                                
                                                <td align="left" height="20" valign="top" class="style6" colspan="2">
                                                    <label>
                                                    &nbsp;&nbsp;<b>Sub Title</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    </label>
                                                    <asp:DropDownList ID="ddlMainTitle0" runat="server"  width="120px">
                                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                                    </asp:DropDownList>
                                                &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style1" colspan="2">
                                                    </td>
                                               
    
                                                                                                                        </td>
                                            </tr>
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
                                                    <asp:TextBox ID="txtQuestion" runat="server" 
                                                       Height="71px" 
                                                        TextMode="MultiLine" Width="357px"  ></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('ContentPlaceHolder1_txtQuestion', { toolbar: 'CodeDigestTool' });
    </script>
   
                                                    &nbsp;&nbsp;
                                                  
                                                    </label>
                                                    </td>
                                            </tr>
                                            <tr>
                                                
                                                <td align="left" height="25" valign="top" class="style6" colspan="2">
                                                    <span class="black_b">Note :</span><span class="form_font"> Select the round 
                                                    button to the correct answer</span></td>
                                            </tr>
                                            <tr>
                                                
                                                <td align="left" colspan="2" height="30" valign="middle" class="style6">
                                                    <table border="0" cellpadding="0" cellspacing="0" >
                                                        <tr>
                                                            <td>
                                                               
                                                                &nbsp;<asp:RadioButton ID="rbtnAnswer1" runat="server" Text="Answer 1" 
                                                                    Font-Bold="True" GroupName="Ans" />
                                                               
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
                                                    &nbsp;<asp:TextBox ID="txtAnswer1" runat="server" Height="71px" 
                                                        TextMode="MultiLine" Width="357px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('ContentPlaceHolder1_txtAnswer1', { toolbar: 'CodeDigestTool' });
    </script>  &nbsp;&nbsp;
                                                    <br />
                                                    </label>
                                                   
                                                </td>
                                            </tr>
                                            <tr>
                                                
                                                <td height="30" class="style6" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" >
                                                        <tr>
                                                            <td >
                                                               <asp:RadioButton ID="rbtnAnswer2" runat="server" Text="Answer 2" 
                                                                    Font-Bold="True" ForeColor="Black" GroupName="Ans" />
                                                               
                                                               
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
                                                    <asp:TextBox ID="txtAnswer2" runat="server" Height="78px" TextMode="MultiLine" 
                                                        Width="361px"></asp:TextBox>
                                                           <script type="text/javascript">
                                                               CKEDITOR.replace('ContentPlaceHolder1_txtAnswer2', { toolbar: 'CodeDigestTool' });</Script>
                                                &nbsp;&nbsp; 
                                                  
                                                </label></td>
                                            </tr>
                                            
                                            <tr>
                                                
                                                <td height="30" class="style6" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="30%">
                                                        <tr>
                                                            <td >
                                                                <label>
                                                                &nbsp;<asp:RadioButton ID="rbtnAnswer3" runat="server" Text="Answer 3" 
                                                                    Font-Bold="True" ForeColor="Black" GroupName="Ans" />
                                                               
                                                               
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
                                                    <asp:TextBox ID="txtAnswer3" runat="server" Height="69px" TextMode="MultiLine" 
                                                        Width="361px" ></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('ContentPlaceHolder1_txtAnswer3', { toolbar: 'CodeDigestTool' });</Script>
                                             
                                               &nbsp;&nbsp; 
                                                   
&nbsp;</label></td>
                                            </tr>
                                            <tr>
                                              
                                                <td align="left" height="30" valign="middle" class="style6" colspan="2">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 44%">
                                                        <tr>
                                                            <td >
                                                                <label>
                                                                &nbsp;<asp:RadioButton ID="rbtnAnswer4" runat="server" Text="Answer 4" 
                                                                    Font-Bold="True" ForeColor="Black" GroupName="Ans" />
                                                               
                                                               
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
                                                    <asp:TextBox ID="txtAnswer4" runat="server" Height="69px" TextMode="MultiLine" 
                                                        Width="361px"></asp:TextBox>
                                                        <script type="text/javascript">
                                                            CKEDITOR.replace('ContentPlaceHolder1_txtAnswer4', { toolbar: 'CodeDigestTool' });</script>
                                             
                                                 &nbsp;&nbsp; 
                                                  
                                                
&nbsp;</label></td>
                                            </tr>
                                            <tr>
                                               
                                                <td height="30" class="style6" colspan="2" valign="middle">&nbsp;&nbsp;<%--ValidationGroup="vrg"--%>
                                                    <asp:Button ID="btnSubmit" runat="server" onclick="Button1_Click" 
                                                        Text="Submit" BackColor="#CCCCCC" />
                                                
                                                    
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
</asp:Content>

