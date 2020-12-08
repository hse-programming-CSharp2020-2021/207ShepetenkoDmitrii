using System;
using static MyLib.Rename;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            GeomProgr geomProgrObj;
            bool flag;
            int b, q, n;
            do
            {
                flag = false;
                try
                {
                    Console.Write("Введите начальный член прогрессии: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Введите знаменатель прогрессии: ");
                    q = int.Parse(Console.ReadLine());
                    geomProgrObj = new GeomProgr(b, q);
                    do
                    {
                        try
                        {
                            Console.Write("Введите номер элемента:");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{n}-й элемент = {geomProgrObj[n]}  сумма {n} элементов = {geomProgrObj.ProgrSum(n)}");
                            Console.WriteLine("Чтобы завершить программу, нажмите Esc...");
                        }
                        catch (ArgumentNullException e1)
                        {
                            Console.WriteLine(e1.Message);
                            Console.WriteLine("Чтобы завершить программу, нажмите Esc...");
                            Console.ReadKey();
                        }                        
                        catch (FormatException e2)
                        {
                            Console.WriteLine(e2.Message);
                            Console.WriteLine("Чтобы завершить программу, нажмите Esc...");
                            Console.ReadKey();
                        }
                        catch (OverflowException e3)
                        {
                            Console.WriteLine(e3.Message);
                            Console.WriteLine("Чтобы завершить программу, нажмите Esc...");
                            Console.ReadKey();
                        }
                        catch(ArgumentException e4)
                        {
                            Console.WriteLine(e4.Message);
                            Console.WriteLine("Чтобы завершить программу, нажмите Esc...");
                            Console.ReadKey();
                        }
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                }
                catch (ArgumentNullException e1)
                {
                    flag = true;
                    Console.WriteLine("Некорректные входные данные! ");
                }
                catch (FormatException e2)
                {
                    flag = true;
                    Console.WriteLine("Некорректные входные данные! ");
                }
                catch (OverflowException e3)
                {
                    flag = true;
                    Console.WriteLine("Некорректные входные данные! ");
                }
            } while (flag);
        }
    }

}
