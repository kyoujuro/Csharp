using System;
using System.Collections.Generic;
using System.Linq;
namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 84, 95, 95, 40, 6 };
            var findAllList = list.FindAll(x => x % 2 == 0);
            Console.WriteLine("=== findAllList ===");
            foreach (var x in findAllList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Hello World!");
            Console.WriteLine(HelloWorld(50));
            var Hoge = new Hoge();
            Hoge.Foo();
            Console.WriteLine(Hoge.Circumference(30));
            Console.WriteLine(Hoge.Relu(-4));
            Console.WriteLine(Hoge.Relu(3));
        }
        static int HelloWorld(int num)
        {
            int sum = 10 + num;
            Console.WriteLine("Your iuput number is " + num);
            return sum;
        }
    }
    class Hoge
    {
        static string test = "hoge";
        public void Foo()
        {
            Console.WriteLine("Foo " + test);
        }
        public static double Circumference(double radius)
        {
            return 2 * System.Math.PI * radius;
        }
        public int Relu(int x){
            if(x < 0){
                return 0;
            }    
            return x;
        }
    }
}
