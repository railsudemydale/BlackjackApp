using System;

using Xamarin.Forms;

namespace XFListView
{
	public class XFListViewPage1 : ContentPage
	{
		public XFListViewPage1 ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


