<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WfrmOrders.aspx.cs" Inherits="WfrmOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <link href="CSS/Style.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    
</head>
<body style="background-color:#DDD">
    <form id="form1" runat="server">
        <div style="margin-bottom:50px">
            <header>
                <nav class="navbar navbar-default navbar-fixed-top" role="navigation" runat="server">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <p class="navbar-brand" >線上飲料POS系統</p>
                    </div>
                    <div id="navbar" class="navbar-collapse collapse" runat="server">
                        <ul class="nav navbar-nav">
                            <li><a href="WfrmOrders.aspx">Home</a></li>
                             <li><a href="WfrmDrinksList.aspx">飲料清單</a></li>
                             <li><a href="WfrmOrderList.aspx">進入購物車</a></li>
                        </ul>
                        <ul class="nav navbar-nav navbar-right">
                            <li>
                                <a><asp:Button ID="btnDoc" runat="server" Text="說明文件" BorderStyle="None" BackColor="White" OnClick="btnDoc_Click"/></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </header>
        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style8">
                        <table class="auto-style1">
                            <tr>
                                <td style="vertical-align:top;text-align:left" rowspan="2" class="auto-style18">
                                    <asp:Label ID="Label1" runat="server" Style="font-size: xx-large; font-family: 'Microsoft YaHei';" Text="飲料種類"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Menu ID="Menu1" runat="server" BackColor="#009900" DynamicHorizontalOffset="2" Font-Names="Microsoft YaHei" Font-Size="0.8em" ForeColor="Black" StaticSubMenuIndent="10px" OnMenuItemClick="Menu1_MenuItemClick" Style="font-size: xx-large">
                                        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                        <DynamicMenuStyle BackColor="#F7F6F3" />
                                        <DynamicSelectedStyle BackColor="#5D7B9D" />
                                        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                        <StaticSelectedStyle BackColor="#5D7B9D" />
                                    </asp:Menu>
                                    <br />
                                    <br />
                                    <asp:Menu ID="Menu2" runat="server" BackColor="#009900" DynamicHorizontalOffset="2" Font-Names="Microsoft YaHei" Font-Size="0.8em" ForeColor="Black" StaticSubMenuIndent="10px" OnMenuItemClick="Menu1_MenuItemClick" Style="font-size: xx-large">
                                        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                        <DynamicMenuStyle BackColor="#F7F6F3" />
                                        <DynamicSelectedStyle BackColor="#5D7B9D" />
                                        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                        <StaticSelectedStyle BackColor="#5D7B9D" />
                                    </asp:Menu>
                                    <br />
                                    <br />
                                    <asp:Menu ID="Menu3" runat="server" BackColor="#009900" DynamicHorizontalOffset="2" Font-Names="Microsoft YaHei" Font-Size="0.8em" ForeColor="Black" StaticSubMenuIndent="10px" OnMenuItemClick="Menu1_MenuItemClick" Style="font-size: xx-large">
                                        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                        <DynamicMenuStyle BackColor="#F7F6F3" />
                                        <DynamicSelectedStyle BackColor="#5D7B9D" />
                                        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                        <StaticSelectedStyle BackColor="#5D7B9D" />
                                    </asp:Menu>
                                    <br />
                                </td>
                                <td style="vertical-align:top;text-align: left">
                                    <br />
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateDeleteButton="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Height="167px" OnRowDeleting="GridView1_RowDeleting" Style="font-size: small" Width="919px">
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
                                    <br />
                                    <table style="vertical-align:central" class="auto-style1">
                                        <tr>
                                            <td style="text-align: left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblPname" runat="server" Style="font-size: x-large; font-weight: 700;" BackColor="#0099FF" BorderStyle="Solid"></asp:Label>
                                            </td>
                                            <td style="vertical-align:central">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style17">數量:</span><asp:TextBox ID="tboxCup" runat="server" Font-Size="Medium" Height="23px" Width="38px"></asp:TextBox>
                                                &nbsp;</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Style="font-size: large" Width="111px">
                                                    <asp:ListItem>多冰</asp:ListItem>
                                                    <asp:ListItem>少冰</asp:ListItem>
                                                    <asp:ListItem>微冰</asp:ListItem>
                                                    <asp:ListItem>去冰</asp:ListItem>
                                                    <asp:ListItem Selected="True"> </asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList2" runat="server" Height="43px" Style="font-size: large" Width="113px">
                                                    <asp:ListItem>少糖</asp:ListItem>
                                                    <asp:ListItem>微糖</asp:ListItem>
                                                    <asp:ListItem>無糖</asp:ListItem>
                                                    <asp:ListItem Selected="True"> </asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style20">
                                                <asp:Button ID="btn7" runat="server" Height="40px" Text="7" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td class="auto-style20">
                                                <asp:Button ID="btn8" runat="server" Height="40px" Text="8" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td class="auto-style20">
                                                <asp:Button ID="btn9" runat="server" Height="40px" Text="9" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td style="font-weight: 700" class="auto-style20">
                                                <asp:Button ID="btnDiscount" runat="server" Height="40px" Text="打折" Width="150px" BackColor="#999999" BorderStyle="None" OnClick="btnDiscount_Click" Font-Size="Medium" />
                                            </td>
                                            <td class="auto-style20"></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btn4" runat="server" Height="40px" Text="4" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btn5" runat="server" Height="40px" Text="5" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btn6" runat="server" Height="40px" Text="6" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btnMiddle" runat="server" Height="40px" Text="中杯" Width="150px" BackColor="#999999" BorderStyle="None" OnClick="btnMiddle_Click" Font-Size="Medium" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btn1" runat="server" Height="40px" Text="1" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btn2" runat="server" Height="40px" Text="2" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btn3" runat="server" Height="40px" Text="3" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btnBig" runat="server" Height="40px" Text="大杯" Width="150px" BackColor="#999999" BorderStyle="None" OnClick="btnBig_Click" Font-Size="Medium" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btn0" runat="server" Height="40px" Text="0" Width="150px" BorderStyle="None" OnClick="btn0_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btnCancel" runat="server" Height="40px" Text="C" Width="150px" BorderStyle="None" OnClick="btnCancel_Click" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btnClear" runat="server" Height="40px" Text="清除畫面" Width="150px" BackColor="#999999" BorderStyle="None" OnClick="btnClear_Click" Font-Size="Medium" />
                                            </td>
                                            <td>
                                                <asp:Button ID="btnCommit" runat="server" Height="40px" Text="確定輸入" Width="150px" BackColor="#999999" BorderStyle="None" OnClick="btnCommit_Click" Font-Size="Medium" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>

                        </table>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
