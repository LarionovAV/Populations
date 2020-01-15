using System.Collections.Generic;

namespace Populations
{
    class EcoSnapshot
    {
        public List<Species>      Spec { get; set; }

        public EcoSnapshot() {
            Spec = new List<Species>();
            foreach(Species sp in Ecosystem.GetInstance().Species)
            {
                Spec.Add(sp.Clone() as Species);
            }
        }
    }
}
