namespace SelecsionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 21, 54, 1, 32, 76 };
            int kicikIndex;
            for (int i = 0; i < numbers.Length; i++)
            {
                kicikIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[kicikIndex] < numbers[j])
                    {
                        kicikIndex = j;
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[kicikIndex];
                numbers[kicikIndex] = temp;
            }
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.Write(numbers[k] + " ");
            }
        }
    }
}