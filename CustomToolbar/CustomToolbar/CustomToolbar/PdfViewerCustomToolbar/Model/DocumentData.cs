using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomToolbar
{
    public static class DocumentData
    {
        public static IList<Document> DocumentList { get; private set; }

        static DocumentData()
        {
            DocumentList = new List<Document>();
            DocumentList.Add(new Document("F# Succinctly"));
            DocumentList.Add(new Document("GIS Succinctly"));
            DocumentList.Add(new Document("HTTP Succinctly"));
            DocumentList.Add(new Document("JavaScript Succinctly"));
        }
    }
}
