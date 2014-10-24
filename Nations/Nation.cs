using System;
using System.Collections.Generic;

namespace Nations
{
    public class Nation
    {
        public World Parent;
        List<Province> provinces;

        public string Name;
        public int Balance;
        // TODO: add government
        // TODO: add unhappiness
        // TODO: add resources
        // TODO: add things like "int totalpopulation" which manually goes through all the province data and counts the total.

        public Nation(World parent)
        {
            Parent = parent;
        }
    }
}
