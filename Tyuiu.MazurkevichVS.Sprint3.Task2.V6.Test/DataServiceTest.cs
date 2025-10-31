using Tyuiu.MazurkevichVS.Sprint3.Task2.V6.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MultSeriesExpression()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startvalue = 1;
            int stopvalue = 10;
            double multseries = ds.GetMultiplySeries(value, startvalue, stopvalue);
            double expected = 0.019;
            Assert.AreEqual(expected, multseries);
        }
    }
}
