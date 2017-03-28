using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonní_seznam_SQLite
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}

