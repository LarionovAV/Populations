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
    public class SystemControllerTest
    {
        [TestMethod]
        public void ControllerTest() {
            //Init
            SystemController.GetInstance().ChangeRefreshStrategy(new ManualRefresh());
            Counter.GetInstance().ChangeMathModel(new LogisticModel());
           
            Species fox = new Species("fox", 10, 3, 1, 200);
            Ecosystem.GetInstance().AddSpecies(fox);

            SystemController.GetInstance().ExecuteRefresh();
            SystemController.GetInstance().StopRefresh();
            Assert.AreEqual(29, fox.Population);

            Species rabbit = new Species("rabbit", 30, 3, 1, 500);
            Ecosystem.GetInstance().AddSpecies(rabbit);
            rabbit.Relations[0] = -1;
            Counter.GetInstance().ChangeMathModel(new N_SpaciesModel_General());
            SystemController.GetInstance().ExecuteRefresh();
            Assert.AreEqual(87, fox.Population);
            Assert.AreEqual(0, rabbit.Population);
            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();

            
        }
    }
}
