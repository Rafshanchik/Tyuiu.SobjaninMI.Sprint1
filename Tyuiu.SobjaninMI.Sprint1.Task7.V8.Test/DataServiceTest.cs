using Tyuiu.SobjaninMI.Sprint1.Task7.V8.Lib;

namespace Tyuiu.SobjaninMI.Sprint1.Task7.V8.Test
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
            Assert.AreEqual(-1.384, res);
        }
    }
}