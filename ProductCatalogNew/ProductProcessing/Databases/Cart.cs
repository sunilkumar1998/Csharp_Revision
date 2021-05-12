using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing.Databases
{
	class Cart
	{
      
        public List<String> productName = new List<string>();
        public int orderID { get; set; }
        public static decimal totalPrice { get; set; }
        private static int genereateID { get; set; }
        public Cart(string productName, decimal price)
        {
            genereateID++;
            this.productName.Add(productName);
            Cart.totalPrice += price;
            this.orderID = genereateID;

        }

        public Cart()
        {
        }

        public void calculateOrder()
        {
            //if (totalPrice == 0)
            //{
            //    Console.WriteLine("Cart is Empty");
            //    Console.WriteLine("wanted to add ....(y/n)");
            //    string ch = Console.ReadLine();
            //    if (ch == "y" || ch == "Y")
            //    {
            //        RepoDb rp = new RepoDb();
            //        CustomerSubMenu customerSubMenuList = new CustomerSubMenu();
            //        customerSubMenuList.DrawSubMenu(rp._inventory);

            //    }
            //    else Console.Clear();

            //}
            //Console.WriteLine("Net Payable Amount: Rs" + totalPrice);

            //long finalAmount;
            //foreach (var o in RepoDb.orderList)
            //{
            //    o
            //    }

        }
    }
}

