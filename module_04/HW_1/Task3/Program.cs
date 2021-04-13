using System;
using System.IO;
using System.Xml.Serialization;

delegate void Qdelegate(Quadratic qe);

class Processing
{
    static Random gen = new Random();

    public static void SolutionReal(Quadratic eq)
    {
        if (eq.Discriminant < 0) return;
        Console.WriteLine(eq.ToString() + "  дискриминант = " +
            eq.Discriminant);
        Console.WriteLine("\tКорни: Х1={0,3:g3}  \tX2={1,3:g3}",
           eq.X1, eq.X2);
    }

    public static void PrintEq(Quadratic eq)
    {
        Console.WriteLine(eq.ToString() + "  дискриминант = "
            + (eq.Discriminant).ToString("g3"));
    }

    static public void WriteFile(string nameFile, int numb)
    {
        using (FileStream streamOut = new FileStream(nameFile, FileMode.Create))
        {
            XmlSerializer formatOut = new XmlSerializer(typeof(Quadratic[]), new Type[] { typeof(double) });
            Quadratic[] a = new Quadratic[numb];
            for (int i = 0; i < numb; i++)
            {
                try
                {
                    a[i] = new Quadratic(gen.Next(-10, 11),
                        gen.Next(-10, 11), gen.Next(-10, 11));
                }
                catch (ArgumentException)
                {
                    i--;
                }
            }

            try
            {
                formatOut.Serialize(streamOut, a);
            }
            catch
            {
                Console.WriteLine("Trouble with serializtion");
            }
        }
    }

    public static void Process(string fileName, Qdelegate qDel)
    {
        using (FileStream streamIn = new FileStream(fileName, FileMode.Open))
        {
            XmlSerializer formatIn = new XmlSerializer(typeof(Quadratic[]), new Type[] { typeof(double) });
            Quadratic[] e;
            while (true)
                try
                {
                    e = (Quadratic[])formatIn.Deserialize(streamIn);
                    foreach(Quadratic eq in e)
                        qDel(eq);
                }
                catch { streamIn.Close(); break; }
        }
    }
}

[Serializable]
public class Quadratic
{
    public double a;
    public double b;
    public double c;

    public Quadratic() { }

    public Quadratic(double a, double b, double c)
    {
        if (a == 0)
            throw new ArgumentException("Это линейное, а не квадратное уравнение!");
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Discriminant
    {
        get
        {
            return b * b - 4 * a * c;
        }
    }

    public double X1
    {
        get
        {
            if (Discriminant < 0)
                return double.NaN;
            return (-b + Math.Sqrt(Discriminant)) / (2 * a);
        }
    }
    public double X2
    {
        get
        {
            if (Discriminant < 0)
                return double.NaN;
            return (-b - Math.Sqrt(Discriminant)) / (2 * a);
        }
    }

    public override string ToString()
    {
        string s = $"{a}x^2";
        if (b > 0)
            s += $"+{b}x";
        if (b < 0)
            s += $"{b}x";
        if (c > 0)
            s += $"+{c}";
        if (c < 0)
            s += $"{c}x";
        return s;
    }
}

class Program
{
    public static void Main()
    {
        Processing.WriteFile("equation.xml", 8);
        Console.WriteLine("Выполнена запись в режиме сериализации.");
        Console.WriteLine("Для вывода на экран нажмите любую клавишу.");
        Console.ReadKey(true);
        Console.WriteLine("В файле сведения о следующих уравнениях: ");
        Processing.Process("equation.xml", new Qdelegate(Processing.PrintEq));
        Console.WriteLine("Для решения уравнений нажмите любую клавишу.");
        Console.ReadKey(true);
        Console.WriteLine("\r\nРешения уравнений с вещественными корнями: ");
        Processing.Process("equation.xml", new Qdelegate(Processing.SolutionReal));
        Console.WriteLine("Для завершения работы нажмите ENTER.");
        Console.ReadLine();

    }
}
