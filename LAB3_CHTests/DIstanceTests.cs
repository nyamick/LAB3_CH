using Microsoft.VisualStudio.TestTools.UnitTesting;
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

    }
}