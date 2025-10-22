using System.Threading.Tasks.Sources;
using Tyuiu.MazurkevichVS.Sprint3.Task0.V16.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MultSeriesExpression()
        {
            DataService ds = new DataService();
            int value = 5;
            int startvalue = 1;
            int stopvalue = 10;
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);
            double expected = 19.49;
            Assert.AreEqual(expected, res);
        }
    }
}
