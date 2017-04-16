<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Return.aspx.cs" Inherits="Return" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
                <link href="StyleSheet.css" rel="stylesheet" />
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
            <div id="jumbotronId" class="">
            <h1 id="Label1" runat="server">Systems Analysis and Design Term Project</h1>
            <h2 id="H1" runat="server" >University Library System</h2>
        </div>
    <form id="form1" runat="server">
    <div class="container">
        <h2>Your Books</h2>
        <div id="Search" class="row">
                <p class="col-lg-1">Search</p>
                <asp:TextBox ID="txtSearch" runat="server" CssClass="col-lg-2"></asp:TextBox>
                    <p class="col-lg-1">By</p>
                    <asp:DropDownList ID="drpSearch" runat="server" CssClass="col-lg-2" >
                        <asp:ListItem Value="Books.Title">Title</asp:ListItem>
                        <asp:ListItem Value="Books.Author">Author</asp:ListItem>
                        <asp:ListItem Value="Books.CatalogNumber">Catalog Number</asp:ListItem>
     
                    </asp:DropDownList>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="col-lg-1" OnClick="btnSearch_Click"/>
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" CssClass="col-lg-1"/>
            
        </div>
        <asp:Repeater runat="server" ID="ViewCheckoutRepeater" DataSourceID="SqlDataSource1" OnItemCommand="ViewCheckoutRepeater_ItemCommand">
            <HeaderTemplate>
                <table class="col-md-12">
                <tr>
                    <th class="col-sm-1">Image</th>
                    <th>Title</th>
                    <th>Author</th>
                    <th>Catalog Number</th>
                    <th>Date Checked Out</th>
                    <th>Due Date</th>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <img width="65" src="<%# Eval("imgURl") %>" />
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblTitle" Text='<%# Eval("Title") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblAuthor" Text='<%# Eval("Author") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblCatalogNumber" Text='<%# Eval("CatalogNumber") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblDateCheckedOut" Text='<%# Eval("DateCheckedOut") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblDueDate" Text='<%# Eval("DueDate") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnReturn" runat="server" Text="Return" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
            
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" OnLoad="SqlDataSource1_Load"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
