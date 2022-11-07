using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Geometri
    {
        // Giving base class a property because it is going to be used in 2 classes

        public double Length;

        // Creating a virtual method to override
        public virtual double Area()
        {
            return 0;
        }


    }
}
