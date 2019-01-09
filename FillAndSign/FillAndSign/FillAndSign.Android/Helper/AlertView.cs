using Xamarin.Forms;

[assembly: Dependency(typeof(FillAndSign.Droid.AlertView))]
namespace FillAndSign.Droid
{
    public class AlertView : IAlertView
    {
        public void Show(string message)
        {
            Xamarin.Forms.Application.Current.MainPage.DisplayAlert("", message, "OK");
        }
    }
}