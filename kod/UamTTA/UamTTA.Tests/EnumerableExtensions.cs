using System.Linq;
using NUnit.Framework;

namespace UamTTA.Tests
{
    [TestFixture]
    public class EnumerableExtensionsTests
    {
        [Test]
        public void ToElementsString_Should_Return_Empty_Braces_For_Empty_Enumeration()
        {
            var empty = Enumerable.Empty<object>();

            var actual = EnumerableExtensions.ToElementsString(empty);

            Assert.AreEqual("[]", actual);
        }
    }
}