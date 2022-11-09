using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Square : Geometri
    {

        public Square()
        {
            Length = 9;
        }

        public override double Area()
        {
            Console.Write("\nArea of the square is: "); return Length * Length;
        }
    }
}
