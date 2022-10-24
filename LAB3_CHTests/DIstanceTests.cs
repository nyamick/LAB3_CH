﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB3_CH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_CH.Tests
{
    [TestClass()]
    public class DIstanceTests
    {


        [TestMethod()]
        public void VerboseTest()
        {
            // тестируем все четыре типа
            var distance = new DIstance(38, MeasureType.Ms);
            Assert.AreEqual("38 м/с", distance.Verbose());

            distance = new DIstance(38, MeasureType.KMh);
            Assert.AreEqual("38 км/ч", distance.Verbose());

            distance = new DIstance(38, MeasureType.Uz);
            Assert.AreEqual("38 узлов", distance.Verbose());

            distance = new DIstance(38, MeasureType.Max);
            Assert.AreEqual("38 Max", distance.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var distance = new DIstance(3, MeasureType.Ms);
            distance = distance - 1.75;
            Assert.AreEqual("1,25 м/с", distance.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var distance = new DIstance(3, MeasureType.Ms);
            distance = distance * 3;
            Assert.AreEqual("9 м/с", distance.Verbose());
        }

        [TestMethod()]
        public void DivByNumberTest()
        {
            var distance = new DIstance(3, MeasureType.Ms);
            distance = distance / 3;
            Assert.AreEqual("1 м/с", distance.Verbose());
        }

        [TestMethod()]
        public void MeterToAnyTest()
        {
            DIstance distance;

            distance = new DIstance(1/3.6, MeasureType.Ms);
            Assert.AreEqual("1 км/ч", distance.To(MeasureType.KMh).Verbose());

            distance = new DIstance(1.944*2, MeasureType.Ms);
            Assert.AreEqual("2 узлов", distance.To(MeasureType.Uz).Verbose());

            distance = new DIstance(333.000333 * 3, MeasureType.Ms);
            Assert.AreEqual("3 Max", distance.To(MeasureType.Max).Verbose());
        }

        [TestMethod()]
        public void AnyToMeterTest()
        {
            DIstance distance;

            distance = new DIstance(3.6, MeasureType.KMh);
            Assert.AreEqual("1 м/с", distance.To(MeasureType.Ms).Verbose());

            distance = new DIstance(1, MeasureType.Uz);
            Assert.AreEqual("1,944 м/с", distance.To(MeasureType.Ms).Verbose());

            distance = new DIstance(1, MeasureType.Max);
            Assert.AreEqual("333,000333 м/с", distance.To(MeasureType.Ms).Verbose());
        }
        [TestMethod()]
        public void AddSubKmMetersTest()
        {
            var ms = new DIstance(1, MeasureType.Ms);
            var kmh = new DIstance(3.6, MeasureType.KMh);

            Assert.AreEqual("2 м/с", (ms + kmh).Verbose());
            Assert.AreEqual("7,2 км/ч", (kmh + ms).Verbose());

            Assert.AreEqual("0 км/ч", (kmh - ms).Verbose());
            Assert.AreEqual("0 м/с", (ms - kmh).Verbose());
        }

    }
}