using Tyuiu.MkhitaryanSG.Sprint4.Task7.V4.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int row = 3;
            int col = 4;
            int[,]matrx = new int[row, col];
            string str = "382976421897";
            DataService ds = new DataService();
            int res = ds.Calculate(row, col, str);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
