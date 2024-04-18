namespace Delegates
{
    internal class Program
    {
        delegate bool Check(int number);
        delegate int Calc(int num1, int num2);
        delegate void Show(int number);
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Check check = IsEven;
            //Check check1 = IsOdd;
            Check check = IsOdd;
            Check check1 = delegate (int i)
            {
                return i % 2 == 1;
            };
            Check check2 = i => i % 2 == 1;

            Calc calc = (x, y) => x + y;
            TestCalc(calc);

            //Console.WriteLine(Sum(arr, ()));

            //Console.WriteLine(Sum(arr, delegate (int i)
            //{
            //    return i % 2 == 1;
            //}));

            //Check check = (i) => i % 2 == 0;
            //Console.WriteLine(Sum(arr,));

            //Calc calc = Sum;
            //Calc calc1 = Product;
            //Calc calc2 = Devide;

            //Show show = ShowNumber;
        }

        //static void ShowNumber(int num)
        //{
        //    Console.WriteLine(num);
        //}

        static bool IsEven(int i)
        {
            return i % 2 == 0;
        }

        static bool IsOdd(int i)
        {
            return i % 2 == 1;
        }

        static int Sum(int[] arr, Check check)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (check(item))
                {
                    sum += item;
                }
            }

            return sum;
        }

        static void TestCalc(Calc calc)
        {

        }

        //static int Sum(int a,int b)
        //{
        //    return a + b;
        //}

        //static int Product(int a,int b)
        //{
        //    return a * b;
        //}

        //static int Devide(int a,int b)
        //{
        //    return a / b;
        //}

        //static int SumEvens(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int i in arr)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            sum += i;
        //        }
        //    }

        //    return sum;
        //}

        //static int SumOdds(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int i in arr)
        //    {
        //        if (i % 2 == 1)
        //        {
        //            sum += i;
        //        }
        //    }

        //    return sum;
        //}

    }
}