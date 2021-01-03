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
            int? num = null;
            if(num.HasValue){
                Console.WriteLine("OK");
            }
            else{
                Console.WriteLine("null");
            }
            Console.WriteLine("Hello World!");
            Age test = new Age();
            Console.WriteLine(test.Bmi(100));
            var car = new Car{
                name = "Track",
                num = 10,
            };
            //var result = car.GetNumber(20) ;
            Console.WriteLine(car.name);
        }

        public int GetNumber()
        {
            return 3;
        }
    }
    public class Car
    {
        public string name{get; set;}
        public int num{get; set;}
        public int  GetNumber(int num)
        {  
            
            return num * 10 ;
        }
    }

}

/// static readonly を読み取り専用の値に使うのが良い
/// var を用いて型推論で可読性を高める
