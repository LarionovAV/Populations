﻿using Populations.Interfaces.Impl;
using System.Windows.Forms.DataVisualization.Charting;

namespace Populations
{
    class HystogramDrawer : ChartDrawer
    {
        public HystogramDrawer(Chart chart) {
            Chart = chart;
            Chart.Series.Add(new Series("Populations"));
        }
        public override void Draw()
        {
            Chart.Series["Populations"].Points.Clear();
            foreach (Species sp in Ecosystem.GetInstance().Species)
            {
                Chart.Series["Populations"].Points.AddXY(sp.Name, sp.Population);
            }
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
