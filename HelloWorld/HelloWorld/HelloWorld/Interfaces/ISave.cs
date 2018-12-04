using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    public interface ISave
    {
        string Save(MemoryStream fileStream);
    }
   
}
