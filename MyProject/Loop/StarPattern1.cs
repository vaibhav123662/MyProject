using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class StarPattern1
    {
        static void Main(string[] args)
        {
            for(int i = 1;i<=4;i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class StarPattern3
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for (int K = 4; K >= i; K--) { 
                Console.WriteLine(" ");
                }
            
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        }
    }

   class StarPattern4
    {
        static void Main(string[] args)
        {   
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if(i==1 || i==4 || j==1 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }

        }
    }

    class StarPattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || j == 4 || (i == 2 && j == 2) || (i == 3 && j == 3))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        } 
    }
}
