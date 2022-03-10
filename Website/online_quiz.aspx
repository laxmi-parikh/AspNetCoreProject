<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="online_quiz.aspx.cs" Inherits="online_quiz" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns >
    <asp:TemplateField >
    
    <ItemTemplate >
    <div class="question">
<div class="qnumdiv"><p class="qnum">Question 1 of 10</p></div>
<p class="qhead">ClassMarker can be used for:- </p>
<div class="qdivider2"></div>
<table cellspacing="0" cellpadding="0" border="0"><tbody><tr><td nowrap="nowrap" valign="top" class="tdleft"><img align="top" onclick="selectRadioButton('1',0, 'mcsa_',0)" src="http://img.classmarker.com/quiz/radio_orange_off.gif" id="answer_1_0" alt=""> <strong>
    a)</strong> <input type="radio" value="1" name="mcsa_1" id="mcsa_1_0_rb" class="rb" style="display: none;">&nbsp;</td><td class="tdright"><p class="ansmulti">
        Schools and educational purposes</p></td></tr>
<tr><td colspan="2"><div class="spacer5"></div></td></tr>

<tr><td nowrap="nowrap" valign="top" class="tdleft"><img align="top" onclick="selectRadioButton('1',1, 'mcsa_',0)" src="http://img.classmarker.com/quiz/radio_orange_off.gif" id="answer_1_1" alt=""> <strong>
    b)</strong> <input type="radio" value="2" name="mcsa_1" id="mcsa_1_1_rb" class="rb" style="display: none;">&nbsp;</td><td class="tdright"><p class="ansmulti">
        Business</p></td></tr>
<tr><td colspan="2"><div class="spacer5"></div></td></tr>

<tr><td nowrap="nowrap" valign="top" class="tdleft"><img align="top" onclick="selectRadioButton('1',2, 'mcsa_',0)" src="http://img.classmarker.com/quiz/radio_orange_off.gif" id="answer_1_2" alt=""> <strong>
    c)</strong> <input type="radio" value="3" name="mcsa_1" id="mcsa_1_2_rb" class="rb" style="display: none;">&nbsp;</td><td class="tdright"><p class="ansmulti">
        Promotion</p></td></tr>
<tr><td colspan="2"><div class="spacer5"></div></td></tr>

<tr><td nowrap="nowrap" valign="top" class="tdleft"><img align="top" onclick="selectRadioButton('1',3, 'mcsa_',0)" src="http://img.classmarker.com/quiz/radio_orange_on.gif" id="answer_1_3" alt=""> <strong>
    d)</strong> <input type="radio" value="4" name="mcsa_1" id="mcsa_1_3_rb" class="rb" style="display: none;">&nbsp;</td><td class="tdright"><p class="ansmulti">
        Just to make a fun quiz for my friends</p></td></tr>
<tr><td colspan="2"><div class="spacer5"></div></td></tr>

<tr><td nowrap="nowrap" valign="top" class="tdleft"><img align="top" onclick="selectRadioButton('1',4, 'mcsa_',0)" src="http://img.classmarker.com/quiz/radio_orange_off.gif" id="answer_1_4" alt=""> <strong>
    e)</strong> <input type="radio" value="5" name="mcsa_1" id="mcsa_1_4_rb" class="rb" style="display: none;">&nbsp;</td><td class="tdright"><p class="ansmulti">
        All of the above</p></td></tr>
<tr><td colspan="2"><div class="spacer5"></div></td></tr>

</tbody></table></div>
    </ItemTemplate>
    <FooterTemplate >
    
    </FooterTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
</asp:Content>

