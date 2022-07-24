using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace MyProject.Training
{
    class CollectionDemo
    {
        //Non Generic
        class K
        {
            private object obj;
            public object Obj { get => obj; set => obj = value; }
        }

        //Generic
        class kk<T>
        {
            private T obj;
            public T Obj { get => obj; set => obj = value; }
        }
        static void Main(string[] args)
        {
            kk<string> obj = new kk<string>();
            obj.Obj = "hello";
            string s = obj.Obj;

            K k = new K();
            k.Obj = "hhhhhh";
            k.Obj = 90;

            //casting 
            int m = (int)k.Obj;

        }
    }


    class CollectionDemo1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(12);
            al.Add("Omkar");
            al.Add(true);
            al.Add(new StringBuilder("Vaibhav"));
                
            foreach(object ob in al)
            Console.WriteLine(ob);
            /*
            for(int i=0;i<al.Count;i++)
                Console.WriteLine(al[i]);*/
        }
    }




    class ListDemo
    {
        static void Main(string[] args)
        {


            List<string> l2 = new List<string> () { "Vaibhav","Rohit","Mahesh"};

            List<string> lst= new List<string>();
           
            //Add always add elements to the last
            lst.Add("om");
            lst.Add("ram");


            //it add the data where you put the method
            lst.AddRange(l2);

            //InsertRange(index,listdata) or insert the data to the index and shift the data forward 
            lst.InsertRange(2, l2);
            
            lst.Add("sam");
            lst.Add("raman");
            lst.Add("om");
            lst.Add("om");

            //Remove take data and remove the first occurance of object from list
            //          lst.Remove("om");

            //Remove take index
            //            lst.RemoveAt(1);

            //Insert(index,"string")
            lst.Insert(2, "chitra");

            //convert the string to array
           string[] str = lst.ToArray();

            int idx = lst.IndexOf("p");
            int idx2 = lst.LastIndexOf("om");

            //Contain have bool return type and checks the data present or not and return true and false
            Console.WriteLine(lst.Contains("KAVITA"));




           // Console.WriteLine(idx+ " " +idx2);
            for(int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }
        }
    }




    class A
    {
        static bool isOdd(int n)
        {
            return n % 2 == 1;
        }


        static void Main(string[] args)
        {
            List<string> l2 = new List<string>() { "Vaibhav", "Rohit", "Mahesh" ,"Kiran"};
            l2.Sort();
            l2.Reverse();

            foreach (string s in l2)
                Console.WriteLine(s);




            List<int> l3 = new List<int>() { 23, 44, 56, 77, 89, 90, 35 };
            //List<int> oddList = l3.FindAll(isOdd);
            List<int> oddList = l3.FindAll((n) => n % 2 == 1);


            foreach (int s1 in oddList)
                Console.WriteLine(s1);
        }
    }




    class Student:IComparable<Student>
    {
        string name;
        int percent;
        string qualification;

        public Student(string name, int percent, string qualification)
        {
            this.Name = name;
            this.Percent = percent;
            this.Qualification = qualification;
        }
        public override string ToString()
        {
            return "name=" + name + " Percentage=" + percent + " Education=" + qualification;
        }

        public int CompareTo(Student other)
        {
            return this.percent.CompareTo(other.percent);
        }

        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string Qualification { get => qualification; set => qualification = value; }
    
        static void Main(string[] args)
        {
            List<Student> slist = new List<Student>();
            slist.Add(new Student("Vaibhav", 90, "MCS"));
            slist.Add(new Student("rohit", 93, "Mcom"));
            slist.Add(new Student("mahesh", 88, "B.Pharm"));
            slist.Add(new Student("kiran", 93, "msc"));
            slist.Add(new Student("Sohel", 89, "Foodtech"));


            //List<Student> ss = slist.FindAll(sobj => sobj.percent > 90);

            /*foreach (Student s in slist)
            {
                if (s.percent > 90)
                {
                    Console.WriteLine(s.name + " " + s.percent + " " + s.qualification);
                }
            }*/

            slist.Sort();

            slist.ForEach(s1 => Console.WriteLine(s1));


            /*string[] arr = { "vaibhav", "rohit", "mahesh", "sohel" };
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        //swap
                    }
                }
            }*/


        }
    }



    //stack- Last in first out
    //queue- first in first out
    class C
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(102);
            st.Push(103);
            st.Push(104);

            Console.WriteLine("After push");
            foreach(int data in st)
                Console.WriteLine(data);

            int val=st.Pop();
            //st.Pop();

            //st.Peek();
            
            Console.WriteLine("After Pop");
            Console.WriteLine("Remove element is="+val);
            
            foreach(int data in st)
                Console.WriteLine(data);
        }
    }


    //Linked List :-
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            //node type of object
            //node- data + address of next element

            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddFirst(97);
            ll.AddFirst(98);

            LinkedListNode<int> n1= ll.Find(100);
            ll.AddAfter(n1,150);
            ll.AddBefore(n1, 149);
            ll.Remove(150);
            
            foreach(int data in ll)
                Console.WriteLine(data);

        }
    }



    class Dept
    {
       public string dname;
    }
    class Employee
    {
        string ename;
        Dept d;
        Employee next;


        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.ename = "Vaibhav";

            Employee e2 = new Employee();
            e2.ename = "Rohit";

            e1.next = e2;
            //e.d = new Dept();
            //e.d.dname = "IT";
        }
    }
}






