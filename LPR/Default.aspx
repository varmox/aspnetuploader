<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LPR.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="upload" OnClick="Button1_Click" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="" />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Visible="false">
                <asp:Label ID="Label2" runat="server" Text="" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
