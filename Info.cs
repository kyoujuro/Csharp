using System;

namespace effective
{
    class Age
    {
        private static readonly int _age = 20;
        //public int heigh = 160;

        public int Bmi(int height)
        {
            var result =  height / _age;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Age test = new Age();
            Console.WriteLine(test.Bmi(100));
        }
    }


}