using CalculateDegree;

namespace DegreeConverter.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
            
        }

        [Test]
        public void ToFahrenheit_ZeroCelcius_Returns32Fahrenhite()
        {
            Degree degreeInstance = new Degree();
            double result = degreeInstance.ToFahrenheit(0);
            Assert.That(result, Is.EqualTo(32));
        }
    }
}