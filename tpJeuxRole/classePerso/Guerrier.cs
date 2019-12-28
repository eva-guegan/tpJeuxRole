using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole 
{
    class Guerrier : Personnage, IAttaquantArme
    {
        public override int getNbSacMax() { return 5; }
        static int pdvMax = 30;
        static int pForceMax = 20;
        static int pAgiliteMax = 15;
        Arme arme = new Arme();

        public Guerrier(string name)
        {
            this.nom = name;
            this.Pdv = statRandom.Next(1, pdvMax+1);
            this.pForce = statRandom.Next(1, pForceMax + 1);
            this.pAgilite = statRandom.Next(1, pAgiliteMax + 1);
            arme.Epee();
        }


        public override void display()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Classe choisi : Guerrier \n");
            Console.WriteLine("Point de vie : " +this.Pdv);
            Console.WriteLine("Point de force : " + this.pForce);
            Console.WriteLine("Point d'agilité : " + this.pAgilite);
        }

        public override void AttaqueBanaleArme()
        {
            Console.WriteLine(arme.NomArme + ": " + arme.degats + "\n");
        }

        public override int getDegatsArme()
        {
            return arme.degats;
        }

        public override void AttaqueBanaleMagie()
        {

        }

        public override int getDegatsSort()
        {
            return 0;
        }

        public void AttaqueSpecialeArme()
        {

        }
    }
}
