using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DistanceConverter.Tests
{
    [TestFixture]
    public class TestDistanceConverter
    {
        [Test]
        public void TestConverter()
            {
            DistanceConverter converter = new DistanceConverter();
            Assert.AreEqual(8.04672, converter.FromMilesToKm(5), 0.001d);
        }

    }
}
