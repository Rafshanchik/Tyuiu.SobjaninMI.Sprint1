using Tyuiu.SobjaninMI.Sprint1.Task2.V28.Lib;

namespace Tyuiu.SobjaninMI.Sprint1.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 25;
            var res = ds.ConvertCelsiusToKelvin(value);
            Assert.AreEqual(298, res);
        }
    }
}