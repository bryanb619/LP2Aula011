using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {

            MyVector mv = new MyVector(10.5f, -1.4f);

            Console.WriteLine($"{mv.X} , {mv.Y}");

            mv["A"] = float.PositiveInfinity;

            Console.WriteLine($"{mv.X} , {mv.Y}");
    
        }
    }
}
