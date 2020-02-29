// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using Populations.Interfaces.Impl;
using System.Windows.Forms.DataVisualization.Charting;

namespace Populations
{
    public class GraficDrawer : ChartDrawer
    {
        public GraficDrawer(Chart chart) {
            Chart = chart;
        }
        public override void Draw()
        {
            int i = 0;
            foreach (Species sp in Ecosystem.GetInstance().Species)
            {
                
                int j = 0;
                foreach (int data in History.GetInstance().Data[i])
                {

                    Chart.Series[i].Points.AddXY(DrawSystem.MAX_X_VALUE - History.GetInstance().Data[i].Count + j, data);
                    j++;
                }
                i++;
            }
        }

        public override void Update()
        {
            Chart.Series.Clear();
            foreach (Species sp in Ecosystem.GetInstance().Species) {
                Chart.Series.Add(new Series(sp.Name));
                Chart.Series[Chart.Series.Count - 1].ChartType = SeriesChartType.Line;
            }
        }
    }
}
