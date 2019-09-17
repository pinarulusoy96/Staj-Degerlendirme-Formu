<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type = "text/css">
    .container {
        margin-left:auto;
        margin-right:auto;
        position: absolute;
        top: 50%;
        left: 50%;
        margin-left: -160px;
        margin-top: -70px;

      
    }
    .txtbox{border-radius:9px;width:200px;height:26px;}
   .align-content-xl-end_1{ border-style:outset; border-color:#aca8a8; border-radius:40px; width:109px; height:30px; background-color:white;}
    </style>
</head>
    
<body>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/image/1.jpg"/>
    <form id="form1" runat="server">
        <div class="container">
        <div>
            <table class="auto-style1">

            <tr>
                <td class="auto-style5">Kullanıcı Adı</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAd" runat="server" cssclass="txtbox"  Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Şifre</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtSifre" TextMode="Password" runat="server" cssclass="txtbox" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                   
                    <asp:Button ID="btnGiris" runat="server" OnClick="btnGiris_Click"  CssClass="align-content-xl-end_1" Text="GİRİŞ"  />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    &nbsp;</td>
            </tr>
        </table>
        </div>
    </div>
    </form>
</body>
</html>

        
        
