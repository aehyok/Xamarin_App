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
	public partial class BbsMessage : ContentPage
	{
		public BbsMessage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var url = "http://192.168.1.74:8098/api/Case/List";

            var client = new RestClient(url);

            var request = new RestRequest("", Method.GET);


            IRestResponse response = client.Execute(request);
            var content = JsonConvert.DeserializeObject<dynamic>(response.Content);


            List<ListViewItem> list = new List<ListViewItem>();
            foreach(var item in content)
            {
                ListViewItem viewItem = new ListViewItem();
                viewItem.AJID = item.AJID;
                viewItem.ID = item.ID;
                viewItem.AJMC = "案件名称："+item.AJMC;
                viewItem.CQSX = "审批事项:"+item.CQSX;
                viewItem.CQRQ = "呈请日期："+item.CQRQ;
                viewItem.CQRY = "呈请人员："+item.CQRY;
                list.Add(viewItem);
            }
            listView.ItemsSource = list;
        }
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            Debug.WriteLine("Tapped: " + e.Item);
            var item = e.Item as ListViewItem;
            DisplayAlert("提示页面", item.ID, "OK ");

            Navigation.PushAsync(new ApprovalDetail(item.ID));
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}