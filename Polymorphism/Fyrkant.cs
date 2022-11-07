using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Fyrkant : Geometri
    {

        public Fyrkant()
        {
            Length = 9;
        }

        public override double Area()
        {
            Console.Write("\nArea of the Fyrkant is: "); return Length * Length;
        }
    }
}
