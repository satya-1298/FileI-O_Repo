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
       
    }
}
