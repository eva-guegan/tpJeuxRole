using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    public class Objet
    {
        private string nom;

        public Objet(string nom)
        {
            this.nom = nom;
        }

        public void AfficherNomObjet()
        {
            Console.WriteLine("- " + this.nom);
        }
    }
}
