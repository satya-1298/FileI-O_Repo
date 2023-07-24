using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            File_Operations file_Operations = new File_Operations();
            while (true)
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1-Check File Exists");
                Console.WriteLine("2-Read all the lines from File");
                Console.WriteLine("-----------------------------------------");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        file_Operations.Check();
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case 2:
                        file_Operations.ReadAll_Line();
                        Console.WriteLine("-----------------------------------------");
                        break;
                    
                }
            }
        }
    }
}
