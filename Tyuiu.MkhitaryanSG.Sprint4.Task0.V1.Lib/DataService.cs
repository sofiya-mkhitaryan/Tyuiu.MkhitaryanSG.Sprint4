using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task0.V1.Lib
{
    public class DataService : ISprint4Task0V1
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0) // Проверка на четность
                {
                    sum += number; // Суммируем четные элементы
                }
            }
            return sum;
        }
    }
}
