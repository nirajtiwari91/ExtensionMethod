using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtendCalculator
    {
        public static int Sub(this Calculator C, int x, int y)
        {
            return x - y;
        }

        public static int returnIdentifier(this Calculator C)
        {
            return C.Identifier;
        }
    }
}
