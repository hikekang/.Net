<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <a href="HtmlPage.html" target="">这是一个连接</a>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="HtmlPage.html">HyperLink</asp:HyperLink>
</asp:Content>
