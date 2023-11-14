using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaVjezba05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi te neki string");
            string x = Console.ReadLine();
            int y = x.Length;
            if(y < 5)
                {
                Console.WriteLine(x);
                }
            Console.WriteLine(x.Substring(2, y - 4));
            Console.ReadKey();
        }
    }
}
