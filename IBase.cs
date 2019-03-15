using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTesting
{
    public interface IBase
    {
        dynamic GetInstance();
        string TypeName { get; }
    }
}
