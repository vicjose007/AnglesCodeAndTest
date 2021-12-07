using Angles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AnglesTesting
{
    [TestClass]
    public class AngleTest
    {
        [Fact]
        public void Validate_Magnitud()
        {
            Angle obj = new Angle(2, 4);

            double value = 4.47213595499958;

            Assert.AreEqual(value, obj.Magnitud());

        }
    }
}