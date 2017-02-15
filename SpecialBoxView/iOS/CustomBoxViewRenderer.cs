using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using CoreGraphics;
using ModelIO;
using Xamarin.Forms;
using SpecialBoxView.iOS;

[assembly: ExportRendererAttribute (typeof(SpecialBoxView), typeof(CustomBoxViewRenderer))]

namespace SpecialBoxView.iOS
{
	public class CustomBoxViewRenderer : BoxRenderer
	{
	
		public override void Draw (CoreGraphics.CGRect rect)
		{
			CustomBoxView boxView = (CustomBoxView)Element;
	
			using (var context = UIGraphics.GetCurrentContext ()) 
			{
				context.SetFillColor (boxView.Color.ToCGColor ());
				context.SetStrokeColor (boxView.BorderColor.ToCGColor ());
				context.SetLineWidth ((float)boxView.BorderThickness);

	
				var rectangle = Bounds.Inset ((int)boxView.BorderThickness,
					(int)boxView.BorderThickness);
	
				var path = CGPath.FromRect (rectangle);
				context.AddPath (path);
				context.DrawPath (CGPathDrawingMode.FillStroke);
	
			}
	
		}

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == CustomBoxView.BorderThicknessProperty.PropertyName) {
				SetNeedsDisplay ();
			}
		}
	
	}
}

//	public class SpecialBoxViewRenderer : ViewRenderer<SpecialBoxView, UIView> {
//		UIView newView;
//
//		protected override void OnElementChanged(ElementChangedEventArgs<SpecialBoxView> e) {
//			base.OnElementChanged(e);
//
//			var specialBoxView = e.NewElement;
//			if (specialBoxView != null) {
//				newView = new UIView() {
//					BackgroundColor = specialBoxView.Color.ToUIColor(),
//					Layer = {
//						BorderColor = specialBoxView.BorderColor.ToCGColor(),
//						BorderWidth = (float)specialBoxView.BorderThickness
//					}
//				};
//				SetNativeControl(newView);
//			}
//		}
//
//		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
//			if (e.PropertyName == SpecialBoxView.BorderThicknessProperty.PropertyName) {
//				newView.Layer.BorderWidth = (float)this.Element.BorderThickness;
//			} else if (e.PropertyName == BoxView.ColorProperty.PropertyName) {
//				newView.BackgroundColor = Element.Color.ToUIColor();
//			}
//		}
//
//	}
//}
