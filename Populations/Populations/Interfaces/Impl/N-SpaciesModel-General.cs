using System;

namespace Populations
{
    class N_SpaciesModel_General : IMathModel
    {
        public void Recount()
        {
            foreach (Species sp in Ecosystem.GetInstance().Species) {
                sp.Population = (int)Math.Round((sp.NaturalBirth - sp.NaturalDeath + Sum(sp.Name)) * sp.Population);
            }
        }

        private double Sum(string spec) {
            double result = 0;
            int i = 0;
            while (Ecosystem.GetInstance().Species[i].Name != spec)
                i++;
            for (int j = 0; j < Ecosystem.GetInstance().Species.Count; j++) {
                result += Ecosystem.GetInstance().Species[i].Relations[j] * Ecosystem.GetInstance().Species[j].Population;
            }
            return result;
        }
    }
}
