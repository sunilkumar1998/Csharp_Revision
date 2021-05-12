using ProductProcessing.Auth;
using ProductProcessing.Databases;
using ProductProcessing.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing
{
	public class MenuManager
	{
        CustomerMenu cm = new CustomerMenu();
        string Categoryfilepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Category.csv";
        public MenuManager()
		{
		}

		public MenuManager(int choice)

        {
            if (choice == 1)
            {  AuthManager.AcceptLoginCreds();
            }
            else if (choice == 2)
            {
                // AuthManager.addUser();

            }

        }

        public bool CreateMenu(string menuType)
        { //InventoryMenu IObj = new InventoryMenu();

            if (menuType == "customer")
            {
                cm.DrawMenu();
                return true;

            }
            else if (menuType == "manager")
            {
                Inventorymenu();
            }
            return true;
        }


        public void UserInput()
        {
            string filepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Product.csv";
            fileProcessor fp = new fileProcessor();
            CustomerSubMenu cm = new CustomerSubMenu();
            
            string UserInput = Console.ReadLine();
            if (UserInput == "1")
            {
                fp.categoryWriteprocess(Categoryfilepath, Category._category);
                Categorymenu();

            }
            else if (UserInput == "2")
            {
                fp.process(filepath, BasicProduct._products);
               
                Inventorymenu();
               
            }
            else if (UserInput == "3")
            {
                Console.Clear();
            }
        }

		private void Categorymenu()
		{
            CategoryMenu catobj = new CategoryMenu();
            Console.WriteLine("Category \n");
            string Categoryfilepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Category.csv";
            fileProcessor fp = new fileProcessor();

            List<Category> catList = fp.showCategoryData(Categoryfilepath);
            fp.listAllCategory();

            Console.WriteLine("Select any one operation\n");
            Console.WriteLine("1.  Enter a Category\n2.  ListAll Categories\n3.  REMOVE \n4.  Search by Id");
            int input = Convert.ToInt32(Console.ReadLine());
            catobj.DoCategoryOperations(input);
        }

		public void Inventorymenu()
        {
            InventoryMenu Iobj = new InventoryMenu();
            Console.WriteLine("products \n");
            string filepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Product.csv";
            fileProcessor fp = new fileProcessor();
            
                List<BasicProduct> productList = fp.showFileData(filepath);
            fp.listAll();

                Console.WriteLine("Select any one operation\n");
            Console.WriteLine("1.  Add\n2.  ListAll Products\n  3.REMOVE \n4.  Search by Id");
            int input = Convert.ToInt32(Console.ReadLine());

            Iobj.DoOperations(input, productList);

        }

    }
}
