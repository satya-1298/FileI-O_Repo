﻿using System;
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
                Console.WriteLine("3-Read all the text");
                Console.WriteLine("4-Copy file");
                Console.WriteLine("5-Delete a file");
                Console.WriteLine("6-Read using Stream Reader");
                Console.WriteLine("7-Write using Stream Writer");
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
                    case 3:
                        file_Operations.ReadAll_Text();
                        Console.WriteLine("------------------------------------------");
                        break;
                    case 4:
                        file_Operations.Copy_File();
                        Console.WriteLine("------------------------------------------");
                        break;
                    case 5:
                        file_Operations.Delete_File();
                        Console.WriteLine("--------------------------------------");
                        break;
                    case 6:
                        file_Operations.ReadFrom_StreamReader();
                        Console.WriteLine("----------------------------------");
                        break;
                    case 7:
                        file_Operations.WriteFrom_StreamWriter();
                        Console.WriteLine("------------------------------------");
                        break;

                }
            }
        }
    }
}
