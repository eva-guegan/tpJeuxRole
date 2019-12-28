using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpJeuxRole
{
    class Sort
    {
        private Random random = new Random();
        public string nomSort;
        static int degats;
        public void AttaqueSort1()
        {
            nomSort = "Pétrification";
            degats = random.Next(1, 10 + 1);
        }

        public void AttaqueSort2()
        {
            nomSort = "Sort 2";
            degats = random.Next(1, 10 + 1);
        }

        public void SortSpeciale1()
        {
            nomSort = "Spéciale 1";
            degats = random.Next(1, 20 + 1);
        }

        public void SortSpeciale2()
        {
            nomSort = "Spéciale 2";
            degats = random.Next(1, 20 + 1);
        }

    }
}
