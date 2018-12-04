using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CustomToolbar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Device.Idiom == TargetIdiom.Phone)
            {
                MainPage = new PDFViewerCustomToolbar_Phone();
            }
            else if (Device.Idiom == TargetIdiom.Tablet)
            {
                MainPage = new PDFViewerCustomToolbar_Tablet();
            }
            else if (Device.Idiom == TargetIdiom.Desktop)
            {
                MainPage = new PDFViewerCustomToolbar_Desktop();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
