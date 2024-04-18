namespace SystemDelegates
{
    internal class Program
    {
        public delegate TResult CustomFunc<T1, TResult>(T1 t1);


        public delegate bool CustomPredicate<T>(T t1);
        static void Main(string[] args)
        {
            // Action, Predicate, Func

            //Action<int, int, string> action = (a, b, str) => Console.WriteLine(a + b + str);
            //action(1, 2, " AB204");

            //Func<int[], int, string> func = FindNum;
            //Func<int,bool> func = (x) => true;
            //int[] ints = { 1, 2, 3, 4, 5, 6, 7 };

            //Console.WriteLine(func(ints, 12));

            //Predicate<int> predicate = FindNum;

            //Console.WriteLine(predicate(2));


            List<int> ints = new List<int>() { 1, 2, 4, 5, 6, 8, 9, 0 };

            //ints.ForEach(num => Console.WriteLine(num + 10));

            int a = ints.Find(x => x > 4);
            List<int> b = ints.FindAll(x => x > 4);
            Console.WriteLine(ints.FirstOrDefault(x => x > 9));

            Console.WriteLine(ints.Any(x => x > 11));
            //b.ForEach(num => Console.WriteLine(num));
        }

        //static bool FindNum(int num)
        //{
        //    int[] ints = { 1, 2, 3, 4, 5, 6, 7 };
        //    foreach (var item in ints)
        //    {
        //        if (item == num)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}