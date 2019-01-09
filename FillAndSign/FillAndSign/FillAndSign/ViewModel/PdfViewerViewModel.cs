using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;

namespace FillAndSign
{
    class PdfViewerViewModel:INotifyPropertyChanged
    {
        private Stream pdfDocumentStream;

        private string m_documentName;

        string filePath = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public string DocumentName
        {
            get
            {
                return m_documentName;
            }
            set
            {
                m_documentName = value;
                
            }
        }

        public PdfViewerViewModel()
        {
            filePath = "FillAndSign.Assets.";
            pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(filePath + "FormFillingDocument.pdf");
        }
        public Stream PdfDocumentStream
        {
            get
            {
                return pdfDocumentStream;
            }
            set
            {
                pdfDocumentStream = value;
                NotifyPropertyChanged("PdfDocumentStream");

            }
        }
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
