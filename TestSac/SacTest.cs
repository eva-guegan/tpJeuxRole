using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestSac
{
    [TestClass]
    class SacTest
    {
        Stack<ObjetTest> contenuSac = new Stack<ObjetTest>(5);
        ObjetTest TestObjet = new ObjetTest();

        [TestMethod]
        public void AjouterTest(ObjetTest objet)
        {
            //ARRANGE : initialise le contexte d'appel méthode = objets passés en paramètre
            //Ex : b.AngleIndique = 0;
            //objet = "TestObjet";

            //ACT : appelle méthode testée
            //Ex : b.rotation(angle);
            contenuSac.Push(objet);

            //ASSERT : vérifie un prédicat
            //Ex : Assert.AreEqual(b.AngleIndique, expectedAngle);
            Assert.IsNotNull(contenuSac);
        }
    }
}
