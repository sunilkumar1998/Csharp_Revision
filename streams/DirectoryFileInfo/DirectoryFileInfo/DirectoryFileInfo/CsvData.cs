using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DirectoryFileInfo
{
    public class CsvData
    {
        
        public static void createCsvFile(string dirPath)
        {
            //File.Create("csvData.csv");
            File.Create(dirPath +"/csvdata.csv");
        }
        
        public static void writeCsvData(string dirPath)
        {
            string filePath = dirPath + "/csvdata.csv";
            //using (StreamWriter file = new StreamWriter(filePath, true))
            //{

            string filerow = "\n" + "2" + "," + "Pencil" + "," + "1000";
                    
                    if(!File.Exists(filePath))
                    {
                    string fileHeader = "Id" + "," + "Name" + "," + "Price";
                    File.WriteAllText(filePath, fileHeader);
                    Console.WriteLine("heelo csv");
                    }
           
                File.AppendAllText(filePath, filerow);
                
            //}
        }
    }
}
