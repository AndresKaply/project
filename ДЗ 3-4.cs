using System;

namespace Морской_бой
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] massSea_battle = {
                {'X','X','O','X','O','O','X','X','X','X'},
                {'O','O','O','X','O','O','O','O','O','O'},
                {'O','O','O','X','O','O','O','O','O','X'},
                {'O','O','O','O','O','O','O','O','O','X'},
                {'O','X','O','O','O','O','O','O','O','O'},
                {'O','X','O','O','O','X','O','O','O','O'},
                {'O','X','O','O','O','O','O','O','O','O'},
                {'O','O','O','O','O','O','O','O','O','O'},
                {'O','O','O','X','O','X','O','O','X','O'},
                {'X','O','O','O','O','O','O','O','X','O'}};


            Console.WriteLine("\"Sea Battle\"");
            for (int i = 0; i < massSea_battle.GetLength(0); i++)
            {
                for (int j = 0; j < massSea_battle.GetLength(1); j++)
                {
                    Console.Write($"{massSea_battle[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}