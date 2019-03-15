using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTesting
{
    public class Base : IBase
    {
        public Base(int v) { value = v; }
        public int value;

        public dynamic GetInstance()
        {
            return Activator.CreateInstance(GetType());
        }

        public string TypeName => $"{GetType().Name + value}";
    }
}
