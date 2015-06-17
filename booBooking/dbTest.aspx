<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dbTest.aspx.cs" Inherits="dbTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        <div>購買成功即將回到登入畫面:</div>
        <div id="div1">
            
            <%--<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />--%>
        </div>
    </form>
</body>
</html>
<script type="text/javascript">

    var t = 5;

    function showTime() {
        t -= 1;
        document.getElementById('div1').innerHTML = t;

        if (t == 0) {
            location.href = 'http://www.google.com';
        }

        setTimeout("showTime()", 1000);
    }

    showTime();
    </script>
