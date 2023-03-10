using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius1 = 95.5;
            double radius2 = -80;
            double radius3 = 0;

            try 
            {                
                Circle circle1 = new Circle(radius1);
                Console.WriteLine(circle1.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Circle circle2 = new Circle(radius2);
                Console.WriteLine(circle2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Circle circle3 = new Circle(radius3);
                Console.WriteLine(circle3.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                        
        }
    }
}
