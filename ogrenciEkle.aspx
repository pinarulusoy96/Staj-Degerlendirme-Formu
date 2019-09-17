<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="ogrenciEkle.aspx.cs" Inherits="ogrenciEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
        .auto-style1 {
            height: 226px;
            width: 315px;
         
        }
        .auto-style2 {
            height: 23px;
          
        }
        .auto-style3 {
            margin-left: auto;
            margin-right: auto;
            position: absolute;
            top: 29%;
            left: 49%;
            margin-left: -160px;
            margin-top: -70px;
            width: 200px;
           
        }
        .auto-style4 {
            height: 29px;
           
        }
       .txtbox{border-radius:9px;width:180px;height:26px;}

       .align-content-xl-end_1{ border-style:outset; border-color:#aca8a8; border-radius:40px; width:109px; height:30px; background-color:white;}
      .align-content-xl-end_2{ border-style:outset; border-color:#aca8a8; border-radius:40px; width:109px; height:35px; background-color:white;}

    </style>
   
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Image ID="arkaplan" ImageUrl="~/image/beyaz.png"  runat="server" />
     </div>
      
     
        <div class="auto-style3">
            <table class="auto-style1">
                 <tr>
                <td class="auto-style5">ÖĞRENCİ ADI:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAd" runat="server" cssclass="txtbox"></asp:TextBox>
                 
                </td>
            </tr>
                 <tr>
                <td class="auto-style5">ÖĞRENCİ SOYADI:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtsoyad" runat="server" cssclass="txtbox"></asp:TextBox>
                </td>
            </tr>
                 <tr>
                <td class="auto-style5">NUMARA:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtnumara" runat="server" cssclass="txtbox"></asp:TextBox>
                </td>
            </tr>
                 <tr>
                <td class="auto-style5">SINIF:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtsinif" runat="server" cssclass="txtbox"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td class="auto-style5">ÖĞRETİM:</td>
                    <td class="auto-style5">
                    <asp:RadioButton ID="RadioButton1" runat="server"  GroupName="ÖĞRETİM" Text="I.ÖĞRETİM"  />
                        <br /> 
                    <asp:RadioButton ID="RadioButton2" runat="server"  GroupName="ÖĞRETİM" Text="II.ÖĞRETİM"  />
                    </td>
            </tr>
                <tr>
                <td class="auto-style4"></td>
                <td class="auto-style4">
                    <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click"  CssClass="align-content-xl-end_1" Text="EKLE"  />
                </td>
            </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Visible="true" CssClass="align-content-xl-end" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Buttongit" runat="server" OnClick="Buttongit_Click"  CssClass="align-content-xl-end_2" Text="STAJ EKLE"  />
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
