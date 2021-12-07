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
            Angle obj = new Angle(2,4);

            double value = 4.47213595499958;

            Assert.AreEqual(value, obj.Magnitud());

        }
        [Fact]
        public void Validate_Dot_Product()
        {
            Angle obj = new Angle(2, 4);
            Angle obj2 = new Angle(3, 6);

            double value = 30;

            Assert.AreEqual(value, obj.DotProduct(obj, obj2));

        }
        [Fact]
        public void Validate_Angles_Between()
        {
            Angle obj = new Angle(2, 4);
            Angle obj2 = new Angle(3, 6);

            double value = 0;

            Assert.AreEqual(value, obj.AngleBetween(obj, obj2));

        }
    }
}