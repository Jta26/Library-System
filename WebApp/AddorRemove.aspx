<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddorRemove.aspx.cs" Inherits="AddorRemove" %>

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
        <div class="row">
            <div id="column1" class="col-lg-6">
                <div id="bookWrapper">
                <h2>Add Book</h2>
                <div id="addBook">
                
                <div class="row">
                    <p class="col-sm-4">Title</p>
                    <asp:TextBox ID="txtTitle" runat="server" CssClass="col-sm-4"></asp:TextBox>
                </div>
                <div class="row">
                    <p class="col-sm-4">Author</p>
                    <asp:TextBox ID="txtAuthor" runat="server" CssClass="col-sm-4"></asp:TextBox>
                </div>
                <div class="row">
                    <p class="col-sm-4">Publisher</p>
                    <asp:TextBox ID="txtPublisher" runat="server" CssClass="col-sm-4"></asp:TextBox>
                </div>
                <div class="row">
                    <p class="col-sm-4">ISBN</p>
                    <asp:TextBox ID="txtISBN" runat="server" CssClass="col-sm-4"></asp:TextBox>
                </div>
                <div class="row">
                    <p class="col-sm-4">Edition</p>
                    <asp:TextBox ID="txtEdition" runat="server" CssClass="col-sm-4"></asp:TextBox>
                </div>
                <div class="row">
                    <p class="col-sm-4">Publication Year</p>
                    <asp:TextBox ID="txtPubYear" runat="server" CssClass="col-sm-4"></asp:TextBox>
                </div>
                <div class="row">
                    <p class="col-sm-4">Image Url</p>
                    <asp:TextBox ID="txtURL" runat="server" CssClass="col-sm-4"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </div>
                    </div>
                <div class="row" id="AdminButtons">
                    <h2>Administrative</h2>
                    <div class="row">
                    <asp:Button ID="btnViewCheckouts" runat="server" Text="View Checked Out Books" />

                </div>
                    <div class="row">
                    <asp:Button ID="btnAddLibrarian" runat="server" Text="Add Librarian User" OnClick="btnAddLibrarian_Click" />
                </div>
                </div>
                    </div>
            </div>
            <div id="column2" class="col-lg-6">
                <h2>Remove Book</h2>
                <div id="searchbook" class="row">
                    <p class="col-sm-2">Search</p>
                    <asp:TextBox ID="txtSearch" runat="server" CssClass="col-sm-3"></asp:TextBox>
                    <p id="by" class="col-sm-2">By</p>
                    <asp:DropDownList ID="drpSearch" runat="server" CssClass="col-lg-3" >
                        <asp:ListItem Value="Title">Title</asp:ListItem>
                        <asp:ListItem Value="Author">Author</asp:ListItem>
                        <asp:ListItem Value="Publisher">Publisher</asp:ListItem>
                        <asp:ListItem Value="ISBN">ISBN</asp:ListItem>
                        <asp:ListItem Value="Edition">Edition</asp:ListItem>
                        <asp:ListItem Value="PublicationYear">Publication Year</asp:ListItem>
                        <asp:ListItem Value="CatalogNumber">Catalog Number</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </div>
                <div class="row">
                    <asp:Repeater ID="bookRepeater" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="bookRepeater_ItemCommand">
                        <HeaderTemplate>
                            <table>
                                <tr>
                                    <th>Image</th>
                                    <th>Title</th>
                                    <th>Author</th>
                                    <th>ISBN</th>
                                    <th>Catalog Number</th>
                                </tr>

                            
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <img width="65" runat="server" src='<%# Eval("imgURl") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblAuthor" runat="server" Text='<%# Eval("Author") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblISBN" runat="server" Text='<%# Eval("ISBN") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lblCatalogNumber" runat="server" Text='<%# Eval("CatalogNumber") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="btnRemove" runat="server" Text="Remove" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>

                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Books] ORDER BY [CatalogNumber]"></asp:SqlDataSource>
    </form>
</body>
</html>
