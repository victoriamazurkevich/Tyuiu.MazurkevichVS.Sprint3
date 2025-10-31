using Tyuiu.MazurkevichVS.Sprint3.Task6.V3.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SumDivisorsExpression()
        {
            DataService ds = new DataService();
            int startValue = 13;
            int stopValue = 19;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int expected = 121;
            Assert.AreEqual(expected, res);
        }
    }
}
