using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rektangel : Geometri
    {

        public double Width;


        // Giving the properties value in the constructor
        public Rektangel()
        {
            Length = 8;
            Width = 7;
        }

        public override double Area()
        {
            Console.Write("\nArea of the Rektangel is: "); return Length * Width;
        }
    }
}
