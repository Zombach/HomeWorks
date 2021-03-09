using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Text
{
    public static class NumbersInWords
    {
        public static string[][] WordsNumbers(string[][] dataText, int x = 11, int i = 0)
        {
            dataText[x][i++] = "один\n";
            dataText[x][i++] = "два\n";
            dataText[x][i++] = "три\n";
            dataText[x][i++] = "четыре\n";
            dataText[x][i++] = "пять\n";
            dataText[x][i++] = "шесть\n";
            dataText[x][i++] = "семь\n";
            dataText[x][i++] = "восемь\n";
            dataText[x][i++] = "девять\n";
            dataText[x][i++] = "Десять\n";
            dataText[x][i++] = "Одиннадцать";
            dataText[x][i++] = "Двенадцать";
            dataText[x][i++] = "Тринадцать";
            dataText[x][i++] = "Четырнадцать";
            dataText[x][i++] = "Пятнадцать";
            dataText[x][i++] = "Шестнадцать";
            dataText[x][i++] = "Семьнадцать";
            dataText[x][i++] = "Восемнадцать";
            dataText[x][i++] = "Девятьнадцать";
            dataText[x][i++] = "Двадцать";
            dataText[x][i++] = "Тридцать";
            dataText[x][i++] = "Сорок";
            dataText[x][i++] = "Пятьдесят";
            dataText[x][i++] = "Шестьдесят";
            dataText[x][i++] = "Семьдесят";
            dataText[x][i++] = "Восемьдесят";
            dataText[x][i] = "Девяносто";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }
    }
}
