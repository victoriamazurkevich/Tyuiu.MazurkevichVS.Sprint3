using Tyuiu.MazurkevichVS.Sprint3.Task4.V22.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculEpression()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double expected = 73.346;
            Assert.AreEqual(expected, res);
        }
    }
}
