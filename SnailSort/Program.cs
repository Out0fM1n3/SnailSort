using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Создаем новый экземпляр класса Random

            var array = new int[3, 3]; // Создаем двумерный массив размером 5 на 5 элементов типа int

            for (var i = 0; i < 3; i++) // Цикл по строкам массива
            {
                for (var j = 0; j < 3; j++) // Цикл по столбцам массива
                {
                    array[i, j] = rnd.Next(1, 10 + 1); // Заполняем каждый элемент массива случайным числом от 1 до 10 включительно
                }
            }
            WriteArray(array); // Вызываем метод WriteArray с аргументом array

            // Вызов метода Snail и получение результата
            List<int> result = Solution.Snail(array);

            Console.WriteLine();
            // Вывод результата
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        static int[,] WriteArray(int[,] array) // Объявляем статический метод WriteArray с двумерным массивом типа int[,] в качестве параметра и возвращаемым значением
        {
            for (int i = 0; i < array.GetLength(0); i++) // Цикл по строкам массива
            {
                for (int j = 0; j < array.GetLength(1); j++) // Цикл по столбцам массива
                {
                    Console.Write(array[i, j] + " "); // Выводим значение текущего элемента массива и пробел в стандартный выходной поток
                }
                Console.WriteLine(); // Переходим на новую строку в стандартном выходном потоке
            }
            return array; // Возвращаем двумерный массив array без изменений
        }
    }
}
