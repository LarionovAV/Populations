using System.Collections.Generic;
using System.Windows.Forms;

namespace Populations
{
    class History
    {
        private Stack<EcoSnapshot>      snapshots;
        private static History          instance = null;

        private History() {
            snapshots = new Stack<EcoSnapshot>();
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
    }
}
