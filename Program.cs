using System;

namespace ConfirmMeWSQuartz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Start Job
            JobScheduler.Start();

            Console.Read();
        }
    }
}
