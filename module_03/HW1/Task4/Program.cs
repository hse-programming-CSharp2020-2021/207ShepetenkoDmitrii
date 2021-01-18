using System;

namespace Task4
{
    class Robot
    {
        public int x, y;

        public void Right() { x++; }
        public void Left() { x--; }
        public void Forward() { y++; }
        public void Backward() { y--; }

        public string Position()
        {
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }

    class Program
    {
        delegate void Steps();
        public static double Input( string s)
        {
            double d;
            do
            {
                Console.WriteLine(s);
            } while (!double.TryParse(Console.ReadLine(), out d));
            return d;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите границы поля");
            double xmax,ymax;
            do
            {
                xmax = Input("Введите максимальный x");
            } while (xmax <= 0);
            do
            {
                ymax = Input("Введите максимальный y");
            } while (ymax <= 0);
            char[,] field = new char[(int)(xmax), (int)(ymax)];
            for(int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    field[i, j] = '-';
            field[0, 0] = '+';
            Robot rob = new Robot();
            Steps delR = new Steps(rob.Right);
            Steps delL = new Steps(rob.Left);
            Steps delF = new Steps(rob.Forward);
            Steps delB = new Steps(rob.Backward);
            Steps delRF = delR + delF;
            Steps delRB = delR + delB;
            Steps delLF = delL + delF;
            Steps delLB = delL + delB;
            bool usl = true;
            Steps[] action;
            do
            {
                usl = true;
                Console.WriteLine("Введите через пробел порядок действий");
                string[] s = Console.ReadLine().Split();
                action = new Steps[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    if (!usl)
                        break;
                    switch (s[i])
                    {
                        case "L":
                            action[i] = delL;
                            break;
                        case "R":
                            action[i] = delR;
                            break;
                        case "F":
                            action[i] = delF;
                            break;
                        case "B":
                            action[i] = delB;
                            break;
                        case "RF":
                            action[i] = delRF;
                            break;
                        case "RB":
                            action[i] = delRB;
                            break;
                        case "LF":
                            action[i] = delLF;
                            break;
                        case "LB":
                            action[i] = delLB;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод");
                            usl = false;
                            break;
                    }
                }
            } while (!usl);
            try
            {
                for (int i = 0; i < action.Length; i++)
                {
                    action[i]();
                    field[rob.x, rob.y] = '+';
                    if (i == action.Length - 1)
                        field[rob.x, rob.y] = '*';
                }
            }
            catch
            {
                Console.WriteLine("Робот ушел за границы....");
            }
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                    Console.Write(field[i, j]);
                Console.WriteLine();
            }
                
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();

        }
    }
}
