<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" >
    <title></title>
   <link rel="stylesheet" type="text/css" href="css.css"/>

   </head>
<body  id="MasterBody" runat="server" >
  

    <form id="form1" runat="server">
      
  <div style="margin:0; width:100%; margin-top:5%;">
      <!-------------------------------------------------------------------------------------------------->
    <div style=" background-color:#260662; border-radius:10px; position:absolute; width:30%; margin-right:-4px; padding:0px; margin-left: 0px; margin-top: 0px; margin-bottom: 0px;">
<!--<iframe id="forecast_embed" frameborder="0" height="245" width="100%" src="//forecast.io/embed/#lat=42.99806&lon=21.94611&name=Leskovac&color=#00aaff&font=Georgia&units=cl"></iframe>
        -->
         <div style="vertical-align:middle; text-align:center; margin:5px;" >
            <asp:Label ID="Label5" runat="server" Text="Временска прогноза" ForeColor="White" Font-Size="25"  Font-Names="Tahoma"></asp:Label>
            </div> 
    <div style="margin: 0 auto; width: 100%; min-width: 150px; position: relative;  "><script type="text/javascript" src="https://weatherfor.us/static/js/minion/minion.js"></script><script type="text/javascript">w4uminion.run({ "location": "leskovac", "txt_color": "#f6f3f3", "bg_color": "#4b74dd", "unit": "metric" });</script></div>





        
          </div>
<!-------------------------------------------------------------------------------------------------->
    <div  style=" width:40%;  position:absolute; left:30%; margin: 0px; margin-right:-4px; padding:0px;">
   <div style="vertical-align:middle; text-align:center" >
       <asp:Image ID="Image1" runat="server" ImageUrl="~/Slike/tsrm.png" />
   </div>
       

 
         <div style="vertical-align:middle; text-align:center; margin-top:5%;" >


   
<div>

     <div>
    <asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
<asp:Timer ID="timer1" runat="server" 
Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
</div>

<asp:UpdatePanel id="updPnl" runat="server" UpdateMode="Conditional">
<ContentTemplate>

    <div style="vertical-align:middle; text-align:center; margin-top:5%;" >
     <asp:Label ID="Label1" runat="server" Text="Trenutno je 20. cas!" Font-Names="Tahoma" Font-Bold="True" Font-Size="XX-Large" ForeColor="#333333"></asp:Label>
 </div>
<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="50" ForeColor="#333333"></asp:Label>
</ContentTemplate>
    
    <Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>

    </asp:UpdatePanel>
    </div>

            

 </div>
    </div>
      <!-------------------------------------------------------------------------------------------------->

    <div  style=" width:30%; position:absolute; left:70%; margin: 0px;margin-right:-4px; padding:0px;  text-align:center; ">

      
        <div style=" background-color:#260662;  border-radius:10px; width:90%;">

         <div style="vertical-align:middle; text-align:center; margin:5px;" >
            <asp:Label ID="Label4" runat="server" Text="Пријатељи" ForeColor="White" Font-Size="25"  Font-Names="Tahoma"></asp:Label>
            </div> 

<div>
<asp:Timer ID="timer2" runat="server" 
Interval="5000" OnTick="Timer2_Tick"></asp:Timer>
</div>

       <asp:UpdatePanel id="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
                
                    
                      <div id="pic"  style="vertical-align:middle; text-align:center; background-color: #4b74dd; padding-bottom:5%;padding-top:5%; border-radius:10px; width:100%;" >
                     <asp:Image ID="Image2" runat="server" ImageUrl="~/Slike/ita.jpg" Width="90%" />
                         </div>

                
    </ContentTemplate>
    
    <Triggers>
<asp:AsyncPostBackTrigger ControlID="timer2" EventName ="tick" />
</Triggers>

    </asp:UpdatePanel>
       </div>    
    </div>
      <!-------------------------------------------------------------------------------------------------->
      <div style="width:100%;  position:absolute;bottom:0px; background-color:#4b74dd; margin-left:-10px; border-top:7px solid; border-color:#260662;" >
        <marquee direction="left" speed="normal" behavior="loop" >
  <asp:Label ID="Label3" runat="server" Text="~ Техничка школа Раде Металац! ~" ForeColor="#333333" Font-Size="20" Font-Names="Tahoma"></asp:Label></marquee>
      </div>
      <!-------------------------------------------------------------------------------------------------->
</div>

    </form>

</body>
</html>
