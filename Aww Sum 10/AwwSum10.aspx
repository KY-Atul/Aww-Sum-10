<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AwwSum10.aspx.cs" Inherits="Aww_Sum_10.AwwSum10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
    <center>
        <table>
            <tr><td></td>
                <td></td>
                <td></td>
                <td></td>
                <td style="text-align:center"><h2>Aww Sum 10</h2></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            </table>
        <br><br><br>
            <table>
            <tr>
                
                <asp:ScriptManager ID="SM" runat="server"></asp:ScriptManager>
                <asp:Timer ID="time" runat="server" Interval="4000" OnTick="time_Tick"></asp:Timer>
                <td><asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium" /></td>
                <td><asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
                <td><asp:Button ID="btn3" runat="server" OnClick="btn3_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
                <td><asp:Button ID="btn4" runat="server" OnClick="btn4_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
                <td><asp:Button ID="btn5" runat="server" OnClick="btn5_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
                <td><asp:Button ID="btn6" runat="server" OnClick="btn6_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
                <td><asp:Button ID="btn7" runat="server" OnClick="btn7_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
                <td><asp:Button ID="btn8" runat="server" OnClick="btn8_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
                <td><asp:Button ID="btn9" runat="server" OnClick="btn9_Click" Width="100px" Height="50px" BorderStyle="Solid" BorderColor="Black" Font-Bold="True" Font-Size="Medium"/></td>
              
             </tr>
                <tr>

                    <td style="text-align:center;color:orangered"><asp:Label ID="l1" runat="server" Font-Bold="true"></asp:Label></td>
                    
                    <td style="text-align:center;color:fuchsia"><asp:Label ID="l2" runat="server" Font-Bold="True"></asp:Label></td>
                    
                    <td style="text-align:center;color:gray"><asp:Label ID="l3" runat="server" Font-Bold="True"></asp:Label></td>
                    
                    <td style="text-align:center;color:orangered"><asp:Label ID="l4" runat="server" Font-Bold="True"></asp:Label></td>
                    
                    <td style="text-align:center;color:fuchsia"><asp:Label ID="l5" runat="server" Font-Bold="True"></asp:Label></td>
                    
                    <td style="text-align:center;color:gray"><asp:Label ID="l6" runat="server" Font-Bold="True"></asp:Label></td>
                    
                    <td style="text-align:center;color:orangered"><asp:Label ID="l7" runat="server" Font-Bold="True"></asp:Label></td>
                    
                    <td style="text-align:center;color:fuchsia"><asp:Label ID="l8" runat="server" Font-Bold="True"></asp:Label></td>
                    
                    <td style="text-align:center;color:gray"><asp:Label ID="l9" runat="server" Font-Bold="True"></asp:Label></td>

                </tr>
        </table>
      </center>
        <br>
        <br><br>
        <center>
            <table>
                <tr>
                    <td style="text-align:center"><asp:TextBox ID="digit1" runat="server" Text="First Number" BorderStyle="Solid" ForeColor="Black" Font-Bold="False" Width="100px" Height="50px" BorderColor="White" Font-Size="Medium" Visible="False"></asp:TextBox></td>
                    <td style="text-align:center; font-size:large"></td>
                    <td style="text-align:center"><asp:TextBox ID="digit2" runat="server" Text="Second Number" BorderStyle="Solid" Font-Bold="False" Width="115px" Height="50px" BorderColor="White" Font-Size="Medium" Visible="False"></asp:TextBox></td>
                    <td style="text-align:center; font-size:large"></td>
                    <td style="text-align:center"><asp:Label ID="lblresult" runat="server" Font-Bold="true" Font-Size="Larger"></asp:Label></td>
                    <td><asp:Label ID="lblwidth" runat="server" Width="50px"></asp:Label></td>
                    <td>You Entered:</td>
                    <td><asp:Label ID="lbl_last_first_digit" runat="server"></asp:Label></td>
                    <td><asp:Label ID="lbl_last_second_digit" runat="server"></asp:Label></td>
                
                
                </tr>
            </table>
        </center>
        <br><br>
        <center>
            <table>
                <tr>
                    <td style="text-align:center; color:green"><h4>Right Answer:</h4></td>
                    <td><asp:Label ID="lbl_right_answer" runat="server"></asp:Label></td>
                    <td><asp:Label ID="lblgap" runat="server" Width="50px"></asp:Label></td>
                    <td style="text-align:center; color:red"><h4>Wrong Answer:</h4></td>
                    <td><asp:Label ID="lbl_wrong_answer" runat="server"></asp:Label></td>
                </tr>
            </table>
        </center>

    </form>

</body>
</html>
