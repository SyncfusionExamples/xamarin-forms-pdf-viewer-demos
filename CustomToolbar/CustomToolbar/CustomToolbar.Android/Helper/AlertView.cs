using Xamarin.Forms;

[assembly: Dependency(typeof(CustomToolbar.Droid.AlertView))]
namespace CustomToolbar.Droid
{
    public class AlertView : IAlertView
    {
        public void Show(string message)
        {
            Xamarin.Forms.Application.Current.MainPage.DisplayAlert("", message, "OK");
        }
    }
}