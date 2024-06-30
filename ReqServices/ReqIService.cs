using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ReqServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ReqIService
    {

        //Req Service 1 from A3 

            [OperationContract]
            string WebDownload(string url);

        //Req Service 2 From A3

        [OperationContract]
        string WordsFilter(String str);




    }

}
