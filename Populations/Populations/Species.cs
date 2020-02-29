// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;

namespace Populations
{
    public class Species : ICloneable
    {
        public string       Name { get; set; }
        public int          Population { get; set; }
        public double       NaturalBirth { get; set; }
        public double       NaturalDeath { get; set; }
        public int          EcosystemCapacity { get; set; }
        public List<double> Relations { get; set; }

        public Species(string name, int pop = 10, double birth = 5, double death = 3, int capacity = 1000) {
            Name = name;
            Population = pop;
            NaturalBirth = birth;
            NaturalDeath = death;
            EcosystemCapacity = capacity;
            Relations = new List<double>();
            foreach (Species sp in Ecosystem.GetInstance().Species) {
                Relations.Add(0);
            }
        }

        public object Clone()
        {
            Species clone = new Species(Name, Population, NaturalBirth, NaturalDeath, EcosystemCapacity);
            foreach (double rel in Relations)
                clone.Relations.Add(rel);
            return clone;
        }
    }
}
