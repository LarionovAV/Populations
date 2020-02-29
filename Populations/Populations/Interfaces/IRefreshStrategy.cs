// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
namespace Populations
{
    public interface IRefreshStrategy
    {
        void Refresh();
        void Stop();
    }
}
