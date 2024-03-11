namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 12, 23, 45, 67, 90 };
            //int product = 1;
            //for (int i = 0; i <= arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        product *= arr[i];
            //    }
            //}
            //Console.WriteLine(product);

            //int[] arr = { 2, 34, 67, 99 };
            //int n = 5;
            //bool test = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (n > arr[i])
            //    {
            //        test = true;
            //        break;
            //    }

            //}
            //Console.WriteLine(test);

            //string[] words = { "salam", "sagol", "falan" };
            //string word = "sagol";
            //bool check = false;
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i] == word)
            //    {
            //        check = true;
            //break;
            //    }

            //}
            //Console.WriteLine(check);

            //string word = "salam";
            //char herf = 'k';
            //bool check = false;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == herf)
            //    {
            //        check = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(check);

            //string[] words = { "salam", "sagol", "falan" };
            //for (int i = 0; i < words.Length; i++)
            //{
            //    string word = words[i];
            //    for (int j = word.Length - 1; j >= 0; j--)
            //    {
            //        Console.Write(word[j]);
            //    }
            //    Console.WriteLine();
            //}

            string[] words = { "salam", "sagol", "falan" }; // -> falan - 2
            string[] test = new string[words.Length]; // -> falan - 0
            //test[0] = words[2]; // -> test[words.Length-1-i] -> test[0]
            //test[1] = words[1];// -> test[words.Length-1-i] -> test[1]
            //test[2] = words[0];// test[words.Length-1-i] -> test[2]
            for (int i = words.Length - 1; i >= 0; i--)
            {
                test[words.Length - 1 - i] = words[i];
                //Console.WriteLine(words[i]);
            }
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
        }
    }
}