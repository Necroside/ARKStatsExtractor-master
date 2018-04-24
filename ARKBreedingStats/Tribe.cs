﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKBreedingStats
{
    public class Tribe
    {
        public string TribeName = "";
        public Relation TribeRelation = Tribe.Relation.Neutral;
        public string Note = "";

        public enum Relation
        {
            Neutral,
            Allied,
            Friendly,
            Hostile
        }
    }
}
