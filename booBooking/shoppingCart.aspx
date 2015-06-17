<%@ Page Language="C#" AutoEventWireup="true" CodeFile="shoppingCart.aspx.cs" Inherits="shoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>購物車清單</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />

    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        .gridviewStyle {
            width: 832px;
            vertical-align:top;

        }
    </style>
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
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/pics/shoppingMall.png" Width="20px" Height="20px" />&nbsp;&nbsp;&nbsp;返回購物商場</a></li>
                            <li><a href="#">
                                <asp:Image ID="Image4" runat="server" /><asp:Image ID="Image5" runat="server" ImageUrl="~/pics/checkIcon.png" />
                                <asp:Button ID="btnCheck" runat="server" Text="進入結帳" BorderStyle="None" BackColor="White" OnClick="btnCheck_Click" />
                                </a></li>
                        </ul>
                    </div>
                    
                </div>
            </nav>
        </header>
    <div>
    
        <table  class="pictureTable">
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookdbConnectionString %>" SelectCommand="SELECT * FROM [book] WHERE ([book_id] = @book_id)">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="book_id" QueryStringField="bid" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" style="font-family: 微軟正黑體">
                        <ItemTemplate>
                            <div class="col-sm-6 col-md-3" style="width: auto">
                                <p>
                                    <asp:Label ID="Label1" runat="server" Text="剛剛加入購物車的商品:" CssClass="justAdd"></asp:Label></p>
                                <div class="thumbnail" style="text-align: center">
                                    
                                    <asp:HyperLink runat="server" ImageUrl='<%# Eval("bookPhoto") %>' Width="150px" Height="150px">
                                    </asp:HyperLink>
                                    <div class="caption" style="text-align: left; margin-top: 60px">
                                        書名:<asp:Label ID="lblTitle" runat="server" Text='<%# Eval("bookName") %>'></asp:Label><br />
                                        價錢:<asp:Label ID="lblPrice" runat="server" Text='<%# Eval("price") %>'></asp:Label>元<br />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </td>
                <td rowspan="2" class="gridviewStyle">
                    <asp:Label ID="Label2" runat="server" Text="已購買商品:" CssClass="cartList"></asp:Label>
                    <asp:GridView ID="GridView2" runat="server" CssClass="table table-bordered table-hover" OnRowDeleting="GridView2_RowDeleting">
                        <Columns>
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CssClass="btn btn-danger"
                                        CommandName="Delete" Text="刪除" OnClientClick="return confirm('是否刪除？');"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
