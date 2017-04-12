<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="StyleSheet.css" rel="stylesheet" />
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body>
        <div id="jumbotronId" class="">
            <h1 id="Label1" runat="server">Systems Analysis and Design Term Project</h1>
            <h2 id="H1" runat="server" >University Library System</h2>
    </div>
    <form id="form1" runat="server">
    <div class="container">
        <div id="welcomeDiv" class="row">
            <h1>
                <asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label>
            </h1>
        </div>
        <div id="btnRow" class="row" runat="server">
            <div class="col-md-2 btn">
            
                <asp:ImageButton ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/PublicInformationSymbol_EmergencyExit.svg/200px-PublicInformationSymbol_EmergencyExit.svg.png" ID="imgLogout" runat="server" CssClass="btn-default imgbtn" AlternateText="Logout" Width="100" Height="100" BorderStyle="Solid" BorderColor="Black" OnClick="imgLogout_Click" />
                <p>User Logout</p>
             </div>
            
            <div class="col-md-2 btn">
                <asp:ImageButton ImageUrl="http://cslainfo.org/wp-content/uploads/2015/07/Book-Cart.png" ID="imgCheckout" runat="server" CssClass="btn-default imgbtn" AlternateText="Logout" Width="100" Height="100" BorderStyle="Solid" BorderColor="Black" OnClick="imgCheckout_Click"/>
                <p>Checkout Books</p>
            </div>
            <div class="col-md-2 btn">
                <asp:ImageButton ImageUrl="http://www.fancyicons.com/free-icons/232/science/png/256/return_book_256.png" ID="imgReturn" runat="server" CssClass="btn-default imgbtn" AlternateText="Logout" Width="100" Height="100" BorderStyle="Solid" BorderColor="Black"/>
                <p>Return Books</p>
            </div>
            <asp:Panel ID="pnlbtn" runat="server" Visible="false">
                <div class="col-md-2 btn" id="btnAddRemove" runat="server">
                <asp:ImageButton ImageUrl="https://d30y9cdsu7xlg0.cloudfront.net/png/281780-200.png" ID="imgAddRemove" runat="server" CssClass="btn-default imgbtn" AlternateText="LibSignIn" Width="100" Height="100" BorderStyle="Solid" BorderColor="Black" OnClick="imgAddRemove_Click"/>
                <p><asp:Label ID="lblAddRemove" runat="server" Text=""></asp:Label></p>
            </div>
            </asp:Panel>
            
         </div>
    </div>
    </form>
    <div id="byBox">
        <asp:Label ID="Label3" runat="server" Text="Joel Austin"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Greg Mckibbin"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Zach McClure"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Aarron Dixon"></asp:Label>
            </div>
</body>
</html>
