<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Aww_Sum_10.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table>
                    <tr>
                        <td></td>
                        <td><h1>Welcome</h1></td>
                    </tr>
                </table>
                <br><br><br>
                
                <table>
                    <tr>
                        <td></td>
                        <td><asp:TextBox ID="txt_player_name" runat="server" BorderStyle="Solid" placeholder="Please enter your name"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfd" runat="server" ControlToValidate="txt_player_name" ErrorMessage="Please enter your name" Display="None" ValidationGroup="pop"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
                <br><br><br>

                <table>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="btnplay" runat="server" Text="Play" Width="100px" OnClick="btnplay_Click" /></td>
                        <td><asp:Label ID="lblgap1" runat="server" Width="50px" Visible="true"></asp:Label></td>
                        <td><asp:HyperLink ID="hpl_about_game" runat="server" NavigateUrl="~/About Game.aspx" Target="_blank">About Game</asp:HyperLink></td>
                    </tr> 
                </table>

                <asp:ValidationSummary ID="vs" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="pop" />

            </center>
        </div>
    </form>
</body>
</html>
