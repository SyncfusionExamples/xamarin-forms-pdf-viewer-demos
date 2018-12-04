using CustomToolbar;
using CustomToolbar.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(SfFontButton), typeof(SfFontButtonRenderer))]
namespace CustomToolbar.UWP
{
    public class SfFontButtonRenderer : ButtonRenderer
    {
        public Thickness Padding { get; set; }
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var nativeButton = (Xamarin.Forms.Button)e.NewElement;
                Control.Padding = new Windows.UI.Xaml.Thickness(0, 0, 0, 0);
            }
        }

    }
}
