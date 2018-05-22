using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            CycleList<int> test = new CycleList<int>();
            Console.WriteLine("Add 3, 12, 100, 111, 12, 999: ");
            Console.Write("==> ");
            test.AddNext(3);
            test.AddNext(12);
            test.AddNext(100);
            test.AddNext(111);
            test.AddNext(12);
            test.AddNext(999);
            test.getAll();
            Console.WriteLine("\nRemove next 12:");
            test.RemoveNext(12);
            Console.Write("==> ");
            test.getAll();
            Console.ReadLine();

        }

    }
}
