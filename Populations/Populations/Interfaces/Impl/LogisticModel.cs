// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;

namespace Populations
{
    public class LogisticModel : IMathModel
    {
        public void Recount()
        {
            foreach (Species sp in Ecosystem.GetInstance().Species) {
                sp.Population = Math.Max(
                    0, 
                    sp.Population + (int) Math.Round(sp.Population * (sp.NaturalBirth - sp.NaturalDeath) * (1.0 - 1.0 * sp.Population / sp.EcosystemCapacity))
                    );
            }
        }
    }
}
