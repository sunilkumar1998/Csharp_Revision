using ProductProcessing.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductProcessing.Menu
{
    public class CustomerSubMenu
    {
        string filepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Product.csv";
        fileProcessor fp = new fileProcessor();
        Boolean check = true;
        public bool DrawSubMenuItem() {
            fp.listAll();

            
            return true;

        }
    }  public class CustomerMenu
        { 
        

       
        internal void DrawMenu()
        {
            Console.WriteLine("***  MENU  ***");
            Console.WriteLine("1.   Category");
            Console.WriteLine("2.   Product");

            Console.WriteLine("Press 3 to go back");

            MenuManager menuobj = new MenuManager();
            menuobj.UserInput();
           
        }
    }
}
