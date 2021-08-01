using System;

namespace ДЗ3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "Hello World!";
            Console.WriteLine();

            for (int i = stroka.Length - 1; i >= 0; i--)
            {
                Console.Write(stroka[i]);

            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
