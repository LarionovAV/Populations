// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populations.Test
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        public void ExecuteTest() {
            //Init data
            int currentPopulation = 10;
            int birth = 3;
            int death = 1;
            int ecoCapacity = 200;
            int expectedpopulation = 29;

            //Actions
            Species fox = new Species("fox", currentPopulation, birth, death, ecoCapacity);
            Ecosystem.GetInstance().AddSpecies(fox);
            LogisticModel lm = new LogisticModel();
            Facade.Execute();

            //Check
            Assert.AreEqual(expectedpopulation, fox.Population);

            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }

        [TestMethod]
        public void TakeSnapshotTest()
        {
            int startPopulation = 10;
            Species fox = new Species("fox", startPopulation, 3, 1, 200);
            Ecosystem.GetInstance().AddSpecies(fox);
            Facade.TakeSnapshot();

            IMathModel model = new LogisticModel();
            model.Recount();

            Assert.AreEqual(29, fox.Population);

            Facade.Restore();
            Assert.AreEqual(startPopulation, Ecosystem.GetInstance().Species[0].Population);

            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }
    }
}
