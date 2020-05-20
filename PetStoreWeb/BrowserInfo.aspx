<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BrowserInfo.aspx.cs" Inherits="PetStoreWeb.BrowserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- From CS -->
            <asp:Panel ID="CsPanel" runat="server">
                <asp:Label ID="CsUserAgentLabel" runat="server"></asp:Label>
            </asp:Panel>
            <br />
            <!-- From markup -->
            <asp:Panel ID="MarkUpPanel" runat="server">
                <asp:Label ID="MarkUpUserAgentLabel" runat="server">
                    MarkUp: <%=Request.UserAgent%>
                </asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
