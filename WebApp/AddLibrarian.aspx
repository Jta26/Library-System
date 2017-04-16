<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddLibrarian.aspx.cs" Inherits="AddLibrarian" %>

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
    <div>
    <div id="AddLibarian" class="container">
        <h2>Add a new Libarian User</h2>
        <div class="row">
            <div class="col-sm-8">
            <p class="col-lg-8">Username</p>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="col-lg-4"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="btnUsername" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <br />
            <asp:Label ID="lblLibrarian" runat="server" Text="" Visible="false"></asp:Label>

        
    </div>
    </div>
    </form>
</body>
</html>
