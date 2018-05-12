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
            var source = new List<ListViewItem>() {
                new ListViewItem(){ Title="1",Detail="1",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="2",Detail="Detail2",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="3",Detail="Detail3",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="4",Detail="Detail4",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="5",Detail="Detail5",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="6",Detail="Detail6",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title7",Detail="Detail7",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title8",Detail="Detail8",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title1Title1Titl5555",Detail="Detail5",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title6",Detail="Detail6",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title7",Detail="Detail7",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title8",Detail="Detail8",DateTimes="呈请时间：2018年4月21日"}
            };
            listView.ItemsSource = source;
        }
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //if (e == null) return;
            //Debug.WriteLine("Tapped: " + e.Item);
            //DisplayAlert("提示页面", e.Item.ToString(), "OK ");
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}