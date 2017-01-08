<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Doctor_Index.aspx.cs" Inherits="WebApplication3.Doctor_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><th>StartTime :</th><th>
        </th> <asp:DropDownList ID="shift" runat="server" Width="200px">
                <asp:ListItem Text="Select Time Shift" Value="-1"></asp:ListItem>
                <asp:ListItem Text="8-8:30" Value="0"></asp:ListItem>
                <asp:ListItem Text="8:30-9" Value="1"></asp:ListItem>
                <asp:ListItem Text="9-9:30" Value="2"></asp:ListItem>
                <asp:ListItem Text="9:30-10" Value="3"></asp:ListItem>
                <asp:ListItem Text="10-10:30" Value="4"></asp:ListItem>
                <asp:ListItem Text="10:30-11" Value="5"></asp:ListItem>
                <asp:ListItem Text="11-11:30" Value="6"></asp:ListItem>
                <asp:ListItem Text="11:30-12" Value="7"></asp:ListItem>
                <asp:ListItem Text="13-13:30" Value="8"></asp:ListItem>
                <asp:ListItem Text="13:30-14" Value="9"></asp:ListItem>
                <asp:ListItem Text="14-14:30" Value="10"></asp:ListItem>
                <asp:ListItem Text="14:30-15" Value="11"></asp:ListItem>
                <asp:ListItem Text="15-15:30" Value="12"></asp:ListItem>
                <asp:ListItem Text="15:30-16" Value="13"></asp:ListItem>
                <asp:ListItem Text="16-16:30" Value="14"></asp:ListItem>
                <asp:ListItem Text="16:30-17" Value="15"></asp:ListItem>
                <asp:ListItem Text="17-17:30" Value="16"></asp:ListItem>
                <asp:ListItem Text="17:30-18" Value="17"></asp:ListItem>
                <asp:ListItem Text="18-18:30" Value="18"></asp:ListItem>
                <asp:ListItem Text="18:30-19" Value="19"></asp:ListItem>
                <asp:ListItem Text="19-19:30" Value="20"></asp:ListItem>
                <asp:ListItem Text="19:30-20" Value="21"></asp:ListItem>
            </asp:DropDownList></tr>
        <tr><th>Date :</th><th><asp:TextBox runat="server" id="_Date" name="password" type="Date" /></th></tr>
        <tr><th><asp:Button OnClick="AddTimeShift" runat="server" id="D_Login" name="submit" type="submit"/></th></tr>
</table>
    </div>
    </form>
</body>
</html>
