using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using tpJeuxRole;

namespace TestSac
{
    [TestClass]
    class SacTest
    {
        Stack<Objet> contenuSac = new Stack<Objet>(5);
        Objet TestObjet = new Objet("Azerty");
        

        [TestMethod]
        public void AjouterTest(Objet TestObjet)
        {
            //ARRANGE : initialise le contexte d'appel méthode = objets passés en paramètre
            //Ex : b.AngleIndique = 0;
            //objet = "TestObjet";

            //ACT : appelle méthode testée
            //Ex : b.rotation(angle);
            contenuSac.Push(TestObjet);

            //ASSERT : vérifie un prédicat
            //Ex : Assert.AreEqual(b.AngleIndique, expectedAngle);
            Assert.IsNotNull(contenuSac);
        }
    }
}
