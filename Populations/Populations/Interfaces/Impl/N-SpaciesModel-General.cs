// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;

namespace Populations
{
    public class N_SpaciesModel_General : IMathModel
    {
        private int[] oldPopulations;
        public void Recount()
        {
            oldPopulations = new int[Ecosystem.GetInstance().Species.Count];
            for  (int i = 0; i < Ecosystem.GetInstance().Species.Count; i++)
            {
                oldPopulations[i] = Ecosystem.GetInstance().Species[i].Population;
            }
            int j = 0;
            foreach (Species sp in Ecosystem.GetInstance().Species) {
                sp.Population = Math.Max(
                    0, 
                    sp.Population + (int)Math.Round((sp.NaturalBirth - sp.NaturalDeath + Sum(j)) * sp.Population));
                j++;
            }
        }

        private double Sum(int specIndex) {
            double result = 0;

            for (int j = 0; j < Ecosystem.GetInstance().Species.Count; j++) {
                result += Ecosystem.GetInstance().Species[specIndex].Relations[j] * oldPopulations[j];
            }
            return result;
        }
    }
}
