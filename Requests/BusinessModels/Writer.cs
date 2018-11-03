using System;
using System.IO;
using System.Web;

namespace Requests.BusinessModels
{
    public class Writer
    {
        private readonly string requestType;
        private readonly string ip;
        private readonly string url;

        public Writer(string requestType, string ip, string url)
        {
            this.requestType = requestType;
            this.ip = ip;
            this.url = url;
        }

        public void WriteToFile()
        {
            string path = HttpContext.Current.Server.MapPath("~/Content/RequestFiles/") + requestType + ".txt"; 
            string requestInfo = $" {DateTime.Now} \n requestType: {requestType} \n ip: {ip} \n url: {url} \n\n";

            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(requestInfo);
            }
        }           
    }
}