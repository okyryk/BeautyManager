/*using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeautyManager.AppLayout
{
	[ContentProperty(nameof(Placeholder))]
	public class LocalizationResourceExtension : IMarkupExtension
	{
		public string Placeholder { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Placeholder == null)
			{
				return null;
			}
			return BeautyManagerResourceManager.Manager.GetString(Placeholder);
		}
	}
}*/
