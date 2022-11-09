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
                Console.Write(item.Area()); 
            }


            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

            Geometri Cir = new Circle();
            Console.Write(Cir.Area());
            Geometri Fyr = new Square();
            Console.Write(Fyr.Area());
            Geometri Rek = new Rectangle();
            Console.Write(Rek.Area());


            Console.ReadKey();

        }
    }
}
