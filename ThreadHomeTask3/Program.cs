using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadHomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelOptions options = new ParallelOptions();

            options.MaxDegreeOfParallelism = 2;

            Parallel.Invoke(options, SomeWork1, SomeWork2);

            //Console.ReadKey();
        }

        static void SomeWork1()
        {
            Console.WriteLine("Working first menthod");
            for (int i = 0; i < 80; i++)
            {
                Console.Write("1");
                Thread.Sleep(100);
            }
            Console.WriteLine("End first menthod");
        }
        static void SomeWork2()
        {
            Console.WriteLine("Working second menthod");
            for (int i = 0; i < 80; i++)
            {
                Console.Write("2");
                Thread.Sleep(100);
            }
            Console.WriteLine("End second menthod");
        }
    }
}
