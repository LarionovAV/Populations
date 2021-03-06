﻿// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
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
