using System;
using System.Collections.Generic;
using System.Linq;
using Nations.GovernmentSystems;

namespace Nations
{
    public class Nation
    {
        public World Parent;
        List<Province> provinces;

        public string Name;
        public int Balance;
        public int Population
        {
            get
            {
                return provinces.Sum(province => province.Population);
            }
        }
        public Government Government;
        public Economy Economy;

        // TODO: add unhappiness
        // TODO: add resources

        public Nation(World parent)
        {
            Parent = parent;
        }
    }
}
