using System;
using System.IO;

namespace Lab_8СамРабота._Работа_с_файловой_системой
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каталог, место на диске:");
            string path = Console.ReadLine();
            PrintDirectoryContents(path);
            Console.ReadLine();
        }

        static void PrintDirectoryContents(string path)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                Console.WriteLine("Каталог: " + path);
                Console.WriteLine("Файлы:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine("Подкаталоги:");
                foreach (string subDirectory in subDirectories)
                {
                    Console.WriteLine(subDirectory);
                    PrintDirectoryContents(subDirectory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Не верный путь Каталогу'{0}'.", path);
            }
        }
    }
}

            