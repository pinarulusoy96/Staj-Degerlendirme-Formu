<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stajibitenlerPDF.aspx.cs" Inherits="stajibitenler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Grid" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ogrnumara" HeaderText="ÖGRENCI NUMARASI" ItemStyle-Width="150" />
                <asp:BoundField DataField="ogradi" HeaderText="AD" ItemStyle-Width="150" />
                <asp:BoundField DataField="ogrsoyadi" HeaderText="SOYAD" ItemStyle-Width="150" />
            </Columns>
        </asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:veritabaniConnectionString4 %>" SelectCommand="SELECT DISTINCT S.[ogrnumara],O.[ogradi],O.[ogrsoyadi] FROM [stajekle] S ,[ogrencibilgileri] O WHERE S.[ogrnumara]=O.[ogrnumara] AND S.[durum]=1"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
