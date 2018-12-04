using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CustomToolbar
{
    public interface ISave
    {
        string Save(MemoryStream fileStream);
    }
   
}
