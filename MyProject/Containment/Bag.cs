using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Containment
{
    class Nib
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Pen
    {
        string pname;
        string color;
        Nib n;

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Nib N
        {
            get { return n; }
            set { n = value; }
        }
    }
    class Bag
    {
        string color;
        string brandname;
        int price;
        Pen p;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Brandname
        {
            get { return brandname; }
            set { brandname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }


        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.Color = "red";
            b.Brandname = "Skybag";
            b.Price = 1000;
            b.p = new Pen();
            b.p.Pname = "Marker";
            b.p.Color = "Blue";
            b.p.N = new Nib();
            b.p.N.Type = "Metal";

            Console.WriteLine(b.Color + " " + b.Brandname + " " + b.Price + " " + b.p.Pname + " " + b.p.Color+" "+b.p.N.Type);
        }
    }
}
