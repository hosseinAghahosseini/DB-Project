<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient_Index.aspx.cs" Inherits="WebApplication3.Pages.Patient_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>

        <tr><th>Select Doctor :</th></tr>
        <tr><th> <asp:DropDownList ID="Doctor_name" runat="server" Width="200px">
                
        </asp:DropDownList></th> <th><asp:Button OnClick="Select_Doctor" runat="server" id="addDrugBtn" name="submit" type="submit"/></th></tr>
         <tr><th> Select Time :</th></tr>
        <tr><th><asp:DropDownList ID="Choose_Time" OnSelectedIndexChanged="abc" runat="server" Width="200px">                
        </asp:DropDownList></th></tr>
        </table>

    </div>
    </form>
</body>
</html>
