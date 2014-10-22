using System;
using System.Collections.Generic;
using SFML.Graphics;

namespace Nations
{
    public class Nation
    {
        public World Parent;

        public string Name;
        public int Balance;
        // TODO: add government
        // TODO: add unhappiness
        // TODO: add resources
        // TODO: add things like "int totalpopulation" which manually goes through all the province data and counts the total.

        List<Province> provinces;
    }
}
