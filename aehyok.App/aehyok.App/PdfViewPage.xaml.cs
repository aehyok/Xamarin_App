using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aehyok.App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PdfViewPage : ContentPage
	{
		public PdfViewPage ()
		{
            InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            var browser = new WebView();
            browser.Source = "http://www.aehyok.com";
            Content = browser;
            base.OnAppearing();
        }
    }
}