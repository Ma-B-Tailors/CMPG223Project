<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productIterms.aspx.cs" Inherits="WebApplication4.productIterms" %>

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
    .image2{
        display: grid;
        grid-template-columns:  1fr 1fr 1fr;
    }
    .image2 div{
         display: grid;
        grid-template-rows:  1fr;
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
    .button1{
        
        margin-top: 10px;
        padding-bottom: 20px;
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
             <div class="image2">
                 <div>
            <img src="https://awerbuchs.co.za/image/cache/catalog/Awerbuchs%20images/School/General/collies%20LS-1000x1000.JPG" alt="Bheki"/>
                     <asp:RadioButton ID="RadioButton1" runat="server" GroupName="ProductIterms" Text="School Trousers" />
                     </div>
                 <div>
            <img src="https://directschoolwear.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/7/0/7040-large.jpg" alt="Dintle"/>
                     <asp:RadioButton ID="RadioButton2" runat="server" GroupName="ProductIterms" Text="long sleeve t shirts" />
                     </div>
                 <div>
            <img src="https://img.joomcdn.net/a24ef869c0254967f9bd1ddee03e5ff71fbf4e5b_original.jpeg" alt="Timothy"/>
                     <asp:RadioButton ID="RadioButton3" runat="server" GroupName="ProductIterms" Text="School skirts" />
                     </div>
                 <div>
            <img src="https://5.imimg.com/data5/OH/QH/MY-65715759/nehru-jacket-500x500.jpg" alt="Jay"/>
                     <asp:RadioButton ID="RadioButton4" runat="server" GroupName="ProductIterms" Text="School blazer" />
                     </div>
                 <div>
            <img src="https://www.ackermans.co.za/cdn-proxy/prod-ack-cdn/product-images/prod/260_260_600112015001_1.webp" alt="Neo"/>
                     <asp:RadioButton ID="RadioButton5" runat="server" GroupName="ProductIterms" Text="short sleeve t shirts" />
                     
                     </div>
                
                 </div>
         <div style="text-align: center">
                     <asp:Label ID="Label2" runat="server" ForeColor="Blue"></asp:Label>
                     </div>
       
        <div style="text-align: center">
        <p>
             <asp:Button ID="Button1" runat="server" Text="Add to cart" BackColor="#0000CC" ForeColor="White" Height="42px" Width="328px" style="border-radius: 13px;" CssClass="button1" OnClick="Button1_Click1"/>
            
        </p>
            </div>
             <p>
                 &nbsp;</p>
             <p>
                 &nbsp;</p>
             <p>
                 &nbsp;</p>
    </form>
</body>
</html>
