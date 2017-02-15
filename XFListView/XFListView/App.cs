using System;

using Xamarin.Forms;

namespace XFListView
{
	public class App : ContentPage
	{
		public App ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


