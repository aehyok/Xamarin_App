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
            var source = new List<ListViewItem>() {
                new ListViewItem(){ Title="Title1Title1Title1Title1",Detail="Detail1Detail1Detail1Detail1Detail1Detail1Detail1",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title1Title1Title1Title222",Detail="Detail2",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title1Title1Title1Titl3333333",Detail="Detail3",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title1Title1Title144444444444",Detail="Detail4",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title1Title1Titl5555",Detail="Detail5",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title6",Detail="Detail6",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title7",Detail="Detail7",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title8",Detail="Detail8",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title1Title1Titl5555",Detail="Detail5",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title6",Detail="Detail6",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title7",Detail="Detail7",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title8",Detail="Detail8",DateTimes="呈请时间：2018年4月21日"}
            };
            listView.ItemsSource = source;
            base.OnAppearing();
        }
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            Debug.WriteLine("Tapped: " + e.Item);
            DisplayAlert("提示页面", e.Item.ToString(), "OK ");
            ((ListView)sender).SelectedItem = null; // de-select the row
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}