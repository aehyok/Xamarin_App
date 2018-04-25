using SinoStar.App.Demo.MasterDetail;
using SinoStar.App.Demo.MVVM;
using SinoStar.App.Demo.Tabbed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinoStar.App.Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
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

        /// <summary>
        /// Open网页页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebViewPageTest());
        }
    }
}