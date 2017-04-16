<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
   
</head>
<body>
    <div id="jumbotronId" class="jumbotron">
            <h1 id="Label1" runat="server">Systems Analysis and Design Term Project</h1>
            <h2 id="Label2" runat="server" >University Library System</h2>
    </div>
    <form id="form1" runat="server">
        <div class="container" id="registerBox">

            <div class="row">
                <h1 class="col-md-12">Registration</h1>

            </div>
            <div class="row">
                <h2 class="col-sm-6">First Name</h2>
                <asp:TextBox ID="txtPickFirstName" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">Last Name</h2>
                <asp:TextBox ID="txtPickLastName" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">Username</h2>
                <asp:TextBox ID="txtPickUsername" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">Password</h2>
                <asp:TextBox ID="txtPickPassword" runat="server" CssClass="txtRegister col-md-2" TextMode="Password"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">Confirm Password</h2>
                <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">Address</h2>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">City</h2>
                <asp:TextBox ID="txtCity" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">State</h2>
                <asp:DropDownList ID="DropDownListState" runat="server" CssClass="txtRegister col-md-2">
	                <asp:ListItem Value="AL">Alabama</asp:ListItem>
	                <asp:ListItem Value="AK">Alaska</asp:ListItem>
	                <asp:ListItem Value="AZ">Arizona</asp:ListItem>
	                <asp:ListItem Value="AR">Arkansas</asp:ListItem>
	                <asp:ListItem Value="CA">California</asp:ListItem>
	                <asp:ListItem Value="CO">Colorado</asp:ListItem>
	                <asp:ListItem Value="CT">Connecticut</asp:ListItem>
	                <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
	                <asp:ListItem Value="DE">Delaware</asp:ListItem>
	                <asp:ListItem Value="FL">Florida</asp:ListItem>
	                <asp:ListItem Value="GA">Georgia</asp:ListItem>
	                <asp:ListItem Value="HI">Hawaii</asp:ListItem>
	                <asp:ListItem Value="ID">Idaho</asp:ListItem>
	                <asp:ListItem Value="IL">Illinois</asp:ListItem>
	                <asp:ListItem Value="IN">Indiana</asp:ListItem>
	                <asp:ListItem Value="IA">Iowa</asp:ListItem>
	                <asp:ListItem Value="KS">Kansas</asp:ListItem>
	                <asp:ListItem Value="KY">Kentucky</asp:ListItem>
	                <asp:ListItem Value="LA">Louisiana</asp:ListItem>
	                <asp:ListItem Value="ME">Maine</asp:ListItem>
	                <asp:ListItem Value="MD">Maryland</asp:ListItem>
	                <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
	                <asp:ListItem Value="MI">Michigan</asp:ListItem>
	                <asp:ListItem Value="MN">Minnesota</asp:ListItem>
	                <asp:ListItem Value="MS">Mississippi</asp:ListItem>
	                <asp:ListItem Value="MO">Missouri</asp:ListItem>
	                <asp:ListItem Value="MT">Montana</asp:ListItem>
	                <asp:ListItem Value="NE">Nebraska</asp:ListItem>
	                <asp:ListItem Value="NV">Nevada</asp:ListItem>
	                <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
	                <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
	                <asp:ListItem Value="NM">New Mexico</asp:ListItem>
	                <asp:ListItem Value="NY">New York</asp:ListItem>
	                <asp:ListItem Value="NC">North Carolina</asp:ListItem>
	                <asp:ListItem Value="ND">North Dakota</asp:ListItem>
	                <asp:ListItem Value="OH">Ohio</asp:ListItem>
	                <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
	                <asp:ListItem Value="OR">Oregon</asp:ListItem>
	                <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
	                <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
	                <asp:ListItem Value="SC">South Carolina</asp:ListItem>
	                <asp:ListItem Value="SD">South Dakota</asp:ListItem>
	                <asp:ListItem Value="TN">Tennessee</asp:ListItem>
	                <asp:ListItem Value="TX">Texas</asp:ListItem>
	                <asp:ListItem Value="UT">Utah</asp:ListItem>
	                <asp:ListItem Value="VT">Vermont</asp:ListItem>
	                <asp:ListItem Value="VA">Virginia</asp:ListItem>
	                <asp:ListItem Value="WA">Washington</asp:ListItem>
	                <asp:ListItem Value="WV">West Virginia</asp:ListItem>
	                <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
	                <asp:ListItem Value="WY">Wyoming</asp:ListItem>
        </asp:DropDownList>
            </div>
            <div class="row">
                <h2 class="col-sm-6">Zip Code</h2>
                <asp:TextBox ID="txtZipCode" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                
                <h2 class="col-sm-6">Phone Number</h2>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
            </div>
            <div class="row">
                <h2 class="col-sm-6">User Type</h2>

                <asp:DropDownList ID="drpUserSelect" runat="server" CssClass="txtRegister col-md-2" OnSelectedIndexChanged="drpUserSelect_SelectedIndexChanged" AutoPostBack="False">
                    <asp:ListItem>Student</asp:ListItem>
                    <asp:ListItem>Faculty</asp:ListItem>
                </asp:DropDownList>
            </div>
                <div class="row">
                
                        <h2 id="h2Program" class="col-sm-6">Student Program</h2>
                    <asp:TextBox ID="txtProgram" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
                    </div>
                <div class="row">
                        <h2 id="h2Credit" class="col-sm-6">Credit Hours</h2>
                    <asp:TextBox ID="txtCredit" runat="server" CssClass="txtRegister col-md-2"></asp:TextBox>
                </div>
            <div class="row">
                <asp:Button ID="btnSubmitRegister" runat="server" Text="Submit User" OnClick="btnSubmitRegister_Click" />
            </div>
        </div>
    </form>
</body>
    <script type="text/javascript" src="onchange.js"></script>
</html>
