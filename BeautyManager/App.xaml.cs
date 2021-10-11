using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Resources;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

using BeautyManager.States;
using BeautyManager.AppLayout;

using Okyryk.Xamarin.Logging;
using NLog;
using BeautyManager.License;

#if EnableAppCenterAnalytics
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
#endif

[assembly: ExportFont("Montserrat-Bold.ttf", Alias = "Montserrat-Bold")]
[assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
[assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]

namespace BeautyManager
{
	[Preserve(AllMembers = true)]
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
		AppState appState = null;

		private static ILoggingService _logger;
		public static ILoggingService Logger
		{
			get
			{
				if (_logger == null) _logger = new LoggingService();
				return _logger;
			}
		}
		public App()
		{
			Logger.ChangeLogLevel(LogLevel.Debug);
			Logger.Info("Application started!");
			
			CultureInfo.CurrentUICulture = new CultureInfo("uk");

			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(LicenseManager.GetSyncfusionLicense);
#if EnableAppCenterAnalytics
            // AppCenter.Start(
            //    $"ios={AppSettings.IOSSecretCode};android={AppSettings.AndroidSecretCode};uwp={AppSettings.UWPSecretCode}",
            //    typeof(Analytics),
            //    typeof(Crashes));
#endif
			appState = new AppState();
			InitializeComponent();

			appState.Init();

			appState.Execute();

			appState.Ending();

			OSAppTheme currentTheme = Application.Current.RequestedTheme;

			if (currentTheme == OSAppTheme.Light)
			{
				Application.Current.Resources.ApplyLightTheme();
			}
			else
			{
				Application.Current.Resources.ApplyDarkTheme();
			}

			//MainPage = new BeautyManager.MainPage();
			MainPage = new BeautyManager.Views.Forms.LoginPage();
		}


		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
