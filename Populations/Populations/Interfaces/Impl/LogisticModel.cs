using System;

namespace Populations
{
    class LogisticModel : IMathModel
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
