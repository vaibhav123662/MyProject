using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Containment
{
    class Address
    {
        int pincode;
        string city;

        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
    class Person
    {
        int id;
        string name;
        Address addr;

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
        public Address Addr
        {
            get { return addr; }
            set { addr = value; }
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 101;
            p.Name = "Vaibhav";
            p.Addr = new Address();

            p.Addr.Pincode = 414303;
            p.Addr.City = "Ahmednagar";

            Console.WriteLine(p.Id+" "+p.Name+" "+p.Addr.Pincode+" "+p.Addr.City);
        }
    }
}
