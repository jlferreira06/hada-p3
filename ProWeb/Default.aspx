<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProWeb.Default_aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p style="margin-bottom: 1px;font-size: 30px">
        Products management</p>
    <p style="margin-bottom: 1px">
        Code&nbsp;    
        <input id="code" type="text" style="width: 250px;border: 1px solid #000000;border-radius: 2px"/></p>
    <p style="margin-bottom: 1px">
        Name&nbsp;&nbsp;
        <input id="name" type="text" style="width: 260px;border: 1px solid #000000;border-radius: 2px" /></p>
    <p style="margin-bottom: 1px">
        Amount&nbsp;&nbsp; <input id="amount" type="text"style="width: 150px;border: 1px solid #000000;border-radius: 2px"" /></p>
    <p style="margin-bottom: 1px">
        Category&nbsp; </p>
    <p style="margin-bottom: 1px">
        Price&nbsp;
        <input id="price" type="text" style="width: 100px;border: 1px solid #000000;border-radius: 2px""/></p>
    <p style="margin-bottom: 1px">
        Creation Date&nbsp;&nbsp;
        <input id="cdate" type="text" style="width: 230px;border: 1px solid #000000;border-radius: 2px"" /></p>
        
        <asp:Button ID="create" runat="server" Text="Create" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="update" runat="server" Text="Update" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="delete" runat="server" Text="Delete" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="read" runat="server" Text="Read" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="readf" runat="server" Text="Read First" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="readp" runat="server" Text="Read Prev" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="readn" runat="server" Text="Read Next" />
            
    </p>
</asp:Content>
