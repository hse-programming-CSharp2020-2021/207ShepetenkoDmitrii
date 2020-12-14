using System;


class Methods
{    
    public static int GetIntValue(string comment)
    {
        int intVal;
        do Console.Write(comment);
        while (!int.TryParse(Console.ReadLine(), out intVal));
        return intVal;
    }
    
    
}
class UserString
{
    string str;
    static Random gen = new Random();
    public UserString(int k, char minChar, char maxChar)
    {
        if (k < 0)
            throw new Exception("Аргумент метода должен быть положительным!");
        if (maxChar < minChar)
        {
            char c = minChar;
            minChar = maxChar;
            maxChar = c;
        }
        str = String.Empty;
        for (int i = 0; i < k; i++)
            str += (char)gen.Next(minChar, maxChar + 1);
    }

    public void MoveOff(string s2)
    {
        int index;
        for (int i = 0; i < s2.Length; i++)
            while ((index = str.IndexOf(s2[i])) >= 0)
                str = str.Remove(index, 1);
    }

    public override string ToString()
    {
        return str;
    }
}
class Program
{
    static void Main(string[] args)
    {
        do
        {
            int n = Methods.GetIntValue("Введите число\n");
            UserString s = new UserString(n, '0', '9');
            Console.WriteLine(s);
            s.MoveOff("02468");
            Console.WriteLine(s);
            Console.WriteLine("Нажмите Esc для завершения...");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

