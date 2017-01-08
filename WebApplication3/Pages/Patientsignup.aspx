<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patientsignup.aspx.cs" Inherits="WebApplication3.Patientsignup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form method="post" id="form2" runat="server">
    <div>
        <table>
        <tr><th>Enter your SSN</th><th><asp:TextBox runat="server" id="pSSN" name="SSN" type="text" /></th></tr>
        <tr><th> Enter your first Name</th><th><asp:TextBox runat="server" id="PatientFName" name="PatientFName" type="text"/></th></tr>
        <tr><th>Enter your family name</th><th><asp:TextBox runat="server" id="PatientLname" name="PatientLname" type="text" /></th></tr>
        <tr><th>Enter your Email</th><th><asp:TextBox runat="server" id="pEmail" name="email" type="email" /></th></tr>
         <tr><th>Enter your password</th><th><asp:TextBox runat="server" id="ppassword" name="password" type="password" /></th></tr>
        <tr><th><asp:Button OnClick="PatientSubmit" runat="server" id="submit" name="submit" type="submit"/></th></tr>
        </table>
        </div>
    </form>
</body>
</html>
