using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        public static string ConvertHex2Bin1(string HexNumber)
        {
            List<string> nums = new List<string> {"0000","0001","0010","0011","0100","0101","0110","0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" }; 
            string s="";
            foreach(char i in HexNumber)
            {
                switch (i)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        if (s == "")
                            s += int.Parse(nums[int.Parse(i.ToString())]).ToString();
                        else
                            s += nums[int.Parse(i.ToString())];
                        break;
                    case 'A':
                        s += nums[10];
                        break;
                    case 'B':
                        s += nums[11];
                        break;
                    case 'C':
                        s += nums[12];
                        break;
                    case 'D':
                        s += nums[13];
                        break;
                    case 'E':
                        s += nums[14];
                        break;
                    case 'F':
                        s += nums[15];
                        break;
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertHex2Bin1(Console.ReadLine()));
        }
    }
}
