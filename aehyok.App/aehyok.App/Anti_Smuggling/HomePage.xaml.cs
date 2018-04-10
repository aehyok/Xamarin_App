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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
            //NavigationPage.SetHasNavigationBar(this, false);
            //NavigationPage.SetHasBackButton(this, false);
            //NavigationPage.SetBackButtonTitle(this, "后退");
            //NavigationPage.SetTitleIcon(this, "F96.png");
            Title = "海关缉私移动应用";
            
            InitializeComponent ();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}