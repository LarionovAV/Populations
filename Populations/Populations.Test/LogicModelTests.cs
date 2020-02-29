// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Populations.Test
{
    [TestClass]
    public class LogicModelTests
    {
        [TestMethod]
        public void N_SpeciesModelTest_10to50_10to105()
        {
            //Init data
            int foxCurrentPopulation = 10;
            int foxBirth = 3;
            int foxDeath = 1;
            int foxEcoCapacity = 200;
            int foxExpectedPopulation = 50;

            int rabbitCurrentPopulation = 10;
            int rabbitBirth = 7;
            int rabbitDeath = 2;
            int rabbitEcoCapacity = 500;
            int rabbitExpectedPopulation = 105;


            //Actions
            Species fox = new Species("fox", foxCurrentPopulation, foxBirth, foxDeath, foxEcoCapacity);
            Ecosystem.GetInstance().AddSpecies(fox);

            Species rabbit = new Species("rabbit", rabbitCurrentPopulation, rabbitBirth, rabbitDeath, rabbitEcoCapacity);
            Ecosystem.GetInstance().AddSpecies(rabbit);

            fox.Relations[0] = -0.1;
            fox.Relations[1] = 0.3;

            rabbit.Relations[0] = -0.05;
            rabbit.Relations[1] = 0.5;


            IMathModel lm = new N_SpaciesModel_General();
            lm.Recount();

            //Check
            Assert.AreEqual(foxExpectedPopulation, fox.Population);
            Assert.AreEqual(rabbitExpectedPopulation, rabbit.Population);

            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }

        [TestMethod]
        public void LogisticModelTest_10to29()
        {
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
            lm.Recount();

            //Check
            Assert.AreEqual(expectedpopulation, fox.Population);

            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }

        [TestMethod]
        public void LogisticModelTest_Extinction()
        {
            //Init data
            int currentPopulation = 10;
            int birth = 1;
            int death = 10;
            int ecoCapacity = 200;
            int expectedpopulation = 0;

            //Actions
            Species fox = new Species("fox", currentPopulation, birth, death, ecoCapacity);
            Ecosystem.GetInstance().AddSpecies(fox);
            LogisticModel lm = new LogisticModel();
            lm.Recount();

            //Check
            Assert.AreEqual(expectedpopulation, fox.Population);

            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }

        [TestMethod]
        public void LogisticModelTest_Overpopulation()
        {
            //Init data
            int currentPopulation = 250;
            int birth = 3;
            int death = 1;
            int ecoCapacity = 200;
            int expectedpopulation = 125;

            //Actions
            Species fox = new Species("fox", currentPopulation, birth, death, ecoCapacity);
            Ecosystem.GetInstance().AddSpecies(fox);
            LogisticModel lm = new LogisticModel();
            lm.Recount();

            //Check
            Assert.AreEqual(expectedpopulation, fox.Population);

            Ecosystem.GetInstance().Species.Clear();
            History.GetInstance().Data.Clear();
        }

        
    }
}
