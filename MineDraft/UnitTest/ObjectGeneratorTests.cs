using System;
using System.Collections.Generic;
using ClassLib.Business_Logic;
using ClassLib.Models.Harvester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ObjectGeneratorTests
    {
        [TestMethod]
        public void PrüftReturnStringDerRegisterMethodsImManager()
        {
            // Arrange
            var dummyList = new List<string> {"ENQ-16853-4588", "5000", "2600", "HAmMeR"};
            const string expectedString = "Neuen hammer-Harvester erfolgreich registriert.";

            // Act
            var manager = new DraftManager();
            var returnString = manager.RegisterHarvester(dummyList);

            // Assert
            Assert.AreEqual(expectedString, returnString);
            
        }

        [TestMethod]
        public void PrüftDictionaryImManager()
        {
            // Arrange
            var expectedHarvester = new HammerHarvester("ENQ-16853-4588", 5000, 2600, "hammer");
            var dummyList = new List<string> { "ENQ-16853-4588", "5000", "2600", "HAmMeR" };

            // Act
            var manager = new DraftManager();
            manager.RegisterHarvester(dummyList);

            // Assert
            Assert.AreEqual(expectedHarvester.HarvesterId, manager.harvesterList["ENQ-16853-4588"].HarvesterId);
        }
    }
}
