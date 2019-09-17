<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stajEkle.aspx.cs" Inherits="stajekle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />

    <title></title>
    <script type="text/javascript">
        function takvimac() {
            window.open('popuptakvim.aspx?ctlid=<%=TextBox1.ClientID %>', 'Calendar', 'scrollbars=no,resizable=no,width=240,height=220');
            return false;
        }  
</script> 
    <script type="text/javascript">
        function takvimkapat() {
            window.open('popuptakvim.aspx?ctlid=<%=TextBox2.ClientID %>', 'Calendar', 'scrollbars=no,resizable=no,width=240,height=220');
            return false;
        }  
</script> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">ÖGRENCİ NUMARASI:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="align-content-xl-end"></asp:TextBox>
                        <asp:Button ID="Button3" runat="server" Text="ARA" CssClass="align-content-xl-end" OnClick="Button3_Click" />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style5" >ÖĞRENCİ ADI:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Visible="False" CssClass="align-content-xl-end" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ÖĞRENCİ SOYADI:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Visible="False" CssClass="align-content-xl-end" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ÖĞRENCİ SINIFI:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Visible="False" CssClass="align-content-xl-end" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ÖĞRENCİ ÖĞRETİMİ:</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Visible="False" CssClass="align-content-xl-end" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                <td class="auto-style5">KURUM ADI:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtkurum" runat="server" Width="150px" CssClass="align-content-xl-end"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">KURUM TÜRÜ:</td>
                    <td class="auto-style5">
                    <asp:RadioButton ID="RadioButton1" runat="server"  GroupName="KURUM TÜRÜ" Text="ARGE" CssClass="align-content-xl-end" />
                        <br /> 
                    <asp:RadioButton ID="RadioButton2" runat="server"  GroupName="KURUM TÜRÜ" Text="DİĞER" CssClass="align-content-xl-end" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style5">ŞEHİR:</td>
                <td class="auto-style4">
                    <asp:dropdownlist ID="txtsehir" runat="server" DataSourceID="SqlDataSource1" CssClass="align-content-xl-end" DataTextField="Il" DataValueField="Il" Width="150px" OnSelectedIndexChanged="txtsehir_SelectedIndexChanged"></asp:dropdownlist>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:veritabaniConnectionString %>" SelectCommand="SELECT [Il] FROM [Iller]"></asp:SqlDataSource>
                </td>
            </tr> 
            <tr>
                <td class="auto-style5">BAŞLAMA TARİHİ:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Width="150px" CssClass="align-content-xl-end"></asp:TextBox>  
                    &nbsp;<asp:Button ID="Button1"  runat="server" CssClass="align-content-xl-end" Text="..."  
                    OnClientClick="javascript:return takvimac();" OnClick="Button1_Click" /> 
                </td>
            </tr>
             <tr>
                <td class="auto-style5">BİTİŞ TARİHİ:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" Width="150px" CssClass="align-content-xl-end"></asp:TextBox>  
                    &nbsp;<asp:Button ID="Button2"  runat="server"  Text="..."  
                    OnClientClick="javascript:return takvimkapat();" OnClick="Button2_Click" CssClass="align-content-xl-end"/> 
                </td>
            </tr>
            <tr>
                <td class="auto-style5">TOPLAM GÜN:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server" Width="150px" CssClass="align-content-xl-end"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">STAJ KONUSU:</td>
                <td class="auto-style4">
                    <asp:dropdownlist ID="stajkonusu" runat="server" DataSourceID="SqlDataSource2" CssClass="align-content-xl-end" DataTextField="stajkonusu" DataValueField="stajkonusu"  Width="150px"></asp:dropdownlist>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:veritabaniConnectionString %>" SelectCommand="SELECT DISTINCT [stajkonusu] FROM [stajekle]"></asp:SqlDataSource>
                </td>
            </tr>
            

            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btn8" runat="server" OnClick="btn8_Click" Text="STAJ EKLE" Width="150px" style="margin-left: 0px" CssClass="align-content-xl-end" />
                </td>
            </tr>
                  <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
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
