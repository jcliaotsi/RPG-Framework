using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGFramework;
using RPGFramework.Entities;
using RPGFramework.Processes;
using RPGFramework.Renderer;
using System.Collections.Generic;

namespace RPGFrameWork.Tests
{
    [TestClass]
    public class ProcessesTests
    {
        [TestMethod]
        public void RollD6()
        {
            Dice d = new Dice();
            int result;
            List<int> results = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                result = d.RollD6();
                results.Add(result);
                Assert.IsTrue(result > 0 && result < 7);
            }
        }

        [TestMethod]
        public void RollD8()
        {
            Dice d = new Dice();
            int result;
            List<int> results = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                result = d.RollD8();
                results.Add(result);
                Assert.IsTrue(result > 0 && result < 9);
            }
        }

        [TestMethod]
        public void RollD10()
        {
            Dice d = new Dice();
            int result;
            List<int> results = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                result = d.RollD10();
                results.Add(result);
                Assert.IsTrue(result > 0 && result < 11);
            }
        }

        [TestMethod]
        public void RollD12()
        {
            Dice d = new Dice();
            int result;
            List<int> results = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                result = d.RollD12();
                results.Add(result);
                Assert.IsTrue(result > 0 && result < 13);
            }
        }

        [TestMethod]
        public void RollD20()
        {
            Dice d = new Dice();
            int result;
            List<int> results = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                result = d.RollD20();
                results.Add(result);
                Assert.IsTrue(result > 0 && result < 21);
            }
        }

        [TestMethod]
        public void RollD120()
        {
            Dice d = new Dice();
            int result;
            List<int> results = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                result = d.RollD120();
                results.Add(result);
                Assert.IsTrue(result > 0 && result < 121);
            }
        }
    }
}
