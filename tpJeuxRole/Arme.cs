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
        public string NomArme { get => nomArme; set => nomArme = value; }
        private string nomArme;
        public int degats { get; set; }

        public void Epee()
        {
            nomArme = "Epée";
            degats = random.Next(1, 10 + 1);
        }

        public void Masse()
        {
            nomArme = "Masse";
            degats = random.Next(1, 10 + 1);
        }

        public void ArmeSpeciale1()
        {
            nomArme = "Spéciale 1";
            degats = random.Next(1, 20 + 1);
        }

        public void ArmeSpeciale2()
        {
            nomArme = "Spéciale 2";
            degats = random.Next(1, 20 + 1);
        }
    }
}
