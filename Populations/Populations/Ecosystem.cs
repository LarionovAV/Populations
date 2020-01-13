using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations
{
    class Ecosystem
    {
        private List<Species> Species { get; set; }
        private double[,] Relations { get; set; }
        private Ecosystem instance = null;

        private Ecosystem(){
            Init();
        }
    }
}
