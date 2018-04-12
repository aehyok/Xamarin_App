using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace aehyok.App.Droid
{
    public class TestClient
    {
        public static void  GetJson()
        {
            var client = new RestClient("http://192.168.1.74:2021");

            var request = new RestRequest("api/Values", Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
        }
    }
}