using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexator indexator = new Indexator();
            for (int i=0;i<indexator.array.Length;i++)
            {
                indexator[i] = i;
                Console.WriteLine(indexator[i]);
            }
            Console.ReadLine();
        }
    }
}
