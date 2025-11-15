//Дана строка из одноразрядных цифр "382976421897". Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.
using Tyuiu.MkhitaryanSG.Sprint4.Task7.V4.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                   *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #4                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"382976421897\".                       *");
        Console.WriteLine("* Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.      *");
        Console.WriteLine("*****************************************************************************");


        int rows = 3; // строки
        int columns = 4; // /столбцы
        int[,] mas2 = new int[rows, columns];
        string str = "382976421897";

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        int index = 0;

        // Выводим массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t"); // для вывода в одной строке
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(rows, columns, str);
        Console.WriteLine($"Сумма нечетных элементов: {res}");
        Console.ReadKey();
    }
}