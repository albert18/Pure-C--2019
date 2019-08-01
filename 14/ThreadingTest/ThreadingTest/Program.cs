using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Thread Basic
            //Console.WriteLine("Console 1");
            //Thread.Sleep(5000);
            //Console.WriteLine("Console 2");
            //Thread.Sleep(5000);
            //Console.WriteLine("Console 3");

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2");
            //}).Start();

            //Console.WriteLine("Console 4");
            #endregion

            var taskCompletionSource = new TaskCompletionSource<bool>();
            var tread = new Thread(() =>
            {
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
            });
            Console.WriteLine(($"Thread number : {tread.ManagedThreadId}"));
            tread.Start();
            var test = taskCompletionSource.Task.Result;


        }
    }
}
