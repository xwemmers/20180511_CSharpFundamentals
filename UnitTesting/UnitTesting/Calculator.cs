﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new CalculatorException("Delen door nul!");

            return a / b;
        }

    }

    class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message)
        {
        }
    }
}
