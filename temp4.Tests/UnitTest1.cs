using NUnit.Framework;

namespace temp4.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase("hello")]
        [TestCase("mum")]
        public void EchoEchoesValue(string value)
        {
            var sut = new Class1();
            var actual = sut.Echo(value);
            Assert.AreEqual(value, actual);
        }
    }
}