using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(CustomToolbar.Droid.SavePdfDocument))]
namespace CustomToolbar.Droid
{
    public class SavePdfDocument : ISave
    {
        public string Save(MemoryStream stream)
        {
            string root = null;
            string fileName = "SavedDocument.pdf";
            if (Android.OS.Environment.IsExternalStorageEmulated)
            {
                root = Android.OS.Environment.ExternalStorageDirectory.ToString();
            }
            Java.IO.File myDir = new Java.IO.File(root + "/Syncfusion");
            myDir.Mkdir();
            Java.IO.File file = new Java.IO.File(myDir, fileName);
            string filePath = file.Path;
            if (file.Exists()) file.Delete();
            Java.IO.FileOutputStream outs = new Java.IO.FileOutputStream(file);
            outs.Write(stream.ToArray());
            var ab = file.Path;
            outs.Flush();
            outs.Close();
            return filePath;
        }
    }
}