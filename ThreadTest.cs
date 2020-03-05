using System;

using System.Threading;

 

namespace TutlaneExamples

{

    class Program

    {

        static void Main(string[] args)

        {

            for (int i = 1; i <= 5; i++)

            {

                Console.WriteLine("Thread paused for {0} second", 1);

                // Pause thread for 1 second

                Thread.Sleep(1000);

                Console.WriteLine("i value: {0}", i);

            }

            Console.ReadLine();

        }

    }

}