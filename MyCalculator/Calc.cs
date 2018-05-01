using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculator
{
    public class Calc
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Minus(double value1, double value2)
        {
            return value1 - value2;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Divide(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new DivisionException("value2 must not be 0");
            }
            return value1 / value2;
        }

        public double SqrtRoot(double value)
        {
            return (Math.Sqrt(value));
        }

        public double ByTwo(double value)
        {
            return Divide(value, 2);
        }

        public double ByFour(double value)
        {
            return Divide(value, 4);
        }
    }

    public class CalcException : Exception
    {
        public CalcException(string v) : base(v)
        {
        }
    }

    public class DivisionException : CalcException
    {
        public DivisionException(string v) : base (v)
        {
        }
    }
}
