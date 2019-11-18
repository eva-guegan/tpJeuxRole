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

        public Guerrier(string name)
        {
            this.nom = name;
            this.pdv = statRandom.Next(1, pdvMax+1);
            this.pForce = statRandom.Next(1, pForceMax + 1);
            this.pAgilite = statRandom.Next(1, pAgiliteMax + 1);
        }


        public override void display()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Classe choisi : Guerrier \n");
            Console.WriteLine("Point de vie : " +this.pdv);
            Console.WriteLine("Point de force : " + this.pForce);
            Console.WriteLine("Point d'agilité : " + this.pAgilite);
        }

        public override void afficherPersoTrier(string nomPerso2)
        {
            SortedSet<string> my_Set1 = new SortedSet<string>();

            my_Set1.Add(this.nom);
            my_Set1.Add(nomPerso2);

            foreach (var val in my_Set1)
            {
                Console.WriteLine(val);
            }
        }
    }
}
