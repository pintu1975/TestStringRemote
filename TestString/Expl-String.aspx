<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expl-String.aspx.cs" Inherits="TestString.Expl_StringBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>string operation</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>String</h3>
    <table width="100%">
        <tr>
            <td colspan="2">Result : &nbsp;<asp:TextBox ID="txtShow" runat="server" Height="135px"  Width="800px" BorderColor="Black" BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" /></td>
        </tr>
        <tr>
            <td>
               First String : <asp:TextBox ID="txt01" runat="server"></asp:TextBox></td>
            <td>
                Second String :<asp:TextBox ID="txt02" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnAppend" runat="server" Text="Concat" OnClick="btnAppend_Click" /></td>
        </tr>
        <tr>
            <td>Single Charecter:<asp:TextBox ID="txtSingleSplit" runat="server"></asp:TextBox></td>
            <td>Multiple Character :<asp:TextBox ID="txtMultiSplit" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnSplit" runat="server" Text="Split" OnClick="btnSplit_Click" />
                <asp:Button ID="btnSplitWord" runat="server" Text="Split Word" OnClick="btnSplitWord_Click" />
            </td>
        </tr>
        <tr>            
            <td>Find Text :<asp:TextBox ID="txtFind" runat="server"></asp:TextBox></td>
            <td>Substring Start Position :<asp:TextBox ID="txtStartPos" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" /> &nbsp;<asp:Button ID="btnSubstring" runat="server" Text="Substring" OnClick="btnSubstring_Click" /></td>
        </tr>

        <tr>
            <td>Find with :<asp:TextBox ID="txtFindWith" runat="server"></asp:TextBox></td>
            <td>Replace with :<asp:TextBox ID="txtReplaceWith" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnReplace" runat="server" Text="Replace" OnClick="btnReplace_Click" />
                &nbsp;<asp:Button ID="btnLength" runat="server" Text="Length" OnClick="btnLength_Click" /></td>
        </tr>

        <tr>
            <td>Compare Type :<asp:DropDownList ID="ddlCaseType" runat="server">
                                <asp:ListItem>Use Case</asp:ListItem>
                                <asp:ListItem>Ignore Case</asp:ListItem>
                                                            </asp:DropDownList> </td>
            <td>Compare Text :<asp:TextBox ID="txtCompareText" runat="server"></asp:TextBox> Compare With :<asp:TextBox ID="txtCompareWith" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnCompare" runat="server" Text="Compare" OnClick="btnCompare_Click" /></td>
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
