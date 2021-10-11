using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BeautyManager.Helpers
{
	class PageHelper
	{
		public static bool IsPortrait(Page p)
		{
			if (p.Width == -1)
			{
				return true;
			}
			return p.Width < p.Height; 
		}
	}
}
