using Tyuiu.MkhitaryanSG.Sprint4.Task0.V1.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] nums = {6, 4, 3, 2, 1, 0, 9, 8, 7, 5};
            int res = ds.GetSumEvenArrEl(nums);
            int wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
