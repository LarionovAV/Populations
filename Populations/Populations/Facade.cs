using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations
{
    class Facade
    {
        public static void Init() {
            InitWindow initWindow = new InitWindow();
            initWindow.ShowDialog();
            DrawSystem.GetInstance().DoDraw();
        }
        public static void TakeSnapshot() {
            Memento.Save();
        }
        public static void Restore() {
            Memento.Restore();
        }
        public static void ChangeSettings() {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
        public static void Execute()
        {
            SystemController.GetInstance().ExecuteRefresh();
            DrawSystem.GetInstance().DoDraw();

        }
        public static void Stop()
        {
            SystemController.GetInstance().StopRefresh();
        }
    }
}
