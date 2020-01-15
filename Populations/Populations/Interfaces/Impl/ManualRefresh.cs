namespace Populations
{
    class ManualRefresh : IRefreshStrategy
    {
        public void Refresh()
        {
            Counter.GetInstance().Recount();
        }

        public void Stop()
        {
            
        }
    }
}
