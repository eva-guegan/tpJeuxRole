using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Tournoi
    {
        public void TournoiArme(Personnage persoUn, Personnage persoDeux)
        {
            int vieP1 = persoUn.Pdv; //get
            int vieP2 = persoDeux.Pdv; //get

            while (vieP1 > 0 && vieP2 > 0)
            {
                //récup dégâts arme p1
                Console.WriteLine("Votre arme : \n");
                persoUn.AttaqueBanaleArme();
                Console.ReadKey();

                Console.WriteLine("Vous attaquez l'ennemi ! \n");
                Console.ReadKey();

                // Calcul dégats p2
                int vieP2Attaquer = vieP2 - persoDeux.getDegatsArme();
                vieP2 = vieP2Attaquer;

                Console.WriteLine("Sa vie restante :" + vieP2 + "\n");
                Console.ReadKey();

                Console.WriteLine("L'ennemi riposte ! \n");

                Console.WriteLine("Son arme : \n");
                persoDeux.AttaqueBanaleArme();
                Console.ReadKey();

                // Calcul dégats p1
                int vieP1Attaquer = vieP1 - persoUn.getDegatsArme();
                vieP1 = vieP1Attaquer;

                Console.WriteLine("Votre vie restante :" + vieP1 + "\n");
                Console.ReadKey();

                Console.Clear();
            }
        }

        public void TournoiMagie(Personnage persoUn, Personnage persoDeux)
        {
            int vieP1 = persoUn.Pdv; //get
            int vieP2 = persoDeux.Pdv; //get

            while (vieP1 > 0 && vieP2 > 0)

            {
                //récup dégâts arme p1
                Console.WriteLine("Votre arme : \n");
                persoUn.AttaqueBanaleMagie();
                Console.ReadKey();

                Console.WriteLine("Vous attaquez l'ennemi ! \n");
                Console.ReadKey();

                // Calcul dégats p2
                int vieP2Attaquer = vieP2 - persoDeux.getDegatsSort();
                vieP2 = vieP2Attaquer;

                Console.WriteLine("Sa vie restante :" + vieP2 + "\n");
                Console.ReadKey();

                Console.WriteLine("L'ennemi riposte ! \n");

                Console.WriteLine("Son arme : \n");
                persoDeux.AttaqueBanaleMagie();
                Console.ReadKey();

                // Calcul dégats p1
                int vieP1Attaquer = vieP1 - persoUn.getDegatsSort();
                vieP1 = vieP1Attaquer;

                Console.WriteLine("Votre vie restante :" + vieP1 + "\n");
                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}
