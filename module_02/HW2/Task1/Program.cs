using System;
using System.ComponentModel;

namespace Task1
{
    class Birthday
    {
        string name;
        int year, month, day;
        public Birthday(string n, int y, int m, int d)
        {
            name = n;
            year = y;
            month = m;
            day = d;
        }
        public Birthday(string n)
        {
            name = n;
            year = 1970;
            month = 1;
            day = 1;
        }
        DateTime BirthDate
        {
            get
            {
                return new DateTime ( year, month, day );
            }
        }
        public string Info1
        {
            get
            {
                return name + " , день рождения:" + day + " " + month + " " + year;
            }
        }
        public string Info2
        {
            get
            {
                string[] m = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря", };
                return name + " , день рождения:" + day + " " + m[month-1] + " " + year;
            }
        }
        public int HowManyDays
        {
            get
            {
                int today = DateTime.Today.DayOfYear;
                int birth = BirthDate.DayOfYear;
                return (birth > today) ? birth - today : 365 - (today - birth);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Birthday bd;
                Console.WriteLine("Введите свое имя");
                string s,name = Console.ReadLine();
                do
                {
                    Console.WriteLine("Будете ли вы вводить свою дату рождения или установить по умолчанию(Введите 'да' или 'нет')");
                    s = Console.ReadLine();
                } while ((s != "да") & (s != "нет"));
                if (s == "нет")
                {
                    bd = new Birthday(name);
                }
                else
                {
                    int m, d, y;
                    do
                    {
                        Console.WriteLine("Введите день");
                    } while (!int.TryParse(Console.ReadLine(), out d));
                    do
                    {
                        Console.WriteLine("Введите месяц");
                    } while (!int.TryParse(Console.ReadLine(), out m));
                    do
                    {
                        Console.WriteLine("Введите год");
                    } while (!int.TryParse(Console.ReadLine(), out y));
                    bd = new Birthday(name, y, m, d);
                }
                int k;
                do
                {
                    Console.WriteLine("Как вывести месяц?\n1 - Цифрами\n2 - Буквами");
                } while (!int.TryParse(Console.ReadLine(), out k) | (k > 2) | (k < 1));
                if(k==1)
                    Console.WriteLine(bd.Info1);
                else
                    Console.WriteLine(bd.Info2);
                Console.WriteLine("До следующего дня рождения осталось вот столько дней: "+bd.HowManyDays);
                Console.WriteLine("Для выхода нажмите Esc");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
