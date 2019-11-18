using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Sac
    {
        Stack<Objet> contenuSac = new Stack<Objet>(5);

        public void Ajouter(Objet objet)
        {
            contenuSac.Push(objet);
        }

        public void Afficher()
        {
            foreach (Objet nom in contenuSac)
            {
                nom.AfficherNomObjet();
            }
        }

        public void Supprimer()
        {
            contenuSac.Pop();
        }
    }
}
