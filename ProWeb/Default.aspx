<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p style="margin-bottom: 1px;font-size: 30px">Products management</p>
    
    <p>Code: <asp:TextBox ID="txtCode" runat="server" Width="250px"></asp:TextBox></p>
    <p>Name: <asp:TextBox ID="txtName" runat="server" Width="260px"></asp:TextBox></p>
    <p>Amount: <asp:TextBox ID="txtAmount" runat="server" Width="150px"></asp:TextBox></p>
    
    <p>Category: 
        <asp:DropDownList ID="ddlCategory" runat="server" Width="150px"></asp:DropDownList>
    </p>
    
    <p>Price: <asp:TextBox ID="txtPrice" runat="server" Width="100px"></asp:TextBox></p>
    <p>Creation Date: <asp:TextBox ID="txtDate" runat="server" Width="230px" ReadOnly="true"></asp:TextBox></p>

    <p>
        <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnRead" runat="server" Text="Read" OnClick="btnRead_Click" />
        <asp:Button ID="btnReadFirst" runat="server" Text="Read First" OnClick="btnReadFirst_Click" />
        <asp:Button ID="btnReadPrev" runat="server" Text="Read Prev" OnClick="btnReadPrev_Click" />
        <asp:Button ID="btnReadNext" runat="server" Text="Read Next" OnClick="btnReadNext_Click" />
    </p>
    
    <p><asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label></p>
</asp:Content>