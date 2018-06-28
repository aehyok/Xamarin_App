using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace SinoStar.Services
{
    /// <summary>
    /// 账户管理
    /// </summary>
    public class AccountApi
    {
        private const string Url = "http://192.168.1.27:8098";
        public static dynamic Login(string loginName,string loginPassword)
        {
            //创建动态对象
            dynamic loginModel = new ExpandoObject();
            loginModel.LoginName = loginName;
            loginModel.LoginPassword = loginPassword;

            //序列化对象为json字符串
            var json = JsonConvert.SerializeObject(loginModel);

            //定义Rest请求（post）
            var client = new RestClient(Url);
            var request = new RestRequest("/api/Account/Login", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };

            //添加Body参数
            request.AddParameter("Application/Json", json, ParameterType.RequestBody);

            //执行请求
            IRestResponse response = client.Execute(request);

            //处理请求返回结果
            var content = JsonConvert.DeserializeObject<dynamic>(response.Content);

            return content;
        }
    }
}
