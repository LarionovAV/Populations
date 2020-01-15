namespace Populations
{
    class Memento
    {
        public static void Save() {
            History.GetInstance().Push(new EcoSnapshot());
        }
        public static void Restore() {
            EcoSnapshot last = History.GetInstance().Pop();

            if (last != null) {
                Ecosystem.GetInstance().Species.Clear();
                foreach (Species sp in last.Spec) {
                    Ecosystem.GetInstance().Species.Add(sp);
                }
            }
        }
    }
}
