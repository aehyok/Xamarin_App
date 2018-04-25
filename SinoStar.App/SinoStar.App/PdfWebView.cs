using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SinoStar.App
{
    public class PdfWebView : WebView
    {
        public static readonly BindableProperty UriProperty = BindableProperty.Create<PdfWebView, string>(p => p.Uri, default(string));

        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }
    }
}
