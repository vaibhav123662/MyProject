using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Containment
{
    class PropertyEmployee
    {
        int id;
        string name;
        double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        static void Main(string[] args)
        {
            PropertyEmployee e = new PropertyEmployee();
            e.Id = 101;
            e.Name = "Vaibhav";
            e.Salary = 12000.43;

            Console.WriteLine(e.Id+"  "+e.Name+"  "+e.Salary);
        }
    }

}
