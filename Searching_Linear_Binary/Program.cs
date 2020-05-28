using System;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Searching_Linear_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(268435450);
            array.SearchBinary(268435450);
            array.SearchLinear(268435450);
            array.SearchBinary(1);
            array.SearchLinear(1);
        }
    }
}
