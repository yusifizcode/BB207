namespace StringAndArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "salam";
            char chr = 'x';
            //Console.WriteLine(word.LastIndexOf(chr));

            //Console.WriteLine(LastIndexOfCustom("salam", 'a'));
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine(CustomToUpper2("salam"));
            Console.WriteLine("String.Compare: " + String.Compare("ABC", "ABCasdasdadsd")); // eger 2ci parametr olaraq gonderdiyim elementin her hansi bir chari 1ciden boyukduse, -1 qaytari, eks halda 1, ikisi de eynidirse, 0 qaytarir
            //Console.WriteLine("Custom Compare: " + CustomCompare(null, null)); // eger 2ci parametr olaraq gonderdiyim elementin her hansi bir chari 1ciden boyukduse, -1 qaytari, eks halda 1, ikisi de eynidirse, 0 qaytarir
        }

        static int LastIndexOfCustom(string word, char chr)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] == chr)
                {
                    return i;
                }
            }
            return -1;
        }

        static string CustomToUpper(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        result += 'A';
                        break;
                    case 'b':
                        result += 'B';
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        static string CustomToUpper2(string word) //salam
        {
            string newStr = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z') // sozdeki herf balaca herfdimi?
                {
                    newStr += (char)(word[i] - 32); // eger balaca herfdise ascii kodundan 32 cixiram ki, boyuk qarshiligi olan edede cevrilsin
                }
            }
            return newStr;
        }

        static string CustomToUpper3(string word)
        {
            string str = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z')
                {
                    str += Char.ToUpper(word[i]);
                }
            }
            return str;
        }

        static int CustomCompare(string word1, string word2)
        {
            int minLength = 0;
            if (word1 == null && word2 == null)
            {
                return 0;
            }

            if (word1.Length > word2.Length)
            {
                minLength = word2.Length;
            }
            else if (word1.Length < word2.Length)
            {
                minLength = word1.Length;
            }
            else
            {
                minLength = word1.Length;
            }

            for (int i = 0; i < minLength; i++)
            {
                if (word1[i] > word2[i])
                {
                    return 1;
                }
                else if (word1[i] < word2[i])
                {
                    return -1;
                }
            }


            if (word1.Length == word2.Length)
            {
                return 0;
            }
            else if (word1.Length > word2.Length)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}