using Populations.Interfaces.Impl;
using System.Windows.Forms.DataVisualization.Charting;

namespace Populations
{
    public class DiagramDrawer : ChartDrawer
    {
        public DiagramDrawer(Chart chart) {
            Chart = chart;
            Chart.Series.Add(new Series("Populations"));
            Chart.Series["Populations"].ChartType = SeriesChartType.Pie;
        }
        public override void Draw()
        {
            Chart.Series["Populations"].Points.Clear();
            int i = 0;
            foreach (Species sp in Ecosystem.GetInstance().Species)
            {
                Chart.Series["Populations"].Points.Add(new DataPoint());
                Chart.Series["Populations"].Points[i].LegendText = sp.Name;
                Chart.Series["Populations"].Points[i].SetValueY(sp.Population);
                i++;
            }
        }

        public override void Update()
        {

        }
    }
}
