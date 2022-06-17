using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class TableNum
    {
        static void Main(string[] args)
        {
            int i, table;
            Console.WriteLine("Enter the number :");
            int num = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                table = num * i;
                Console.WriteLine("Table is = " +table);
            }

        }
    }
}
