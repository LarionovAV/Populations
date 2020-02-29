using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Populations
{
    public partial class InitWindow : Form
    {
        public InitWindow()
        {
            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InitTable.Rows) {
                if (row.Cells["SpecName"].Value.ToString() != "")
                {
                    Ecosystem.GetInstance().AddSpecies(
                        new Species(
                            row.Cells["SpecName"].Value.ToString(),
                            int.Parse(row.Cells["Count"].Value.ToString()),
                            double.Parse(row.Cells["Birth"].Value.ToString()),
                            double.Parse(row.Cells["Death"].Value.ToString()),
                            int.Parse(row.Cells["EcoCapacity"].Value.ToString()))
                        );
                }
            }
            Close();
            DrawSystem.GetInstance().Update();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            InitTable.Rows.Add();
        }

        private void InitWindow_Load(object sender, EventArgs e)
        {
            foreach (Species sp in Ecosystem.GetInstance().Species) {
                InitTable.Rows.Add(sp.Name, sp.Population, sp.EcosystemCapacity, sp.NaturalBirth, sp.NaturalDeath);
            }
        }

        private void InitTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = InitTable.SelectedRows[0].Index;
            Ecosystem.GetInstance().RemoveSpecies(index);
        }
    }
}
