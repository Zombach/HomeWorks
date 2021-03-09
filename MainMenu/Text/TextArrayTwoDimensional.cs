using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Text
{
    public static class TextArrayTwoDimensional
    {
        public static string[][] ArrayTwoDimensionalText(string[][] dataText, int x = 9, int i = 0)
        {
            dataText[x][i++] = "\n\n\n                      РАЗДЕЛ № 5 Двухмерные массивы\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 1\n" +
                "Найти минимальный элемент массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 2\n" +
                "Найти максимальный элемент массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 3\n" +
                "Найти индекс минимального элемента массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 4\n" +
                "Найти индекс максимального элемента массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 5\n" +
                "Найти количество элементов массива, которые больше всех своих соседей одновременно\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 6\n" +
                "Отразите массив относительно его главной диагонали.\n";
            dataText[x][i] = "Введите номер раздела, от 1 до 6: ";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }

        public static string[][] ArrayTwoDimensionalTextAnswers(string[][] dataText, int x = 10, int i = 0)
        {
            dataText[x][i++] = "\nОтвет: ";
            dataText[x][i++] = "Минимальный элемент масива равен: \n1";
            dataText[x][i++] = "Максимальный элемент масива равен: \n2";
            dataText[x][i++] = "Индекс минимального элемента масива равен: \n3";
            dataText[x][i++] = "Индекс максимального элемента масива равен: \n4";
            dataText[x][i++] = "Колличество элементов массива, которые больше всех своих соседей ранво: \n5";
            dataText[x][i] = "Отраженный двухмерный массив относительно своей главной диагонали:\n5";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }
    }
}
