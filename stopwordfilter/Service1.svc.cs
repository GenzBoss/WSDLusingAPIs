using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace stopwordfilter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string WordsFilter(string str)
        {
            using (var client = new HttpClient()) {
                var endpoint = new Uri("https://stopwordapi.com/api/v1/stopwords?langs=en&categories=4");   //call this api to get list of stop word
                var result =  client.GetAsync(endpoint).Result;
                string json = result.Content.ReadAsStringAsync().Result;   //convert words to json string
                //Debug.WriteLine(json);

               
               json = json.Replace("\n\r", "");
               json = json.Replace("\n\r", "");
               json = json.Replace("\"", "");
               json = json.Replace("\n", String.Empty);
               json = json.Replace("\r", String.Empty);
               json = json.Replace("\t", String.Empty);   //remove unwanted charactes


                json = json.Trim('[',']');


                string[] words = json.Split(',');   //create array of stop words

                str = " " + str + " ";

                foreach (var word in words)
                {

                    String stopword = " " + word.Trim() + " ";   //create correctly formated stop word

                    str = str.Replace(stopword, " ");
                  //  Debug.WriteLine(str);
                  //  Debug.WriteLine(stopword);
                    
                }

               


            }

            //str = str.Replace("the", "");
          
            return str.Trim();
        }


    }
}
