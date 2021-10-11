<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication4.WebForm4" %>

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

    .container{
        display: grid;
        grid-template-columns: 1fr 1fr 1fr;
        margin: 100px;
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
        <div class="container">
        <div>
            <img src="https://cdn.icon-icons.com/icons2/933/PNG/512/round-account-button-with-user-inside_icon-icons.com_72596.png" style="width:150px;height:150px"/>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
             <br />
            <asp:Button ID="Button4" runat="server" Text="Button" Width="262px" />
             <br />
           
        </div>

         <div>
            <img src="https://cdn-icons-png.flaticon.com/512/942/942810.png" style="width:150px;height:150px"/>
             <h3>Delete your Appointment now</h3>
             <p>
                 <asp:Button ID="Button5" runat="server" Text="Button" Width="262px" />
             </p>

        </div>
        <div>
            <img src="https://cdn-icons-png.flaticon.com/512/942/942810.png" style="width:150px;height:150px"/>
             <h3>Delete your payment now</h3>
            <p>
                <asp:Button ID="Button6" runat="server" Text="Button" Width="262px" />
            </p>
        </div>
            </div>
       
       
        <p>
            &nbsp;</p>
    </form>
</body>
</html>