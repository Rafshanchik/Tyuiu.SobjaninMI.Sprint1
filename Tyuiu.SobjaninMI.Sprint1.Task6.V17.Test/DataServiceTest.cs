using Tyuiu.SobjaninMI.Sprint1.Task6.V17.Lib;

namespace Tyuiu.SobjaninMI.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "шалаш";
            var res = ds.CheckPalindrome(value);
            Assert.AreEqual(true, res);
        }
    }
}