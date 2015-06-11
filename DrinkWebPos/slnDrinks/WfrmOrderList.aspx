<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WfrmOrderList.aspx.cs" Inherits="WfrmOrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: xx-large;
            color: #FF0000;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            font-size: medium;
        }
    </style>
</head>
<body style="background-color:#EEE">
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2"><strong>結帳</strong></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <span class="auto-style3">總金額 : </span>
                <asp:Label ID="lblTotal" runat="server" CssClass="auto-style3" Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <span class="auto-style3">總數量 : </span>
                <asp:Label ID="lblTotalCount" runat="server" CssClass="auto-style3" Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><span class="auto-style4">已付 :
                </span>
                <asp:TextBox ID="tboxPay" runat="server" Width="100px" CssClass="auto-style4"></asp:TextBox>
&nbsp;<asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="找錢" CssClass="auto-style4" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4"><span class="auto-style4">找零 : </span> <asp:TextBox ID="tboxReturn" runat="server" Width="100px" CssClass="auto-style4"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEnd" runat="server" BorderStyle="None" Height="23px" PostBackUrl="~/WfrmOrders.aspx" Text="結束結帳" Width="78px" OnClick="btnEnd_Click" style="font-size: medium" Enabled="False" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
