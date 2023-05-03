using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileHandling
{
    internal class FileInfo1
    {
        public static void Main()
        {
            { 
                FileInfo fs = new FileInfo("C:\\\\Users\\\\anami\\\\Svam\\b.txt")'
                    fs.Create();
                


            File.Create("C:\\Users\\anami\\Svam\\C#\\Day7\\b.txt");
            /*File.Delete(*/
            Console.WriteLine("MAin STarted");
            Directory.CreateDirectory("C:\\Users\\anami\\Svam\\C#\\Day7\\folder1");
            string[] list = Directory.GetFiles("C:\\Users\\anami\\Svam\\Day1");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Directory.GetCreationTime("C:\\Users\\anami\\Svam");


        }
         
    }
}
