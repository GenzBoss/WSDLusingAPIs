using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Web;

namespace WebDownloading
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string WebDownload(string url)
        {
            
              // hey https://www.google.com/

            System.Net.WebClient wc = new System.Net.WebClient();
            try
            {
                byte[] raw = wc.DownloadData(url);
                string randString = wc.DownloadString(url); //return string
                string webData = System.Text.Encoding.UTF8.GetString(raw);

                return randString;


            }

            catch(Exception e)
            {
                return "website is not corrrectly specified, or faulty " + e.Message;
            
            }




            

            

          

        


        }


    }

}
