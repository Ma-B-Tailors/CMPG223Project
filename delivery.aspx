<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delivery.aspx.cs" Inherits="WebApplication4.delivery" %>

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
    .col{
        margin-right: 25%;
        padding-top: 40px;
        padding-bottom: 50px;
        padding-bottom: 50px;

    }
    .col div{
        float: right;
        margin-right: 5%;
        border: 1px inset gray;
        padding: 10px;
        background-color: honeydew;
        
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
        <h1 style="text-align: center; padding-top: 70px">Enter your delivery Information to Purchase product</h1>
        <div class="col">
            
            <div class="choose1" aria-disabled="True">
                <h2>Delivery</h2>
                <p>Courier delivery to your door</p>
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Confirm" Width="101px" OnClick="Button1_Click" BackColor="#009900" ForeColor="White" Height="40px" />
                <asp:Button ID="Button2" runat="server" Text="Edit" Width="101px" OnClick="Button2_Click" style="margin-left: 10px" BackColor="#000099" ForeColor="White" Height="40px"/>
                
            </div>
            <div class="choose2">
                <h2>collection</h2>
                <p style="padding-bottom: 10px;">CMa-B Pickup point local wise. open 5 days a week</p>
                <p>
                    <asp:Button ID="Button3" runat="server" BackColor="#009900" ForeColor="White" OnClick="Button3_Click" Text="confirm" Height="40px" Width="101px" />
                </p>

                </div>
            </div> 
        
        <div style="border-radius: 13px; text-align: center; padding: 10px; margin-top: 150px; margin-left: 6%">
        <asp:Button ID="Button4" runat="server" BackColor="#0000CC" ForeColor="White" Height="40px" Text="Continue to payment" Width="450px" OnClick="Button4_Click" />
                </div>
        </div>
        
    </form>
</body>
</html>
