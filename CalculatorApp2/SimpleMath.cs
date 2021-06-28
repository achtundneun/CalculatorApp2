using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp2
{
    public static class SimpleMath
    {
        public static double Summ(double num_1, double num_2)
        {
            return num_1 + num_2;
        }
        public static double Subtraction(double num_1, double num_2)
        {
            return num_1 - num_2;
        }
        public static double Multiplication(double num_1, double num_2)
        {
            return num_1 * num_2;
        }
        public static double Division(double num_1, double num_2)
        {
            return num_1 / num_2;
        }
        public static double Remainder_Division(double num_1, double num_2)
        {
            return num_1 % num_2;
        }
    }

}

