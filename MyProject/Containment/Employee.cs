using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Containment
{
    class Department
    {
        public int did;
        public string dname;

        public Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }
        public void show()
        {
            Console.WriteLine(did+"  "+dname);
        }
    }
    class Employee
    {
        int eid;
        string ename;
        Department dept;

        Employee(int eid,string ename,Department dept)
        {
            this.eid = eid;
            this.ename = ename;
            this.dept = dept;
        }

        void Display()
        {
            Console.WriteLine(eid+" "+ename+" ");
            dept.show();
        }

        static void Main(string[] args)
        {
            /*            Department d = new Department(1,"Sales");
                        Employee e = new Employee(101, "Vaibhav", d);
                        Console.WriteLine(d);*/

            Employee e = new Employee(101, "vaibhav", new Department(1, "Sales"));
            e.Display();
        }
    }
}
