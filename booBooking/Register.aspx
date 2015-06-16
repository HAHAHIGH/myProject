<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .registerTitle {
            font-size: xx-large;
            font-family: 微軟正黑體;
            margin:-650px 300px 20px 300px;
            padding:15px 30px;
            text-align:center;
            background-color:white;
            opacity:0.8;
            z-index:200;
        }
        .registerForm {
            font-size: 22pt;
            font-family: 微軟正黑體;
        
        }
        .inputText {
            font-weight: normal; 
            font-size: medium; 
            color: #000000;
            height:45px;
            margin:3px 0;
        }
        .btnInsert {
            background-color:#0099FF;
            color :Black;
            Height :45px;
            Width :300px;
            border: None;
            font-size: large;
        }
    </style>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="css/carouselFull.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <script src="../../assets/js/ie-emulation-modes-warning.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="registerTitle" runat="server">
            <div style="text-align:left">註冊</div>
            <div class="registerForm">
            <input id="lastName" name="lastName" type="text" placeholder="姓" class="inputText"style="width:240px"/>
            <input id="firstName" name="firstName" type="text" placeholder="名" class="inputText"style="width:350px"/><br />
            <input id="userName" name="userName" type="text" placeholder="帳號" class="inputText"style="width:600px"/><br />
            <input id="password" name="password" type="password" placeholder="密碼" class="inputText"style="width:600px"/><br />
            <input id="passwordComit" name="passwordComit" type="password" placeholder="確認密碼" class="inputText"style="width:600px"/><br />
            <asp:Button ID="btnInsert" runat="server" Text="新增使用者" CssClass="btnInsert" OnClick="btnInsert_Click"/>
        </div>
        </div>
    </form>
</body>
</html>
