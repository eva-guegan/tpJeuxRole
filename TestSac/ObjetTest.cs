using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSac
{
    [TestClass]
    class ObjetTest
    {
        private string nom;

        [TestMethod]
        public void Objet(string nom)
        {
            this.nom = nom;
        }

        [TestMethod]
        public void AfficherNomObjetTest()
        {
            Console.WriteLine("- " + this.nom);
        }
    }
}
