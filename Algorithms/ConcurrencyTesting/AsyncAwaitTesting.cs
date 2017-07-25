using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Algorithms.Attributes;

namespace Algorithms.ConcurrencyTesting
{
    [DisplayInfo("Concurrency", "Async Await Testing", typeof(List<int>))]
    class AsyncAwaitTesting
    {
        public List<int> Go()
        {

            
            Console.WriteLine(ShowTodaysInfo());
           // ShowTodaysInfo();
            return new List<int>();
        }

        private async Task<int> ShowTodaysInfo()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            //string ret = $"Today is {DateTime.Today:D}\n" +
            //             "Today's hours of leisure: " +
            //             $"{await GetLeisureHours()}";
            //var ret = await GetLeisureHours();
            //int result = await GetPrimesCountAsync(2, 1000000);
            var task =  GetPrimesCountAsync(2, 1000000);
            //Console.WriteLine(Thread.CurrentThread.Name);
           // await Task.Delay(10000);

            var res = Task.WhenAny(task).ContinueWith((task1, o) =>
            {
                return o;
            }, task);
            
        //    Console.WriteLine(result);
            return 2;
        }

        static async Task<int> GetLeisureHours()
        {
            // Task.FromResult is a placeholder for actual work that returns a string.  
            //var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            await Task.Delay(10000);
            // The method then can process the result in some way.  
            var leisureHours =  5;
            return leisureHours;
        }

        Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(
                () =>
                    //ParallelEnumerable.Range(start, count).Count(n =>
                    //Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0))
                { Thread.Sleep(10000);
            return 2;
        }
        );
    }
    }
}
