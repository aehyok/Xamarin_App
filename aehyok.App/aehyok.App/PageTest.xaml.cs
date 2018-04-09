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
	public partial class PageTest : ContentPage
	{
		public PageTest ()
		{
			InitializeComponent ();
		}

        private void alert_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("提示页面", "请确认是否删除？", "OK ");
        }

        private async void commitalert_Clicked(object sender, EventArgs e)
        {
            var data = await DisplayAlert("提示页面","请确认是否删除？","确定","取消");
            await DisplayAlert("提示页面", "选中了"+data, "确定");
        }

        private async void actionalert_Clicked(object sender, EventArgs e)
        {
            var action =await DisplayActionSheet("请选择支付方式", "取消", null, "微信", "支付宝", "银联");
            await DisplayAlert("提示", "选中了" + action, "确定");
        }
    }
}