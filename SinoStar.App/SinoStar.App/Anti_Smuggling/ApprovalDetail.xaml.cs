using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinoStar.App.Anti_Smuggling
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApprovalDetail : ContentPage
	{
        private string _itemId;
		public ApprovalDetail (string itemId)
		{
            _itemId = itemId;
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var url = "http://192.168.1.27:8098/api/Case/GetDocList";

            var client = new RestClient(url);

            var request = new RestRequest("", Method.GET);
            request.AddParameter("itemId", _itemId);

            IRestResponse response = client.Execute(request);
            var content = JsonConvert.DeserializeObject<dynamic>(response.Content);


            List<ListDocView> listDocView = new List<ListDocView>();
            foreach (var item in content.DYSX)
            {
                var viewItem = new ListDocView();
                viewItem.DocId = item.DocId;
                viewItem.DocTitle = item.DocTitle;
                listDocView.Add(viewItem);
            }
            listView.ItemsSource = listDocView;
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            var item = e.Item as ListDocView;
            Debug.WriteLine("Tapped: " + e.Item);
            DisplayAlert("提示页面", e.Item.ToString(), "OK ");

            //Navigation.PushAsync(new ApprovalDetail());
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}