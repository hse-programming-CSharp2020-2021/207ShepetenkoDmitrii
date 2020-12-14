using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            string[] ss = Abb.ValidatedSplit(s, ';');
            if (ss == null)
                Console.WriteLine("Неверный ввод");
            else
            {
                foreach (string a in ss)
                {
                    Console.WriteLine(Abb.Abbrevation(a));
                }
            }
            Console.WriteLine("Нажмите Esxc для завершения...");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);        
    }
}