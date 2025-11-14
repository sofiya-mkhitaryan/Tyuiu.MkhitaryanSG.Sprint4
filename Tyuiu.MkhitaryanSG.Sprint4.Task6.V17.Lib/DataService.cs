using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, prog => prog.Length == 6);
            return mas.Length;
        }
    }
}
