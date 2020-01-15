using System.Collections.Generic;

namespace Populations
{
    class DrawSystem
    {
        private List<IDrawer>       drawers;
        private static DrawSystem   instance = null;

        private DrawSystem() {
            drawers = new List<IDrawer>();
        }

        public void DoDraw() {
            foreach (IDrawer drawer in drawers) {
                drawer.Draw();
            }
        }
        public static DrawSystem GetInstance() {
            if (instance == null)
                instance = new DrawSystem();

            return instance;
        }
    }
}
