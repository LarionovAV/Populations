namespace Populations
{
    public class Memento
    {
        public static void Save() {
            History.GetInstance().Push(new EcoSnapshot());
        }
        public static void Restore() {
            EcoSnapshot last = History.GetInstance().Pop();

            if (last != null) {
                History.GetInstance().ClearData();
                Ecosystem.GetInstance().Species.Clear();
                int i = 0;
                foreach (Species sp in last.Spec) {
                    Ecosystem.GetInstance().AddSpecies(sp);
                    History.GetInstance().Data[i].Add(sp.Population);
                    i++;
                }
            }
        }
    }
}
