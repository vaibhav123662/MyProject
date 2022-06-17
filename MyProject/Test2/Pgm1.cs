using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test2
{
    class Pgm1
    {
        static void Main(string[] args)
        {
            int i = 1, a = 1;

            while (i <= 100)
            {
                if (a % 5 == 0 && a % 10 == 0)
                {
                    a = a + 1;
                    //   Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    a = a + 1;
                    i = i + 1;
                }
            }
        }
    }


    class Que2
    {

        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);

            //output is =222
        }
    }


    class Que3
    {
        static void Main(string[] args)
        {

            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k = k * i;
            }
            Console.WriteLine("k=" + k + "i=" + i);
        }
        //output= k=720 i=7
    }

    class Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0, product = 1, r;

            while (num != 0)
            {
                r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("Number is spy number");
            }
            else
            {
                Console.WriteLine("Number is not spy number");
            }
        }
    }

    class Que5
    {
        //Trimorphic or not
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            int flag = 0;
            int cube = num * num * num;
            while (num != 0)
            {
                if (num % 10 != cube % 10)
                {
                    flag = 1;
                    break;
                }
                num /= 10;
                cube /= 10;
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is trimorphic number");
            }
            else
            {
                Console.WriteLine("number is not a Trimorphic Number.");
            }
        }
    }


    class Que6
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j > i; j--)
                {
                    Console.WriteLine(" ");
                }
                for (k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("\n");
            }
        }
    }


    class Que8
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("\n");
            }
        }
    }


    class Que9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mystertInt = 100;
                mystertInt -= i;
                Console.WriteLine(mystertInt);
            }
        }

        //95 96 97 98 99
    }


    class Que11
    {
        //2 12 36  80
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine((i * i) + (i * i * i));
                i++;
            }
        }
    }

    class Que12
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 50 ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-(i*i));
                }
            }
            
        }
    }

    class Que13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }
        //output= infinite time 1
    }

    class Que14
    {
        static void Main(string[] args)
        {
            int prv = 0, pre = 1, trm, i;
            for (i = 1; i <= 20; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
        }
    }

    class Que15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find factorial");
            int num = int.Parse(Console.ReadLine());
            
            int i, sum = 1 , fact = 1;
            
            for (i = 1; i <= num; i++)

                fact = fact * i;
                sum = sum + fact;

            Console.Write("The Factorial is= "+fact);
            Console.WriteLine("Sum= "+sum);
        }
    }
}
    