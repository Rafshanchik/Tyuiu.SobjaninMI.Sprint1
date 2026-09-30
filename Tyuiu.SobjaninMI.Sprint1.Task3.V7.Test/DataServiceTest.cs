using Tyuiu.SobjaninMI.Sprint1.Task3.V7.Lib;

namespace Tyuiu.SobjaninMI.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double versts = 100;
            var res = ds.VerstsToKilometers(versts);
            Assert.AreEqual(106.68, res);
        }
    }
}