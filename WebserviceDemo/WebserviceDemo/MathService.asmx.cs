using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebserviceDemo
{
    /// <summary>
    /// Summary description for MathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public dynamic Add(String arg)
        {
            List<dynamic> inps=JsonConvert.DeserializeObject<List<dynamic>>(arg);
            dynamic res=inps[0];
            for(int i=1;i<inps.Count;i++)
            {
                res += inps[i];
            }
            return res;
        }
        [WebMethod]
        public dynamic Sub(String arg)
        {
            List<dynamic> inps = JsonConvert.DeserializeObject<List<dynamic>>(arg);
            dynamic res = inps[0];
            for (int i = 1; i < inps.Count; i++)
            {
                res -= inps[i];
            }
            return res;
        }
    }
}
