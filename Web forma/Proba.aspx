<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Proba.aspx.cs" Inherits="Proba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
    <asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
<asp:Timer ID="timer1" runat="server" 
Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
</div>

<asp:UpdatePanel id="updPnl" runat="server" UpdateMode="Conditional">
<ContentTemplate>
<asp:Label ID="Label2" runat="server"></asp:Label>
</ContentTemplate>
    
    <Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>

    </asp:UpdatePanel>
    
    </form>
</body>
</html>
