using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android.AppCompat;
using Xamarin.Forms;
using System.ComponentModel;
using Android.Graphics;
using Xamarin.Forms.Platform.Android;
using CustomToolbar.Droid;
using CustomToolbar;

[assembly: ExportRenderer(typeof(SfFontButton), typeof(SfFontButtonRenderer))]
namespace CustomToolbar.Droid
{
    public class SfFontButtonRenderer : Xamarin.Forms.Platform.Android.ButtonRenderer
    {
        public SfFontButtonRenderer(Context context) : base(context) { }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            double? fontSize = e.NewElement?.FontSize;
            if (fontSize == null || e.NewElement.FontFamily == null)
            {
                return;
            }
            Typeface font = Typeface.CreateFromAsset(Context.Assets, e.NewElement.FontFamily);
            Control.Typeface = font;
            Control.TextSize = 25;
        }
    }
}