using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace SinoStar.App.Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QrCodeTest : ContentPage
    {
        public QrCodeTest()
        {
            InitializeComponent();
        }

        void OnGenerateButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new BarcodePage());
        }

        async void OnScanButtonClicked(object sender, EventArgs args)
        {
            var scanPage = new ZXingScannerPage();

            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            // Navigate to our scanner page
            await Navigation.PushAsync(scanPage);
        }
    }
}