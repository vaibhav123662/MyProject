using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Training
{
    class DelegateDemo
    {
        //To declare a delegate
        public delegate void MyDelegate(int x);

        public void Square(int a)
        {
            Console.WriteLine("Square ="+a*a);
        }
        static void Main(string[] args)
        {
            //set a target
            DelegateDemo obj = new DelegateDemo();
            MyDelegate d = obj.Square;
            d(7);
        }
    }



    class DelegateDemo2
    {
        public delegate int MyFactorial(int x);

        public int Factorial(int a)
        {
            int f = 1;
            for(int i = 1; i <= a; i++)
            {
                f = f * 1;
            }
            return f;
        }
        static void Main(string[] args)
        {
            DelegateDemo2 obj = new DelegateDemo2();
            MyFactorial f = obj.Factorial;
            
        }
    }



    class DelegateDemo3
    {
        //To declare a delegate
        public delegate void MyDelegate1(int x);

        public void Square(int a)
        {
            Console.WriteLine("Square =" + a * a);
        }
        public void Cube(int x)
        {
            Console.WriteLine("Cube="+x*x*x);
        }
        public static void Doubleup(int a)
        {
            Console.WriteLine("Double Up="+2*a);
        }
        static void Main(string[] args)
        {
            //set a target
            DelegateDemo3 obj = new DelegateDemo3();
            MyDelegate1 d1 = obj.Square;
            //d1 = d1 + obj.Cube;
            d1 = d1 - obj.Cube;
            d1 = d1 + DelegateDemo3.Doubleup;
            d1(6);
        }
    }




    //Lambda Expression
    public delegate int mydel1(int x, int y);
    class LambdaDemo
    {
        static void Main(string[] args)
        {
            //Anonymous function
            mydel1 d1 = delegate (int x, int y)
            {
                Console.WriteLine("Sum=" + (x + y));
                return x + y;
            };

            d1(10, 20);

            //lambda expression
            mydel1 d2 = (x, y) =>
            {
                Console.WriteLine("Addition=" + (x + y));
                return x + y;
            };
            d2(10, 10);
        }
    }


    class Prime
    {
        public delegate bool mydel2(int x);

        static bool isPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        static void Main(string[] args)
        {
            mydel2 d3 = (n) =>
            {
                bool isPrime = true;
                for(int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            };
            bool answer = d3(97);
            Console.WriteLine(answer);
        }
    }



    /*
    1) Func- use when function compulsary returns a value back and can take one or max 16 parameters.
    2) Action- if function return type is void and may 0 or more parameters.
    3) Predicate- function compulsary return boolean value back and may take 0 or more parameters.*/


    class DemoFF
    {
        static string greet()
        {
            return "Good Morning";
        }
        static int product(int a,int b,int c)
        {
            return a * b * c;
        }
        static bool iseven(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Func<string> d1 = greet;
//            Func<int, int, int,int> d2 = product;
            Func<int, int, int, int> d2 =(a,b,c)=>(a*b*c);
            int prod = d2(2, 3, 4);
            Console.WriteLine("Multiplication="+prod);

            Action<int, int> d3 = (a, b) => Console.WriteLine("Addition="+(a+b));
            d3(10, 10);

            Func<int, bool> d4 = iseven;
            bool b = d4(77);
            Console.WriteLine(b);

            Predicate<int> d5 = iseven;
            bool b1 = d5(55);
            Console.WriteLine(b1);
        }
    }


    class CallBack
    {
        public static void display()
        {
            Console.WriteLine("Good Morning");
        }
        public static void square(int a,Action d1)
        {
            Console.WriteLine("Square="+a*a);
            d1();
        }
        static void Main(string[] args)
        {
            //square(10, () => Console.WriteLine("happy morning"));
            square(9, display);
        }
    }
}
