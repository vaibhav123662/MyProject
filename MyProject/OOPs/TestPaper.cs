using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class TestPaper
    {
        static void Main(string[] args)
        {
            float area;
            Console.WriteLine("Enter the length of side :");
            float side = float.Parse(Console.ReadLine());

            float root = (float)Math.Sqrt(3) / 4;
            area = root * side * side;

            Console.WriteLine("Area of equilateral triangle is = " + area);
        }
    }

    class Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mark of english:");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark of math:");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark of marathi:");
            int mar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark of hindi:");
            int hin = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mark of biology:");
            int bio = int.Parse(Console.ReadLine());

            float total = eng + math + mar + hin + bio;
            float avg = total / 5.0f;
            float percentage= (total / 500.0f) * 100;

            Console.WriteLine("Total="+total);
            Console.WriteLine("Average="+avg);
            Console.WriteLine("percentage="+percentage);
        }
    }

    class Que3
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4, c = 3;

            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a="+a+"b="+b+"c="+c);
            Console.WriteLine(b*5/a + b++ +b);
            Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
        }
    }

    class Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("year is leap");
            }
            else
            {
                Console.WriteLine("Not leap");
            }
        }
    }

    class Que5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());


            if (num % 5 == 0)
            {
                if (num % 11 == 0)
                {
                    Console.WriteLine("Number is divisible by 5 and 11");
                }
                else
                {
                    Console.WriteLine("Number is divisible by 5 but not 11");
                }
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }

        }
    }

    class Que6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number One is Greatest");
                }
                else
                {
                    Console.WriteLine("Number Three is Greatest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number Two is Greatest");
            }
            else
            {
                Console.WriteLine("Number three is largest");
            }
        }
    }


    class Que7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Character");
            char ch = Console.ReadLine()[0];

            if (ch == 'a' || ch == 'A')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine(ch + " is Vowel");
            }

            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine(ch + " is Vowel");
            }

            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else
            {
                Console.WriteLine(ch + " is consonent");
            }
        }
    }

    class Que8
    {
        static void Main(string[] args)
        {
            int a, b, result;

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter choice (1-4):");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine("Addition is = " + result);
                    break;

                case 2:
                    Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("Substraction is = " + result);
                    break;
                case 3:
                    Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Multiplication is = " + result);
                    break;
                case 4:
                    Console.WriteLine("Enter A:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter B:");
                    b = int.Parse(Console.ReadLine());
                    result = a / b;
                    Console.WriteLine("division is = " + result);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }

    class Que9
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            ch = Console.ReadLine()[0];

            if((ch>'a' && ch<='z') || (ch>='A' && ch <= 'Z'))
            {
                Console.WriteLine("This is lphabet");
            }
            else if(ch>='0' && ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("special charcter");
            }
        }
    }


    class Que10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
