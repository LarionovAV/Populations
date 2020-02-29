namespace Populations
{
    public interface IRefreshStrategy
    {
        void Refresh();
        void Stop();
    }
}
