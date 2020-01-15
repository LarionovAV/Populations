using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Populations
{
    class FixedItterationsRefresh : IRefreshStrategy
    {
        private readonly int itterCount;

        public FixedItterationsRefresh(int itCount) {
            itterCount = itCount;
        }
        public void Refresh()
        {
            for (int i = 0; i < itterCount; i++) {
                Counter.GetInstance().Recount();
            }
        }

        public void Stop()
        {
        }
    }
}
