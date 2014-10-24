using System;
using System.Collections.Generic;

namespace Nations
{
    public class Province
    {
        public Nation Parent;

        public string Name;
        public int Population;

        // TODO: add list of neighboring provinces. generate this; maybe put all shapes in a collision detector and for every province have it put add the provinces it collided with?
        // TODO: infrastructure!!

        public Province(Nation parent)
        {
            Parent = parent;
        }
    }
}
