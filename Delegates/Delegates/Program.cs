namespace Delegates
{
    internal class Program
    {
        public delegate T Calc<T>(T num1, T num2);
        public delegate void Test(Calc<int> calc);
        static void Main(string[] args)
        {

            Calc<int> calc = Sum;
            calc += Product;
            calc += Minus;
            //calc.Invoke(3, 4);
            //Console.WriteLine(calc(3, 4));
            Calculate(calc);
        }

        static void Calculate(Calc<int>? calc)
        {
            Console.WriteLine(calc.Invoke(3, 4));
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Product(int a, int b)
        {
            return a * b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }
    }
}