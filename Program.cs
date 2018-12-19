using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int randomNumber = rdm.Next(1, 51);
            Console.WriteLine("Dévinez le nombre que j'ai choisi entre 1 et 50");
            int userNumber = int.Parse(Console.ReadLine());
            int loop = 0;
            while (userNumber != randomNumber)
            {
                if (userNumber > randomNumber)
                {
                    Console.WriteLine("Le nombre à deviner est plus petit, essaie encore!");
                }
                else
                {
                    Console.WriteLine("Le nombre à deviner est plus grand, essaie encore!");
                }
                loop++;
                userNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Bravo, vous avez trouvé! \n Nombre de tentative:" + loop);
        }
    }
}
