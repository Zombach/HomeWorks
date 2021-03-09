using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Text
{
    public static class TextVariables
    {
        public static string[][] VariablesText(string[][] dataText, int x = 1, int i = 0)
        {
            dataText[x][i++] = "\n\n\n                      РАЗДЕЛ № 1 Переменные\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 1\n" +
                "Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2)/(B-A)\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 2\n" +
                "Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 3\n" +
                "Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 4" +
                "\nПользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X)" +
                "\nлинейного уравнения стандартного вида, где A*X+B=C.\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 5" +
                "\nПользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.\n" +
                "Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.\n";
            dataText[x][i] = "Введите номер задания, от 1 до 5: ";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }

        public static string[][] VariablesTextAnswers(string[][] dataText, int x = 2, int i = 0)
        {
            dataText[x][i++] = "\nОтвет: ";
            dataText[x][i++] = "\nРешения данного уровнения (5*A+B*B)/(B-A) = ";
            dataText[x][i++] = "\nПосле обмена переменных, значения А и Б стали: ";
            dataText[x][i++] = "\nРезультат деления значений А на В и их остаток: ";
            dataText[x][i++] = "\nРешения линейного уровнения A*X+B=C, являются значения Х = ";
            dataText[x][i++] = "\nДанное уравнение не имеет решений\n";
            dataText[x][i++] = "\nДанное уравнение имеет неограниченное колличество решений";
            dataText[x][i] = "\nУравнение прямой проходящее через эти точки: ";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }


    }
}
