using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Searching_Linear_Binary
{
    public class Array
    {
        private long sizeArray;
        private long[] array;

        private Array()
        {
            this.sizeArray = 0;
        }
        public Array(long sizeArray) : this()
        {
            this.sizeArray = sizeArray;
            this.array = new long[this.sizeArray];
            SetElements();
        }
        private void SetElements()
        {
            for (long i = 0; i <= this.sizeArray - 1; i++)
            {
                array[i] = i + 1;
            }
        }
        public void SearchBinary(long searchElement)
        {
            long Operation;
            if (BinarySearching.Search(this.array, searchElement, out Operation) == true)
            {
                Console.WriteLine($"Complexity searching binary for {searchElement} in array {this.sizeArray} elements:{Operation}");
            }
            else
            {
                Console.WriteLine("This element isn't in array");
            }
        }
        public void SearchLinear(long searchElement)
        {
            long Operation;
            if (LinearSearching.Search(this.array, searchElement, out Operation) == true)
            {
                Console.WriteLine($"Complexity searching linear for {searchElement} in array {this.sizeArray} elements:{Operation}");
            }
            else
            {
                Console.WriteLine("This element isn't in array");
            }
        }
    }
}
