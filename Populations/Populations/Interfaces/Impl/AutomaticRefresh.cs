﻿// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Windows.Forms;


namespace Populations
{
    public class AutomaticRefresh : IRefreshStrategy
    {
        private static Timer timer = null;

        public AutomaticRefresh(int freq = 1000) {
            if (timer == null)
            {
                timer = new Timer();
                timer.Tick += new EventHandler(TimerTick);
                timer.Interval = freq;
            }
            else
                timer.Stop();
        }

        public void Refresh()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void TimerTick(object sender, EventArgs e) {
            Counter.GetInstance().Recount();
            History.GetInstance().RenewData();
            DrawSystem.GetInstance().Update();
            DrawSystem.GetInstance().DoDraw();
        }
    }
}
