<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

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
        <h2>Checkout a Book</h2>
        <div id="Search" class="row">
                <p class="col-lg-1">Search</p>
                <asp:TextBox ID="txtSearch" runat="server" CssClass="col-lg-2"></asp:TextBox>
                    <p class="col-lg-1">By</p>
                    <asp:DropDownList ID="drpSearch" runat="server" CssClass="col-lg-2" >
                        <asp:ListItem Value="Title">Title</asp:ListItem>
                        <asp:ListItem Value="Author">Author</asp:ListItem>
                        <asp:ListItem Value="Publisher">Publisher</asp:ListItem>
                        <asp:ListItem Value="ISBN">ISBN</asp:ListItem>
                        <asp:ListItem Value="Edition">Edition</asp:ListItem>
                        <asp:ListItem Value="PublicationYear">Publication Year</asp:ListItem>
                        <asp:ListItem Value="CatalogNumber">Catalog Number</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="col-lg-1" OnClick="btnSearch_Click"/>
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" CssClass="col-lg-1"/>
            
        </div>
        <div id="Checkout">
            <asp:Repeater ID="bookRepeater" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="bookRepeater_ItemCommand" OnItemDataBound="bookRepeater_ItemDataBound">
                <HeaderTemplate>
                    <table class="col-md-12">  
                        <tr>
                            <th>Image</th>
                            <th>Title</th>
                            <th>Author</th>
                            <th>Publisher</th>
                            <th>ISBN</th>
                            <th>Edition</th>
                            <th>Publication Year</th>
                            <th>Catalog Number</th>
                            <th>Copy Number</th>
                            <th>Reserved</th>
                            <th>Checked Out</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <img width="65" id="imgImage" runat="server" src='<%# Eval("imgURl") %>' />
                        </td>
                            <td>
                                <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblAuthor" runat="server" Text='<%# Eval("Author") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblPublisher" runat="server" Text='<%# Eval("Publisher") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblISBN" runat="server" Text='<%# Eval("ISBN") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblEdition" runat="server" Text='<%# Eval("Edition") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblPublicationYear" runat="server" Text='<%# Eval("PublicationYear") %>' />
                            </td>
                        <td>
                                <asp:Label ID="lblCatalogNumber" runat="server" Text='<%# Eval("CatalogNumber") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblCopyNumber" runat="server" Text='<%# Eval("CopyNumber") %>' />
                            </td>
                                              <td>
                                <asp:Label ID="lblReserved" runat="server" Text='<%# Eval("Reserved") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblBookStatus" runat="server" Text='<%# Eval("BookStatus") %>' />
                            </td>
                            <td>
                                <asp:Button ID="btnCheckout" runat="server" Text="Checkout" CommandName="test" />
                            </td>
                        </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>

            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Books] ORDER BY Title"></asp:SqlDataSource>
        </div>
    </div>
    </form>
</body>
</html>
