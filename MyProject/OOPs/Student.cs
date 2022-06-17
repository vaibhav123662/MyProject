using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class Student
    {
        int id;
        string name;
        double mark1;
        double mark2;
        double mark3;
        double percentage;


        public void Accept(int id1, string name1,double marks1, double marks2, double marks3)
        {
            id = id1;
            name = name1;
            mark1 = marks1;
            mark2 = marks2;
            mark3 = marks3;

        }

        public void Percentage()
        {
            percentage = ((mark1 + mark2 + mark3) / 300) * 100;
        }

        public void Display()
        {
            Console.WriteLine("id = "+id+"\nname = "+name+"\nMarathi = "+mark1+"\nHindi = "+mark2+"\nEnglish = "+mark3+"\nPercentage is = "+percentage);
        }
        static void Main(string[] args)
        {

            Student s = new Student();
            s.Accept(1, "Vaibhav", 65, 60, 55);
            s.Percentage();
            s.Display();



        }
    }
}
