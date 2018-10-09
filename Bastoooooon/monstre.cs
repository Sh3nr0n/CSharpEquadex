using System;

namespace Bastoooooon
{
    public class Monstre : Personnage
    {

        //Paramétrage des atrtributs de la classe
        //Si non spécifié, l'attribut à un sélecteur privé

        //Attribut avec un sélecteur public
        //Lorsque les getter et setter ne font rien de plus que retourner / définir l’attribut on écrit {get;set;} car plus court (syntaxe raccourcie)
        


        //Constructeur initialisant les attributs
        public Monstre (string nom ) : base(nom,0)
        {
            Random random = new Random();
            Pv = random.Next(0,123) ;

        }
        
        }

    }
