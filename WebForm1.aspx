<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="GameOfWar.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1643px;
            height: 1116px;
            position: absolute;
            top: 174px;
            left: 223px;
            z-index: 1;
            background-color: #CC9900;
        }
        .auto-style26 {
            height: 865px;
            width: 464px;
            text-align: center;
        }
        .auto-style27 {
            height: 90px;
            width: 464px;
            text-align: center;
        }
        #form1 {
            width: 1389px;
            height: 865px;
        }
        .auto-style29 {
            position: relative;
            top: -200px;
            left: -274px;
            width: 292px;
            height: 235px;
            margin-right: 60px;
        }
        .auto-style30 {
            width: 1287px;
            height: 854px;
        }
        .auto-style33 {
            height: 75px;
            text-align: center;
        }
        .auto-style37 {
            height: 75px;
            width: 350px;
        }
        .auto-style38 {
            width: 350px;
            text-align: center;
        }
        .auto-style46 {
            width: 349px;
            text-align: center;
        }
        .auto-style48 {
            height: 75px;
            width: 349px;
        }
        .auto-style50 {
            height: 865px;
            width: 460px;
            text-align: center;
        }
        .auto-style51 {
            height: 90px;
            width: 460px;
            text-align: center;
        }
        .auto-style52 {
            height: 49px;
            text-align: center;
        }
        .auto-style53 {
            width: 349px;
            text-align: center;
            height: 49px;
        }
        .auto-style54 {
            width: 350px;
            text-align: center;
            height: 49px;
        }
    </style>
</head>
<body style="height: 1113px; width: 1474px; position: relative; left: 78px; top: 36px; margin-right: 261px;">
    <form id="form1" runat="server" class="auto-style30">
        <div class="auto-style29">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style53">
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Cards:"></asp:Label>
                        <asp:Label ID="lblANum" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style52" colspan="2">
                        <asp:Label ID="lblResults" runat="server" Font-Size="XX-Large"></asp:Label>
                        <br />
                        <asp:Label ID="lblResults0" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style54">
                        <asp:Label ID="lblAPlay1" runat="server" Font-Size="XX-Large" Text="Cards:"></asp:Label>
                        <asp:Label ID="lblBNum" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style46" rowspan="2">
                        <br />
                        <asp:Image ID="imgAA" runat="server" Width="200px" BorderColor="#CCCCCC" BorderStyle="Groove" BorderWidth="6px" Visible="False" />
                        <br />
                        <asp:Label ID="lblAAPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Image ID="imgAAA" runat="server" Width="125px" BorderColor="#CCCCCC" BorderStyle="Groove" BorderWidth="6px" Visible="False" />
                        <br />
                        <asp:Label ID="lblAAAPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                    </td>
                    <td class="auto-style26">
                        <asp:Image ID="imgA" runat="server" Width="250px" BorderColor="#CCCCCC" BorderStyle="Groove" BorderWidth="6px" Visible="False" />
                        <br />
                        <asp:Label ID="lblAPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style50">
                        <asp:Image ID="imgB" runat="server" Width="250px" BorderColor="#CCCCCC" BorderStyle="Groove" BorderWidth="6px" Visible="False" />
                        <br />
                        <asp:Label ID="lblBPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style38" rowspan="2">
                        <br />
                        <asp:Image ID="imgBB" runat="server" Width="200px" BorderColor="#CCCCCC" BorderStyle="Groove" BorderWidth="6px" Visible="False" />
                        <br />
                        <asp:Label ID="lblBBPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Image ID="imgBBB" runat="server" Width="125px" BorderColor="#CCCCCC" BorderStyle="Groove" BorderWidth="6px" Visible="False" />
                        <br />
                        <asp:Label ID="lblBBBPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        <asp:Button ID="btnPlayerA" runat="server" Font-Size="X-Large" Height="56px" Text="Attack" Width="259px" BackColor="#CC0000" BorderColor="White" BorderStyle="Solid" ForeColor="#FFCC00" />
                    </td>
                    <td class="auto-style51">
                        <asp:Button ID="btnPlayerB" runat="server" Font-Size="X-Large" Height="56px" Text="Attack" Width="259px" BackColor="#666699" BorderColor="White" BorderStyle="Solid" ForeColor="#FFCC00" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style48"></td>
                    <td class="auto-style33" colspan="2">
                        <asp:Button ID="btnGame" runat="server" Text="New Game" Font-Bold="True" Font-Size="X-Large" height="56px" width="259px" BackColor="#333333" ForeColor="White" />
                    </td>
                    <td class="auto-style37"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
