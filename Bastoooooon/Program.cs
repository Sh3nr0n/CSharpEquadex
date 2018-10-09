using System;

namespace Bastoooooon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bastooooooon!");
            //Créer un objet "nouveauPerso" qui hérite des méthodes et attributs de la classe Personnage, on lui passe deux attributs obligatoires lors de la construction de l'objet
            Personnage raymond = new Personnage("raymond", 20);
            // Console.WriteLine($"nom initial : {raymond.Nom}");
            Personnage gege = new Personnage("gégé", 20);

            // nouveauPerso.Nom="gégé";            
            // Console.WriteLine($"nouveau nom : {gege.Nom}");
            // gege.Bagarre(raymond);
            // Console.WriteLine("PV de raymond"+raymond.Pv);

            // Console.WriteLine(gege._mort && !raymond._mort);

            while (!gege._mort && !raymond._mort)
            {
                gege.Bagarre(raymond);
                Console.WriteLine("PV de Gégé = " + raymond.Pv);

                raymond.Bagarre(gege);
                Console.WriteLine("PV de Raymond = " + gege.Pv);

            }

            Monstre yeti = new Monstre("yeti");
            Console.WriteLine(yeti.Pv);





        }
    }
}
