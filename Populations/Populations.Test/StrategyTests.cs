// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Populations.Test
{
    [TestClass]
    public class StrategyTests
    {
        [TestMethod]
        public void FewItterationsStrategyTest() {
            //Data Init
            Species fox = new Species("Fox", 10, 3, 1, 200);
            Ecosystem.GetInstance().AddSpecies(fox);
            Counter.GetInstance().ChangeMathModel(new LogisticModel());
            IRefreshStrategy strategy = new FixedItterationsRefresh(5);
            int expectResult = 177;
            //Actions
            strategy.Refresh();

            //Check results
            Assert.AreEqual(expectResult, fox.Population);
            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }

        [TestMethod]
        public void SimpleStrategyTest()
        {
            //Data Init
            Species fox = new Species("Fox", 10, 3, 1, 200);
            Ecosystem.GetInstance().AddSpecies(fox);
            Counter.GetInstance().ChangeMathModel(new LogisticModel());
            IRefreshStrategy strategy = new ManualRefresh();
            int expectResult = 29;
            //Actions
            strategy.Refresh();

            //Check results
            Assert.AreEqual(expectResult, fox.Population);
            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }
    }
}
