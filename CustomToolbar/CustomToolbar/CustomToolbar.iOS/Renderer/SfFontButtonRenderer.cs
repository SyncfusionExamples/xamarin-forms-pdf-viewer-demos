using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using CustomToolbar;
using CustomToolbar.iOS;

[assembly: ExportRenderer(typeof(SfFontButton), typeof(SfFontButtonRenderer))]
namespace CustomToolbar.iOS
{
	public class SfFontButtonRenderer : ButtonRenderer
	{


		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			double? fontSize = e.NewElement?.FontSize;
            if(fontSize==null || e.NewElement.FontFamily==null)
            {
                return;
            }
			UIFont font = UIFont.FromName(e.NewElement.FontFamily, (int)fontSize);
			Control.Font = font;
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName.Equals("Text"))
			{
				Label label = sender as Label;
				UIFont font = UIFont.FromName("Final_PDFViewer_IOS_FontUpdate", 50);
				Control.Font = font;
				Control.Font.WithSize(35);

			}
		}
	}
}