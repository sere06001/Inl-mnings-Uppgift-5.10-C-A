using System;
namespace Uppgift5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 1, 2, 3, 4, 4, 9, 9, 5, 9};
            int maxantal = 0;
            int mestFrekventTal = 0;
            for (int i = 0; i < tal.Length; i++)
            {
                int antal = 0;
                for (int j = 0; j < tal.Length; j++)
                {
                    if (tal[i] == tal[j])
                    {
                        antal++;
                    }
                }

                if (antal > maxantal)
                {
                    maxantal = antal;
                    mestFrekventTal = tal[i];
                }
            }
            Console.WriteLine("Följande tal är vanligast: "+mestFrekventTal);
            Console.ReadKey();
        }
    }
}