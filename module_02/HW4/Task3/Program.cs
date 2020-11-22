using System;
using System.Diagnostics.CodeAnalysis;

namespace Task3
{
    public class Employee:IComparable<Employee>
    {
        public string name;
        
        protected decimal basepay;
        
        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }
        
        public virtual decimal CalculatePay()
        {
            return basepay;
        }

        public int CompareTo( Employee other)
        {
            return this.CalculatePay().CompareTo(other.CalculatePay());
        }
    }
    
    public class SalesEmployee : Employee
    {        
        private decimal salesbonus;
        
        public SalesEmployee(string name, decimal basepay,
                  decimal salesbonus) : base(name, basepay)
        {
            this.salesbonus = salesbonus;
        }
        
        public override decimal CalculatePay()
        {
            return basepay + salesbonus;
        }
    }

    class PartTimeEmployee:Employee
    {
        int workingDays;

        public PartTimeEmployee(string name,decimal basepay,int days) : base(name, basepay)
        {
            workingDays = days;
        }

        public override decimal CalculatePay()
        {
            return (decimal)((double)basepay * (workingDays / 25.0));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Employee[] s = new Employee[r.Next(3, 12)];
            for(int i = 0; i < s.Length; i++)
            {
                if (r.Next(0, 2) == 1)
                    s[i] = new SalesEmployee("anton", r.Next(2, 232535), r.Next(2, 232535));
                else
                    s[i] = new PartTimeEmployee("dima", r.Next(2, 232535), r.Next(1, 25));
            }
            Array.Sort(s);
            Console.WriteLine("PartTimeEmployee:");
            foreach(var a in s)
            {
                if (a is PartTimeEmployee)
                    Console.WriteLine($"{a.name}    {a.CalculatePay()}");
            }
            Console.WriteLine("SalesEmployee:");
            foreach (var a in s)
            {
                if (a is SalesEmployee)
                    Console.WriteLine($"{a.name}    {a.CalculatePay()}");
            }
        }
    }
}
