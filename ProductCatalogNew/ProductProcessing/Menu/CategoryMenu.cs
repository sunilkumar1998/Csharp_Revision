using ProductProcessing.Databases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing.Menu
{
	class CategoryMenu
	{
        string filepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Product.csv";
        fileProcessor fpObj = new fileProcessor();
        public void DoCategoryOperations(int input)
        {
            string Categoryfilepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Category.csv";

            if (input == 1)
            {
                Console.WriteLine("Category Details");
                Category cat = new Category();
                Console.WriteLine("Enter category Code\n");
                cat.CategoryId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter short Code\n");
                cat.shortcode = Console.ReadLine();
                

                fpObj.AddCategoryToFile(cat);

                //rp.Add<BasicProduct>(prod);

                //rp.GetAll(typeof(BasicProduct));


            }


            else if (input == 2)
            {
                fpObj.listAllCategory();
            }

            else if (input == 3)
            {


                bool found1 = false;
                Console.WriteLine("Enter Category Id You want to Remove\n");
                int id = Convert.ToInt32(Console.ReadLine());
                fpObj.deleteRecordfromCategoryFileById(id);
                Console.WriteLine("Successfully deleted");

            }

            else if (input == 4)
            {


                bool found1 = false;
                Console.WriteLine("Enter category Id You want to Search\n");
                int id = Convert.ToInt32(Console.ReadLine());
                Category x = fpObj.searchFromCategoryById(id);
                Console.WriteLine("Category Code\t\tshort Code\t\t");
               
                Console.WriteLine(x.CategoryId + "\t\t" + x.shortcode );
            }
        }
    }
}
