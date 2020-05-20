<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DogsList.aspx.cs" Inherits="PetStoreWeb.DogsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletedDogList" runat="server">
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
