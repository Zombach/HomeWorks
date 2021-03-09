using System;
using System.Collections.Generic;
using System.Text;

namespace MainMenu.Text
{
    public static class TextStart
    {
        public static string[][] StartText(string[][] dataText, int x = 0, int i = 0)
        {
            dataText[x][i++] = "Добро пожаловать! Выберете интересующий вас раздел\n\n\n";
            dataText[x][i++] = "          ОГЛАВЛЕНИЕ\n\n";
            dataText[x][i++] = "РАЗДЕЛ № 1 Переменные\n";
            dataText[x][i++] = "РАЗДЕЛ № 2 Структуры Ветвления\n";
            dataText[x][i++] = "РАЗДЕЛ № 3 Циклы\n";
            dataText[x][i++] = "РАЗДЕЛ № 4 Одномерные массивы\n";
            dataText[x][i++] = "РАЗДЕЛ № 5 Двухмерные массивы\n";
            dataText[x][i++] = "ДЛЯ ВЫХОДА ИЗ ПРОГРАММЫ - НАЖМИТЕ 6\n";
            dataText[x][i] = "Введите номер раздела, от 1 до 6: ";
#if DEBUG
            Console.WriteLine($"Размер dataText[{x}][{i}]");
#endif
            return dataText;
        }
    }
}
