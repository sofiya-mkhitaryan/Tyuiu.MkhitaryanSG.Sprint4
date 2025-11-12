using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task2.V6.Lib
{
    public class DataService : ISprint4Task2V6
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                int product = 1; // Начальное значение произведения
                bool hasOdd = false; // Флаг для проверки наличия нечетных элементов

                foreach (var num in array)
                {
                    if (num % 2 != 0) // Проверяем на нечетность
                    {
                        product *= num;
                        hasOdd = true; // Устанавливаем флаг, если найден хотя бы один нечетный элемент
                    }
                }

                return hasOdd ? product : 0; // Если нечетные элементы отсутствуют, возвращаем 0
            }
            return sum;
        }
    }
}
