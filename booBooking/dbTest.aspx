<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dbTest.aspx.cs" Inherits="dbTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookdbConnectionString %>" SelectCommand="SELECT * FROM [book]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                        <ItemTemplate>
                            <div class="col-sm-6 col-md-3" style="width:auto">
                                <div class="thumbnail" style="text-align:center">
                                    <asp:HyperLink runat="server" ImageUrl='<%# Eval("bookPhoto") %>' Width="150px" Height="150px">
                                    </asp:HyperLink>
                                    <div class="caption" style="text-align:center;margin-top:60px">
                                     書名:<asp:Label ID="lblTitle" runat="server" Text='<%# Eval("bookName") %>'></asp:Label><br />
                                     價錢:<asp:Label ID="lblPrice" runat="server" Text='<%# Eval("bookPrice") %>'></asp:Label>元
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
    
    </div>
    </form>
</body>
</html>
