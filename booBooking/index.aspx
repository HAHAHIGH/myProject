<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>購物首頁</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />

    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript">

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <nav class="navbar navbar-default navbar-fixed-top wet-asphalt" role="banner">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#">
                            <img src="pics/logo.png" alt="logo" /></a>
                    </div>
                    <div class="collapse navbar-collapse">
                        <ul class="nav navbar-nav navbar-left">
                            <li><a href="index.aspx">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/pics/shoppingMall.png" Width="20px" Height="20px" />&nbsp;&nbsp;&nbsp;購物商場</a></li>
                            <li><a href="shoppingCart.aspx">
                                <asp:Image ID="Image1" runat="server" ImageUrl="pics/shoppingCartIcon.png" Width="24px" Height="24px" />確認購物車</a></li>
                            <li><a href="#">
                                <asp:Image ID="Image4" runat="server" /><asp:Image ID="Image5" runat="server" ImageUrl="~/pics/checkIcon.png" />進入結帳</a></li>
                        </ul>
                        <ul class="nav navbar-nav navbar-right">
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <span style="padding-right: 10px">
                                        <asp:Image ID="Image3" runat="server" ImageUrl="~/pics/accountIcon.png" /></span><asp:Label ID="lblLoginName" runat="server" Text="Label" Font-Size="Large"></asp:Label><i class="icon-angle-down"></i></a>
                                <ul class="dropdown-menu" style="font-size: medium;">
                                    <li><a href="login.aspx">登出</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </header>
        <table class="pictureTable">
            <tr>

                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookdbConnectionString %>" SelectCommand="SELECT * FROM [book]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" Style="font-family: 微軟正黑體">
                        <ItemTemplate>
                            <div class="col-sm-6 col-md-3" style="width: auto">
                                <div class="thumbnail" style="text-align: center">
                                    <asp:HyperLink runat="server" ImageUrl='<%# Eval("bookPhoto") %>' Width="150px" Height="150px">
                                    </asp:HyperLink>
                                    <div class="caption" style="text-align: left; margin-top: 60px">
                                        書名:<asp:Label ID="lblTitle" runat="server" Text='<%# Eval("bookName") %>'></asp:Label><br />
                                        價錢:<asp:Label ID="lblPrice" runat="server" Text='<%# Eval("price") %>'></asp:Label>元<br />
                                        <asp:DropDownList ID="DropDownList1" runat="server">
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:Button ID="btnSubmit" runat="server" Text="加入購物車" ToolTip='<%# Eval("book_id") %>' CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
