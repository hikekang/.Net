<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>选择题</h3>
    <ul>
        <li>
            1+1=? ( )
        </li>
        <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" Text="2" />
        <br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" Text="3"/>
        <li>
            (x+1)*x=0  x是多少？

        </li>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="0" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="-1" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="-2" />
     </ul>

    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
    <br />
    最后得分：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
   
</asp:Content>
