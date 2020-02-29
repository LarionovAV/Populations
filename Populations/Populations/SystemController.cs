using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations
{
    public class SystemController
    {
        private static SystemController                instance = null;
        private IRefreshStrategy                       refreshMode;

        private SystemController(IRefreshStrategy refreshStrategy) {
            if (refreshStrategy != null)
                refreshMode = refreshStrategy;
            else
                refreshMode = new ManualRefresh();
        }

        public void ExecuteRefresh() {
            refreshMode.Refresh();
        }
        public void StopRefresh()
        {
            refreshMode.Stop();
        }
        public static SystemController GetInstance(IRefreshStrategy refreshStrategy = null) {
            if (instance == null)
                instance = new SystemController(refreshStrategy);

            return instance;
        }
        public Type GetRefreshMode() {
            return refreshMode.GetType();
        }
        public void ChangeRefreshStrategy(IRefreshStrategy newStrategy) {
            refreshMode = newStrategy;
        }
    }
}
