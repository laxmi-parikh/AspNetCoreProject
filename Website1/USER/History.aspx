<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="History.aspx.cs" Inherits="USER_WelCome"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <title></title>
<style type="text/css">
body {
	background-color: #888888;
	margin-top: 0px;
}

</style>
<link href="style.css" rel="stylesheet" type="text/css" />
<script language="JavaScript">
javascript:window.history.forward(1);
</script>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="126" valign="bottom" class="headerbg"><table width="356" border="0" cellpadding="0" cellspacing="0" class="pad1">
      <tr>

        <td width="356" height="73" class="name"></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="70" align="right" valign="top" bgcolor="#FFFFFF"><table width="73" border="0" cellpadding="0" cellspacing="0" class="margin">
      <tr>
        <td height="28">
         
             <table border="0" cellpadding="0" cellspacing="0" width="100%" >
             <tr><td> <asp:ImageButton ID="ImageButton1" ImageUrl ="~/Images/home_btn.gif" 
                runat="server" onclick="ImageButton1_Click"  
                /> </td>
                <td>&nbsp;</td>
                <td>              
              <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click"><img alt="img" border="0" src="../Images/history_btn.gif" /></asp:LinkButton>
                       
         </td>
         <td>&nbsp;</td> 
         <td>              
              <asp:ImageButton ID="imgdownloadebook" ImageUrl ="~/USER/image/download_e-book.png" runat="server" onclick="imgdownloadebook_Click" />
                       
         </td>
         <td>&nbsp;</td> 
         <td><asp:ImageButton ID="ImageButton21" ImageUrl ="~/Admin/images/lod_out.gif" runat="server" onclick="ImageButton21_Click" /> </td>
         </tr>
             
             </table>   
       
       
          </td>
      </tr>

    </table></td>
  </tr>
  <tr>
  <td height="404" align="center" valign="top" bgcolor="#FFFFFF">
<table border="0" cellpadding="0" cellspacing="0" width="95%" class="form_font">
<tr>
            <td align="center" bgcolor="#ffffff" height="30" valign="top" >
              <strong>  Welcome &nbsp;<asp:Label ID="lblUsername" runat="server"></asp:Label> </strong>
                
                </td>
                </tr>
              <%--  <tr>
                
            <td align="center" bgcolor="#ffffff" height="30" valign="top">
              &nbsp;<br />
                </td>
                </tr>
                <tr>--%>
            <td align="center" bgcolor="#ffffff" height="15" valign="top">
              <strong>  <asp:Label ID="lblMessage" runat="server" CssClass="r" Text=""></asp:Label> </strong>
                
                </td>
                
                <tr>
                            </tr>
<tr><td align="left" valign="top" width="100%">
<table align="left" border="0" cellpadding="0" cellspacing="0" width="100%">
        
              <%--  <tr height="30px">
               <td align="left" bgcolor="#ffffff" height="30" valign="top">
                   &nbsp;<b>Category:</b>&nbsp;                                     </td><td align="left" valign="top">
                                    <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" 
                          onselectedindexchanged="ddlCategory_SelectedIndexChanged" Width="120px">
                         
                      </asp:DropDownList>
                  
                                    </td>
        </tr>
        
         <tr height="30px">
               <td align="left" bgcolor="#ffffff" height="30" valign="top">
                 <b>Sub Category:</b>
                                    </td>
                                    <td align="left" valign="top">
                                     <asp:DropDownList ID="ddlMainTitle0" runat="server"  Width="120px">
                                                    </asp:DropDownList>
                  
                                    </td>
        </tr>--%>
          
         <%--  <tr height="30px">
           <td></td>
               <td align="left" bgcolor="#ffffff" height="30" valign="top" >
                   <asp:ImageButton ID="ImageButton1" runat="server"  
                       ImageUrl="~/image/submit.gif" onclick="ImageButton1_Click"/>
                  
                                    </td>
        </tr>--%>
          
        <tr>
            <td align="left" bgcolor="#ffffff" valign="top" >
                              &nbsp;      </td>
                  <td  align="left" valign="top" width="100%">
                  
                <asp:GridView ID="gvExam" runat="server" AutoGenerateColumns="False"  
                          RowStyle-HorizontalAlign="Center" Width="100%" 
                          onselectedindexchanged="gvExam_SelectedIndexChanged" 
                          AllowPaging="True" AllowSorting="True" 
                          onpageindexchanging="gvExam_PageIndexChanging" BackColor="#CCCCCC" 
                          BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
                          CellSpacing="2" ForeColor="Black" onrowdatabound="gvExam_RowDataBound">
                          <HeaderStyle CssClass="gridviewdata" />
<RowStyle HorizontalAlign="Center" BackColor="White"></RowStyle>
                    <Columns>
                    <asp:TemplateField HeaderText="SrNo" ItemStyle-Width="2%">
                                  <%--  <EditItemTemplate>
                                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>--%>
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Exam Title" ItemStyle-Width="35%">
                            <ItemTemplate>
                                    <table width ="100%" border="1"  cellpadding="0" cellspacing="0">
                                    <tr>
                                    <td bgcolor="#5c5c5c" height="15" width="150">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                        <tr>
                                                            <td width="10%">
                                                                <img class="m_img" height="13" src="../image/2arrow.gif" width="11" /></td>
                                                            <td class="white_font" width="90%">
                                                                       <asp:Label ID="lblSetId" runat="server" class="white_font" Text ='<% #Eval("SetId") %>' Visible="false"></asp:Label>
                                                                      
                                                                      <asp:panel ID="panel1" runat="server" > 
                                                                       <a href='Preview.aspx?SetId=<%#Eval("SetId") %>' class="white_font" target="_blank">
                                                               <asp:Label ID="lblExamTitle" runat="server" cssclass="white_font" ></asp:Label>
                                                               </a></asp:panel>
                                                                <asp:panel ID="panel2" runat="server" >
                                                                <a href='#' class="white_font" >
                                                                <asp:Label ID="lblExamTitle1" runat="server" cssclass="white_font" ></asp:Label></a>
                                                                </asp:panel>
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                 </tr>
                                    </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <%--<asp:TemplateField HeaderText="Exam Start Date">
                            <ItemTemplate>
                     <asp:Label ID="lblStartDate" runat="server"  ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Exam End Date">
                            <ItemTemplate>
                     <asp:Label ID="lblEndDate" runat="server"  ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                         <asp:TemplateField HeaderText="Exam Appeared on" ItemStyle-Width="10%">
                            <ItemTemplate>
                     <asp:Label ID="lblDate" runat="server" Text='<%#Eval("InsertedOn","{0:dd-MMM-yyyy}") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Total Marks " ItemStyle-Width="8%">
                            <ItemTemplate>
                     <asp:Label ID="lblMarks" runat="server"  ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Marks obtained" ItemStyle-Width="8%">
                            <ItemTemplate>
                     <asp:Label ID="lblMarksobt" runat="server"  ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Total Question" ItemStyle-Width="8%">
                            <ItemTemplate>
                     <asp:Label ID="lbltotalQuestion" runat="server" Text='<%#Eval("TotalQuestion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Total Correct Answer" ItemStyle-Width="10%">
                          
                            <ItemTemplate>
                                   
                                            
                                                           
                    <asp:Label ID="lblCorrect" runat="server"  Text='<%#Eval("CorrectAnswer") %>'  ></asp:Label>
                                                              
                               
                               
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Total Wrong Answer" ItemStyle-Width="10%">
                          
                            <ItemTemplate>
                                   
                                            
                                                           
                    <asp:Label ID="lblwrong" runat="server"  Text='<%#Eval("WrongAnswer") %>'  ></asp:Label>
                                                              
                               
                               
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                                                         
                         <asp:TemplateField HeaderText="Percentage">
                          
                            <ItemTemplate>
                                   
                                            
                                                           
                     <asp:Label ID="lblpercentage" runat="server"  ></asp:Label>
                            
                               
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Grade">
                          
                            <ItemTemplate>
                                   
                                            
                                                           
                     <asp:Label ID="lblGrade" runat="server"  ></asp:Label>
                            
                               
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                       
                       
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <EmptyDataTemplate >
                     <%--   Please Select a Category--%>
                    
                    </EmptyDataTemplate>
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
                
                 <br />
                <br />
                </td>
                
                  <td width ="20">
                <br />
                <br />
                      
                
                </td>
                </tr>
                
               
                
            </table>
             <br />
                <br />

</td></tr>

</table>

 </td>

  </tr>
  
</table>


<map name="Map" id="Map"><area shape="rect" coords="7,2,73,25" href="#" />
    </div>
    </form>
</body>
</html>

    
<%--</asp:Content>--%>