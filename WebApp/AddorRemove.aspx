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
                <h3>Add Book</h3>
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
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                </div>
            </div>
            <div id="column2" class="col-lg-6">
                <h2>Remove Book</h2>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
