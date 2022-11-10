using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        public static void Greetings()
        {
            while (true)
            {

                Console.WriteLine("Good Morning");
                Thread.Sleep(2000);
                Console.WriteLine("Hello");
                Thread.Sleep(3000);
                Console.WriteLine("Welcome");
                Thread.Sleep(1000);

            }

        }


        static void Main(string[] args)
        {


            Thread mainthread = new Thread(Program.Greetings);
            mainthread.Start();

        }
    }
}

