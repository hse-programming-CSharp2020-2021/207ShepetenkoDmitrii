using System;

namespace Task3
{

    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

        public static State operator +(State state1, State state2)
        {
            return new State(){ Area=state1.Area+state2.Area, Population = state1.Population+state2.Population};
        }

        public static bool operator >(State state1, State state2)
        {
            return state1.Area > state2.Area;
        }

        public static bool operator <(State state1, State state2)
        {
            return state1.Area < state2.Area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State(); 
            State state3 = state1 + state2;
            bool isGreater = state1 > state2;
        }
    }
}
