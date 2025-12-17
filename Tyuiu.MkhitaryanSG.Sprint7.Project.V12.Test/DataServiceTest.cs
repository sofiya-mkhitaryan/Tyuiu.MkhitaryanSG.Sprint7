using Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint7.Project.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckCalculateAverage()
        {
            DataService ds = new DataService();
            int[] valuesAverageTest = { 5, 10, 15, 20 };
            double wait = 12.5;

            double res = ds.CalculateAverage(valuesAverageTest);

            Assert.AreEqual(wait, res);
        }

        public void CheckCalculateMin()
        {
            DataService ds = new DataService();
            int[] valuesMintest = { 5, 10, 15, 20 };
            double wait = 5;

            double res = ds.CalculateMin(valuesMintest);

            Assert.AreEqual(wait, res);
        }

        public void CheckCalculateMax()
        {
            DataService ds = new DataService();
            int[] valuesMaxtest = { 5, 10, 15, 20 };
            double wait = 20;

            double res = ds.CalculateMax(valuesMaxtest);

            Assert.AreEqual(wait, res);
        }
    }
}
