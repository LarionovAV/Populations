namespace Populations
{
    class LogisticModel : IMathModel
    {
        public void Recount()
        {
            foreach (Species sp in Ecosystem.GetInstance().Species) {
                sp.Population += sp.Population * (sp.NaturalBirth - sp.NaturalDeath) * (1 - sp.Population / sp.EcosystemCapacity);
            }
        }
    }
}
