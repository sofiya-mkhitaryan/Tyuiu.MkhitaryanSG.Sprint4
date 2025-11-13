using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task4.V9.Lib
{
    public class DataService : ISprint4Task4V9
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0; // Сумма четных элементов

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) // Проверяем на четность
                    {
                        sum += matrix[i, j]; // Добавляем к сумме
                    }
                }
            }

            return sum; // Возвращаем сумму четных элементов
        }
    }
}
