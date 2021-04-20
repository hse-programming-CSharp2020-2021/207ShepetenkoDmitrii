﻿using System;

namespace Task2
{
    // хлеб
    class Bread
    {
        public int Weight { get; set; } // масса
    }

    // масло
    class Butter
    {
        public int Weight { get; set; } // масса

        public static Sandwich operator +(Bread bread, Butter butter)
        {
            return new Sandwich() { Weight = bread.Weight + butter.Weight };
        }

        public static Sandwich operator +(Butter butter, Bread bread)
        {
            return new Sandwich() { Weight = bread.Weight + butter.Weight };
        }
    }

    // бутерброт
    class Sandwich
    {
        public int Weight { get; set; } // масса
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight);  // 100
        }
    }
}
