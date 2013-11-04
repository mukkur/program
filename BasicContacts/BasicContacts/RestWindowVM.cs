using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BasicContacts
{
    public class RestWindowVM: BaseVM
    {
        public RestWindowVM()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://graph.facebook.com");
            //Log = client.GetStringAsync("jewpaltz").Result;
            //Log = client.SendAsync(new HttpRequestMessage(HttpMethod.Get,"jewpaltz")).Result.Content.read;

        }
        private String _Log;
        public String Log
        {
            get { return _Log; }
            set { _Log = value; }
        }
    }
    public class FBUser
    {
        public string Name { get; set; }
    }
}

    