using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadHomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] data = new int[100000000];

            Parallel.For(0, data.Length, (i) => data[i] = rand.Next(0, 1000));         
            var even= data.AsParallel().AsOrdered().Where(element => element % 2== 0 && element!=0);

            foreach (int element in even)
            {
                Console.Write($"{element}" + " ");
            }
        }
    }
}
