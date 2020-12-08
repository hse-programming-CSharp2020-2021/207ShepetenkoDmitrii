using System;
using static MyLib.Rename;

namespace Task1
{
    class Program
    {
        public static void Main()
        {
            Matrix res=new Matrix(); // ссылка на двумерный массив (матрица)
            int rank; // Порядок матрицы
            do
            { // цикл повторения решений
                try
                {
                    rank = ForMatrix.GetIntValue("Введите порядок матрицы: ");
                    res.UnitMatr(rank);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (ArgumentNullException e1) 
                {
                    Console.WriteLine(e1.Message);
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (FormatException e2)
                {
                    Console.WriteLine(e2.Message);
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (OverflowException e3)
                {
                    Console.WriteLine(e3.Message);
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }

                res.MatrPrint();
                Console.WriteLine("Для завершения программы нажмите ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }

}
