﻿namespace Lebiru.Calculator
{
    public class Addition : IOperation
    {
        public double Execute(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
