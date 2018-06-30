using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinoStar.App.Demo
{

    public class PdfModel
    {
        public string PdfUrl { get; set; }
    }
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PdfViewPage : ContentPage
	{

        private string _docId;
		public PdfViewPage (string docId)
		{
            _docId = docId;

            //var url = "http://192.168.1.74:8098/api/Case/GetDocPdf";

            //var client = new RestClient(url);

            //var request = new RestRequest("", Method.GET);


            //IRestResponse response = client.Execute(request);
            //var content = JsonConvert.DeserializeObject<dynamic>(response.Content);



            InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            PdfModel pdf = new PdfModel();

            var url = "http://192.168.1.74:8098/api/Case/GetDocPdf?docId=" + _docId;

            var client = new RestClient(url);

            var request = new RestRequest("", Method.GET);


            IRestResponse response = client.Execute(request);
            var content = response.RawBytes;



            //Pdf.Uri = content; //"http://192.168.1.74:8098/api/Case/GetDocPdf?docId=" + _docId;
            //Pdf.BindingContext = pdf;

            var fileName = _docId + ".pdf";

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = path+"/" + fileName;
            if (!File.Exists(filePath))
            {
                
                var createFile = new FileStream(filePath, FileMode.Create);
                createFile.Write(content, 0, content.Length);
            }
            Pdf.Uri = filePath;
            base.OnAppearing();
        }
    }
}