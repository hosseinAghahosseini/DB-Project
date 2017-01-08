<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log_In.aspx.cs" Inherits="WebApplication3.Log_In" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Doctor Login
    <table>
        <tr><th>Username :</th><th><asp:TextBox runat="server" id="D_Username1" name="location" type="text" /></th></tr>
         <tr><th>Password :</th><th><asp:TextBox runat="server" id="D_Password1" name="password" type="password" /></th></tr>
        <tr><th><asp:Button OnClick="DoctorLogin" runat="server" id="D_Login1" name="submit" type="submit"/></th></tr>
    </table>
    </div>

        Patient Login

        <table>
        <tr><th>Username :</th><th><asp:TextBox runat="server" id="P_username1" name="location" type="text" /></th></tr>
         <tr><th>Password :</th><th><asp:TextBox runat="server" id="P_Password1" name="password" type="password" /></th></tr>
        <tr><th><asp:Button OnClick="PatientLogin" runat="server" id="P_login1" name="submit" type="submit"/></th></tr>
    </table>
    </form>
    

</body>
</html>
