using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FillAndSign
{
    public interface ISave
    {
        string Save(MemoryStream fileStream);
    }
   
}
