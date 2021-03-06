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
        Sort sort = new Sort();

        public Chaman(string name)
        {
            this.nom = name;
            this.Pdv = statRandom.Next(1, pdvMax + 1);
            this.pForce = statRandom.Next(1, pForceMax + 1);
            this.pAgilite = statRandom.Next(1, pAgiliteMax + 1);
            sort.AttaqueSort1();
        }

        public override void display()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("Classe choisi : Chaman \n");
            Console.WriteLine("Point de vie : " + this.Pdv);
            Console.WriteLine("Point de force : " + this.pForce);
            Console.WriteLine("Point d'agilité : " + this.pAgilite);
        }
        
        public override void AttaqueBanaleMagie()
        {
            Console.WriteLine(sort.NomSort + ": " + sort.degats + "\n");
        }

        public override int getDegatsSort()
        {
            return sort.degats;
        }

        public override void AttaqueSpecialeMagie()
        {

        }

        public override void AttaqueBanaleArme()
        {
        }

        public override int getDegatsArme()
        {
            return 0;
        }

        public override void AttaqueSpecialeArme()
        {

        }
    }
}
