<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorSignUp.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form method="post" id="form1" runat="server">
    <div><table>
        <tr><th> Enter Name</th><th><asp:TextBox runat="server" id="DoctorFName" name="DoctorFName" type="text"/></th></tr>
        <tr><th>Enter your family name</th><th><asp:TextBox runat="server" id="DoctorLname" name="DoctorLname" type="text" /></th></tr>
        <tr><th>Enter your SSN</th><th><asp:TextBox runat="server" id="SSN" name="SSN" type="text" /></th></tr>
        <tr><th>Enter your Email</th><th><asp:TextBox runat="server" id="Email" name="email" type="email" /></th></tr>
        <tr><th>Location</th><th><asp:TextBox runat="server" id="location" name="location" type="text" /></th></tr>
         <tr><th>Enter your password</th><th><asp:TextBox runat="server" id="password" name="password" type="password" /></th></tr>
        <tr><th><asp:Button OnClick="DoctorSubmit" runat="server" id="submit" name="submit" type="submit"/></th></tr>
        </table>
    </div>
    </form>
</body>
</html>
