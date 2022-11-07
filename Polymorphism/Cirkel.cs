using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Cirkel : Geometri
    {

        public double Radius;
        public double Pi;   

        public Cirkel()
        {
            Radius = 3;
            Pi = 3.14;
        }

        public override double Area()
        {
            Console.Write("Area of the Cirkel is: "); return Radius * Radius * Pi;
        }
    }
}
