using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using RaysHotDogs.Core;

namespace RaysHotDogs
{
	partial class HotDogTableViewController : UITableViewController
	{

		HotDogDataService dataService = new HotDogDataService ();

		public HotDogTableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var hotDogs = dataService.GetAllHotDogs ();
			var datasource = new HotDogDataSource (hotDogs, this);

			TableView.Source = datasource;
		}
	}
}
