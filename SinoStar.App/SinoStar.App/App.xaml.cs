using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SinoStar.App
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            var mainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromRgb(82, 104, 180) };
            MainPage = mainPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
