using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.condition
{
    class FriendAge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your friend age");
            int fage = int.Parse(Console.ReadLine());

            if (fage > myage)
            {
                Console.WriteLine("hi");
            }
            else if (myage > fage)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How are you");
            }

        }
    }


    class TFriendAge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your friend age");
            int fage = int.Parse(Console.ReadLine());

            string result = fage > myage ? "Hi" : myage > fage ? "Good Morning" : "How are you";
            Console.WriteLine(result);
        }
    }

}
