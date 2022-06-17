using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Containment
{
    class Carengine
    {
        
        public string type;

        public Carengine(string type)
        {
            this.type = type;
        }
        public void show()
        {
            Console.WriteLine(type);
        }
    }
    class ConstructorCar
    {
        int modelno;
        string name;
        int price;
        Carengine eng;

        ConstructorCar(int modelno, string name,int price, Carengine eng)
        {
            this.modelno = modelno;
            this.name = name;
            this.price = price;
            this.eng = eng;
        }

        void Display()
        {
            Console.WriteLine(modelno + " " + name + " "+price+" ");
            eng.show();
        }

        static void Main(string[] args)
        {

            ConstructorCar c = new ConstructorCar(101, "Mercedes",1200000, new Carengine("Petrol"));
            c.Display();
        }
    }
}
