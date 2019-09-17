<%@ Page Language="C#" AutoEventWireup="true" CodeFile="popuptakvim.aspx.cs" Inherits="popuptakvim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <script type="text/javascript">
 
        function passDateValue(CtlID, DateValue) {
            window.opener.document.getElementById(CtlID).value = DateValue;
            window.close();
        }  
   
     </script> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1"  runat="server"   OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged">  
                 <SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" />  
                 <SelectorStyle ForeColor="#336666" />  
            </asp:Calendar> 
            
        </div>
    </form>
</body>
</html>
