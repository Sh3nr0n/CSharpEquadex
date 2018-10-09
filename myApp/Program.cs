using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args) {

            int vieMonstre = 40;
            string nomMonstre = "Terminator";
            int viePersonnage = 30;
            string nomPersonnage = "GI Joe";
            Random rand = new Random();

            //Atention boucle infinie
            while (vieMonstre != 0 || viePersonnage != 0)
            {
                int degatsMonstre = rand.Next(0, 16);//On appelle la méthode Next de la classe random
                int degatsPersonnage = rand.Next(0, 16);

                vieMonstre -= degatsPersonnage;
                Console.WriteLine($"{nomPersonnage} inflige " + degatsPersonnage + $" points de dégats à {nomMonstre}. Il reste " + vieMonstre + $" PV à {nomMonstre}!");

                viePersonnage -= degatsMonstre;
                Console.WriteLine($"{nomMonstre} inflige "+ degatsMonstre +$" points de dégats à {nomPersonnage}. Il reste " + viePersonnage+ $" PV à {nomPersonnage}!");

                if (viePersonnage < 0)
                {
                    Console.WriteLine($"RIP {nomPersonnage}, tu as bien combattu, il te reste:" + viePersonnage );
                    break;
                }
                if (vieMonstre < 0)
                {
                    Console.WriteLine($"Mouhahaha {nomPersonnage} a mouru, il lui reste :" + vieMonstre + "PV restants!");
                    break;
                }
            };
        }
    }
};