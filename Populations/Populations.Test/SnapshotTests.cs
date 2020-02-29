using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations.Test
{
    [TestClass]
    public class SnapshotTests
    {
        [TestMethod]
        public void SnapshotTest() {
            int startPopulation = 10;
            Species fox = new Species("fox", startPopulation, 3, 1, 200);
            Ecosystem.GetInstance().AddSpecies(fox);
            Memento.Save();

            IMathModel model = new LogisticModel();
            model.Recount();

            Assert.AreEqual(29, fox.Population);

            Memento.Restore();
            Assert.AreEqual(startPopulation, Ecosystem.GetInstance().Species[0].Population);

            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }
    }
}
