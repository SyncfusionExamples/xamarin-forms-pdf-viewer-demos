using Xamarin.Forms;

[assembly: Dependency(typeof(HelloWorld.Droid.AlertView))]
namespace HelloWorld.Droid
{
    public class AlertView : IAlertView
    {
        public void Show(string message)
        {
            Xamarin.Forms.Application.Current.MainPage.DisplayAlert("", message, "OK");
        }
    }
}