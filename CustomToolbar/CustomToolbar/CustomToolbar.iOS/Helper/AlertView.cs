﻿using CustomToolbar.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(AlertView))]
namespace CustomToolbar.iOS
{
    class AlertView : IAlertView
    {
        public void Show(string message)
        {
            UIAlertView popUpView = new UIAlertView();
            popUpView.Message = message;
            popUpView.AddButton("OK");
            popUpView.Show();
        }

    }
}