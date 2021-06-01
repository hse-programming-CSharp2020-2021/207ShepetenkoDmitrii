using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        private const int RUNS = 1_000;
        static readonly ConcurrentDictionary<int, int> concurrentDictionary = new ConcurrentDictionary<int, int>();
        static void AddOrUpdate()
        {
            for (var i = 0; i < RUNS; ++i)
            {
                if (concurrentDictionary.ContainsKey(i))
                {
                    concurrentDictionary.TryUpdate(i, concurrentDictionary[i] + 1, concurrentDictionary[i].CompareTo(i));
                }
                else
                {
                    concurrentDictionary.TryAdd(i, i);
                    Console.WriteLine($"{i} was added");
                }
            }
        }
        static void Main(string[] args)
        {
            Task t = Task.WhenAll(
                        Task.Run(() => AddOrUpdate()),
                        Task.Run(() => AddOrUpdate()),
                        Task.Run(() => AddOrUpdate()),
                        Task.Run(() => AddOrUpdate()),
                        Task.Run(() => AddOrUpdate()));

            t.Wait();
            Console.WriteLine($"Total number of elements:{ concurrentDictionary.Count}");
        }

    }
}
