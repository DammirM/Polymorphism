using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            // Run time Polymorphism

            Geometri[] Geo = new Geometri[3];
            Geo[0] = new Cirkel();
            Geo[1] = new Fyrkant();
            Geo[2] = new Rektangel();

            foreach (Geometri item in Geo)
            {
                Console.Write(item.Area()); 
            }


            Console.ReadKey();

        }
    }
}
