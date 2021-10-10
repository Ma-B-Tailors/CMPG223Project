<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="WebApplication4.product" %>

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
            text-align: center;
        }
       
        .auto-style2 {
            height: 37px;
            width: 329px;
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
        <div class="contain">
        <div style="margin-left: 70px;">
        <div>
         <h1 class="auto-style1">
             <asp:Label ID="Label1" runat="server" Text="Create your measurements"></asp:Label>
         </h1>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
         <p>
             <asp:Label ID="Label2" runat="server" Text="Neck"></asp:Label>
         </p>
         <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="460px"></asp:TextBox>
            </div>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter valid input" ForeColor="Red"></asp:RequiredFieldValidator>
         <br />
             <asp:Label ID="Label3" runat="server" Text="Chest"></asp:Label>
         <br />
         <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="460px"></asp:TextBox>
            <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter valid input" ForeColor="#CC0000"></asp:RequiredFieldValidator>
         <br />
             <asp:Label ID="Label4" runat="server" Text="Arm Length"></asp:Label>
         <br />
         <asp:TextBox ID="TextBox3" runat="server" Height="35px" Width="460px"></asp:TextBox>
            <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter valid input" ForeColor="Red"></asp:RequiredFieldValidator>
         <br />
             <asp:Label ID="Label5" runat="server" Text="Shoulder width"></asp:Label>
         <br />
         <asp:TextBox ID="TextBox4" runat="server" Height="35px" Width="460px"></asp:TextBox>
            <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter valid input" ForeColor="Red"></asp:RequiredFieldValidator>
         <br />
             <asp:Label ID="Label6" runat="server" Text="Waist"></asp:Label>
         <br />
         <asp:TextBox ID="TextBox5" runat="server" Height="35px" Width="460px"></asp:TextBox>
            <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter valid input" ForeColor="Red"></asp:RequiredFieldValidator>
         <br />
             <asp:Label ID="Label7" runat="server" Text="Insean"></asp:Label>
         <br />
         <asp:TextBox ID="TextBox6" runat="server" Height="35px" Width="460px"></asp:TextBox>
            <br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter valid input" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Choose a Tailor"></asp:Label>
         <br />
         <p>
             <asp:DropDownList ID="DropDownList1" runat="server" Height="35px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="460px">
             </asp:DropDownList>
         </p>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;<asp:Button ID="Button1" runat="server" BackColor="#0000CC" ForeColor="White" Height="35px" OnClick="Button1_Click" Text="Submit" Width="460px" />
         </p>
         <p>
             &nbsp;</p>
            </div>
        <div class="contain2">
                <div style="padding: 100px">
                <h1 style="color: white; font-size: 40px">Dont know your Measurements</h1><br />
                <p style="color: white;">proceed below to schedule an Appointment. Be sure of your measurement</p><br />
                
                <button class="auto-style2" style="background-color: deepskyblue"><a href="/Appointment.aspx" style="color: white;">proceed</a>
                    </button>
                    </div>
            </div>
            </div>
        
    </form>
</body>
</html>
