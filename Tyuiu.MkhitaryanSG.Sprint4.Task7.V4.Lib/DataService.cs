using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MkhitaryanSG.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrx = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //matrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                    matrx[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrx[i, j] % 2 != 0) // Проверяем на нечетность
                    {
                        sum += matrx[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
