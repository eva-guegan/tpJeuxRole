using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Equipe
    {
        static SortedSet<Personnage> team = new SortedSet<Personnage>(); 

        public static void AjouterPerso(Personnage p)
        {
            team.Add(p);
        }
        public static void AfficherEquipe()
        {
            foreach (var val in team)
            {
                val.display();
            }
        }
    }
}
