<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="WebApplication4.Appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
    * {
        box-sizing: border-box;
        margin: 0;
    }
    img {
        width: 100%;
        height: 500px;
        object-fit: cover;
       
    }
.one { height: 500px; background-image: url('https://as2.ftcdn.net/v2/jpg/04/11/19/61/1000_F_411196188_YqkLOl76sIUXDuRaLqsSOWlrihf8FZie.jpg'); background-position: center; background-repeat: no-repeat; background-size: cover; position: relative; 

}

div .one{
    padding-top: 12%;
    text-align: center;
    color: white;
}
    ul {
        margin: 0;
        padding: 0;
        list-style: none;
    }

    h2,
    h3,
    a {
        color: black;
    }

    

    a {
        text-decoration: none;
    }

    .logo {
        margin: 0;
        font-size: 20px;
    }

    .main-nav {
        margin-top: 5px;
    }

        .logo a,
        .main-nav a {
            padding: 10px 15px;
            text-transform: uppercase;
            text-align: center;
            display: block;
        }

    .logo a {
        text-transform: lowercase;
        font-size: 15px;
        color: #574a2b;
    }

    .main-nav a {
        color: black;
        font-size: .99em;
        border: 1.2px solid #574a2b;
        border-top: 0;
        border-bottom: 0;
    }

        .main-nav a:hover {
            color: rgb(167, 54, 54);
        }

    .header1 {
        padding-top: .8em;
        padding-bottom: .8em;
        padding-left: 20px;
        padding-right: 20px;
        
    }

    .contain{
        display: grid;
        grid-template-columns: 1fr 1fr;
        grid-gap: 4px;
        width: 100%;
    }
    .contain2 {
        padding-left: -60px;
        background-color: deepskyblue;
        height: 100vh;
    }
     @media (min-width: 769px) {
        .header1,
        .main-nav {
            display: flex;
        }

        .header1 {
            flex-direction: column;
            align-items: center;
            .header1

    {
        width: 80%;
        margin: 0 auto;
        max-width: 1150px;
    }

    }
    }

    @media (min-width: 1025px) {
        .header1 {
            flex-direction: row;
            justify-content: space-between;
            max-width: 100%;
        }
    }
        .auto-style1 {
            margin-top: 0;
        }
        .auto-style2 {
            margin-left: 0px;
        }
               
        .auto-style4 {
            margin-bottom: 0;
        }
       
        .auto-style6 {
            text-align: center;
        }
       
        .auto-style7 {
            padding-left: -60px;
            background-color: deepskyblue;
            height: 100vh;
        }
       
        .auto-style8 {
            display: grid;
            grid-template-columns: 1fr 1fr;
            grid-gap: 4px;
            width: 100%;
            height: 1498px;
        }
       
        .auto-style9 {
            width: 328px;
            height: 40px;
            border-radius: 13px;
        }
       
        </style>
<body>
 <form id="form1" runat="server">
    <header class="header1">
        <h1 class="logo">
            <a href="#">Call us(0797394470)</a>
        </h1>
        <ul class="main-nav" id="myTopnav">
             <li><a href="/About.html">About</a></li>
            <li><a href="/landing.html">Home</a></li>
            <li><a href="/Tailor.aspx">Become a Tailor</a></li>
            <li><a href="/WebForm1.aspx" class="btn btn-secondary">Customer</a></li>
            <li><a href="/product.aspx">Login</a></li>

        </ul>

    </header>
        
            
        
        <div class="auto-style8">
        <div class="contain1" style="margin-left: 15%; padding-top: 20px; padding-right: 10%; max-width: 100%">
            <h1 style="text-align: center; padding-bottom: 30px; padding-top: 30px;">Schedule an Appointment now</h1>
            <br />
            <a href="/users/apply">Choose a Date</a>:<br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Height="35px" Width="455px" TextMode="Date"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Enter valid name*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
            <p>
                <a href="/users/apply">Choose a Tailor</a></p>
           
        <p>
           
            <asp:DropDownList ID="DropDownList1" runat="server" Height="35px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="455px">
            </asp:DropDownList>
           </p>
            <p>
           
                &nbsp;</p>
            <h3 style="text-align: center;">
                <asp:Label ID="Label2" runat="server" Text="Address information" ></asp:Label>
            </h3>
            <p>
                &nbsp;</p>
            <p>
                <a href="/users/apply">Street Name:</a></p>
            <p>
        <asp:TextBox ID="TextBox5" runat="server" Height="35px" Width="455px" CssClass="auto-style2" TextMode="Password"></asp:TextBox>
            </p>
            <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Enter valid name*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </p>
            <p>
                <a href="/users/apply">City</a></p>
            <p>
        <asp:TextBox ID="TextBox6" runat="server" Height="35px" Width="455px" CssClass="auto-style2" TextMode="Password"></asp:TextBox>
            </p>
            <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="*Enter valid name*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </p>
            <p>
                <a href="/users/apply">House number:</a></p>
            <p>
        <asp:TextBox ID="TextBox7" runat="server" Height="35px" Width="455px" CssClass="auto-style2" TextMode="Password"></asp:TextBox>
            </p>
            <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="*Enter valid name*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </p>
            <p>
                &nbsp;</p>
            <h4 class="auto-style6">
                <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Save Address info" ForeColor="#33CC33" />
            </h4>
            <p>
                &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" BorderColor="#FF3300"></asp:Label>
        </p>
            <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#000099" ForeColor="White" OnClick="Button1_Click" Width="455px" CssClass="auto-style4" Height="42px" style="padding-right: 5px;"/>
        </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
             </div>
            <div class="auto-style7">
                <div style="padding: 100px; ">
                <h1 style="color: white; font-size: 40px">Do you know your Size</h1><br />
                <p style="color: white;">proceed below to enter your details. No need to schedule any Appointment</p><br />
                <button class="auto-style9" style="background-color: deepskyblue"><a href="/product.aspx" style="color: white;">proceed</a>
                    </button>
                    </div>
               
                    </div>
            </div>
            </div>
    </form>
</body>
</html>
