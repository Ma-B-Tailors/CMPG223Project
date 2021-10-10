<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="WebApplication4.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

    * {
        box-sizing: border-box;
        margin: 0;
    }
        .auto-style2 {
            margin-left: 0px;
        }
               
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="margin-left: 30%">
            <div>
                <h1><asp:Label ID="Label2" runat="server" Text="Address information" ></asp:Label></h1>
            <br />
        <br />
                <p>Street Name:</p>
                
        <asp:TextBox ID="TextBox5" runat="server" Height="35px" Width="455px" CssClass="auto-style2" TextMode="Password"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*Enter valid name*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
                <p>City:</p>
                
        <asp:TextBox ID="TextBox6" runat="server" Height="35px" Width="455px" CssClass="auto-style2" TextMode="Password"></asp:TextBox>
            <br />
                <p>House Number:</p>
                
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="*Enter valid name*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
        <asp:TextBox ID="TextBox7" runat="server" Height="35px" Width="455px" CssClass="auto-style2" TextMode="Password"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="*Enter valid name*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" BackColor="#0000CC" ForeColor="White" Height="40px" Text="Submit" Width="455px" OnClick="Button1_Click" />
            </div>
            </div>
    </form>
</body>
</html>
