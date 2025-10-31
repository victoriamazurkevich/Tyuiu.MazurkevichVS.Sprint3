using Tyuiu.MazurkevichVS.Sprint3.Task5.V28.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SumExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue2 = 12;
            int stopValue1 = 3;
            double sumseries = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double expected = -1032.182;
            Assert.AreEqual(expected, sumseries);
        }
    }
}
