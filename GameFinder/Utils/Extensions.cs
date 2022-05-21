using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFinder.Utils
{
    static class Extensions
    {
        public static bool IsEmpty<T>(this List<T> list) => list.Count == 0;
    }
}
