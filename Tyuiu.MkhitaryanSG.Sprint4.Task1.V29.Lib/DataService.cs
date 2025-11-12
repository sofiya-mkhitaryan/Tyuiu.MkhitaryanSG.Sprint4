using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                if (number % 2 != 0) // Проверка на четность
                {
                    sum += number; // Суммируем четные элементы
                }
            }
            return sum;
        }
    }
}
