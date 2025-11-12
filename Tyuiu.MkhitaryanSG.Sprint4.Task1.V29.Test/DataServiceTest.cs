using Tyuiu.MkhitaryanSG.Sprint4.Task1.V29.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] nums = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            int res = ds.Calculate(nums);
            int wait = 31;
            Assert.AreEqual(wait, res);
        }
    }
}
