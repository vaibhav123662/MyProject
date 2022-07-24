using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class NumberPattern
    {
        static void Main(string[] args)
        {
            
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
    class NumberPattern1
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--) 
                { 
                    Console.Write(j+"");
                }
                Console.WriteLine("");
            }
        }
    }
    class NumberPattern2
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = i; j <= 4; j++)
                {
                    Console.Write(j+"");
                }
                Console.WriteLine();
            }
        }
    }

    class NumberPattern3
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write("" + count);
                }
                Console.WriteLine("");
            }
        }
    }

    class NumberPattern4
    {
        static void Main(string[] args)
        {

            int i, j;
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j % 2);
                }
                Console.WriteLine(""); 
            }
        }
    }

    class CharNumberPattern
    {
        static void Main(string[] args)
        {
            int num = 4;
            char ch;
            for(int i = 1; i <= num; i++)
            {
                if(i==2 || i == 4)
                {
                    ch = '4';
                    for(int j = 1; j <= i; j++)
                    {
                        ch++;
                        Console.Write(ch+"");
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j+"");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    }

