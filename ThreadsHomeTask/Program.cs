using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первичный поток: ID {0}", Thread.CurrentThread.ManagedThreadId);

            Func<string, string> func = new Func<string, string>(PrintHello);

            var asyncResult = func.BeginInvoke("Hello", CallBack, "Alex");
            string res =func.EndInvoke(asyncResult);
            Console.WriteLine("Результат = " + res);
            Console.ReadKey();
          
         
        }
       
        static void CallBack(IAsyncResult asyncResult)
        {
        
            Console.WriteLine("асинхронной операция - "
               + asyncResult.AsyncState);
        }
        static string PrintHello(string name)
        {
            // Thread.CurrentThread.IsBackground = false;

            Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            return name;
        }

    }
}
