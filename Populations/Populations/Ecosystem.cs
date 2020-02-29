// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Collections.Generic;

namespace Populations
{
    public class Ecosystem
    {
        public List<Species>            Species     { get; private set; }
        private static Ecosystem        instance    = null;

        //Конструктор
        private Ecosystem(List<Species> spec)
        {
            if (spec != null) {
                Species = spec;
            }
            else 
                Species = new List<Species>();
        }
        private Species HasSpecies(string spName) {
            foreach (Species sp in Species) {
                if (sp.Name == spName) {
                    return sp;
                }
            }
            return null;
        }

        public static Ecosystem GetInstance(List<Species> spec = null) {
            if (instance == null)
                instance = new Ecosystem(spec);

            return instance;
        }
        public void AddSpecies(Species sp) {
            Species tmp = HasSpecies(sp.Name);
            if (tmp == null)
            {
                Species.Add(sp);
                foreach (Species spec in Species)
                {
                    spec.Relations.Add(0);
                }
                History.GetInstance().AddDataSource(new List<int>());
                History.GetInstance().Data[History.GetInstance().Data.Count - 1].Add(sp.Population);
            }
            else {
                tmp.Population = sp.Population;
                tmp.NaturalDeath = sp.NaturalDeath;
                tmp.NaturalBirth = sp.NaturalBirth;
                tmp.EcosystemCapacity = sp.EcosystemCapacity;
            }
        }
        public void RemoveSpecies(int index) {
            foreach (Species sp in Species)
            {
                sp.Relations.RemoveAt(index);
            }
            Species.RemoveAt(index);
            History.GetInstance().Data.RemoveAt(index);
        }
    }
}
