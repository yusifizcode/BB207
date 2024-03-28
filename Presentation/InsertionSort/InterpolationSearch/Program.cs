namespace InterpolationSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, };
            int n = Convert.ToInt32(Console.ReadLine());
            int start = 0;
            int end = arr.Length - 1;
            int result = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int target = start + ((n - arr[start]) * (arr[end] - arr[start])) / (end - start);
                while (start < end && n <= arr[end] && n >= arr[start])
                {
                    if (arr[target] == n)
                    {
                        result = target;
                        break;
                    }
                    if (arr[target] < n)
                    {
                        start = target + 1;

                    }
                    else
                    {
                        end = target - 1;
                    }
                }
            }
            if (result == -1)
            {
                Console.WriteLine($"{n} bu arrayda yoxdur");
            }
            else
            {
                Console.WriteLine($"{n} arrayda {result} indeksindedir");
            }
        }
    }
}