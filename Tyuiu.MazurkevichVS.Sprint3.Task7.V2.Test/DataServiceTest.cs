using Tyuiu.MazurkevichVS.Sprint3.Task7.V2.Lib;
namespace Tyuiu.MazurkevichVS.Sprint3.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MassFunctionExpression()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] ValidExpectedArray;
            ValidExpectedArray = new double[len];

            ValidExpectedArray[0] = 59.49;
            ValidExpectedArray[1] = 38.47;
            ValidExpectedArray[2] = -2.81;
            ValidExpectedArray[3] = -19.67;
            ValidExpectedArray[4] = -8.42;
            ValidExpectedArray[5] = 0.57;
            ValidExpectedArray[6] = -6.30;
            ValidExpectedArray[7] = -20.14;
            ValidExpectedArray[8] = -3.51;
            ValidExpectedArray[9] = 38.13;
            ValidExpectedArray[10] = 59.60;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(ValidExpectedArray, res);

        }
    }
}
