using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestSac
{
    [TestClass]
    class SacTest
    {
        Stack<ObjetTest> contenuSac = new Stack<ObjetTest>(5);

        [TestMethod]
        public void AjouterTest(ObjetTest objet)
        {
            contenuSac.Push(objet);
        }

        [TestMethod]
        public void AfficherTest()
        {
            foreach (ObjetTest nom in contenuSac)
            {
                nom.AfficherNomObjetTest();
            }
        }

        [TestMethod]
        public void SupprimerTest()
        {
            contenuSac.Pop();
        }
    }
}
