// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
namespace Populations
{
    public class ManualRefresh : IRefreshStrategy
    {
        public void Refresh()
        {
            Counter.GetInstance().Recount();
            History.GetInstance().RenewData();
            DrawSystem.GetInstance().Update();
            DrawSystem.GetInstance().DoDraw();
        }

        public void Stop()
        {
            
        }
    }
}
