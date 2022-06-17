using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class ConstructorOverloding
    {
        ConstructorOverloding()
            {
                Console.WriteLine("Car");
            }

        ConstructorOverloding(string brand)
            {

                Console.WriteLine("Brand: " + brand);
            }

            static void Main(string[] args)
            {
            ConstructorOverloding car = new ConstructorOverloding();

            ConstructorOverloding car2 = new ConstructorOverloding("Bugatti");

                
            }
        }
    
}
