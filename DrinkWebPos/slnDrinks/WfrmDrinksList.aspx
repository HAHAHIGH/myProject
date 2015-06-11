<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WfrmDrinksList.aspx.cs" Inherits="WfrmDrinksList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>飲料清單</title>
    
    <link href="Content/bootstrap.css" rel="stylesheet" />

    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <style type="text/css">
        
    </style>
</head>
<body style="background-color:#EEE">
    <form id="form1" runat="server">
        <div style="margin-bottom:50px;padding-bottom:60px;">
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
        <table>
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DrinkdbConnectionString %>" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server">
                                        <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                            <tr runat="server" style="">
                                            </tr>
                                            <tr id="itemPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server">
                                        <asp:DataPager ID="DataPager1" runat="server" PageSize="5">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" ButtonCssClass="btn-primary"/>
                                            </Fields>
                                        </asp:DataPager>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="col-sm-6 col-md-3" style="width:auto">
                                <div class="thumbnail">
                                    <asp:HyperLink runat="server" ImageUrl='<%# Eval("pPhoto") %>' Width="150px" Height="150px">
                                    </asp:HyperLink>
                                    <div class="caption" style="text-align:center">
                                     <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("pName") %>'></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </form>
</body>
</html>
