using System;
using System.Collections.Generic;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 0, 1, 700, 0 };

            // Find index of element 100 or greater.
            int result = list.FindIndex(element => element >= 100);
            Console.WriteLine("FINDINDEX: {0}", result);
            Console.ReadKey();
        }
    }
}

//Reference: https://www.dotnetperls.com/list-find