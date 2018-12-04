using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(CustomToolbar.iOS.SavePdfDocument))]

namespace CustomToolbar.iOS
{
    class SavePdfDocument : ISave
    {
        public string Save(MemoryStream fileStream)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filepath = Path.Combine(path, "SavedDocument.pdf");

            FileStream outputFileStream = File.Open(filepath, FileMode.Create);
            fileStream.Position = 0;
            fileStream.CopyTo(outputFileStream);
            outputFileStream.Close();
            return filepath;
        }
    }
}