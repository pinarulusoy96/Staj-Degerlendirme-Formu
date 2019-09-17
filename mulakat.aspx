<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mulakat.aspx.cs" Inherits="mulakat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .txtbox{border-radius:9px;width:200px;height:26px;}
   .align-content-xl-end_1{ border-style:outset; border-color:#aca8a8; border-radius:40px; width:109px; height:30px; background-color:white;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="400">
            <tr>
                <td>
                    ÖĞRENCİ NUMARASI:
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" cssclass="txtbox" runat="server"></asp:TextBox>
                </td>
            </tr><!-- www.aspnetornekleri.com -->
            <tr>
                <td>
                    TARİH:
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" cssclass="txtbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" CssClass="align-content-xl-end_1" Text="Ekle" OnClick="Button1_Click" />
                    
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="numara" HeaderText="ÖĞRENCİ NUMARASI" ItemStyle-Width="150" />
                <asp:BoundField DataField="tarih" HeaderText="TARİH" ItemStyle-Width="150" />
            </Columns>
        </asp:GridView>
        </div>
    </form>
</body>
</html>
