using System;
using System.IO;

namespace DirectoryFileInfo
{
	class Program
	{
		static void Main(string[] args)
		{
            
			string filepath = @"C:/Users/s s infotech/source/repos/DirectoryFileInfo/DirectoryFileInfo/csvData.txt";
            string filepath1 = @"C:/Users/s s infotech/source/repos/DirectoryFileInfo/DirectoryFileInfo/csvData1.txt";
            string dirPath = @"C:/Users/s s infotech/source/repos/DirectoryFileInfo/DirectoryFileInfo";
            //CsvData.createCsvFile(dirPath);
           CsvData.writeCsvData(dirPath);
            string filedata = "abcdkfjdlkflkfd";
            //addRecord(filedata, filepath);
            //readRecord(filepath);
            Console.WriteLine("Get Current directory ");
            Console.WriteLine(Directory.GetCurrentDirectory());//
                                                               //return absolute path of the
                                                               //current working direcitory 
            Console.WriteLine(" directory Exist  ");
            Console.WriteLine(Directory.Exists(dirPath));//
                                                         //return true if provided directory  exist

            
            Console.WriteLine("CreateDirectory ");
            Console.WriteLine(Directory.CreateDirectory("C:/sunil"));// creates a new directory on the specified location

            //Console.WriteLine("Delete Directory ");
            //Directory.Delete("C:/sunil");
            DateTime creat_time = new DateTime(2019, 05, 09, 09, 15, 00);
          
            Console.WriteLine("Delete Directory ");

            Directory.SetCreationTime("C:/sunil",creat_time);
            Console.WriteLine(Directory.GetCreationTime("C:/sunil"));

            //Console.WriteLine( Directory.GetDirectoryRoot(dirPath));

            //string[] str= Directory.GetFileSystemEntries("C:/"); //return all available directories instring array.
            //foreach (var s in str) {
            //    Console.WriteLine(s);
            //}

            File.WriteAllText(filepath, "I can do this all day");// override the old data with new
            Console.WriteLine(File.ReadAllText(filepath));

            File.Create(dirPath + "/xyz.txt");

            //var fi1 = new FileInfo(filepath);
            var fi2 = new FileInfo(filepath1);
            Console.WriteLine(fi2.FullName);
            Console.WriteLine(fi2.Name);
            Console.WriteLine(fi2.Length);
            Console.WriteLine(fi2.DirectoryName);
            using (StreamWriter file = fi2.AppendText())
            {
                file.Write("Saini");
            }
        }

        public static void readRecord( string filepath) {
            using (StreamReader read = new StreamReader(filepath))
            {
                if (!File.Exists(filepath)) {
                    Console.WriteLine("File not found");
                    return;
                }
                while (!read.EndOfStream){

                    string readtoConsole = read.ReadLine();
                    Console.WriteLine(readtoConsole);
                } }
            
            
        }

        public static void addRecord(  string filedata,string filepath)
        {
            using (StreamWriter file = new StreamWriter(filepath, true))
            {
                file.WriteLine(filedata);
            }
        }

       
    }
}
