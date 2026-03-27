<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProWeb.Default_aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p style="margin-bottom: 1px;font-size: 30px">Products management</p>
    
    <p>Code: <asp:TextBox ID="code" runat="server" Width="250px"></asp:TextBox></p>
    <p>Name: <asp:TextBox ID="name" runat="server" Width="260px"></asp:TextBox></p>
    <p>Amount: <asp:TextBox ID="amount" runat="server" Width="150px"></asp:TextBox></p>
    
    <p>Category: 
        <asp:DropDownList ID="category" runat="server" Width="150px"></asp:DropDownList>
    </p>
    
    <p>Price: <asp:TextBox ID="price" runat="server" Width="100px"></asp:TextBox></p>
    <p>Creation Date: <asp:TextBox ID="date" runat="server" Width="230px" ReadOnly="true"></asp:TextBox></p>

    <p>
        <asp:Button ID="bcreate" runat="server" Text="Create" OnClick="createButton" />
        <asp:Button ID="bupdate" runat="server" Text="Update" OnClick="updateButton" />
        <asp:Button ID="bdelete" runat="server" Text="Delete" OnClick="deleteButton" />
        <asp:Button ID="bread" runat="server" Text="Read" OnClick="readButton" />
        <asp:Button ID="breadfirst" runat="server" Text="Read First" OnClick="readfButton" />
        <asp:Button ID="breadprev" runat="server" Text="Read Prev" OnClick="readpButton" />
        <asp:Button ID="breadnext" runat="server" Text="Read Next" OnClick="readnButton" />
    </p>
    
    <p><asp:Label ID="lbl" runat="server" ForeColor="Red"></asp:Label></p>
</asp:Content>
