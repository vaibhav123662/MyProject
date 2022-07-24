using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test4_String
{
    class Question1
    {
    }

    class DupWordString
    {
        static void Main(string[] args)
        {
            string str = "black black brown big dog big dog cat";
            string[] words = str.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {

                    if (words[i] == words[j])
                    {
                        count++;
                        Console.WriteLine(words[i] + " " + count);
                    }
                }
            }
        }
    }


    class CountWords
    {
        static void Main(string[] args)
        {
            string str = "black black brown big dog big dog cat";
            string[] words = str.Split(" ");
            int Count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                Count++;
            }
            Console.WriteLine("Count is= " + Count);
        }
    }


    class Anagram
    {
        static void Main(string[] args)
        {
            string str1 = "goda";
            string str2 = "dog";

            string[] s1 = str1.Split(" ");
            string[] s2 = str2.Split(" ");

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] != s2[j])
                    {
                        Console.WriteLine("Ana");
                    }
                    else
                    {
                        Console.WriteLine("Not");
                    }

                }
            }
        }
    }

    class Decending
    {
        static void Main(string[] args)
        {
            string[] str = { "vaibhav", "rohit", "ketan", "sohel", "bhushan", "abhijit", "shubham", "omkar", "Mujahid", "prashant" };
            Console.WriteLine(string.Join(" ", str));

            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    /*if (str[i] < str[j])
                    {

                    }*/
                }
            }
        }
    }

    class Alphabet
    {
        static void Main(string[] args)
        {
            int alphabet = 0, digit = 0, special = 0;

            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    special++;
                }
            }
            Console.WriteLine("Alphabet=" + alphabet + "   " + "Digit=" + digit + "   " + "special character=" + special);
        }
    }

    class UppertoLower
    {
        public static string Changestr(string str)
        {
            string newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    newString = newString + Char.ToLower(str[i]);
                }
                else if (Char.IsLower(str[i]))
                {
                    newString = newString + Char.ToUpper(str[i]);
                }
                else
                {
                    newString = newString + str[i];
                }
            }
            return newString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            Console.WriteLine(Changestr(s));
        }
    }

    class Reverse
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            int j = arr.Length - 1;
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j--;
                }
                Console.WriteLine();
                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }

    class ArrayMergeRemoveDup
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33 };
            int[] b = { 101, 102, 33, 103, 104, 22 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool isPresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == b[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine("///////////////////");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }


    class AscendingSort
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 3, 4, 1 };
            Console.WriteLine(string.Join(" ",a));

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",a));
        }
    }


    class ZeroToOne
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };

            Console.WriteLine(string.Join(" ",a));
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = 1;
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }


    class NegativeLeftSquare
    {
        static void Main(string[] args)
        {
            int[] a = { 12,3,-19,29,5,-61,44,7,-9};
            /*Console.WriteLine(string.Join(" ",a));
*/
            for(int i = 1; i < a.Length; i++)
            {
                 if (a[i]<0)
                {
                    a[i]--;
                }
                /*              Console.WriteLine(string.Join(" ",a));
                */
                Console.WriteLine(a[i]);  
            }
        }
    }


    class MinElementArray
    {
        static void Main(string[] args)
        {
            char[] a = { 'A', 'D', 'E', 'x', 'z', 'R' };
            char min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Minimum character is= " + min);
        }
    }

    class UniqueElement
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 5, 2, 3, 7, 5, 9, 6 };

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < i; j ++)
                {
                    if (a[i] == a[j])
                    {
                        i++;
                    }                    
                }
                Console.WriteLine(a[i]);
            }
        }
    }

    class SumOFTwoNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1+num2;
            Console.WriteLine("sum=" +sum);

        }
    }

    class Arithmatic
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



    class Arearectangle
    {
        static void Main(string[] args)
        {
            int l, b, area;
            Console.WriteLine("Enter Length");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            b = int.Parse(Console.ReadLine());
            area = l * b;
            Console.WriteLine(area);
        }
    }


    class AreaTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Base");
            int b = int.Parse(Console.ReadLine());

            int Area = (h * b) / 2;
            Console.WriteLine(Area);
        }
    }

    class SquareOfNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            int Square = num * num;
            Console.WriteLine("suqare of number is=" +Square);
        }
    }


    class CubeOfNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            int Cube = num * num * num;
            Console.WriteLine("suqare of number is=" + Cube);
        }
    }

    class ConvertCmToM
    {
        static void Main(string[] args)
        {
            double  meter, km;
            Console.WriteLine("Enter the length ");
            double cm = double.Parse(Console.ReadLine());
            meter = cm / 100.0;
            km = cm / 100000.0;

            Console.WriteLine("Length in meter= "+meter);
            Console.WriteLine("length in kilometer= "+km);

        }
    }


    class Marks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks of Marathi");
            int marathi = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of English");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of Chemistry");
            int chem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of Math");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of Biology");
            int Bio = int.Parse(Console.ReadLine());

            int sum = marathi + eng + chem + math + Bio;
            int avg = sum / 5;
            double percentage = (sum / 500.0) * 100;

            Console.WriteLine("Total= "+sum+"  "+"Average= "+avg+"  "+"Percentage= "+percentage);

        }
    }


    class SimpleInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle amount");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time in year");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Interest rate");
            double r = double.Parse(Console.ReadLine());

            double simpleinterest = (p * t * r) / 100;
            Console.WriteLine("Simple Interest ="+simpleinterest);
        }
    }

    class RectanglePerimeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width");
            int width = int.Parse(Console.ReadLine());
            int perimeter = 2 * (length + width);

            Console.WriteLine("Perimeter of rectangle is =" + perimeter);
        }
    }


    class abc
    {
        static void Main(string[] args)
        {
            int[,,] a = new int[3, 2, 3];
            Console.WriteLine(a.Length);
        }
    }
}

