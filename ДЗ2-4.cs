using System;

namespace ДЗ2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Брекун Ольга Игоревна";
            int num = 12345;
            DateTime DateN = DateTime.Now;
            string date = DateN.ToString("dddd, dd MMMM yyyy HH:mm:ss");

            string product1 = "Тофу \"Итальянский\". шт.";
            int product1koll = 2;
            float product1Pr = 170f;

            string product2 = "Плов с курицей. шт.";
            int product2koll = 1;
            float product2Pr = 156f;


            string product3 = "Закуска \"Закарпатская\". шт.";
            int product3koll = 2;
            float product3Pr = 85f;


            string product4 = "Салат \"Крабовый\". шт.";
            int product4koll = 1;
            float product4Pr = 168f;


            string product5 = "Салат\"Мимоза\". шт.";
            int product5koll = 3;
            float product5Pr = 138f;




            Console.WriteLine($"{"",40} КАССОВЫЙ ЧЕК");
            Console.WriteLine($"{name,57}");
            Console.WriteLine($"{"",38} ПРОДАЖА № {num}");
            Console.WriteLine($"{date,59}");
            Console.WriteLine($"{"___________________________________________________",71}");

            
            Console.WriteLine(String.Format("{0,-10} Товар: {1,-30} {2,5:F1} * {3,5:F2} = {4,5:F2}", "", product1, product1koll, product1Pr, product1koll * product1Pr));
            Console.WriteLine(String.Format("{0,-10} Товар: {1,-30} {2,5:F1} * {3,5:F2} = {4,5:F2}", "", product2, product2koll, product2Pr, product2koll * product2Pr));
            Console.WriteLine(String.Format("{0,-10} Товар: {1,-30} {2,5:F1} * {3,5:F2} = {4,5:F2}", "", product3, product3koll, product3Pr, product3koll * product3Pr));
            Console.WriteLine(String.Format("{0,-10} Товар: {1,-30} {2,5:F1} * {3,5:F2} = {4,5:F2}", "", product4, product4koll, product4Pr, product4koll * product4Pr));
            Console.WriteLine(String.Format("{0,-10} Товар: {1,-30} {2,5:F1} * {3,5:F2} = {4,5:F2}", "", product5, product5koll, product5Pr, product5koll * product5Pr));



            Console.WriteLine($"{"___________________________________________________",71}");


            float summ = (product1koll * product1Pr) + (product2koll * product2Pr) + (product3koll * product3Pr) + (product4koll * product4Pr) + (product5koll * product5Pr);
            Console.WriteLine($"{"",57} ИТОГО: {summ:F2}");

            Console.ReadKey();
        }
    }
}
