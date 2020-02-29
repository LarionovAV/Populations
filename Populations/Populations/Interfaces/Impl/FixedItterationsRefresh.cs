namespace Populations
{
    public class FixedItterationsRefresh : IRefreshStrategy
    {
        private readonly int itterCount;

        public FixedItterationsRefresh(int itCount) {
            itterCount = itCount;
        }
        public void Refresh()
        {
            for (int i = 0; i < itterCount; i++) {
                Counter.GetInstance().Recount();
                History.GetInstance().RenewData();
                DrawSystem.GetInstance().Update();
                DrawSystem.GetInstance().DoDraw();
            }
        }

        public void Stop()
        {
        }
    }
}
