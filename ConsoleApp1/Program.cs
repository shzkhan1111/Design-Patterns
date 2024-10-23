using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemoryCache.Create();
            //MemoryCache.Create();
            //MemoryCache.Create();
            //MemoryCache.Create();
            //MemoryCache.Create();
            //MemoryCache.Create();

            ////constructor called only once
            ///task in paralell 
            ///


            ///creates many instances
            int size = 20;
            Task[] tasks = new Task[size];

            for (int i = 0; i < size; i++)
            {
                tasks[i] = Task.Run(    
                    () => MemoryCache.Create()
                    )
                    ;
            }
            Task.WaitAll(tasks);
            Console.WriteLine("Hello World!");
        }
    }
}
