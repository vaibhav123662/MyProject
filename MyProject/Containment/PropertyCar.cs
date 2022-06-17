using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Containment
{
    class Engine
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class PropertyCar
    {
        int modelno;
        string name;
        int price;
        Engine eng;

        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Engine Eng
        {
            get { return eng; }
            set { eng = value; }
        }


        static void Main(string[] args)
        {
            PropertyCar c = new PropertyCar();
            c.Modelno = 101;
            c.Name = "Mercedes";
            c.Price = 9000000;
            c.Eng = new Engine();

            c.Eng.Type = "Petrol";

            Console.WriteLine(c.Modelno + " " + c.Name + " " +c.Price+" "+ c.Eng.Type);
        }
    }
}
