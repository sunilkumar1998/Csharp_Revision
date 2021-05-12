using ProductProcessing.Databases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing.Menu
{
    class InventoryMenu
    {
        string filepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Product.csv";
        fileProcessor fpObj = new fileProcessor();
        public void DoOperations(int input, List<BasicProduct> productList)
        {
            string filepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Product.csv";

            if (input == 1)
            {
                Console.WriteLine("Product Details");
                BasicProduct prod = new BasicProduct();
                Console.WriteLine("Enter Product Code\n");
                prod.ProductCode = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter category Code\n");
                prod.categoryCode = Console.ReadLine();
                Console.WriteLine("Enter Product Name\n");
                prod.Name = Console.ReadLine();

                Console.WriteLine("Enter Product manufacturer\n");
                prod.Manufacturer = Console.ReadLine();

                Console.WriteLine("Enter Product Manufacturing Date\n");
                prod.ManufacturingDate = Console.ReadLine();

                Console.WriteLine("Enter Product Expiry date\n");
                prod.ExpiryDate = Console.ReadLine();

                Console.WriteLine("Enter Product Amount\n");
                prod.Amount = Convert.ToInt32(Console.ReadLine());


                fpObj.AddproductToFile(prod);

                //rp.Add<BasicProduct>(prod);
                
                //rp.GetAll(typeof(BasicProduct));


            }


            else if (input == 2)
            {
                fpObj.listAll();
            }

            else if (input == 3)
            {

                
                    bool found1 = false;
                    Console.WriteLine("Enter User Name You want to Remove\n");
                    int id = Convert.ToInt32(Console.ReadLine());
                    fpObj.deleteRecordfromFileById(id);
                    Console.WriteLine("Successfully deleted");
                
            }

            else if (input == 4)
            {

             
                    bool found1 = false;
                    Console.WriteLine("Enter User Name You want to Search\n");
                    int id = Convert.ToInt32(Console.ReadLine());
                    BasicProduct x=fpObj.searchFromFileById(id);
                Console.WriteLine("Code\t\tName\t\tManufacturer\t\tManufacturingDate\t\tExpiryDate\t\tAmount");
                Console.WriteLine(x.ProductCode + "\t\t" + x.Name + "\t\t" + x.Manufacturer + "\t\t\t"
                                + x.ManufacturingDate + "\t\t\t" + x.ExpiryDate + "\t\t" + x.Amount);
            }
        }
    }
}
