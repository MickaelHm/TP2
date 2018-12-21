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
            Random rdm = new Random();// déclaration d'une variable rdm qui va générer un chiffre aléatoir
            int randomNumber = rdm.Next(1, 51); // déclaration d'une variable a laquelle on affecte le chiffre aléatoire choisi par le code et défini dans la fourchette choisie. Sachant qu'avec la fonction next le "51" est exclu de la fourchette
            Console.ForegroundColor = ConsoleColor.Red;//rajout de couleur bonus proposé par Amélie, couleur texte
            Console.BackgroundColor = ConsoleColor.Green; // changement de couleur de fond
            Console.SetCursorPosition(10, 1); // changement de position du texte (x, y)
            Console.WriteLine("Dévinez le nombre que j'ai choisi entre 1 et 50");
            int userNumber = int.Parse(Console.ReadLine());
            int loop = 0;
            while (userNumber != randomNumber)
            {
                if (userNumber <1 || userNumber >50)
                {
                    //Console.Clear(); permet d'effacer la console
                    Console.WriteLine("Oops, votre nombre n'est pas compris entre 1 et 50!");
                }
                else if (userNumber > randomNumber)
                {
                    //Console.Clear(); permet d'effacer la console
                    Console.WriteLine("Le nombre à deviner est plus petit, essaie encore!");
                }
                else
                {
                    //Console.Clear(); permet d'effacer la console
                    Console.WriteLine("Le nombre à deviner est plus grand, essaie encore!");
                }
                loop++;
                userNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Bravo, vous avez trouvé! \n Nombre de tentative:" + loop);
        }
    }
}
