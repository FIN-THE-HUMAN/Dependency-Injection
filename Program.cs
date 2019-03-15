using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletone.Add<Base>(7);
            Singletone.Add<Derived>(8);
            Singletone.Add<Base>(4);
            Singletone.Add<Derived>(3);
            Singletone.Add<Base>(2);
            Singletone.Add<Derived>(1);

            Base s1 = Singletone.GetInstance<Base>();
            Derived s2 = Singletone.GetInstance<Derived>();
            Base s3 = Singletone.GetInstance<Base>();
            Derived s4 = Singletone.GetInstance<Derived>();
            s1.value = 100;
            Console.WriteLine(s1.TypeName);
            Console.WriteLine(s2.TypeName);
            Console.WriteLine(s3.TypeName);
            Console.WriteLine(s4.TypeName);

            Console.ReadKey();
        }
    }
}
