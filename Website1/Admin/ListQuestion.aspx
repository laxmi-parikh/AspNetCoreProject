<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ListQuestion.aspx.cs" Inherits="Admin_ListQuestion"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            background-image: url(images/top_gred.gif);
            background-repeat: repeat-x;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <table width ="90%"  class="top_margin02" >
   <tr height="30">
                        <td align="left" class="top_pinktab" valign="middle" colspan="2"  >
                           &nbsp; <img height="9" src="images/arrow.gif"  />&nbsp;
                            <span class="que1">List Of Questions</span>
                        </td>
                    </tr>
                    
                      <tr height="30"> <td colspan="2" align="center" class="form_font"> 
                      <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label></td></tr>
                   <%--   <tr height="30px">
                    
                    <td class="form_font" valign="top" Width="10%" >&nbsp;<b>Function</b></td>
                    <td align="left" valign="top" width="90%" >
                  
                        <asp:DropDownList ID="ddlMainTitle" runat="server" AutoPostBack="True"  width="120px" 
                                                                        
                            onselectedindexchanged="ddlMainTitle_SelectedIndexChanged" 
                             >
                        </asp:DropDownList>
                      </td>
                  </tr>--%>
                  <%--<tr height="30px">
                   
                    <td class="form_font" valign="top" >&nbsp;<b>Level</b></td>
                    <td  align="left" valign="top"><label>
                        <asp:DropDownList ID="ddlSubTitle" runat="server" width="120px" 
                            AutoPostBack="True" onselectedindexchanged="ddlSubTitle_SelectedIndexChanged" >
                        </asp:DropDownList>
                        
</label></td>
                  </tr>--%>
                      <tr height="30px">
                   
                    <td class="form_font" valign="top" width="50px" >&nbsp;<b>Topic/Title</b></td>
                    <td  align="left" valign="top"><label>
                        <asp:DropDownList ID="ddlExamTitle" runat="server" width="120px" 
                            >
                        </asp:DropDownList>
                        
</label></td>
                  </tr>
                   <tr height="30px">
                   <td ></td valign="top">
                    <td  class="form_font"  align="Left">
                     <asp:ImageButton ID="btn_Submit" runat="server"  ImageUrl="~/image/submit.gif" 
                            onclick="btn_Submit_Click"></asp:ImageButton>
                    
                    </td>
                  </tr>
                    
    
<tr>
 
<td colspan="2" align="center" valign="top" class="form_font" width="90%">
    <asp:GridView ID="gvQuestion" runat="server"  AllowPaging="True" 
        AutoGenerateColumns="False" onpageindexchanging="GridView1_PageIndexChanging" 
        Width="100%" onrowcommand="gvQuestion_RowCommand" 
        onrowdeleting="gvQuestion_RowDeleting"  RowStyle-HorizontalAlign="Left"
        onrowdatabound="gvQuestion_RowDataBound" PageSize="20">
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
           <asp:Label ID="lblQuestion" runat="server" Text='<%#Eval("QuestionId") %>' Visible="false"></asp:Label>
               <%--
                 <asp:Label ID="lblImageStatus" runat="server" Text='<%# Eval("lblImageStatus") %>' 
                                Visible="false"></asp:Label>
                                <asp:Image ID="Image1"  runat="server" ImageUrl ='<%#  Eval("lblImageStatus") %>' Visible="false"></asp:Image>
                 --%>
                <table width ="200Px" ><tr>
                <td>
                
               
                <asp:Literal ID="Label1"   runat="server"    
                        
                        Text='<%# System.Web.HttpUtility.HtmlDecode((string)Eval("question")) %>' />
                <%-- <asp:Label ID="LabelDescription" runat="server"
                   Text='<%# System.Web.HttpUtility.HtmlEncode((string)Bind("question")) %>' />--%>
                   </td>
                </tr>
                </table>
                
            </ItemTemplate>
           
                <EditItemTemplate>
                <%--   <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("QuestionId") %>'></asp:TextBox>  --%>    
                </EditItemTemplate>
                <ItemTemplate>
               <%--
                 <asp:Label ID="lblImageStatus" runat="server" Text='<%# Eval("lblImageStatus") %>' 
                                Visible="false"></asp:Label>
                                <asp:Image ID="Image1"  runat="server" ImageUrl ='<%#  Eval("lblImageStatus") %>' Visible="false"></asp:Image>
                 --%>
                <table width ="200Px" ><tr>
                <td>
                
               
                <asp:Literal ID="Label1"   runat="server"    Text='<%# System.Web.HttpUtility.HtmlDecode((string)Eval("question")) %>' />
                <%-- <asp:Label ID="LabelDescription" runat="server"
                   Text='<%# System.Web.HttpUtility.HtmlEncode((string)Bind("question")) %>' />--%>
                   </td>
                </tr>
                </table>
                </ItemTemplate>
            </asp:TemplateField>
            
         
        
            
          <%-- <asp:TemplateField HeaderText = "SubjectId">
         <ItemTemplate>
         <asp:Label ID = "lblSubjectId" runat ="server" Text = '<%#Bind("SubjectId") %>'></asp:Label>
         </ItemTemplate>
         </asp:TemplateField>--%>
           
         <%-- <asp:TemplateField HeaderText = "Question">
         <ItemTemplate>
         <asp:Label ID = "Question" runat ="server" Text = '<%#Bind("Question") %>'></asp:Label>
         </ItemTemplate>
         </asp:TemplateField>--%>
            
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
                                                            
                                                                <a class="g" href='EditQUestion.aspx?QuestionId=<%# Eval("QuestionId") %>'  >Edit</a>
                                                               <%-- <img height="19"  src="images/G_pencil.gif" width="18" border ="0" />--%>
                                                                </td>
                                                            <td>
                                                            <%-- <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False">
                                                              --%>                                                                                      
                                                                
                                                              <%--  </asp:LinkButton>--%>
                                                                </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                    </tr>
                                    </table>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                  <table width ="100%" >
                                    <tr>
                                       <td align="center" bgcolor="#eeeeee" width="121">
                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="60%">
                                                        <tr>
                                                            
                                                              <asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" 
                                            CommandName="Delete" CommandArgument = '<%#Eval("QuestionId") %>' >
                                                                <img height="14" src="images/R_cross.gif" width="14" border ="0"/>
                                                                </asp:LinkButton>
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
    <br />
    <br />
</td>
</tr>
</table>
</asp:Content>

