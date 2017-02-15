using System;

using Xamarin.Forms;

namespace ActivityIndicatorCase
{
	public class ActivityPage : ContentPage
	{
		public ActivityPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


