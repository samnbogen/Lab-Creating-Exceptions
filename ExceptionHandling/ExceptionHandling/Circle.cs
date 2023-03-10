using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Circle
    {
        public double Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * (Radius * Radius);
            }
        }
        public virtual void SetRadius()
        {
            if (Radius <= 0)
            {
                throw new InvalidRadiusException();
            }
        }

        public Circle(double radius)
        {
            
            Radius = radius;
            SetRadius();
        }

        

        public override string ToString()
        {
            string formatted = "";

            formatted += "The radius is " + Radius;

            return formatted;
        }
    }
}
