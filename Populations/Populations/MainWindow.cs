using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Populations
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_Resize(object sender, EventArgs e)
        {
            ControlPanel.Width = Width * 30 / 100;
            ControlPanel.Height = Height;
            ControlPanel.Location = new Point(Width - ControlPanel.Width, 0);

            GraficChart.Width = Width * 70 / 100;
            GraficChart.Height = Height / 2;
            GraficChart.Location = new Point(0, 0);

            CircleChart.Width = Width * 35 / 100;
            CircleChart.Height = Height / 2;
            CircleChart.Location = new Point(Width * 35 / 100, Height / 2);

            HystoChart.Width = Width * 35 / 100;
            HystoChart.Height = Height / 2;
            HystoChart.Location = new Point(0, Height / 2);

            
            InitBtn.Location = new Point((InitBtn.Parent.Width - InitBtn.Width) / 2, 10);
            StartRefreshBtn.Location = new Point((StartRefreshBtn.Parent.Width - StartRefreshBtn.Width) / 2, InitBtn.Height + InitBtn.Location.Y + 20);
            StopRefreshBtn.Location = new Point((StopRefreshBtn.Parent.Width - StopRefreshBtn.Width) / 2, StartRefreshBtn.Height + StartRefreshBtn.Location.Y + 20);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Width = 1280;
            Height = 720;
            CenterToScreen();
        }

        private void InitBtn_Click(object sender, EventArgs e)
        {
            InitWindow iw = new InitWindow();
            iw.ShowDialog();
        }
    }
}
