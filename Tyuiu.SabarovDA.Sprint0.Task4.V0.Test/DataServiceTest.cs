﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SabarovDA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SabarovDA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()

        {
            Assert.AreEqual(10, DataService.Addition(5, 5));

        }
        public void CheckedSubstractionValid()
        {

            Assert.AreEqual(5, DataService.Subtraction(10, 5));

        }

        public void CheckedMuliplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));

        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
