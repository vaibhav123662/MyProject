using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Test2
{
    class Test3
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 1, 4, 5, 6 };
            int Evencount = 0;
            int Oddcount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Evencount++;
                }
                else
                {
                    Oddcount++;
                }
            }
            Console.WriteLine("Even numbers count=" + Evencount + "Odd numbers count=" + Oddcount);
        }
    }


    // trace the output == 101 102
    class Q2
    {

        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(String[] arg)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
        }
    }

    class Q3
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'b', 'c', 'c', 'b' };
            Console.WriteLine("enter character from given array");
            char ch = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i <= arr.Length; i++)
            {
                if (ch == arr[i])
                {
                    count++;
                }
                Console.WriteLine(ch+" "+count);
            }

        }
    }

    //Question4
    class Refill
    {
        string inkcolor;
        int length;

        public Refill R
        {
            set;
            get;
        }
        public string Inkcolor
        {
            set;
            get;
        }
        public int Length
        {
            set;
            get;
        }

    }
    class Nib
    {
        string materialtype;
        int width;

        public Nib N
        {
            get;
            set;
        }
        public string Materialtype
        {
            get;
            set;
        }
        public int Width
        {
            get;
            set;
        }
    }
    class Pen
    {
        int caplength;
        string brand;
        Refill r;
        Nib n;

        public int Caplength
        {
            get;
            set;
        }
        public string Brand
        {
            get;
            set;
        }
        public Refill R
        {
            get;
            set;
        }
        public Nib N
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Caplength = 12;
            p.Brand = "stylo";
            p.R = new Refill();
            p.R.Inkcolor = "Blue";
            p.R.Length = 5;
            p.N = new Nib();
            p.N.Materialtype = "Plastic";
            p.N.Width = 3;

            Console.WriteLine(p.Caplength + " " + p.Brand + " " + p.R.Inkcolor + " " + p.R.Length + " " + p.N.Materialtype + " " + p.N.Width);
        }

    }

    class Q5
    {
        static void Main(string[] args)
        {
               
            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {

                if (a[i] == 0)
                {
                    int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                }
                }
            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }

    class Q6
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 2, 4, 9, 2 };
            int size = a.Length;
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (a[i] == a[j])
                    {
                        for(int k = j; k < size-1; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        size--;
                        j--;
                    }
                }
            }
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]+" ");
            }

        }
    }
    /////////////
    ///

    class SubEngine
    {
        public string setype;

        public SubEngine(string setype)
        {
            this.setype = setype;
        }
        public void show()
        {
            Console.WriteLine(setype);
        }
    }
    class Engine
    {
        public int eid;
        public string cleandate;
        SubEngine se;
        public Engine(int eid, string cleandate, SubEngine se)
        {
            this.eid = eid;
            this.cleandate = cleandate;
            this.se = se;
        }
        public void show()
        {
            Console.WriteLine(eid + " " + cleandate+" "+se);
        }
    }

    class Gear
    {
        public string gtype;

        public Gear(string gtype)
        {
            this.gtype = gtype;
        }
        public void show()
        {
            Console.WriteLine(gtype);

        }
    }
    class Car
    {
        int carid;
        string carcolor;
        Engine e;
        Gear g;

        public Car(int carid, string carcolor, Engine e, Gear g)
        {
            this.carid = carid;
            this.carcolor = carcolor;
            this.e = e;
            this.g = g;
        }

        void Display()
        {
            Console.WriteLine(carid + " " + carcolor);
            e.show();
            g.show();
        }
        static void Main(string[] args)
        {
            Car c = new Car(101, "black", new Engine(11, "12/12/2022", new SubEngine("petrol")), new Gear("Auto"));
            c.Display();
        }
    }


    // trace the o/p = 0 2 4 6 8
    class Q8
    {
        public static void Main(String[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] + " ");
                i++;
            }
        }
    }

    class Q9
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };

            for(int i = 0; i < a.Length; i++)
            {
                for(int k = 2; k < a.Length; k++)
                {
                    if (a[i] == k * k)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }
            
        }
    }

    /*public class Q10
    {
        public static void Main(string[] args)
        {
            int a1[], a2;
            a1 = { 1,2,3};
            a2 = new String[a1.length];
            for (int i = 0; i < a1.length; i++)
            {
                a2[i] = a1[i];
            }
            for (int i = 0; i < a2.length(); i++)
            {
                Console.WriteLine(a2[i]);
            }
        }
    }
*/
    
    class Q13
    {
        static void Main(string[] args)
        {
            int[] a ={26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34};
            
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = 1;
/*                    a[i] = a[i] + 1;*/
                }
                Console.WriteLine(a[i]);
            }

        }
    }

    class Q14
    {
        static void Main(string[] args)
        {
            int buzzCount = 0, fizzCount = 0, buzzfizzCount = 0;
            for(int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("buzz");
                    buzzCount++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("fizz");
                    fizzCount++;
                }
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("buzzfizz");
                    buzzfizzCount++;
                }
            }
            Console.WriteLine(buzzCount+" "+fizzCount+" "+buzzfizzCount);
        }
    }
}

