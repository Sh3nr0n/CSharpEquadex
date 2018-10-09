//Requérir les classes qui vont être utilisées pour créer des objets standards (ex : Random)
using System;

namespace Bastoooooon
{
    public class Personnage
    {

        //Paramétrage des atrtributs de la classe
        //Si non spécifié, l'attribut à un sélecteur privé
        // string _secret;
        public bool _mort;

        //Attribut avec un sélecteur public
        //Lorsque les getter et setter ne font rien de plus que retourner / définir l’attribut on écrit {get;set;} car plus court (syntaxe raccourcie)
        public string Nom {get;set;}
        public int Pv {get;set;}


        //Constructeur initialisant les attributs
        public Personnage (string nom, int pv){
            Nom = nom;
            Pv = pv;
            //LA valeur de cet attribut ne pourra pas être changée à l'extérieur de la classe car elle est privée
            // _secret = "botte secrete";
            _mort = false;
        }
        
        //Créer une méthode publique à laquelle on passe un objet de type Personnage, le nom générique de l'objet est "cible"
        public void Bagarre(Personnage cible){
            Random rand = new Random();
            int degats = rand.Next(0, 16);
            //Décrémenter le nombre de pv du cible passé en entrée
            cible.Pv -= degats;
            //Si les pv passent à 0 le personnage est mort: cible._mort = true
            if(Pv<=0){

                cible._mort=true;
            }
            

            //Infliger des dégats à une cible
        }

    }
}