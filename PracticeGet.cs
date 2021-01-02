using System;

namespace Pra
{
    class Program
    {

        static void Main(string[] args)
        {
            var c = new Circle();
            Console.WriteLine(c[10]);
            Area area = new Area();
            area.property = 10;
            Console.WriteLine(area.Property);
            FreeArray freeArray = new FreeArray(10);
            freeArray[0] = 10;
            Console.WriteLine(freeArray[0]);
        }
    }

    class Circle
    {
        
        public double this[double radius]
        {
            
            get
            {
                return radius * radius * 3.14;
            }
            
        }
    }

    class Area
    {
        private int length = 10;
        public int property;
        public int Property
        {
            set{property = value;}
            get{return property*length;}
        }
    }

    class FreeArray
    {
        private int _size;
        private int[] _list;

        public FreeArray(int size)
        {
            this._size = size;
            this._list = new int[size];
        }
    

    public int this[int index]
    {
        set
        {
            this._list[this.GetIndex(index)] = value;
        }

        get
        {
            return this._list[this.GetIndex(index)];
        }
    }
    
    private int GetIndex(int index)
    {
        if(index < 0)
        {
            return 0;
        }
        else
        {
            return index % this._size;
        }
    }
    }
}
