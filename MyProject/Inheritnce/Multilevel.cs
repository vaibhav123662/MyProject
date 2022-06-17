using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Inheritnce
{
    class Car
    {
        public string type = "car";
        
    }
    class Maruti : Car
    {
        public string brand = "maruti";
        public string speed = "90kmph";
    } 
    class Maruti800:Maruti 
    {
        public int model = 800;
        

        public void show()
        {
            Console.WriteLine(type+" "+ brand + " "+ speed +" " + model);
        }
    }
    class Multilevel
    {
        static void Main(string[] args)
        {
            Maruti800 m = new Maruti800();
            m.show();
        }
    }
}
