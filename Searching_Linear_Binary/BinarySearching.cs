using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Searching_Linear_Binary
{
    class BinarySearching
    {
        public static bool Search(long[] array, long searchElement, out long countOperation)
        {
            countOperation = 0;
            long Left = 0, Right = array.Length - 1, Middle;
            while (Left <= Right)
            {
                countOperation++;
                Middle = (Left + Right) / 2;
                if (array[Middle] == searchElement)
                {
                    return true;
                }
                else if (array[Middle] > searchElement)
                {
                    Right = Middle - 1;
                }
                else
                {
                    Left = Middle + 1;
                }
            }
            return false;
        }
    }
}
