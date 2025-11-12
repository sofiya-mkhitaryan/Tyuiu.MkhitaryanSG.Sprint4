//Вариант 29
//Дан одномерный целочисленный массив на 14 элементов заполненный значениями
//с клавиатуры в диапазоне от 1 до 9 подсчитать сумму нечетных элементов массива.
//С клавиатуры: 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8
using Tyuiu.MkhitaryanSG.Sprint4.Task1.V29.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                              *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #29                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный           *");
        Console.WriteLine("* статическими значениями в диапазоне от 1 до 9                             *");
        Console.WriteLine("* подсчитать сумму нечетных {5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8}      *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        int len = 14; // Установим фиксированное значение 14
        int[] nums = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine($"Введите значение {i} элемента массива (от 1 до 9): ");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 9)
            {
                Console.WriteLine("Ошибка ввода! Введите число от 1 до 9.");
            }
            nums[i] = input;
        }

        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(nums[i] + "\t"); // Используем Console.Write для вывода в одной строке
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Получаем сумму нечетных элементов
        int res = ds.Calculate(nums);
        Console.WriteLine($"Сумма нечетных элементов: {res}");
        Console.ReadKey();
    }
}