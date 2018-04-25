using SinoStar.App.Anti_Smuggling;
using SinoStar.App.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SinoStar.App
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            Image image = new Image();

            //image上添加单击Tap事件
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 1;
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                //H11.Source = "H12.png";
                Navigation.PushAsync(new BbsMessage());
            };
            //tapGestureRecognizer
            H11.GestureRecognizers.Add(tapGestureRecognizer);
            base.OnAppearing();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }

        private void Image_Focused(object sender, FocusEventArgs e)
        {
            DisplayAlert("提示页面", "请确认操作记录？", "OK ");
        }

        private void H11_ChildAdded(object sender, ElementEventArgs e)
        {
            DisplayAlert("提示页面", "请确认操作记录？", "OK1111 ");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("提示页面", "请确认操作记录？", "OK1111 ");
        }
    }
}
