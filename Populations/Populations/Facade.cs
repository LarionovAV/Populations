// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System.Windows.Forms;

namespace Populations
{
    public class Facade
    {
        public static void Init() {
            if (new InitWindow().ShowDialog() == DialogResult.OK) {
                new InitWindow2().ShowDialog();
                new SettingsWindow().ShowDialog();
                DrawSystem.GetInstance().DoDraw();
            }
        }
        public static void TakeSnapshot() {
            Memento.Save();
        }
        public static void Restore() {
            Memento.Restore();

            History.GetInstance().RenewData();
            DrawSystem.GetInstance().Update();
        }
        public static void ChangeSettings() {
           new SettingsWindow().ShowDialog();
        }
        public static void Execute()
        {
            SystemController.GetInstance().ExecuteRefresh();

        }
        public static void Stop()
        {
            SystemController.GetInstance().StopRefresh();
        }
    }
}
