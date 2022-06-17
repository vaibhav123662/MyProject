using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class Car
    {
        public int ModelNo;
        public string carname;
        public string carcolor;
        public int price;

        static void Main(string[] args)
        {
            Car c = new Car();

            c.ModelNo = 1;
            c.carname = "Harrier";
            c.carcolor = "black";
            c.price = 1500000;

            Console.WriteLine(c.ModelNo+" "+c.carname+" "+c.carcolor+" "+c.price);


            Car c1 = new Car();

            c1.ModelNo = 2;
            c1.carname = "Fortuner";
            c1.carcolor = "White";
            c1.price = 3000000;

            Console.WriteLine(c1.ModelNo + " " + c1.carname + " " + c1.carcolor + " " + c1.price);



            Car c2 = new Car();

            c2.ModelNo = 3;
            c2.carname = "Endaviour";
            c2.carcolor = "Black";
            c2.price = 3500000;

            Console.WriteLine(c2.ModelNo + " " + c2.carname + " " + c2.carcolor + " " + c2.price);

        }
    }
}
