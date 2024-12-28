namespace Lebiru.Calculator
{
    public class Division : IOperation
    {
        public double Execute(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return num1 / num2;
        }
    }
}
