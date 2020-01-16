using System;

namespace Populations
{
    class Counter
    {
        private IMathModel          math;
        private static Counter      instance = null;

        private Counter(IMathModel model) {
            if (model != null)
                math = model;
            else
                math = new LogisticModel();
        }

        public static Counter GetInstance(IMathModel model = null) {
            if (instance == null) {
                instance = new Counter(model);
            }

            return instance;
        }

        public void ChangeMathModel(IMathModel newModel) {
            math = newModel;
        }

        public void Recount() {
            math.Recount();
        }
        public Type GetMathModel() {
            return math.GetType();
        }
    }
}
