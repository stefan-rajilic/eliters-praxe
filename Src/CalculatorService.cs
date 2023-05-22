namespace CalculatorAPI
{
    public class CalculatorService : ICalculatorService
    {
        public int Addition(int a, int b) 
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            if (b != 0) return a / b;
            else return 0;
        }
    }
}