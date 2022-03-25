using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H1_Mehtods_Files_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            string search = "";
            string file = "";
            int menu = 0;

            do
            {
                switch (menu)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine
                        (
                         "============================================\n" +
                         "                H1 Queue Operation Menu     \n" +
                        "============================================\n" +
                        "1. Add File " +
                        "\n2. Delete file " +
                        "\n3. Display files" +
                        "\n4. Add folder " +
                        "\n5. Search for file in folder " +
                        "\n6. Exit\n" +
                        "\nEnter your choice"       
                        );
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Where should the file be located");
                        path = Console.ReadLine();
                        Console.WriteLine("What should the file be called?");
                        file = Console.ReadLine();
                        CreateFile(file, path);
                        Console.WriteLine("File " + file + " Has been created");
                        Console.WriteLine("0. Back to menu "+"6. Exit Program");
                        menu = int.Parse(Console.ReadLine());

                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.WriteLine("What file do you want to delete?");
                        file = Console.ReadLine();
                        DeleteFile(file);
                        Console.WriteLine("0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.WriteLine("What folder do you want to look through? ");
                        path = @"" + Console.ReadLine();
                        Console.WriteLine("All files in "+ path+" shown down bellow");
                        Enumeratiton(path);
                        Console.WriteLine("0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                        Console.WriteLine("What should the folder be called?");
                        string newFolder = Console.ReadLine();
                        CreateFolder(newFolder);
                        Console.WriteLine("0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());

                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Where is the file located");
                        path = Console.ReadLine();
                        Console.WriteLine("What is the file called");
                        search = Console.ReadLine();
                        SearchFile(path, search);
                        Console.WriteLine("0. Back to menu " + "6. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;

                }
            }while(menu != 6);
        }
        public static void CreateFile(string file,string path)
        {
            
            File.WriteAllText($@"{path}\{file}", "");
        }
        public static string[] Enumeratiton(string path)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
            return files;
        }
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
        public static void CreateFolder(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
        }
        public static string [] SearchFile(string path, string search)
        {
            string[] files = Directory.GetFiles(path, search+"*", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
            return files;
        }
    }
}
