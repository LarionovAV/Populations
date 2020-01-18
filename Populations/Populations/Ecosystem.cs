using System.Collections.Generic;

namespace Populations
{
    class Ecosystem
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
        private bool HasSpecies(string spName) {
            bool res = false;
            foreach (Species sp in Species) {
                if (sp.Name == spName) {
                    res = true;
                    break;
                }
            }
            return res;
        }

        public static Ecosystem GetInstance(List<Species> spec = null) {
            if (instance == null)
                instance = new Ecosystem(spec);

            return instance;
        }
        public void AddSpecies(Species sp) {
            if (!HasSpecies(sp.Name)) {
                Species.Add(sp);
                foreach (Species spec in Species) {
                    spec.Relations.Add(0);
                }
                History.GetInstance().AddDataSource(new List<int>());
                History.GetInstance().Data[History.GetInstance().Data.Count - 1].Add(sp.Population);
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
