using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPs
{
    class ShoppingThis
    {
        string purchaseitem;
        int priceperitem;
        int quantity;

        int totalbill;

        public void Accept()
        {
            purchaseitem = "Laptop";
            priceperitem = 30000;
            quantity = 2;

        }

        public void getBill()
        {
            
            if (quantity > 0)
            {
                totalbill = quantity * priceperitem;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public void ShowBill()
        {
            Console.WriteLine("Purchase Item = " +purchaseitem);
            Console.WriteLine("Price of Item = " +priceperitem);
            Console.WriteLine("Quantity of Item = " +quantity);
            Console.WriteLine("Total Bill is = " +totalbill);
        }

        static void Main(string[] args)
        {
            ShoppingThis s = new ShoppingThis();

            s.Accept();
            s.getBill();
            s.ShowBill();
        }
    }
}
