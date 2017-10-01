using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;
using System.Xml;

public partial class index : System.Web.UI.Page
{
    
    DateTime[] Zvono = new DateTime[28];
    static int CasID;
    static int SmenaID;
    static bool Cas;
    static int VremeID;
    static bool Rezim30= false;
    static int Reklama=1;
   

    

    protected void Page_Load(object sender, EventArgs e)
    {
       // MasterBody.Attributes.Remove("style");
      


        Label2.Text = "TSRM";
        if (!Rezim30)
        {
            SetRezim45();
        }
        else
        {
            SetRezim30();
        }
        

        GetData();

    }

    protected void Timer2_Tick(object sender, EventArgs e)
    {

        Image2.ImageUrl = "~/Reklame/"+Reklama.ToString()+".jpg";
        Reklama++;
        if (Reklama >= 3)
            Reklama = 0;

    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
       // Page.ClientScript.RegisterClientScriptBlock(GetType(), "JScript1", "ShowDiv('data');", true);
      //  MasterBody.Attributes.Add("style", "background-color: yellow; margin: 0;");
       // sec++;
       
        DateTime nowtime = DateTime.Now;
         if (nowtime.Hour > 6 &&  VremeID < 27)//19:15
        {
            if (nowtime.TimeOfDay < Zvono[VremeID].TimeOfDay)
            {
                string ssec;
                int sec = -((nowtime.TimeOfDay - Zvono[VremeID].TimeOfDay).Seconds);

                if (sec < 10)
                    ssec = "0" + sec.ToString();
                else
                    ssec = sec.ToString();

                Label2.Text = "-"+(-((nowtime.TimeOfDay - Zvono[VremeID].TimeOfDay).Minutes)).ToString() + ":"+ssec;
              
            }
               
            else
            {
                GetData();

            }
                
        }
        else
        {
            Label2.Text = "ТШРМ";//iskljuceno zbog testiranja
        }

      

        
   
    }

    private void  GetData()
    {

        DateTime t = DateTime.Now;


        int id = 0;
        while (t.TimeOfDay > Zvono[id].TimeOfDay)
            id++;

        VremeID = id;
        if (VremeID <= 13)
            SmenaID = 1;
        else
            SmenaID = 2;

        if (SmenaID == 1)
        {
            if (id % 2 == 0)
                Cas = false;
            else
            {
                Cas = true;
                CasID = (id + 1) / 2;
                
            }

        }
        else
        {
            if (id % 2 == 0)
            {
                Cas = true;
                CasID = (id - 12) / 2;
            }
            else
                Cas = false;
               
        }

        if (t.Hour > 6 && VremeID < 27)
            if (Cas)
                Label1.Text =CasID.ToString() + ". Час|" + SmenaID.ToString() + ". Смена";
            else
            {
                Label1.Text = "Тренутно је одмор!";
               // Label2.Text = VremeID.ToString() + "   " + SmenaID.ToString();
            }
        else
        {
            Label1.Text = "Часови нису у току!";
        }
          

            
    }

    public void SetRezim45()
    {
        Rezim30 = false;
        Zvono[0] = new DateTime(2017, 9, 28, 7, 15, 0);//1
        Zvono[1] = new DateTime(2017, 9, 28, 8, 0, 0);
        Zvono[2] = new DateTime(2017, 9, 28, 8, 5, 0);//2
        Zvono[3] = new DateTime(2017, 9, 28, 8, 50, 0);
        Zvono[4] = new DateTime(2017, 9, 28, 9, 10, 0);//3
        Zvono[5] = new DateTime(2017, 9, 28, 9, 55, 0);
        Zvono[6] = new DateTime(2017, 9, 28, 10, 0, 0);//4
        Zvono[7] = new DateTime(2017, 9, 28, 10, 45, 0);
        Zvono[8] = new DateTime(2017, 9, 28, 10, 50, 0);//5
        Zvono[9] = new DateTime(2017, 9, 28, 11, 35, 0);
        Zvono[10] = new DateTime(2017, 9, 28, 11, 40, 0);//6
        Zvono[11] = new DateTime(2017, 9, 28, 12, 25, 0);
        Zvono[12] = new DateTime(2017, 9, 28, 12, 30, 0);//7
        Zvono[13] = new DateTime(2017, 9, 28, 13, 15, 0);//1
        Zvono[14] = new DateTime(2017, 9, 28, 14, 0, 0);
        Zvono[15] = new DateTime(2017, 9, 28, 14, 5, 0);//2
        Zvono[16] = new DateTime(2017, 9, 28, 14, 50, 0);
        Zvono[17] = new DateTime(2017, 9, 28, 15, 10, 0);//3
        Zvono[18] = new DateTime(2017, 9, 28, 15, 55, 0);
        Zvono[19] = new DateTime(2017, 9, 28, 16, 0, 0);//4
        Zvono[20] = new DateTime(2017, 9, 28, 16, 45, 0);
        Zvono[21] = new DateTime(2017, 9, 28, 16, 50, 0);//5
        Zvono[22] = new DateTime(2017, 9, 28, 17, 35, 0);
        Zvono[23] = new DateTime(2017, 9, 28, 17, 40, 0);//6
        Zvono[24] = new DateTime(2017, 9, 28, 18, 15, 0);
        Zvono[25] = new DateTime(2017, 9, 28, 18, 20, 0);//7
        Zvono[26] = new DateTime(2017, 9, 28, 19, 5, 0);
        Zvono[27] = new DateTime(2017, 9, 28, 23, 59, 59);//casovi nisu u toku
        GetData();
    }

    public void SetRezim30()
    {
        Rezim30 = true;
        Zvono[0] = new DateTime(2017, 9, 28, 7, 15, 0);//1
        Zvono[1] = new DateTime(2017, 9, 28, 8, 0, 0);
        Zvono[2] = new DateTime(2017, 9, 28, 8, 5, 0);//2
        Zvono[3] = new DateTime(2017, 9, 28, 8, 50, 0);
        Zvono[4] = new DateTime(2017, 9, 28, 9, 10, 0);//3
        Zvono[5] = new DateTime(2017, 9, 28, 9, 55, 0);
        Zvono[6] = new DateTime(2017, 9, 28, 10, 0, 0);//4
        Zvono[7] = new DateTime(2017, 9, 28, 10, 45, 0);
        Zvono[8] = new DateTime(2017, 9, 28, 10, 50, 0);//5
        Zvono[9] = new DateTime(2017, 9, 28, 11, 35, 0);
        Zvono[10] = new DateTime(2017, 9, 28, 11, 40, 0);//6
        Zvono[11] = new DateTime(2017, 9, 28, 12, 25, 0);
        Zvono[12] = new DateTime(2017, 9, 28, 12, 30, 0);//7
        Zvono[13] = new DateTime(2017, 9, 28, 13, 15, 0);//1
        Zvono[14] = new DateTime(2017, 9, 28, 14, 0, 0);
        Zvono[15] = new DateTime(2017, 9, 28, 14, 5, 0);//2
        Zvono[16] = new DateTime(2017, 9, 28, 14, 50, 0);
        Zvono[17] = new DateTime(2017, 9, 28, 15, 10, 0);//3
        Zvono[18] = new DateTime(2017, 9, 28, 15, 55, 0);
        Zvono[19] = new DateTime(2017, 9, 28, 16, 0, 0);//4
        Zvono[20] = new DateTime(2017, 9, 28, 16, 45, 0);
        Zvono[21] = new DateTime(2017, 9, 28, 16, 50, 0);//5
        Zvono[22] = new DateTime(2017, 9, 28, 17, 35, 0);
        Zvono[23] = new DateTime(2017, 9, 28, 17, 40, 0);//6
        Zvono[24] = new DateTime(2017, 9, 28, 18, 15, 0);
        Zvono[25] = new DateTime(2017, 9, 28, 18, 20, 0);//7
        Zvono[26] = new DateTime(2017, 9, 28, 19, 5, 0);
        Zvono[27] = new DateTime(2017, 9, 28, 23, 59, 59);//casovi nisu u toku
        GetData();
    }

   

   
}

