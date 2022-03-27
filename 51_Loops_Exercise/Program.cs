using System;

namespace _51_Loops_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops Exercise!");

            Console.WriteLine("Even numbers Loop!");
            for (int i = 0; i <= 100; i+=2)
            {
                Console.Write(i +",");
            }

            Console.WriteLine("");
            Console.WriteLine("Triangle Loop!");
            string sline = "";
            for (int i = 1; i<= 10; i++)
            {
                sline = sline + "0 ";
                Console.WriteLine(sline);
            }
        }
    }
}
