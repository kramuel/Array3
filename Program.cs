using System;
using System.Linq;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Övning 3
Skapa en lottorad med hjälp av en array. En lottorad består av 7 st unika heltal mellan 1 och
35
*/

            int[] lotto = new int[7];
            Random rnd = new Random();
            for (int i = 0; i < lotto.Length; i++)
            {
                int x = rnd.Next(1, 36);
                if (!lotto.Contains(x))
                {
                    lotto[i] = x;
                    Console.Write($"{lotto[i]}  ");
                }
                else
                {
                    i--;
                }
            }



            Console.ReadKey();
        }
    }
}
