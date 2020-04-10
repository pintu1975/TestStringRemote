<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expl-StringReader.aspx.cs" Inherits="TestString.Expl_StringReader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h3>String Reader</h3>
            <table width="100%">
                <tr>
                    <td colspan="2">Result : &nbsp;<asp:TextBox ID="txtShow" runat="server" Height="135px" Width="800px" BorderColor="Black" BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />&nbsp;
                <asp:Button ID="btnResult" runat="server" Text="Result" OnClick="btnResult_Click" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
