using Tyuiu.SobjaninMI.Sprint1.Task4.V2.Lib;

namespace Tyuiu.SobjaninMI.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.2, res);
        }
    }
}