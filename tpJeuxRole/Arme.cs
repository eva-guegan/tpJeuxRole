using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Arme
    {
        private Random random = new Random();
        public string nomArme;
        public int degats;
        public void AttaqueEpee ()
        {
            nomArme = "Epée";
            degats = random.Next(1, 10);
        }

        public void AttaqueMasse()
        {
            nomArme = "Masse";
            degats = random.Next(1, 10);
        }
    }
}
