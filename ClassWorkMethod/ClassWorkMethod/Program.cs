namespace ClassWorkMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MakeString("salam dunya");
            //ShowCapitalLetters("salam     dunya    ");
            Console.WriteLine(Calculate(1, 2, '!'));

        }
        public static void Key(int r)
        {
            int p = 3;
            Console.WriteLine(p * (r * r));
        }
        public static void Key(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Key(int a, int b, int c)
        {
            Console.WriteLine(2 * (a * b + a * c + b * c));
        }

        public static void MakeString(string str)
        {
            string newStr = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine(newStr);
        }

        public static void ShowCapitalLetters(string str)
        {
            string newStr = "";

            if (str[0] != ' ')
            {
                newStr += str[0];
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                {
                    newStr += str[i + 1];
                }
            }

            Console.WriteLine(newStr);
        }

        public static double Calculate(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                default:
                    Console.WriteLine("Duzgun operator daxil edin!");
                    return -1;
            }
        }
    }
}