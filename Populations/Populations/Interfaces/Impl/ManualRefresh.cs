namespace Populations
{
    class ManualRefresh : IRefreshStrategy
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
