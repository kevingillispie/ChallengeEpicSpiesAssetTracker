<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asset Tracker</title>
    <style type="text/css">
        .auto-style1 {
            width: 242px;
            height: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img class="auto-style1" src="epic-spies-logo.jpg" style="height: 150px; width: auto;" /><br /></div>
            <div><h2 style="font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;">Asset Performance Tracker</h2>
        </div>
        <div>
            <p>Asset Name: 
                <asp:TextBox ID="assetNameBox" runat="server"></asp:TextBox>
            </p>
            <p>Number of Elections Rigged:
                <asp:TextBox ID="electionsRiggedBox" runat="server"></asp:TextBox>
            </p>
            <p>Number of Acts of Subterfuge Performed:
                <asp:TextBox ID="subterfugeBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="assetButton" runat="server" Text="Add Asset" OnClick="assetButton_Click" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
