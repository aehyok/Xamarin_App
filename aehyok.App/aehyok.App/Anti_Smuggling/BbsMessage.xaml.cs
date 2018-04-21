using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aehyok.App.Anti_Smuggling
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
                new ListViewItem(){ Title="Title1",Detail="Detail1",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title2",Detail="Detail2",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title3",Detail="Detail3",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title4",Detail="Detail4",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title5",Detail="Detail5",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title6",Detail="Detail6",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title7",Detail="Detail7",DateTimes="呈请时间：2018年4月21日"},
                new ListViewItem(){ Title="Title8",Detail="Detail8",DateTimes="呈请时间：2018年4月21日"},
            };
            listView.ItemsSource = source;
            base.OnAppearing();
        }
        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            Debug.WriteLine("Tapped: " + e.Item);
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}