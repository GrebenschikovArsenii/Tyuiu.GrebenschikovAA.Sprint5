using Tyuiu.GrebenschikovAA.Sprint5.Task2.V14.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint5.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 2,                       *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt                *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] array = new int[3, 3];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Введите элемент [{i},{j}]:");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.SaveToFileTextData(array);
            //Console.WriteLine(result);
            Console.WriteLine("Файл " + result + " создан.");
            Console.ReadKey();
        }
    }
}
