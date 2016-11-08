using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGFramework;
using RPGFramework.Entities;
using RPGFramework.Processes;
using RPGFramework.Renderer;

namespace RPGFrameWork.Tests
{
    [TestClass]
    public class EntitiesTests
    {
        [TestCategory("Classes")]
        [TestMethod]
        public void GetClasses()
        {
            EntityClass classGroup = new EntityClass();
            Assert.AreEqual("Barbarian", classGroup.GetClasses[0]);
            Assert.AreEqual("Builder", classGroup.GetClasses[1]);
            Assert.AreEqual("Thief", classGroup.GetClasses[2]);
            Assert.AreEqual("Mage", classGroup.GetClasses[3]);
            Assert.AreEqual("Civilian", classGroup.GetClasses[4]);
        }
    }
}
