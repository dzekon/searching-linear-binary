using System;
using System.Collections.Generic;
using System.Text;

namespace Searching_Linear_Binary
{
    class LinearSearching
    {
        public static bool Search(long[] array, long searchElement, out long countOperation)
        {
            countOperation = 0;
            for (long i = 0; i < array.Length; i++)
            {
                countOperation++;
                if (array[i] == searchElement)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
