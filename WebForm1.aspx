<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="GameOfWar.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1682px;
            height: 937px;
            position: absolute;
            top: 17px;
            left: 30px;
            z-index: 1;
            background-color: #CC9900;
        }
        .auto-style26 {
            height: 703px;
            width: 464px;
            text-align: center;
        }
        .auto-style27 {
            height: 82px;
            width: 464px;
            text-align: center;
        }
        #form1 {
            width: 1389px;
            height: 865px;
        }
        .auto-style29 {
            position: relative;
            top: 5px;
            left: 3px;
            width: 1049px;
            height: 884px;
            margin-right: 60px;
        }
        .auto-style30 {
            width: 1759px;
            height: 1083px;
        }
        .auto-style33 {
            height: 74px;
            text-align: center;
        }
        .auto-style34 {
            height: 126px;
            width: 350px;
            text-align: center;
        }
        .auto-style36 {
            height: 82px;
            width: 350px;
        }
        .auto-style37 {
            height: 74px;
            width: 350px;
        }
        .auto-style38 {
            height: 703px;
            width: 350px;
            text-align: center;
        }
        .auto-style45 {
            height: 126px;
            width: 349px;
            text-align: center;
        }
        .auto-style46 {
            height: 703px;
            width: 349px;
            text-align: center;
        }
        .auto-style47 {
            height: 82px;
            width: 349px;
        }
        .auto-style48 {
            height: 74px;
            width: 349px;
        }
        .auto-style49 {
            height: 126px;
            text-align: center;
        }
        .auto-style50 {
            height: 703px;
            width: 460px;
            text-align: center;
        }
        .auto-style51 {
            height: 82px;
            width: 460px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 998px; width: 1612px; position: relative; left: 170px; top: 100px; margin-right: 261px;">
    <form id="form1" runat="server" class="auto-style30">
        <div class="auto-style29">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style45">
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Cards:"></asp:Label>
                        <asp:Label ID="lblANum" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style49" colspan="2">
                        <asp:Label ID="lblResults" runat="server" Font-Size="XX-Large"></asp:Label>
                        <br />
                        <asp:Label ID="lblResults0" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                    <td class="auto-style34">
                        <asp:Label ID="lblAPlay1" runat="server" Font-Size="XX-Large" Text="Cards:"></asp:Label>
                        <asp:Label ID="lblBNum" runat="server" Font-Size="XX-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style46">
                        <br />
                        <asp:Image ID="imgAA" runat="server" Width="250px" Visible="False" />
                        <br />
                        <asp:Label ID="lblAAPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Image ID="imgAAA" runat="server" Width="150px" Visible="False" />
                        <br />
                        <asp:Label ID="lblAAAPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                    </td>
                    <td class="auto-style26">
                        <asp:Image ID="imgA" runat="server" Width="300px" />
                        <br />
                        <asp:Label ID="lblAPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style50">
                        <asp:Image ID="imgB" runat="server" Width="300px" />
                        <br />
                        <asp:Label ID="lblBPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style38">
                        <br />
                        <asp:Image ID="imgBB" runat="server" Width="250px" Visible="False" />
                        <br />
                        <asp:Label ID="lblBBPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                        <br />
                        <asp:Image ID="imgBBB" runat="server" Width="150px" Visible="False" />
                        <br />
                        <asp:Label ID="lblBBBPlay" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#660033"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style47"></td>
                    <td class="auto-style27">
                        <asp:Button ID="btnPlayerA" runat="server" Font-Size="X-Large" Height="56px" Text="Play!" Width="259px" />
                    </td>
                    <td class="auto-style51">
                        <asp:Button ID="btnPlayerB" runat="server" Font-Size="X-Large" Height="56px" Text="Play!" Width="259px" />
                    </td>
                    <td class="auto-style36"></td>
                </tr>
                <tr>
                    <td class="auto-style48"></td>
                    <td class="auto-style33" colspan="2">
                        <asp:Button ID="btnGame" runat="server" Text="New Game" Font-Bold="True" Font-Size="X-Large" height="56px" width="259px" />
                    </td>
                    <td class="auto-style37"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
