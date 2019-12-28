using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Paladin : Personnage, IAttaquantArme, IAttaquantMagie
    {
        public override int getNbSacMax() { return 3; }
        static int pdvMax = 25;
        static int pForceMax = 20;
        static int pAgiliteMax = 15;

        public Paladin(string name)
        {
            this.nom = name;
            this.Pdv = statRandom.Next(1, pdvMax + 1);
            this.pForce = statRandom.Next(1, pForceMax + 1);
            this.pAgilite = statRandom.Next(1, pAgiliteMax + 1);
        }

        public override void display()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Classe choisi : Paladin \n");
            Console.WriteLine("Point de vie : " + this.Pdv);
            Console.WriteLine("Point de force : " + this.pForce);
            Console.WriteLine("Point d'agilité : " + this.pAgilite);
        }

        public override void AttaqueBanaleArme()
        {
        }

        public void AttaqueSpecialeArme()
        {

        }

        public void AttaqueBanaleMagie()
        {
        }

        public void AttaqueSpecialeMagie()
        {

        }
    }
}
