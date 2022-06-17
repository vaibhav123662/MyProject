using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class TernaryOddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            string str = num % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(str);
        }
    }

    class Ternary2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


/*            int temp = num1 > num2 ? num1 : num2;
            int result = num3 > temp ? num3 : temp;*/


/*            int result =  (num1 > num2) ? num1 > num3 ? num1 : num3 : num2 > num3 ? num2: num3;*/
            
            
            int result = (num1 > num2 && num1 > num3) ? num1 : (num2 > num1 && num2 > num3) ? num2 : num3;
            Console.WriteLine("Greatest number is" +result);
        }
    }

}
