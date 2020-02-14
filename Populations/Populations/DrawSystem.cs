using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Populations
{
    public class DrawSystem
    {
        public const int MAX_X_VALUE = 100;

        public List<IDrawer>        Drawers { get; set; }
        
        private static DrawSystem   instance = null;


        private DrawSystem() {
            Drawers = new List<IDrawer>();
        }

        public void DoDraw() {
            foreach (IDrawer drawer in Drawers) {
                drawer.Draw();
            }
        }
        public static DrawSystem GetInstance() {
            if (instance == null)
                instance = new DrawSystem();

            return instance;
        }
        public void Update() {
            foreach (IDrawer drawer in Drawers)
                drawer.Update();
        }
        
    }
}
