using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtendString
    {
        public static int stringLength(this string strinput)
        {
            return strinput.Length;
        }
    }
}
