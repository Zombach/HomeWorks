using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Text
{
    public static class TextArraySingle
    {
        public static string[][] ArraySingleText(string[][] dataText, int x = 7, int i = 0)
        {
            dataText[x][i++] = "\n\n\n                      РАЗДЕЛ № 4 Одномерные массивы\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 1\n" +
                "Найти минимальный элемент массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 2\n" +
                "Найти максимальный элемент массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 3\n" +
                "Найти индекс минимального элемента массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 4\n" +
                "Найти индекс максимального элемента массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 5\n" +
                "Посчитать сумму элементов массива с нечетными индексами\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 6\n" +
                "Сделать реверс массива(массив в обратном направлении)\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 7\n" +
                "Посчитать количество нечетных элементов массива\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 8\n" +
                "Поменять местами первую и вторую половину массива, например:\nдля массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 9\n" +
                "Отсортировать массив по возрастанию одним из способов:\nпузырьком(Bubble), выбором(Select) или вставками(Insert))\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 10\n" +
                "Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании):\n" +
                                "пузырьком(Bubble), выбором(Select) или вставками(Insert))\n";
            dataText[x][i] = "Введите номер раздела, от 1 до 10: ";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }

        public static string[][] ArraySingleTextAnswers(string[][] dataText, int x = 8, int i = 0)
        {
            dataText[x][i++] = "\nОтвет: ";
            dataText[x][i++] = "\n1";
            dataText[x][i++] = "\n2";
            dataText[x][i++] = "\n3";
            dataText[x][i++] = "\n4";
            dataText[x][i] = "\n5";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }
    }
}
