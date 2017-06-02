using System;
using System.Net;
using System.Text;


namespace NFine.WinForm.Base
{
    public static class Api
    {
        public static string url = "http://localhost:8473/SystemManager/" ;

        /// <summary>
        /// 增
        /// </summary>
        public static string Post(string action  )
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Type"] = "GET";                
                client.Headers["Accept"] = "application/json";
                //client.Headers.Add(header);
                client.Encoding = Encoding.UTF8;
                string JsonObject = string.Empty ;
                client.DownloadStringCompleted += (senderobj, es) =>
                {
                    if (es.Result != null)
                    {
                        JsonObject = es.Result ;
                    }
                };
                client.DownloadStringAsync(new Uri(url + action));
                return JsonObject;

            }

        }

    }
}
