using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Text
{
    public static class TextBranching
    {
        public static string[][] BranchingText(string[][] dataText, int x = 3, int i = 0)
        {
            dataText[x][i++] = "\n\n\n                      РАЗДЕЛ № 2 Структуры Ветвления\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 1\n" +
                "Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 2\n" +
                "Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 3\n" +
                "Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 4\n" +
                "Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного" +
                "\n уравнения стандартного вида, где AX^2+BX+C=0.\n";
            dataText[x][i++] = "                            ЗАДАНИЕ № 5\n" +
                "Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25”\n" +
                "в консоль будет выведено “двадцать пять”.\n";
            dataText[x][i] = "Введите номер раздела, от 1 до 5: ";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }

        public static string[][] BranchingTextAnswers(string[][] dataText, int x = 4, int i = 0)
        {
            dataText[x][i++] = "\nОтвет: ";
            dataText[x][i++] = "\nРаз А > B то сумма А + B = ";
            dataText[x][i++] = "\nРаз А = B то произведение А * B = ";
            dataText[x][i++] = "\nРаз А < B то разность А - B = ";
            dataText[x][i++] = "\nПервой четверти принадлежит точка с координатами: ";
            dataText[x][i++] = "\nВторой четверти принадлежит точка с координатами: ";
            dataText[x][i++] = "\nТретий четверти принадлежит точка с координатами: ";
            dataText[x][i++] = "\nЧетвертой четверти принадлежит точка с координатами: ";
            dataText[x][i++] = "\nТочка лежит на оси с координатами";
            dataText[x][i++] = "\nЧисла А В С в порядке возврастания: ";
            dataText[x][i++] = "\nКорни уравнения равны: ";
            dataText[x][i++] = "\nУ данного уравнения нет корней";
            dataText[x][i++] = "\nДанное уравнение не квадратное!";
            dataText[x][i++] = "\n";
            dataText[x][i++] = "\n";
            dataText[x][i++] = "\n";
            dataText[x][i++] = "\n";
            dataText[x][i] = "\n";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }

    }
}
