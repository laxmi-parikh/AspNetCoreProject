<%@ Page Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true" CodeFile="EditUserList.aspx.cs" Inherits="Admin_AddMainTitle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" border="0" cellpadding="0" cellspacing="0" class="form_font" >
        <tr>
            <td align="left" bgcolor="#FFFFFF" valign="top" width="710">
                <table border="0" cellpadding="0" cellspacing="0" class="top_margin" width="80%"  
                    height="277">
                       <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle"  colspan="2">
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1"> Edit User</span>
                        </td>
                    </tr>
                      <tr height="30"> <td colspan="2" align="center" class="r"> 
                      <asp:Label ID="lbltitle" runat="server" Text="" ForeColor="Red" ></asp:Label></td></tr>
                      
                        
                     
                  
                        <td colspan="2" height="10" valign="top">
                            <img height="1" src="images/llist_line.gif" width="412" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" height="235" valign="top">
                            <table cellspacing="0" cellpadding="0" border="0" 
            style="height: 350px; width: 458px">
      <tbody><tr>
        <td height="28" width="125" valign="top" align ="left" class="form_font">Employee 
            Code </td>
        <td class="style1">:</td>
        <td align="left" width="165">
       
            <asp:TextBox ID="txtEmployeeCode" runat="server" ValidationGroup="G1" ></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmployeeCode" ValidationGroup="G1"
                ErrorMessage="Enter Employee Code" Display="Dynamic" Font-Size="X-Small"></asp:RequiredFieldValidator>
          </td>
      </tr>
      <tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">First Name</td>
        <td height="28" class="style1">:</td>
        <td height="28" width="165" align ="left">
            <asp:TextBox ID="txtFirstName" runat="server" ValidationGroup="G1"></asp:TextBox>
           <br />
           
           
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ValidationGroup="G1"
                ErrorMessage="Enter First Name" ControlToValidate="txtFirstName" 
                Font-Size="Smaller"></asp:RequiredFieldValidator>
                    </td>
      </tr>
      <tr height="28">
        <td height="28" width="125" valign="top" class="form_font" align="left">Middle Name</td>
        <td height="28" class="style1">:</td>
        <td height="28" width="165"  align="left">
            <asp:TextBox ID="txtMName" runat="server" ValidationGroup="G1"></asp:TextBox>
          
           &nbsp;
                     
                    </td>
      </tr>
      <tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">Last Name</td>
        <td height="28" class="style1">:</td>
        <td height="28" width="165"  align="left">
            <asp:TextBox ID="txtLName" runat="server" ValidationGroup="G1"></asp:TextBox>
                
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="Enter Last Name" ControlToValidate="txtLName" ValidationGroup="G1"
                Font-Size="Smaller"></asp:RequiredFieldValidator>
                                                                          </td>
      </tr>
      <tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">Sex       
          <td height="28" class="style1">
              :</td>
        <td height="28" width="165" class="form_font">
            <asp:RadioButton ID="rbtnMale" runat="server" Text="Male " Checked ="True"
                GroupName="Gender" />
        
            &nbsp;<asp:RadioButton ID="rbtnFemale" runat="server" Text="Female " 
                GroupName="Gender" />
            
        </td>
      </tr>
      <tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">Member</td>
        <td height="28" class="style1">:</td>
        <td height="28" width="165" class="form_font" align="left">
        <asp:DropDownList id="ddlfuntion" runat="server"></asp:DropDownList>
        </td>
      </tr>
      <tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">Email ID<td 
              height="28" class="style1">
          :</td>
        <td height="28" width="165"  align="left">
            <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="G1"></asp:TextBox>
            <label>
            &nbsp;</label>
      
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="InValid ID" ControlToValidate="txtEmail" Display="Dynamic" 
                Font-Size="Smaller" ToolTip="Enter Email" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ValidationGroup="G1"></asp:RegularExpressionValidator>
            
        </td>
      </tr>
      <%--<tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">Password       
          <td height="28" class="style1">
              :</td>
        <td height="28" width="165" align="left">
            <asp:TextBox ID="txtPassword" runat="server" ValidationGroup="G1" 
                TextMode="Password"></asp:TextBox>
            <label>
            &nbsp;</label>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword"
                ErrorMessage="Enter Password" Font-Size="Smaller" ValidationGroup="G1"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">Confirm 
            Password</td>
        <td height="28" class="style1">:</td>
        <td height="28" width="165" align="left">
            <asp:TextBox ID="txtConformPwd" runat="server" ValidationGroup="G1" 
                TextMode="Password"></asp:TextBox>
            <label>
            &nbsp;</label>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ErrorMessage="Please Enter Same Password" ControlToCompare="txtPassword" 
                ControlToValidate="txtConformPwd" Font-Size="Smaller" ValidationGroup="G1"></asp:CompareValidator>
        </td>
      </tr>--%>
      <tr>
        <td height="28" width="125" valign="top" class="form_font" align="left">Mobile</td>
        <td height="28" class="style1">:</td>
        <td height="28" width="165" align="left">
            <asp:TextBox ID="txtMobileNo" runat="server" ValidationGroup="G1" 
                ></asp:TextBox>
            <label>
            &nbsp;</label>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ErrorMessage="Enter Mobile No" ControlToValidate="txtMobileNo" 
                Font-Size="Smaller" ValidationGroup="G1"></asp:RequiredFieldValidator>
        </td>
      </tr>
      <tr>
        <td height="28" width="125" valign="top" class="form_font">
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
          </td>
        <td height="28" class="style1">&nbsp;</td>
        <td height="28" align="right" width="165">
            <asp:ImageButton ID="iBtnSubmit" runat="server" ImageUrl ="../image/submit.gif" 
                onclick="iBtnSubmit_Click" ValidationGroup="G1" Height="28px" />
        
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        
         </td>
      </tr>
    </tbody></table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

