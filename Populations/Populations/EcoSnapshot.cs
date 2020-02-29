// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Collections.Generic;

namespace Populations
{
    public class EcoSnapshot
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
