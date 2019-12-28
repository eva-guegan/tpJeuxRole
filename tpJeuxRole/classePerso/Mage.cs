﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Mage : Personnage, IAttaquantMagie
    {
        static int pdvMax = 15;
        static int pForceMax = 15;
        static int pAgiliteMax = 15;
        static int manaMax = 20;
        private int mana;
        public override int getNbSacMax() { return 2; }

        public Mage(string name)
        {
            this.nom = name;
            this.Pdv = statRandom.Next(1, pdvMax + 1);
            this.pForce = statRandom.Next(1, pForceMax + 1);
            this.pAgilite = statRandom.Next(1, pAgiliteMax + 1);
            this.mana = statRandom.Next(1, manaMax + 1);
        }

        public override void display()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Classe choisi : Mage \n");
            Console.WriteLine("Point de vie : " + this.Pdv);
            Console.WriteLine("Point de force : " + this.pForce);
            Console.WriteLine("Point d'agilité : " + this.pAgilite);
            Console.WriteLine("Point de mana : " + this.mana);

        }

        public override void AttaqueBanaleArme()
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
