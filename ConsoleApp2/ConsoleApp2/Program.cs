using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void xyz()
        {
            while (true)
            {

                Console.WriteLine("apple");
                Thread.Sleep(1000);

            }

        }


        static void Main(string[] args)
        {


            Thread thread = new Thread(Program.xyz);
            thread.Start();

        }
    }
}
