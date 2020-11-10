using System;

namespace _A
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the beginning of the interval.: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Please enter the end of the interval.: ");
            int end = int.Parse(Console.ReadLine());
            double avg = (start + end) / 2;
            double dis = (Math.Pow((end-start),2) / 12);
          
            Console.WriteLine("The uniform distribution: Average is {0}, Distributed is {1}", avg, dis);
        }
    }
}
