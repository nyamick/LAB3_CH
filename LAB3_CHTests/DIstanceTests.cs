using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB3_CH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CH;

namespace LAB3_CH.Tests
{
    [TestClass()]
    public class LengthTests
    {

        [TestMethod()]
        public void AddNumberTest()
        {
            var distance = new DIstance(1, MeasureType.Ms);
            distance = distance + 2;
            Assert.AreEqual(new DIstance(3, MeasureType.Ms), distance);
        }
      
        [TestMethod()]
        public void SubNumberTest()
        {
            var distance = new DIstance(3, MeasureType.Ms);
            distance = distance - 2;
            Assert.AreEqual(new DIstance(1, MeasureType.Ms), distance);
        }
        [TestMethod()]
        public void ConvertToTest()
        {
            DIstance distance;
            distance = new DIstance(1, MeasureType.KMh);
            Assert.AreEqual("0,2777777777777778 м/с", distance.To(MeasureType.Ms).Verbose());

            distance = new DIstance(1, MeasureType.Uz);
            Assert.AreEqual("1,944 м/с", distance.To(MeasureType.Ms).Verbose());

            distance = new DIstance(1, MeasureType.Max);
            Assert.AreEqual("333,000333 м/с", distance.To(MeasureType.Ms).Verbose());
        }
        [TestMethod()]
        public void AddSubKmMetersTest()
        {
       
            DIstance Test1 = new DIstance(10, MeasureType.KMh);
            DIstance Test2 = new DIstance(2, MeasureType.Ms);
            DIstance Test3 = Test1 + Test2;
            Assert.AreEqual(new DIstance(17.2, MeasureType.KMh), Test3);



           
        }
        [TestMethod()]
        public void AddMultiplicateTest()
        {
            var distance = new DIstance(4, MeasureType.Ms);
            distance = distance * 2;
            Assert.AreEqual(new DIstance(8, MeasureType.Ms), distance);
        }
        [TestMethod()]
        public void AddСomparisonKmMetersTest2()
        {
            var firstSpeed = new DIstance(10, MeasureType.Ms);
            var secondSpeed = new DIstance(37, MeasureType.KMh);
            var result = firstSpeed.Compare(firstSpeed, secondSpeed);
            Assert.AreEqual(false, result);
        }
    }
}