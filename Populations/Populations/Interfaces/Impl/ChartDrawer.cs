﻿// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Populations.Interfaces.Impl
{
    public abstract class ChartDrawer : IDrawer
    {
        protected Chart Chart { get; set; }

        virtual public void Draw()
        {
            MessageBox.Show("Функция вывода графика не определена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public virtual void Update() { }
    }
}
