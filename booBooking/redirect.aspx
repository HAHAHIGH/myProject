<%@ Page Language="C#" AutoEventWireup="true" CodeFile="redirect.aspx.cs" Inherits="redirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size:x-large">購買成功!!<span id="span1"></span>後即將回到購物商場</div>
    </form>
</body>
</html>
<script type="text/javascript">

    var t = 5;

    function showTime() {
        t -= 1;
        document.getElementById('span1').innerHTML = t;

        if (t == 1) {
            location.href = 'index.aspx';
        }

        setTimeout("showTime()", 1000);
    }

    showTime();
</script>
