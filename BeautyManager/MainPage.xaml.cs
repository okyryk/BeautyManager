using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeautyManager
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDYzNzU2QDMxMzkyZTMxMmUzMGxMcnFNVWxnL3R2YlVPSlpmalVGNEZ6cmpFMkJ0czhPN0ZIeUFSMEJnUGM9");
			InitializeComponent();
		}

		private void SfButton_Clicked(object sender, EventArgs e)
		{
			//Navigation.PushAsync(new BeautyManager.Views.Forms.LoginPage());

			App.Current.MainPage = new NavigationPage(new BeautyManager.Views.Forms.LoginPage());
		}
	}
}
