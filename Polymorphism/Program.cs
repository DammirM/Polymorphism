using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2way polymorphism

            Geometri[] Geo = new Geometri[3];
            Geo[0] = new Cirkel();
            Geo[1] = new Fyrkant();
            Geo[2] = new Rektangel();

            foreach (Geometri item in Geo)
            {
                Console.Write(item.Area()); 
            }


            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

            Geometri Cir = new Cirkel();
            Console.Write(Cir.Area());
            Geometri Fyr = new Fyrkant();
            Console.Write(Fyr.Area());
            Geometri Rek = new Rektangel();
            Console.Write(Rek.Area());


            Console.ReadKey();

        }
    }
}
