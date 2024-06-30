using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace requiredSerivices1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequiredServiceReference.ReqIServiceClient service1Client = new RequiredServiceReference.ReqIServiceClient();// callwebdownload service

            
            webstring.Text = service1Client.WebDownload(url.Text);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RequiredServiceReference.ReqIServiceClient filterclient = new RequiredServiceReference.ReqIServiceClient(); //call string filter service
            filtered.Text = filterclient.WordsFilter(unfiltered.Text);



        }

        protected void forecast_Click(object sender, EventArgs e)
        {
            ElectiveServiceReference.combelectIServiceClient forecast = new ElectiveServiceReference.combelectIServiceClient();
            string[] output = forecast.Weather5day(Zip.Text);

            if(output == null)
            {
                foreout.Text = "Invalid ZipCode or location result not found";
                return;

            }

            string fore="";

            for(int i = 0; i < output.Length; i++) 
            {
                string[] values = output[i].Split(',');

                fore += "date: " + values[0] + " Description: " + values[1] + " High Temp (Cel): " + values[2] + "Low Temp (Cel): " + values[3];
                fore += "\n";
                
            
            }
            foreout.Text = fore;


         }

        protected void efficiency_Click(object sender, EventArgs e)
        {

            ElectiveServiceReference.combelectIServiceClient effi = new ElectiveServiceReference.combelectIServiceClient();
            if (!Int32.TryParse(area.Text, out int aream2))
            {
                saving.Text =  "Enter Valid integer for Area";
                return;
            }

            if (!Int32.TryParse(paneleff.Text, out int paneleffint))
            {
                saving.Text = "Enter Valid integer for panel";
                return;
            }

            saving.Text = effi.GetSolarsaving(zip2.Text,aream2,paneleffint);

        }
    }
}
