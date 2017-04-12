<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="StyleSheet.css" rel="stylesheet" />
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body>
    <div id="jumbotronId" class="jumbotron">
            <h1 id="Label1" runat="server">Systems Analysis and Design Term Project</h1>
            <h2 id="H1" runat="server" >University Library System</h2>
    </div>
    <form id="form1" runat="server">
    <div class="container">
       <div class="row">
                <h1 class="col-md-12">Login</h1>
            <div id="LoginBox">
            
                <div class="row">
                    <h2 class="col-sm-6">Username</h2>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
                </div>
                <div class="row">
                    <h2 class="col-sm-6">Password</h2>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="txtRegister col-md-2">
                    </asp:TextBox>
                </div>
               
            </div>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            <asp:Button ID="btnNewUser" runat="server" Text="New User" OnClick="btnNewUser_Click" />
           <div class="row">
               <asp:Label ID="lblPassincorrect" runat="server" Text=""></asp:Label> 
                </div>
        </div>
        </div>
        
        <div id="byBox">
        <asp:Label ID="Label3" runat="server" Text="Joel Austin"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Greg Mckibbin"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Zach McClure"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Aarron Dixon"></asp:Label>
            </div>
    </form>
</body>
</html>
