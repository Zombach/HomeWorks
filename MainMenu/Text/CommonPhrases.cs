using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Text
{
    public static class CommonPhrases
    {
        public static string[][] PhrasesCommon(string[][] dataText, int x = 12, int i = 0)
        {
            dataText[x][i++] = "Введите число A = ";
            dataText[x][i++] = "Введите число B = ";
            dataText[x][i++] = "Введите число C = ";
            dataText[x][i++] = "Введите число X1 = ";
            dataText[x][i++] = "Введите число Y1 = ";
            dataText[x][i++] = "Введите число X2 = ";
            dataText[x][i++] = "Введите число Y2 = ";
            dataText[x][i++] = "Введите двухзначное число: ";
            dataText[x][i++] = "Укажите размер массива: ";
            dataText[x][i++] = "Укажите множитель изменения чисел массива: ";
            dataText[x][i++] = "\n3";
            dataText[x][i++] = "\n4";
            dataText[x][i++] = "\n1";
            dataText[x][i++] = "\n2";
            dataText[x][i++] = "\n3";
            dataText[x][i++] = "\nВы ввели не правильное число";
            dataText[x][i] = "\nВременные данные";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }
    }
}
