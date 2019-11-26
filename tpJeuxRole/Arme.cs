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
        public string nomArme { get; set; }
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

        public void Speciale1()
        {
            nomArme = "Spéciale 1";
            degats = random.Next(1, 20 + 1);
        }

        public void Speciale2()
        {
            nomArme = "Spéciale 2";
            degats = random.Next(1, 20 + 1);
        }
    }
}
