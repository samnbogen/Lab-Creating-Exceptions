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

            try 
            {                
                Circle circle1 = new Circle(radius1);
                Console.WriteLine(circle1.ToString());
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                        
        }
    }
}
