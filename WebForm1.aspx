<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="GameOfWar.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1158px;
            height: 774px;
            position: absolute;
            top: 0px;
            left: 0px;
            z-index: 1;
        }
        .auto-style9 {
            height: 516px;
            width: 439px;
        }
        .auto-style11 {
            width: 452px;
        }
        .auto-style12 {
            width: 452px;
            height: 516px;
        }
        .auto-style15 {
            height: 516px;
            width: 408px;
            text-align: center;
        }
        .auto-style17 {
            width: 439px;
        }
        .auto-style19 {
            width: 452px;
            height: 70px;
            text-align: center;
        }
        .auto-style21 {
            height: 70px;
            width: 439px;
            text-align: center;
        }
        .auto-style22 {
            width: 452px;
            height: 78px;
        }
        .auto-style23 {
            height: 78px;
            width: 408px;
            text-align: center;
        }
        .auto-style24 {
            height: 78px;
            width: 439px;
        }
        .auto-style25 {
            height: 70px;
            text-align: center;
        }
        .auto-style26 {
            height: 516px;
            width: 407px;
            text-align: center;
        }
        .auto-style27 {
            height: 78px;
            width: 407px;
            text-align: center;
        }
        .auto-style28 {
            text-align: center;
        }
        #form1 {
            width: 1389px;
            height: 865px;
        }
    </style>
</head>
<body style="height: 861px; width: 1383px; position: relative;">
    <form id="form1" runat="server">
        <div style="position: relative; top: 0px; left: 0px; width: 1431px; height: 936px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style19">
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Cards:"></asp:Label>
                        <asp:Label ID="lblANum" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style25" colspan="2">
                        <asp:Label ID="lblResults" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style21">
                        <asp:Label ID="lblAPlay1" runat="server" Font-Size="XX-Large" Text="Cards:"></asp:Label>
                        <asp:Label ID="lblBNum" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style26">
                        <asp:Label ID="lblAPlay" runat="server" Font-Size="50px" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Label ID="lblAAPlay" runat="server" Font-Size="50px" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Label ID="lblAAAPlay" runat="server" Font-Size="50px" Font-Bold="True" ForeColor="#660033"></asp:Label>
                    </td>
                    <td class="auto-style15">
                        <asp:Label ID="lblBPlay" runat="server" Font-Size="50px" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Label ID="lblBBPlay" runat="server" Font-Size="50px" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Label ID="lblBBBPlay" runat="server" Font-Size="50px" Font-Bold="True" ForeColor="#660033"></asp:Label>
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style22"></td>
                    <td class="auto-style27">
                        <asp:Button ID="btnPlayerA" runat="server" Font-Size="X-Large" Height="56px" Text="Play!" Width="259px" />
                    </td>
                    <td class="auto-style23">
                        <asp:Button ID="btnPlayerB" runat="server" Font-Size="X-Large" Height="56px" Text="Play!" Width="259px" />
                    </td>
                    <td class="auto-style24"></td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style28" colspan="2">
                        <asp:Button ID="btnGame" runat="server" Text="New Game" Font-Bold="True" Font-Size="X-Large" height="56px" width="259px" />
                    </td>
                    <td class="auto-style17">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
