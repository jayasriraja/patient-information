<%@ Page Language="C#" AutoEventWireup="true" CodeFile="homepage.aspx.cs" Inherits="homepage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>home page</title>
</head>
<body>
<center>
    <h1 style="font-family: Elephant; font-size: x-large; text-decoration: underline; background-color: #FF9999;">HOME PAGE</h1></center>
    <form id="form1" runat="server">
    <div>
    <center style="background-color: #FFFFCC">
        <asp:Button ID="Button1" runat="server" Text="Click to register the Patient information" 
            onclick="Button1_Click" BackColor="#CCFF99" Font-Names="Algerian" 
            Font-Size="Large" Width="422px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Click to view the Patient Details" 
            onclick="Button2_Click" BackColor="#CCFF99" Font-Names="Algerian" 
            Font-Size="Large" Width="390px" />
    </center>
    </div>
    </form>
</body>
</html>
