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

            while (vieP1 > 0 || vieP2 > 0)
            {
                //récup dégâts arme p1
                persoUn.AttaqueBanaleArme();

                //vieP1 - dégâts arme p1
                //persoUn.NomArme;

                //Pdv1 - dégâts arme p1

                //récup dégâts arme p2
                persoDeux.AttaqueBanaleArme();

                //vieP2 - dégâts arme p2
                //Pdv2 - dégâts arme p1

                Console.ReadKey();
            }
        }

        public void TournoiMagie(Personnage persoUn, Personnage persoDeux)
        {
            int vieP1 = persoUn.Pdv; //get
            int vieP2 = persoDeux.Pdv; //get

            while (vieP1 > 0 || vieP2 > 0)
            {
                /*test boucle
                Console.WriteLine("Perso 1 attaque \n");
                Console.WriteLine("Perso 2 attaque \n");
                Console.ReadKey();*/
            }
        }
    }
}
