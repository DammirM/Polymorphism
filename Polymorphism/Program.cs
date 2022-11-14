using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2way polymorphism

            Geometri[] Geo = new Geometri[3];
            Geo[0] = new Circle();
            Geo[1] = new Square();
            Geo[2] = new Rectangle();

            foreach (Geometri item in Geo)
            {
                Console.Write(item.Area() + "\n"); 
            }

            
            Console.WriteLine("------------------\n");

            Geometri Cir = new Circle();
            Console.Write(Cir.Area());
            Geometri Squ = new Square();
            Console.Write(Squ.Area());
            Geometri Rec = new Rectangle();
            Console.Write(Rec.Area());


            Console.ReadKey();

        }
    }
}
