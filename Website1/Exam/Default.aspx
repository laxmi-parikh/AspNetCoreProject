<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="USER_WelCome"  %>

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
  
    <link href="../Admin/Js_css/themes/ui-lightness/jquery.ui.all.css" rel="stylesheet"
        type="text/css" />
    <script src="../Admin/Js_css/jquery-1.6.2.js" type="text/javascript"></script>
    <script src="../Admin/Js_css/ui/jquery.effects.core.js" type="text/javascript"></script>
    <script src="../Admin/Js_css/ui/jquery.ui.widget.js" type="text/javascript"></script>
    <script src="../Admin/Js_css/ui/jquery.ui.mouse.js" type="text/javascript"></script>
    <script src="../Admin/Js_css/ui/jquery.ui.resizable.js" type="text/javascript"></script>
    <script src="../Admin/Js_css/ui/jquery.ui.accordion.js" type="text/javascript"></script>
	
    <link href="../Admin/Js_css/demos.css" rel="stylesheet" type="text/css" />
	
	<script type="text/javascript">

	    $(document).ready(function () {
	        $(function () {
	            $("#accordion").accordion({
	                fillSpace: true
	            });
	        });
	        $(function () {
	            $("#accordionResizer").resizable({
	                minHeight: 140,
	                resize: function () {
	                    $("#accordion").accordion("resize");
	                }
	            });
	        });

	    });
	</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="126" valign="bottom" class="headerbg">
    <table width="356" border="0" cellpadding="0" cellspacing="0" class="pad1">
      <tr>

        <td width="356" height="73" class="name"></td>
      </tr>
    </table>
    </td>
  </tr>
  <tr>
    <td height="70" align="right" valign="top" bgcolor="#FFFFFF">
    <table width="73" border="0" cellpadding="0" cellspacing="0" class="margin">
      <tr>
        <td height="28" align="right">
             
             <table border="0" cellpadding="0" cellspacing="0" width="100%" >
             <tr><td> <asp:ImageButton ID="ImageButton1" ImageUrl ="~/Images/home_btn.gif" 
                runat="server" onclick="ImageButton1_Click"  
                /> </td><td>&nbsp;</td><td> 
              
              <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" Visible="false"><img alt="img" border="0" src="../Images/history_btn.gif" /></asp:LinkButton>
             
           
         </td><td>&nbsp;</td><td>
                 <asp:ImageButton ID="imgdownloadebook" ImageUrl ="~/USER/image/download_e-book.png"  Visible="false"
                runat="server" onclick="imgdownloadebook_Click" />
                </td><td>&nbsp;</td><td>  <asp:ImageButton ID="ImageButton21" ImageUrl ="~/Admin/images/lod_out.gif" 
                runat="server" onclick="ImageButton21_Click" 
                /> </td></tr>
             
             </table>   
       
          
       
        
          </td>
      </tr>

    </table>
    </td>
  </tr>
  <tr>
  <td height="404" align="center" valign="top" bgcolor="#FFFFFF">
<table border="0" cellpadding="0" cellspacing="0" width="80%" class="form_font">
<tr>
            <td align="center" bgcolor="#ffffff" height="30" valign="top" >
              <strong>  Welcome &nbsp;<asp:Label ID="lblUsername" runat="server"></asp:Label>&nbsp;&nbsp; </strong>
                
                </td>
                </tr>
              <%--  <tr>
                
            <td align="center" bgcolor="#ffffff" height="30" valign="top">
              &nbsp;<br />
                </td>
                </tr>
                <tr>--%>

            

                <tr>
            <td align="center" bgcolor="#ffffff" height="30" valign="top">
              <strong>  <asp:Label ID="lblMessage" runat="server" CssClass="r" Text=""></asp:Label> </strong>
                
                </td>
                </tr>
             
             <tr><td>
             
             <div id="accordionResizer" style="padding:10px; width:750px; height:auto;" class="ui-widget-content">
 
<div id="accordion">

<h3><a href="#"><asp:Label ID="lblFunct" runat="server"></asp:Label> </a></h3>
	<div>

             
             <table border="0" cellpadding="0" cellspacing=0" width="100%" bgcolor="#ffffff"> 

                    <tr>
            <td align="center" bgcolor="#ffffff" height="40" valign="top" >
              <strong>
              <table border="0" cellpadding="0" cellspacing="0" width="70%" height="40" class="form_font">
              
               <tr><td width="10%" >&nbsp;</td>
                <td width="2%"><%--Function&nbsp;:&nbsp;--%></td>
               <td align="left"><asp:Label ID="lblFunction" runat="server"></asp:Label>  </td>
               <td width="7%" >&nbsp; </td>
                 <td width="2%"></td>
               <td align="left"><asp:Label ID="lblLevel" runat="server"></asp:Label>  </td>
               </tr>
              </table>
              
             </strong>
                
                </td>
                </tr>
            
              
<tr><td align="left" valign="top">
<table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
        
           
          
        <tr>
            <td align="left" bgcolor="#ffffff" 
                valign="top" width="5%"  >
                              &nbsp;      </td>
                  <td  align="center" valign="top">
                  
                <asp:GridView ID="gvExam" runat="server" AutoGenerateColumns="False"  
                          RowStyle-HorizontalAlign="Center" Width="70%" 
                          onselectedindexchanged="gvExam_SelectedIndexChanged" 
                          AllowPaging="True" AllowSorting="True" 
                          onpageindexchanging="gvExam_PageIndexChanging" BackColor="#CCCCCC" 
                          BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
                          CellSpacing="2" ForeColor="Black">
<RowStyle HorizontalAlign="Center" BackColor="White"></RowStyle>
                    <Columns>
                    <asp:TemplateField HeaderText="SrNo" ItemStyle-Width="10%">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                     <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Exam Title" ItemStyle-Width="60%">
                          
                            <ItemTemplate>
                                    <table width ="100%" border="1"  cellpadding="0" cellspacing="0">
                                    <tr>
                                    <td bgcolor="#5c5c5c" height="20">
                                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                                        <tr>
                                                            <td width="10%">
                                                                <img class="m_img" height="13" src="../image/2arrow.gif" width="11" /></td>
                                                            <td class="white_font" width="90%" align="left">
                                                                 <a href='Question.aspx?SubId=<%#Eval("levelId") %> &SettingId=<%#Eval("SettingId") %>'  class="white_font"> 
                                                               <asp:Label ID="Label2" runat="server" class="white_font" Text ='<% # Bind("TitleForExam") %>'></asp:Label>
                                                               </a>  
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                 </tr>
                                    </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                      <%--  <asp:TemplateField HeaderText="Start Date" ItemStyle-Width="15%">
                            <ItemTemplate>
                     <asp:Label ID="Label2" runat="server"  Text ='<% #Eval("Start_Date","{0:dd-MMM-yyyy}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="End Date" ItemStyle-Width="15%">
                            <ItemTemplate>
                     <asp:Label ID="Label2" runat="server"  Text ='<% #Eval("End_Date","{0:dd-MMM-yyyy}") %>'></asp:Label>
                            
                               
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        
                       
                       
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
              
                 <asp:Label ID="Label3" runat="server" Text="No Exam" CssClass="form_font" ForeColor="Red" Visible="false"></asp:Label>
              
                </td>
                
                  <td width="5%">
                <br />
                <br />
                      
                
                </td>
                </tr>
                
               
                
            </table>
             <br />
                <br />

</td></tr>
</table>
</div>



	


</div>

</td></tr>
</table>


  
</table>


<map name="Map" id="Map"><area shape="rect" coords="7,2,73,25" href="#" />
    </div>
    </form>
</body>
</html>

    
<%--</asp:Content>--%>