using System;

namespace ДЗ_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] massPhonebook = { { "Саша", "8-495-211-35-66" },
                {"Таня", "8-495-333-45-67"},
                {"Вася", "8-916-093-54-32"},
                {"Катя", "8-917-234-65-98" },
                {"Дима", "8-926-248-57-32"} };

            Console.WriteLine("Phonebook:");
            for (int i = 0; i < massPhonebook.GetLength(0); i++)
            {

                Console.WriteLine($"{massPhonebook[i, 0]}: {massPhonebook[i, 1]}");
            }
            Console.ReadKey();
        }
    }
}
