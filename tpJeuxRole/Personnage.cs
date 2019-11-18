using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    abstract class Personnage
    {
        protected Random statRandom = new Random();
        protected int pdv;
        protected int pForce;
        protected int pAgilite;
        protected string nom;
        protected Sac[] tabSac;

        public Personnage()
        {
            int nms = getNbSacMax();

            this.tabSac = new Sac[nms];
            for (int i = 0; i < nms; i++)
            {
                tabSac[i] = new Sac();
            }

        }
        public void AjouterObjetChoisi(int numSac, Objet objChoisi)
        {
            tabSac[numSac-1].Ajouter(objChoisi);
        }

        public void AfficherSacs(int numSac)
        {
            tabSac[numSac-1].Afficher();
        }

        public abstract int getNbSacMax();
        public abstract void display();
        public abstract void afficherPersoTrier(string nomPerso2);

    }
}
