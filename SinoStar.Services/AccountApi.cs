using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinoStar.Services
{
    public class AccountApi
    {
        public static dynamic Login(string loginName,string loginPassword)
        {
            var url = "http://192.168.1.74:2020/api/Account/Login?loginName="+loginName+"&loginPassword="+loginPassword;
            var client = new RestClient(url);

            var request = new RestRequest("", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("loginName", loginName, ParameterType.RequestBody);
            request.AddParameter("loginPassword", loginPassword,ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            var content = JsonConvert.DeserializeObject<dynamic>(response.Content);
            //return content;
            return content;
        }
    }
}
