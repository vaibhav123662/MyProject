using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class ArithmticOprOverloading
    {
        void Calculate(int num1,int num2)
        {
            Console.WriteLine("Addition is="+(num1+num2));
        }

        void Calculate(float num1,int num2)
        {
            Console.WriteLine("Substarction is = "+(num1-num2));
        }

        void Calculate(double num1,double num2)
        {
            Console.WriteLine("Multiplication is ="+(num1*num2));
        }


        void Calculate(int num1,double num2)
        {
            Console.WriteLine("Division is ="+(num1/num2));
        }


        static void Main(string[] args)
        {
            ArithmticOprOverloading a = new ArithmticOprOverloading();
            a.Calculate(10, 20);
            a.Calculate(5.0f, 2);
            a.Calculate(4.5,5.6);
            a.Calculate(12, 4.0);
        }
    }
}
