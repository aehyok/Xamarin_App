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
	public partial class WebViewPageTest : ContentPage
	{
		public WebViewPageTest ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            var browser = new WebView();
            browser.Source = "https://www.baidu.com";
            Content = browser;
            base.OnAppearing();
        }
    }
}