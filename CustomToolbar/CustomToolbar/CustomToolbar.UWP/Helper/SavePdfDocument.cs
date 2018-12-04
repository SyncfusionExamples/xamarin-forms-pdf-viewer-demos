using System;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(CustomToolbar.UWP.SavePdfDocument))]
namespace CustomToolbar.UWP
{
    class SavePdfDocument : ISave
    {
        MemoryStream stream;
        StorageFolder folder;
        StorageFile file;
        public string Save(MemoryStream documentStream)
        {
            documentStream.Position = 0;
            stream = documentStream;
            SaveAsync();
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, "SavedDocument.pdf");
        }

        private async void SaveAsync()
        {
            folder = ApplicationData.Current.LocalFolder;
            file = await folder.CreateFileAsync("SavedDocument.pdf", CreationCollisionOption.ReplaceExisting);
            if (file != null)
            {
                Windows.Storage.Streams.IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.ReadWrite);
                Stream st = fileStream.AsStreamForWrite();
                st.SetLength(0);
                st.Write((stream as MemoryStream).ToArray(), 0, (int)stream.Length);
                st.Flush();
                st.Dispose();
                fileStream.Dispose();
            }
        }
    }
}
