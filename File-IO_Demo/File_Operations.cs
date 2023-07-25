using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Demo
{
    public class File_Operations
    {
        public string path = @"C:\Users\PC\Desktop\RFP288\FileI-O_Repo\File-IO_Demo\File\Satya.txt";
        public void Check()
        {
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
        public void ReadAll_Line()
        {
            //ReadAllLines-Used to open a text file then it will read all the lines in to a
            ////string array and then close the file.
            string[] lines = File.ReadAllLines(path);
            {
                Console.WriteLine(lines[0]); //Read only the indexed line
                Console.WriteLine("-----------------------------------------------");
            }
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public void ReadAll_Text()
        {
            //ReadAllText- used to open text file then it will read all the lines at a time with out help of array
            string lines=File.ReadAllText(path);
            {
                Console.WriteLine(lines);
            }
        }
        public void Copy_File()
        {
            string copyPath = @"C:\Users\PC\Desktop\RFP288\FileI-O_Repo\File-IO_Demo\File\Sai.txt";
            File.Copy(path, copyPath);
            Console.WriteLine("File is copied");

        }
        public void Delete_File()
        {
            string copyPath = @"C:\Users\PC\Desktop\RFP288\FileI-O_Repo\File-IO_Demo\File\Sai.txt";
            File.Delete(copyPath);
            Console.WriteLine("File Deleted");
        }
    }
}
