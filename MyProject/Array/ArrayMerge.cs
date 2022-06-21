using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Array
{
    class ArrayMerge
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33 };
            int[] b = { 44, 55, 66 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            //  OR  //
            /*Console.WriteLine("//////////////////////");
            foreach(int x in c)
            {
                Console.WriteLine(x);
            }*/
        }
    }


    class ArrayMergeRemoveDup
    {
        static void Main(string[] args)
        {
                int[] a = { 11, 22, 33 };
                int[] b = {101,102,33,103,104,22 };
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


    class ArrayMergeRemoveDupA
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33 ,101,103};
            int[] b = { 101, 102, 103, 104,};
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            
            for (int i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                bool isPresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == a[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {
                    c[j] = a[i];
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

}

