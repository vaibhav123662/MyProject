using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Training
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Division="+(n1/n2));
                Console.WriteLine("Try block ends");
            }
            catch(FormatException e)
            {
                Console.WriteLine("In catch 2");
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("In catch 1");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e) 
            {
                Console.WriteLine("In catch 3");
                Console.WriteLine(e.Message);
            }

            /*for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
*/

        }
    }




    class ExceptionDemo1
    {
        public static void M1(int a,int b)
        {
            Console.WriteLine("M1 Starts");
            Console.WriteLine("Division="+a/b);
            Console.WriteLine("M1 Ends");
        }
        public static void M2(int x,int y)
        {
            Console.WriteLine("M2 Starts");
            M1(x, y);
            Console.WriteLine("M2 ends");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts");
            try
            {
                M2(10, 1);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Main Ends");
            }
        }
    }




    class ExceptionDemo2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number");
                int a = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }
        }
    }




    class ExceptionDemo3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Division=" + (n1 / n2));
                Console.WriteLine("Try block ends");
                
                
                try
                {
                    Console.WriteLine("Enter Name");
                    string nm = Console.ReadLine();
                    Console.WriteLine("Enter Marks");
                    int mks = int.Parse(Console.ReadLine());
                    Console.WriteLine("3rd character in name is="+nm[2]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }




    // Custom_ExceptionDemo
    class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException()
        {

        }
        public InvalidPasswordException(string msg) : base(msg)
        {

        }
    }
    class Studd
    {
        string username;
        string password;

        public string Username
        {
            set { this.username = value; }
            get { return username; }
        }
        public string Password
        {
            set
            {
                if (value.Length <= 5)
                {
                    throw new InvalidPasswordException("Password length should be greater than 5");
                }
                else
                {
                    this.password = value;
                }
            }
            get
            {
                return password;
            }
        }
        static void Main(string[] args)
        {
            Studd s1 = new Studd();
            s1.username = "Vaibhav";

            try
            {
                s1.password = "abcde";
            }
            catch(InvalidPasswordException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Main Ends");
        }
    }

}
