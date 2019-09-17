<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnaSayfa.aspx.cs" Inherits="AnaSayfa" %>

<!DOCTYPE html>
<style>
    .align-content-xl-end_1{ top:15%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px;  }
   .align-content-xl-end_2{ top:26%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px;  }
   .align-content-xl-end_3{ top:37%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px; }
    .align-content-xl-end_4{ top:48%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px;  }
    .align-content-xl-end_5{ top:59%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px;   }
     .align-content-xl-end_6{ top:70%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px;  }
      .align-content-xl-end_7{ top:81%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px;  }
          .align-content-xl-end_8{ top:92%; left:39%; position:absolute; background-color:#f7f7f7; border-radius:20px;  font: 20px Segoe Script, Helvetica, Sans-seri; border-style:outset; color:#0094ff; border-color:#0094ff;height:67px; width:280px;  }

      </style>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
            <asp:Image ID="arkaplan" ImageUrl="~/image/beyaz.png"  runat="server" />
     </div>
        <div>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="ÖĞRENCİ EKLE" CssClass="align-content-xl-end_1" />
                </td>
            </tr>
            </br>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnstaj" runat="server" OnClick="btnstaj_Click" Text="STAJ EKLE" CssClass="align-content-xl-end_2" />
                </td>
            </tr>
            </br>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btndegerlendirme" runat="server"  Text="STAJ DEĞERLENDİRME" CssClass="align-content-xl-end_3" OnClick="btndegerlendirme_Click" />
                </td>
            </tr>
            </br>
             <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnkomisyon" runat="server"  Text="KOMİSYON ÜYESİ EKLE" CssClass="align-content-xl-end_4" OnClick="btnkomisyon_Click" />
                </td>
            </tr>
            </br>
             <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnmulakat" runat="server"  Text="MÜLAKAT TARİHLERİ" CssClass="align-content-xl-end_5" OnClick="btnmulakat_Click" />
                </td>
            </tr>
            </br>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnbitenler" runat="server" OnClick="btnbitenler_Click" Text="STAJI BİTEN ÖĞRENCİLER" CssClass="align-content-xl-end_6" />
                </td>
            </tr>
            </br>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btntariharaligi" runat="server" OnClick="btntariharaligi_Click" Text="TARİH ARALIĞINA GÖRE STAJ LİSTELEME" CssClass="align-content-xl-end_7" />
                </td>
            </tr>
            </br>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnogrencibilgileri" runat="server" OnClick="btnogrencibilgileri_Click" Text="ÖĞRENCİ BİLGİLERİ" CssClass="align-content-xl-end_8" />
                </td>
            </tr>
            


        </div>
    </form>
</body>
</html>
