using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.IO;
using ProductProcessing.Databases;
using CsvHelper.Configuration;
using System.Globalization;
using System.Linq;

namespace ProductProcessing
{
	public class fileProcessor
	{
		public string filepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Product.csv";
		string Categoryfilepath = @"C:\Users\s s infotech\source\repos\ProductCatalogNew\ProductCatalogNew\Category.csv";
		public static List<BasicProduct> productList = new List<BasicProduct>();
		public static List<Category> CatList = new List<Category>();

		public void getFilePath()
		{
			
		}
		public void process(string filepath, List<BasicProduct> CSVproductList)
		{

			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,



			};

			using (StreamWriter writer = new StreamWriter(filepath, false))
			using (CsvWriter csvwriter = new CsvWriter(writer, config))
			{
				csvwriter.WriteRecords(CSVproductList);
			}
			//	foreach (BasicProduct b in CSVproductList)
			//		Console.WriteLine(b.Name);
			//if (File.Exists(filepath))
			//{
			//	Console.WriteLine("file do exist");
			//	string fileHeader = "ProductCode" + "," + "Name" + "," + "categoryCode" + "," + "Manufacturer" + "," +
			//		"ManufacturingDate" + "," + "Amount" + "," + "ExpiryDate" + "\n";
			//	File.WriteAllText(filepath, fileHeader);
			//}
			//bool empty;
			//if (File.ReadAllText(filepath) == "")
			//{
			//	empty = true;
			//}
			//else empty = false;


			//	using (StreamWriter writer = new StreamWriter(filepath, true))
			//	{
			//		foreach (BasicProduct b in CSVproductList)
			//		{
			//			writer.WriteLine(b.ProductCode + "," + b.Name + "," + b.categoryCode + "," +
			//				b.Manufacturer + "," + b.ManufacturingDate + "," + b.Amount + "," + b.ExpiryDate);
			//		}
			//	}


		}


		public void categoryWriteprocess(string Categoryfilepath, List<Category> CSVcategoryList)
		{

			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,



			};

			using (StreamWriter writer = new StreamWriter(Categoryfilepath, false))
			using (CsvWriter csvwriter = new CsvWriter(writer, config))
			{
				csvwriter.WriteRecords(CSVcategoryList);
			}
			


		}

		public List<BasicProduct> showFileData(string filepath)
		{
			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,
			};


			using (StreamReader read = new StreamReader(filepath))
			using (CsvReader csvreader = new CsvReader(read, config))
			{
				productList = csvreader.GetRecords<BasicProduct>().ToList();
			}

			return productList;




		}

		public List<Category> showCategoryData(string Categoryfilepath)
		{
			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,
			};


			using (StreamReader read = new StreamReader(Categoryfilepath))
			using (CsvReader csvreader = new CsvReader(read, config))
			{
				CatList = csvreader.GetRecords<Category>().ToList();
			}

			return CatList;




		}

		public void AddproductToFile(BasicProduct product)
		{
			bool append = true;
			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,
				HasHeaderRecord = !append,
			};
			using (var writer = new StreamWriter(filepath, append))
			using (CsvWriter csvwriter = new CsvWriter(writer, config))
			{
				csvwriter.NextRecord();
				csvwriter.WriteRecord(product);
				Console.WriteLine("SuccessFully Added");
			}
			listAll();

		}

		public void AddCategoryToFile(Category cat)
		{
			bool append = true;
			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,
				HasHeaderRecord = !append,
			};
			using (var writer = new StreamWriter(Categoryfilepath, append))
			using (CsvWriter csvwriter = new CsvWriter(writer, config))
			{
				
				csvwriter.WriteRecord(cat);
				Console.WriteLine("SuccessFully Added");
			}
			showCategoryData(Categoryfilepath);
			listAllCategory();

		}



		public void deleteRecordfromFileById(int id)
		{
			BasicProduct prod = productList.Single(x => x.ProductCode == id);
			productList.Remove(prod);

			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,



			};

			using (StreamWriter writer = new StreamWriter(filepath, false))
			using (CsvWriter csvwriter = new CsvWriter(writer, config))
			{
				csvwriter.WriteRecords(productList);
			}
			listAll();


		}




		public void deleteRecordfromCategoryFileById(int id)
		{
			Category cat = CatList.Single(x => x.CategoryId == id);
			CatList.Remove(cat);

			CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				TrimOptions = TrimOptions.Trim,
				Comment = '@',
				AllowComments = true,



			};

			using (StreamWriter writer = new StreamWriter(Categoryfilepath, false))
			using (CsvWriter csvwriter = new CsvWriter(writer, config))
			{
				csvwriter.WriteRecords(CatList);
			}
			listAllCategory();


		}

		public BasicProduct searchFromFileById(int id) {
			BasicProduct prod = productList.Single(x => x.ProductCode == id);
			return prod;


		}

		public Category searchFromCategoryById(int id)
		{
			Category cat = CatList.Single(x => x.CategoryId == id);
			return cat;


		}

		public void listAll() 
		{
			Console.WriteLine("Code\t\tName\t\tManufacturer\t\tManufacturingDate\t\tExpiryDate\t\tAmount");
			productList.ForEach(x => Console.WriteLine(x.ProductCode + "\t\t" + x.Name + "\t\t" + x.Manufacturer + "\t\t\t"
					+ x.ManufacturingDate + "\t\t\t" + x.ExpiryDate + "\t\t" + x.Amount));
		}

		public void listAllCategory()
		{
			Console.WriteLine("Category Code\t\tshort Code\t\t");
			CatList.ForEach(x => Console.WriteLine(x.CategoryId + "\t\t" + x.shortcode));
		}
	}

}