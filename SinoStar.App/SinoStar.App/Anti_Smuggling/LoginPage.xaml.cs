using SinoStar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinoStar.App.Anti_Smuggling
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}


        private void Click_LoginEvent(object sender, FocusEventArgs e)
        {
            var loginName=this.LoginName.Text;
            var loginPassword = this.LoginPassword.Text;
            var result = AccountApi.Login(loginName, loginPassword);

            //if(result)
            //{
            //    DisplayAlert("登录提示","登录成功！","OK");
            //    Navigation.PushAsync(new MainPage());
            //}
        }  
    }
}