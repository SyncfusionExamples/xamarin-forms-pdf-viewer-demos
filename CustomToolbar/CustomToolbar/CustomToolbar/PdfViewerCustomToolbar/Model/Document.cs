using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomToolbar
{
    public class Document
    {
        public string FileName { get; private set; }
        public Document(string fileName)
        {
            FileName = fileName;
        }
    }
}
