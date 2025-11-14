//Дан строковый массив данных ["Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby"]
//используя класс Array подсчитайте количество элементов, длина которых равна 6.
using Tyuiu.MkhitaryanSG.Sprint4.Task6.V17.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Класс Array                                                         *");
        Console.WriteLine("* Задание #6                                                                *");
        Console.WriteLine("* Вариант #17                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Дан строковый массив данных. Используя класс Array подсчитайте            *");
        Console.WriteLine("* количество элементов, длина которых равна 6.                              *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");
       
        var prog = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < prog.Length; i++)
        {
            Console.WriteLine(prog[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Получаем сумму четных элементов
        int nums = ds.Calculate(prog);
        Console.WriteLine($"Количество элементов длина которых = 7: {nums}");

        Console.ReadKey();
    }
}