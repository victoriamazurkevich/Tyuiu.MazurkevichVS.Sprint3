using Tyuiu.MazurkevichVS.Sprint3.Task1.V25.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MultSeriesExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            int startvalue = 1;
            int stopvalue = 6;
            double multseries = ds.GetMultiplySeries(value, startvalue, stopvalue);
            double expected = 844.664;
            Assert.AreEqual(expected, multseries);
        }
    }
}
