<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expl-StringBuilder.aspx.cs" Inherits="TestString.Expl_StringBuilder1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>String Builder</h3>
            <table width="100%">
                <tr>
                    <td colspan="2">Result : &nbsp;<asp:TextBox ID="txtShow" runat="server" Height="135px" Width="800px" BorderColor="Black" BorderStyle="Solid" TextMode="MultiLine"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />&nbsp;
                <asp:Button ID="btnResult" runat="server" Text="Result" OnClick="btnResult_Click" /></td>
                </tr>
                <tr>
                    <td>First String :
                        <asp:TextBox ID="txt01" runat="server"></asp:TextBox></td>
                    <td>Second String :<asp:TextBox ID="txt02" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnAppend" runat="server" Text="Append" OnClick="btnAppend_Click" /></td>
                </tr>
                <tr>
                    <td>Third String :
                        <asp:TextBox ID="txt03" runat="server"></asp:TextBox></td>
                    <td>Forth String :<asp:TextBox ID="txt04" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnAppendLine" runat="server" Text="AppendLine" OnClick="btnAppendLine_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Find Text :<asp:TextBox ID="txtFind" runat="server"></asp:TextBox></td>
                    <td>Substring Start Position :<asp:TextBox ID="txtStartPos" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
                        &nbsp;<asp:Button ID="btnSubstring" runat="server" Text="Substring" OnClick="btnSubstring_Click" /></td>
                </tr>

                <tr>
                    <td>Find with :<asp:TextBox ID="txtFindWith" runat="server"></asp:TextBox></td>
                    <td>Replace with :<asp:TextBox ID="txtReplaceWith" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnReplace" runat="server" Text="Replace" OnClick="btnReplace_Click" />
                        &nbsp;<asp:Button ID="btnLength" runat="server" Text="Length" OnClick="btnLength_Click" /></td>
                </tr>

                <tr>
                    <td>Remove Start Position :<asp:TextBox ID="txtStartRemove" runat="server"></asp:TextBox>
                    </td>
                    <td>Remove End Position :<asp:TextBox ID="txtEndRemove" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnRemove" runat="server" Text="Remove" OnClick="btnRemove_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Insert Start Position :<asp:TextBox ID="txtInsertStart" runat="server"></asp:TextBox>
                    </td>
                    <td>Insert Text :<asp:TextBox ID="txtToInsert" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"  />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
