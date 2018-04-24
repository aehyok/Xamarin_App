using aehyok.App.Anti_Smuggling;
using aehyok.App.MVVM;
using aehyok.App.Tabbed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aehyok.App
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.Title = "缉私平台";

            var myButton = new Button
            {
                Text = "自定义按钮",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            myButton.Pressed += (sender, args) =>
            {
                myButton.BackgroundColor = Color.Red;
            };
            myButton.Released += (sender, args) =>
            {
                myButton.BackgroundColor = Color.Blue;
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageTest());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MasterDetailPageTest());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TabbedPageTest());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MvvmDemoPage());   //PushModalAsync隐藏顶部导航
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MvvmDemoPage2());
        }

        /// <summary>
        /// 跳转到缉私平台页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());  //PushAsync保留顶部导航
        }

        /// <summary>
        /// 布局测试页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutPageTest());
        }

        /// <summary>
        /// OpenPDF页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PdfViewPage());
        }
    }
}
