<%@ Page Language="C#" AutoEventWireup="true" CodeFile="check.aspx.cs" Inherits="check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />

    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding:80px 100px">
        <div class="lblPay">
            <asp:Label ID="Label3" runat="server" Text="結帳明細:"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblTotal0" runat="server" Text="本次結帳金額:" CssClass="lblResult"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" Text="Label" CssClass="lblResult"></asp:Label><br />
            <asp:Label ID="lblTotalCont0" runat="server" Text="本次購買數量:" CssClass="lblTotalCount"></asp:Label>
            <asp:Label ID="lblTotalCont" runat="server" Text="Label" CssClass="lblTotalCount"></asp:Label>
        </div>
        <div class="lblPay">
            <asp:Label ID="Label2" runat="server" Text="運送方式:"></asp:Label>
        </div>
            <asp:DropDownList ID="dDownListPay" runat="server">
                <asp:ListItem>宅配</asp:ListItem>
                <asp:ListItem>貨到付款</asp:ListItem>
                <asp:ListItem>面交</asp:ListItem>
            </asp:DropDownList>
        <div class="lblPay">
            <asp:Label ID="Label1" runat="server" Text="付款方式:"></asp:Label>
        </div>
        <div class="tabbable">
            <ul class="nav nav-tabs">
                <li class="active"><a href="#tab1" data-toggle="tab">匯款和面交</a></li>
                <li><a href="#tab2" data-toggle="tab">信用卡</a></li>
            </ul>
            <div class="tab-content">
                <div class="tab-pane active" id="tab1">
                    <table>
                        <tr style="height:50px">
                            <td style="text-align:right">收件人姓名:</td>
                            <td><asp:TextBox ID="tboxName1" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">電話:</td>
                            <td><asp:TextBox ID="tboxPhone1" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">Email:</td>
                            <td><asp:TextBox ID="tboxEmail1" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">地址:</td>
                            <td><asp:TextBox ID="tboxAddress1" runat="server"></asp:TextBox></td>
                        </tr>
                    </table>
                </div>
                <div class="tab-pane" id="tab2">
                    <table>
                        <tr style="height:50px;">
                            <td style="text-align:right">收件人姓名:</td>
                            <td><asp:TextBox ID="tboxName2" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">電話:</td>
                            <td><asp:TextBox ID="tboxPhone2" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">Email:</td>
                            <td><asp:TextBox ID="tboxEmail2" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">地址:</td>
                            <td><asp:TextBox ID="tboxAddress2" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">信用卡卡號:</td>
                            <td>
                                <asp:DropDownList ID="dDownListCardType" runat="server">
                                    <asp:ListItem>Visa</asp:ListItem>
                                    <asp:ListItem>JCB</asp:ListItem>
                                    <asp:ListItem>MasterCard</asp:ListItem>
                                </asp:DropDownList>
                                <asp:TextBox ID="tboxCardID" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">信用卡有效截止日期:</td>
                            <td>
                                <asp:TextBox ID="tboxCardMonth" runat="server" Width="50px"></asp:TextBox>月/
                                <asp:TextBox ID="tboxCardYear" runat="server" Width="50px"></asp:TextBox>年
                            </td>
                        </tr>
                        <tr style="height:50px">
                            <td style="text-align:right">信用卡安全碼:</td>
                            <td><asp:TextBox ID="tboxSecurityID" runat="server" Width="80px"></asp:TextBox>(卡片背面末三碼)</td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <div style="text-align:center">
            <asp:Button ID="btnCheck" runat="server" Text="確認送出" CssClass="btn btn-success" Width="200px" OnClick="btnCheck_Click"/>
        </div>
    </div>
    </form>
</body>
</html>
