using System;

namespace MyLib
{
    public class Rename
    {
        public class Matrix
        {
            int[,] ar;            
            public Matrix()
            {
            }
            public void MatrPrint()
            {
                for(int i = 0; i < ar.GetLength(0); i++)
                {
                    for (int j = 0; j < ar.GetLength(1); j++)
                        Console.Write($"{ar[i, j]} ");
                    Console.WriteLine();
                }
            }
            public void UnitMatr(int n)
            {// Сформировать единичную матрицу:
                if (n <= 0)
                    throw new ArgumentOutOfRangeException("Аргумент метода должен быть положительным!");        
                ar = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        ar[i, j] = (i == j ? 1 : 0);
                
            }
        }
        public static class ForMatrix 
        {
            public static int GetIntValue(string comment)
            {
                do
                {
                    try
                    {
                        Console.Write(comment);
                        return int.Parse(Console.ReadLine());
                    }
                    catch (ArgumentNullException e1)
                    {
                        Console.WriteLine(e1.Message);
                        Console.WriteLine("Нажмите любую кнопку, чтобы повторить попытку");
                        Console.ReadKey();
                    }
                    catch (FormatException e2)
                    {
                        Console.WriteLine(e2.Message);
                        Console.WriteLine("Нажмите любую кнопку, чтобы повторить попытку");
                        Console.ReadKey();
                    }
                    catch (OverflowException e3)
                    {
                        Console.WriteLine(e3.Message);
                        Console.WriteLine("Нажмите любую кнопку, чтобы повторить попытку");
                        Console.ReadKey();
                    }
                } while (true);                
            }
        }



        public class GeomProgr
        {            
            public static uint objectNumber = 0;
            double _b;
            double _q;
            public double B
            {
                get { return _b; }
                set
                {
                    if (value == 0)
                        throw new Exception("Недопустимое значение первого члена прогрессии!");
                    _b = value;
                }
            }
            public double Q
            {
                get { return _q; }
                set
                {
                    if (value == 0)
                        throw new Exception("Недопустимое значение знаменателя прогрессии!");
                    _q = value;
                }
            }            
            public GeomProgr()
            {
                _b = 1;
                _q = 1;
                objectNumber++;
                Console.WriteLine(objectNumber + ": Конструктор без параметров");
            }           
            public GeomProgr(double b, double q) : this()
            {
                if (b == 0 || q == 0)
                {
                    objectNumber--;
                    throw new Exception("Ошибка в аргументах конструктора!");
                }
                _b = b;
                _q = q;
                Console.WriteLine(objectNumber + ": Конструктор с параметрами");
            }

            public double this[int n]
            {
                get
                {
                    if (n < 0)
                        throw new ArgumentException("Число должно быть положительным");
                    return B * Math.Pow(Q, n - 1);
                }
            }

            public double ProgrSum(int n)
            {
                if (n < 0)
                    throw new ArgumentException("Число должно быть положительным");
                return B * (Math.Pow(Q, n) - 1) / (Q - 1);
            }
        }


        public abstract class MyStrings
        {
            public string str;
            public static Random rnd=new Random();
            public bool IsPalindrome
            {
                get
                {
                    if (str.Length > 0)
                    {
                        char[] tmp = str.ToCharArray();
                        Array.Reverse(tmp);
                        string tmpString = new string(tmp);
                        if (str.CompareTo(tmpString) == 0) return true;
                    }
                    return false;
                }
            }
            public abstract bool Validate(int n, char start, char finish);

            public abstract int CountLetter(char letter);
            
            public override string ToString()
            {
                return str;
            }
        }



        public class RusString:MyStrings
        {
            public RusString(char start, char finish, int n)
            {                
                if (!Validate(n,start,finish))
                    throw new ArgumentOutOfRangeException();
                char[] letters = new char[n];
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = (char)rnd.Next(start, finish + 1);
                }
                str = new String(letters);
            }            

            public override int CountLetter(char letter)
            {
                if (letter < 'а' || letter > 'я') return 0;
                int start = 0, result = -1, res;
                do
                {
                    res = str.IndexOf(letter, start);
                    start = res + 1;
                    result++;
                } while (res >= 0);
                return result;
            }

            public override bool Validate(int n,char start,char finish)
            {
                if (n <= 0 || start < 'а' || finish > 'я')
                    return false;
                return true;
            }

        }

        public class LatString : MyStrings
        {
            public LatString(char start, char finish, int n)
            {
                if (!Validate(n, start, finish))
                    throw new ArgumentOutOfRangeException();
                char[] letters = new char[n];
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = (char)rnd.Next(start, finish + 1);
                }
                str = new String(letters);
            }

            public override int CountLetter(char letter)
            {
                if (letter < 'a' || letter > 'z') return 0;
                int start = 0, result = -1, res;
                do
                {
                    res = str.IndexOf(letter, start);
                    start = res + 1;
                    result++;
                } while (res >= 0);
                return result;
            }

            public override bool Validate(int n, char start, char finish)
            {
                if (n <= 0 || start < 'a' || finish > 'z')
                    return false;
                return true;
            }
        }


        public class QuadraticTrinomial
        {            
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public QuadraticTrinomial(double a, double b, double c)
            {
                A = a; B = b; C = c;
            }
            
            public double ValueInX(double x0)
            {
                return A * x0 * x0 + B * x0 + C;
            }
            
            public double Division(QuadraticTrinomial another, double x0)
            {
                double div = 1;
                if (another.ValueInX(x0) == 0)
                    throw new DivideByZeroException("Деление на ноль");
                div =ValueInX(x0) / another.ValueInX(x0);
                return div;
            }
        }


    }
}
