using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Создать новый файл и запишите в него 10 случайных чисел
        string filePath = "randomNumbers.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(1, 100);
                writer.WriteLine(number);
            }
        }

        // Считайте числа из файла и вычислить сумму
        int sum = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                int number = int.Parse(reader.ReadLine());
                sum += number;
            }
        }

        // Выведите сумму на консоль
        Console.WriteLine("Sum: " + sum);
        Console.ReadLine();
    }
}
