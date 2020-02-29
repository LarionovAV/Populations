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
    public partial class InitWindow2 : Form
    {
        public InitWindow2()
        {
            InitializeComponent();
        }

        private void InitWindow2_Load(object sender, EventArgs e)
        {
            DataGridViewCellStyle dataGridCellStile = new DataGridViewCellStyle();
            dataGridCellStile.Format = "N2";
            dataGridCellStile.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int i = 0;
            RelationsTable.Columns.Add("Head", "");
            foreach (Species sp in Ecosystem.GetInstance().Species)
            {
                RelationsTable.Columns.Add("Col" + i.ToString(), sp.Name);
                RelationsTable.Columns["Col" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
                RelationsTable.Columns["Col" + i.ToString()].DefaultCellStyle = dataGridCellStile;
                i++;
            }
            i = 0;
            foreach (Species sp in Ecosystem.GetInstance().Species)
            {
                RelationsTable.Rows.Add();
                RelationsTable.Rows[RelationsTable.Rows.Count - 1].Cells["Head"].Value = sp.Name;
                for (int j = 0; j < sp.Relations.Count; j++) {
                    RelationsTable.Rows[i].Cells[j + 1].Value = sp.Relations[j];
                }
                i++;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Ecosystem.GetInstance().Species.Count; i++)
                for (int j = 0; j < Ecosystem.GetInstance().Species.Count; j++)
                    Ecosystem.GetInstance().Species[i].Relations[j] = double.Parse(RelationsTable.Rows[i].Cells[j + 1].Value.ToString());
            Close();
        }
    }
}
