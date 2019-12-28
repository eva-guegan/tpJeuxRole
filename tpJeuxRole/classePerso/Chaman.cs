﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Chaman : Personnage, IAttaquantMagie
    {
        public override int getNbSacMax() { return 2; }
        static int pdvMax = 20;
        static int pForceMax = 15;
        static int pAgiliteMax = 15;

        public Chaman(string name)
        {
            this.nom = name;
            this.Pdv = statRandom.Next(1, pdvMax + 1);
            this.pForce = statRandom.Next(1, pForceMax + 1);
            this.pAgilite = statRandom.Next(1, pAgiliteMax + 1);
        }

        public override void display()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Classe choisi : Chaman \n");
            Console.WriteLine("Point de vie : " + this.Pdv);
            Console.WriteLine("Point de force : " + this.pForce);
            Console.WriteLine("Point d'agilité : " + this.pAgilite);
        }

        public override void AttaqueBanaleArme()
        {
        }

        public override int getDegatsArme()
        {
            Sort sort = new Sort();
            sort.AttaqueSort1();

            return sort.degats;
        }

        public void AttaqueBanaleMagie()
        {
        }

        public void AttaqueSpecialeMagie()
        {

        }
    }
}
