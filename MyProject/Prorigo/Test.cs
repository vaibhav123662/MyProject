using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Prorigo
{
    /*class Test
    {
        public static void Pupage()
        {
            int age = 0;
            age = age + 7;
            Console.WriteLine("Puppy age is=" + age);
        }
        static void Main(string[] args)
        {
            Test t = new Test();
            Test.Pupage();
        }
        //output = puppy age=7;
    }



    class abc
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 100;
            j = 200;
            while(++i < --j)
            {
                Console.WriteLine("midpoint is="+i);
            }
        }
    }

*/
    /*    class abc1 { }
        public class TestChild extends  abc1
        {
            int k;
            public TestChild()
        {
            this();
            super();
            k = 5;
        }
        }*/

    /*class Abc2
    {
        public Abc2(int ii, int jj, double kk)
        {
            i = ii;
            j = jj;
            k = kk;
        }

        static void Main(string[] args)
        {
            int i;
            Single j;
            double k;
            Abc2 a = new Abc2(10);
        }
    }*/


    //  Ouestion 8

    /*    class HelloWorld
        {
            public static void main(String[] args)
            {
                sum(10, 20);
            }
            static void sum(long l1, long l2)
            {
                System.out.println("long");
            }
            static void sum(float f1, float f2)
            {
                System.out.println("float");
            }
        }

        //Output =Long
    }
    */


    // Question 10
    /*class Test
    {
        void display(Test t)
        {
            System.out.println("Test");
        }
        void display(string str)
        {
            System.out.println("String");
        }
        public static void main(string[] args)
        {
            new Test().display(null);
        }

        //Output=Compile time error
    }*/


    //Question 9
    /*class Test
    {
        void display(Object o)
        {
            System.out.println("Object");
        }
        void display(string str)
        {
            System.out.println("String");
        }
        public static void main(string args[])
        {
            new Test().display(null);
        }
    OutPut= Compile time error
    }*/



    //Question 10
    /*public class Test
    {
        int Test(int i)
        {
            System.out.println("Test2");
            return i;
        }
        Test()
        {
            System.out.println("Test1");
        }
        public static void main(String[] args)
        {
            Test test = new Test(5);
        }

        Output=Compile time error
    }*/


    //Question 9
    /*class Parent
    {
        void display(int i)
        {

        }
    }
    class Child extends Parent
    {
    void Display(){

        }
        //Output=compile time error;
    }*/



    /*final class A
    {
        System.out.println("Hello world");
    }

    class B extends A
    {
        System.out.println("Have a great day");
    }
    class demo
    {
        public static void main(String[] args)
        {
            B.obj = new B();
        }
    }
*/


/*
    class Test
    {
        static void Main(string[] args)
        {*/
            /*int val;
            for (val = -5; val <= 5; val++)
            {
                switch (val)
                {
                    case 0:
                        Console.WriteLine("India");
                        break;
                }
                if (val > 0)
                
                    Console.WriteLine("R");
                    else if(val<0)
                    Console.WriteLine("X");
                
            }*/
            /*
                        int i;
                        int j = new int();
                        i = 10;
                        j = 20;
                        string str;
                        str= i.ToString();
                        str = j.ToString();
                    }

                }*/


/*
            class Largest_Subarray_Length
        {
            static void Main(string[] args)
            {
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int j;
                int max = 0;
                int zeros, ones = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    zeros = 0;
                    ones = 0;
                    for (j = i; j < arr.Length; j++)
                    {
                        if (arr[j] == 0)
                            zeros++;
                        else
                            ones++;

                        if (zeros == ones)
                        {
                            max = max > (j - i + 1) ? max : j - i + 1;

                        }

                    }
                }
                Console.WriteLine(max);
            }
        }
*/




class Scope
    {
        int x = 10;
        static int y = 20;
        public static void Main(string[] args)
        {
            int x = 100; int y = 200;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Scope.y);
        }
    }
    // output== 100 200 20





class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[4]{0, 1, 4, 3};
            a[1] = new int[3] { 9, 2, 7 };
            Console.WriteLine(a[1].GetUpperBound(0));
        }
    }
    //output== 2






    class Garbage
    {
        static void Main(string[] args)
        {
            String str = new String("Hello");
            String str1 = str;
            str = new String("Hi");
            str1 = new String("Hello Again");
            return;
        }
    }






    class abc
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 100;
            j = 200;
            while (++i < --j)
            {
                Console.WriteLine("midpoint is=" + i);
            }
        }
    }


    /*   public class Test extends Thread
       {
   public void run()
       {
           System.out.println("Start");
           yield();
           System.out.println("End");
       }
       public static void main(String[] argv)
       {
           (new Test()).start();
       }
   // Output== Start End
   }




     public class Metal{

       public static void check(){
           System.out.println("1");
       }
       public static int check(){

           return 1;
       }
       public static void Main(){
       check();    
       }

   }// Output== Compile time error
 
     
     
     
     public class Test extends Thread
{
    public void run()
    {
        System.out.println("Run method");
    }
    public static void main(String[] args)
    {
        Test t1=new Test();
        Test t2=new Test();
        t1.start();
        t2.start();
    }
}// Output== Run MethodRun Method
     
     


     public class Mettl
    {
    public static void check()
    {
    System.out.println("1");
    }
    public static int check()
    {
    return 1;
    }
    public static void main()
    {
    check();
    }
    //Output== Two Methods are Overloaded
    }






     */




    /*    class Test
        {
            static void Main(string[] args)
            {
                int i = 0, j = 0;
                label:
                i++;
                j = j + 1;
                if (i < 10)
                {
                    Console.WriteLine(i+" ");
                    goto label;
                }
            }
        }
        // output= 1 2 3 4 5 6 7 8 9
    */




    //****FINAL METHOD CANNOT BE OVERRIDDEN ,HENCE COMPILE TIME EXCEPTION****
    /*class Test
    {
        static void Main(string[] args)
        {
            int m = 10;int n = 7;
            while (m % n>=0)
            {
                
                m = m + 1;
                n = n + 2;
            }
            Console.WriteLine(m+" "+n);
        }
    }
    //Output== Infinite Times
    
     






    public class qq40
       {
       public static void main(String as[])
       {
           sum(10,20);
       }
       static void sum(long l1,long l2)
       {
           System.out.println("long");
       }
       static void sum(float f1,float f2)
       {
           System.out.println("float");
       }
   // Output== long
   }

    
    
    
    //Five friends, A, B, C, D. and E, with different occupational backgrounds (Teacher, Doctor, Accountant,
Businessman, and Engineer) were sitting in a row. The doctor sat next to B. The engineer sat between
B and the accountant. A and the accountant were sitting next to each other but none of them sat at the
extreme ends. What is the occupation of A?


    Answer is == Doctor
 
     



    public class Test{
    
int Test(int i){
    System.out.println("Test 2");
    return i;
}
Test()
{
    System.out.println("test 1");
}
public static void main()
{
    Test t=new Test(5);
}
   // Output== Compile time exception in line Test t=new Test(5) as a paamererized constructor
   }




    Four movies A,B,Cand D are scheduled to release on four days of a week. A is released on Wednesday.
    B is not the first movie to be released.
    C and D were not released on consecutive days.
    C was released on Saturday.No movie was released on Thursday or Sunday.
    How many such arrangements are possible?


    Answer =There are four arrangements are possible

     */


    
    class Nxc
    {
        static void Main(string[] args)
        {
            int[][] a= new int[2][];
            a[0] = new int[4] { 6, 1, 4, 3 };
            a[1] = new int[3] { 9, 2, 7 };
            Console.WriteLine(a[1].GetUpperBound(0));
        }
    }


}

