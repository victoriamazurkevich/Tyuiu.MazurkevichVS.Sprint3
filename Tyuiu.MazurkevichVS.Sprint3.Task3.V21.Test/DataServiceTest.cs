using Tyuiu.MazurkevichVS.Sprint3.Task3.V21.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void RepNumOnChar()
        {
            DataService ds = new DataService();
            string value = "f3g5ht g4j 34kg4";
            char item = 'e';
            value = ds.ReplaceNumOnChar(value, item);
            string expected = "fegeht gej eekge";
            Assert.AreEqual(expected, value);
        }
    }
}
