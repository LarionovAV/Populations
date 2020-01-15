using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Populations.Interfaces.Impl
{
    abstract class ChartDrawer : IDrawer
    {
        protected Chart Chart { get; set; }

        virtual public void Draw()
        {
            MessageBox.Show("Функция вывода графика не определена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
