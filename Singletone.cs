using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTesting
{
    public static class Singletone
    {
        static List<object> Content = new List<object>();

        public static void Add<T>(params dynamic[] par)
        {
            for (int i = 0; i < Content.Count; i++)
                if (Content[i].GetType() == typeof(T))
                    return;

            Content.Add(Activator.CreateInstance(typeof(T), par));
        }

        public static dynamic GetInstance<T>()
        {
            for (int i = 0; i < Content.Count; i++)
                if (Content[i].GetType() == typeof(T))
                    return Content[i];

            return 0;
        }
    }
}
