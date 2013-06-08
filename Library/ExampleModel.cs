using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Library
{
    public class ExampleModel
    {
        private ExampleModel() { }

        public static string DownloadString()
        {
            string response = string.Empty;
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    client.Headers.Add("Accept", "xml");
                    response = client.DownloadString("http://h.acfun.tv/api/Metadata");
                }
            }
            catch (Exception ex)
            {
                response += ex;
            }
            return response;
        }
    }
}
