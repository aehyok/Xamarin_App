using aehyok.App.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aehyok.App.Anti_Smuggling
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : CustomPage
    {

        protected override void OnAppearing()
        {
            Image image = new Image();

            //image上添加单击Tap事件
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 1;
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                H11.Source = "H12.png";
                Navigation.PushAsync(new BbsMessage());
            };
            //tapGestureRecognizer
            H11.GestureRecognizers.Add(tapGestureRecognizer);
            base.OnAppearing();
        }
        public HomePage ()
		{
            //NavigationPage.SetHasNavigationBar(this, false);
            //NavigationPage.SetHasBackButton(this, false);
            //NavigationPage.SetBackButtonTitle(this, "后退");
            //NavigationPage.SetTitleIcon(this, "F96.png");
            
            CustomNavigationPage.SetTitlePosition(this, CustomNavigationPage.TitleAlignment.Center);
            CustomNavigationPage.SetTitleBorderWidth(this, 10);

            //调用Web Api测试
            //TestClient.GetJson();


            InitializeComponent ();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("提示页面", "请确认操作记录？", "OK ");
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