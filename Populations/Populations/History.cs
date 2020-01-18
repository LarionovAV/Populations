using System.Collections.Generic;
using System.Windows.Forms;

namespace Populations
{
    class History
    {
        public List<List<int>>          Data { get; }
        private Stack<EcoSnapshot>      snapshots;
        private static History          instance = null;

        private History() {
            snapshots = new Stack<EcoSnapshot>();
            Data = new List<List<int>>();
        }

        public void Push(EcoSnapshot snapshot) {
            snapshots.Push(snapshot);
        }

        public EcoSnapshot Pop() {
            if (snapshots.Count > 0)
            {
                return snapshots.Pop();
            }
            else {
                MessageBox.Show("История пуста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static History GetInstance() {
            if (instance == null)
                instance = new History();

            return instance;
        }

        public void AddDataSource(List<int> source)
        {
            Data.Add(source);
        }

        public void RenewData()
        {
            int i = 0;
            foreach (List<int> DataSource in Data)
            {
                DataSource.Add(Ecosystem.GetInstance().Species[i].Population);
                if (DataSource.Count > DrawSystem.MAX_X_VALUE)
                    DataSource.RemoveAt(0);
                i++;
            }
        }

        public void ClearData() {
            Data.Clear();
        }

        public int GetSnapshotCount() {
            return snapshots.Count;
        }
    }
}
