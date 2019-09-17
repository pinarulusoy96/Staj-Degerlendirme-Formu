<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ogrencibilgileri.aspx.cs" Inherits="ogrencibilgileri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
        .txtbox{border-radius:9px;width:200px;height:26px;}
        .align-content-xl-end_1{ border-style:outset; border-color:#aca8a8; border-radius:40px; width:109px; height:30px; background-color:#dbd2d2;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" cssclass="txtbox" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" CssClass="align-content-xl-end_1" runat="server" Text="ARA" OnClick="Button1_Click1" />
            
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="ogrnumara" HeaderText="ÖĞRENCİ NUMARASI" ItemStyle-Width="150" />
                <asp:BoundField DataField="ogradi" HeaderText="AD" ItemStyle-Width="150" />
                <asp:BoundField DataField="ogrsoyadi" HeaderText="SOYAD" ItemStyle-Width="150" />
                <asp:BoundField DataField="kurumadi" HeaderText="KURUM ADI" ItemStyle-Width="150" />
                <asp:BoundField DataField="sehir" HeaderText="SEHİR" ItemStyle-Width="150" />
                <asp:BoundField DataField="toplamgün" HeaderText="TOPLAM GÜN" ItemStyle-Width="150" />
                <asp:BoundField DataField="baslamatarihi" HeaderText="BAŞLAMA TARİHİ" ItemStyle-Width="150" />
                <asp:BoundField DataField="bitistarihi" HeaderText="BİTİŞ TARİHİ" ItemStyle-Width="150" />
                <asp:BoundField DataField="stajkonusu" HeaderText="STAJ KONUSU" ItemStyle-Width="150" />
                <asp:BoundField DataField="kabuledilengun" HeaderText="KABUL EDİLEN GÜN" ItemStyle-Width="150" />
            </Columns>
        </asp:GridView>
            

        </div>
    </form>
</body>
</html>
