using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace BeautyManager.WPF
{
	/// <summary>
	/// Interaction logic for MainPage.xaml
	/// </summary>
	public partial class MainPage : FormsApplicationPage
	{
		public MainPage()
		{
			InitializeComponent();
			this.Title = "$BeautyManager";
			Forms.Init();
			Syncfusion.SfSchedule.XForms.WPF.SfScheduleRenderer.Init();
			Syncfusion.XForms.WPF.Border.SfBorderRenderer.Init();
			Syncfusion.XForms.WPF.Buttons.SfButtonRenderer.Init();
			LoadApplication(new BeautyManager.App());
		}
	}
}
