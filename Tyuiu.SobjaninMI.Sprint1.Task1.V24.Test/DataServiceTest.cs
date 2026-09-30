using Tyuiu.SobjaninMI.Sprint1.Task1.V24.Lib;

namespace Tyuiu.SobjaninMI.Sprint1.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.2, res);
        }
    }
}