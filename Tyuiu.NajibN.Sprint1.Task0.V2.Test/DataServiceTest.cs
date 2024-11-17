using Tyuiu.NajibN.Sprint1.Task0.V2.Lib;

namespace Tyuiu.NajibN.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate_ShouldReturnExpectedResult()
        {
            // Arrange
            DataService dataService = new DataService();
            double expected = 6.0; // This should match the result of your Calculate() method.

            // Act
            double result = dataService.Calculate(); // Call Calculate on the instance

            // Assert
            Assert.AreEqual(expected, result, 0.0001); // Adding a tolerance for double comparison
        }
    }
}