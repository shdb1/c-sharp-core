using System;
using System.Threading;

namespace c_sharp_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate demo gonna start!");
            SampleMethod(24,
                      delegate
                      {
                         Console.WriteLine("This is delegate action!");
                      });
            Console.WriteLine("Delegate has been passed to method");
        }
         public static void SampleMethod(int data, Action action) {
          Console.WriteLine("Hey i am invoked to test delegate");
          if (action != null)
                    action();
        Console.WriteLine("END");
        }
      }
    }

