<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stajdegerlendirme.aspx.cs" Inherits="stajdegerlendirme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
   <%--<div>
            <asp:Image ID="arkaplan" ImageUrl="~/image/pp.png"  runat="server" />
     </div>--%>
          <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">ÖGRENCİ NUMARASI:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                        <asp:Button ID="Button50" runat="server" Text="ARA" OnClick="Button50_Click" CssClass="align-content-xl-end" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ÖĞRENCİ ADI:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ÖĞRENCİ SOYADI:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ÖĞRENCİ SINIFI:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ÖĞRENCİ ÖĞRETİMİ:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">KURUM ADI:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label5" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ŞEHİR:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">BAŞLAMA TARİHİ:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label7" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">BİTİŞ TARİHİ:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label8" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">TOPLAM GÜN:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label9" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">STAJ KONUSU:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label10" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">DEVAM:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtdevam" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">ÇABA VE ÇALIŞMA:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtcalısma" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">İŞİ VAKTİNDE YAPMA:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtvakit" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">AMİRE KARŞI DAVRANIŞ:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtamir" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">İŞ ARKADAŞLARINA KARŞI DAVRANIŞ:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtdavranis" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">PROJE:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtproje" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">DÜZEN:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtduzen" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">SUNUM:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtsunum" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">İÇERİK:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txticerik" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5">MÜLAKAT:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtmulakat" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btndegerlendir" runat="server" OnClick="btndegerlendir_Click" CssClass="align-content-xl-end" Text="DEĞERLENDİR" Width="150" style="margin-left: 0px" />
                </td>
            </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label12" runat="server" Text="KABUL EDİLEN GÜN:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="Label11" runat="server" Visible="False" Width="150px" CssClass="align-content-xl-end"></asp:Label>
                    </td>
                </tr>
                <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                   <asp:ImageButton ID="ImageButton1" runat="server" Width="55px" ImageUrl="~/image/home.png" OnClick="ImageButton1_Click" />
                </td>
            </tr>
            </table>
        </div>
    </form>
</body>
</html>
