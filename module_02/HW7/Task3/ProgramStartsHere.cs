using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class ProgramStartsHere
{
    private static void BracketsCount(string tmp, ref int openBrackets, ref int closedBrackets)
    {
        bool u1 = true;
        bool u2 = true;
        for (int i = 0; i < tmp.Length; i++)
        {
            if (tmp[i] >= 'a' && tmp[i] <= 'z')
                stat[tmp[i] - 'a']++;            
            if (u1&u2)
            {
                if (tmp[i] == '{') openBrackets++;
                if (tmp[i] == '}') closedBrackets++;
                if (tmp[i] == '\"')
                    u1 = false;
                if (tmp[i] == '\'')
                    u2 = false;
            }
            else
            {
                if (tmp[i] == '\"')
                    u1 = true;
                if (tmp[i] == '\'')
                    u2 = true;
            }
        }
    }

    public static string StatToString()
    {
        string output = string.Empty;
        for (int i = 0; i < stat.Length; i++)
        {
            output += (char)('a' + i) + " - " + stat[i] + " ";
        }
        return output;
    }


    static int[] stat = new int[26];
    static void Main(string[] args)
    {
        string ou=null;
        string tmp;
        int openBrackets = 0; // количество {
        int closedBrackets = 0; // количество }
        int total = 0; // общее количество символов файла

        var In = Console.In; // Запоминаем стандартный входной поток
        // Создаем файл и текстовый входной поток: 
        StreamReader stream_in = new StreamReader(@"..\..\..\Program.cs");
        // Настраиваем стандартный входной поток на чтение из файла:
        Console.SetIn(stream_in);
        // чтение из файла
        // восстановление потока
        while (true)
        { // цикл бесконечен
            tmp = stream_in.ReadLine();
            if (tmp == null) break; // условие прерывание цикла
            total += tmp.Length;
            // подсчёт количества фигурных скобок
            BracketsCount(tmp, ref openBrackets, ref closedBrackets);
            ou += tmp + "\n";
        }
        // восстанавливаем состояние потока
        stream_in.Close();
        Console.SetIn(In);
        // обрабатываем данные по скобкам
        tmp = "Баланс скобок не соблюдён";
        if (openBrackets == closedBrackets)
            tmp = "Баланс скобок соблюдён, количество блоков " + closedBrackets;
        ou += StatToString() + "\n";
        ou += tmp + "\n";
        File.WriteAllText("output.txt", ou);
        Console.WriteLine("Результат работы сохранен в output.txt");
        Console.WriteLine("Для завершения работы нажмите любую клавишу.");
        Console.ReadKey();

    }
}
