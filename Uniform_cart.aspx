<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uniform_cart.aspx.cs" Inherits="WebApplication4.Uniform_cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    .image2 img {
        width: 200px;
        height: 250px;
    }
    .image2{
        padding-top: 65px;
        padding-bottom: 120px;
        padding-left: 100px;
        align-content: center;
    }
    .footer{
        padding-bottom: 80px;
        padding-top: 80px;
        text-align: center;
        background-color: black;
    }
    footer {
        padding-top: 120px;
    }
    .button1{
        text-align: center;
        padding-top: 15px;
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
  
</style>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            margin-left: 33%;
            margin-right: auto;
            padding-top: 50px;
        }
        .dive{
            text-align: center;
        }
    </style>
</head>
<body>
     <header class="header1">
        <h1 class="logo">
            <a href="#">Call us(0797394470)</a>
        </h1>
        <ul class="main-nav" id="myTopnav">
              <li><a href="/About.html">About</a></li>
            <li><a href="/landing.html">Home</a></li>
            <li><a href="/Tailor.aspx">Become a Tailor</a></li>
            <li><a href="/WebForm1.aspx" class="btn btn-secondary">Customer</a></li>
            <li><a href="/Login.aspx">Login</a></li>

        </ul>

    </header>
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="text-align: center">
        <div class="auto-style1">
            <asp:GridView ID="GridView1" runat="server" BackColor="#999966" Height="204px" Width="395px">
            </asp:GridView>
            <br />
        </div>
        
            </div>
        <div class="dive">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete product" BackColor="#009933" ForeColor="White" Height="40px" Width="231px" />
        <br />
            <div style="padding-top: 20px";>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="confirm product" BackColor="#0000CC" ForeColor="White" Height="40px" Width="328px"/>
            </div>

    </form>
</body>
</html>
