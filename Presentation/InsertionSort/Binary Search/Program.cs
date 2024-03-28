namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("axtarilan ededi daxil et");
            int search = Convert.ToInt32(Console.ReadLine());
            int start = 0;
            int end = nums.Length - 1;
            int mid;
            bool a = false;
            for (int i = 0; i < nums.Length; i++)
            {
                mid = (start + end) / 2;
                if (search == nums[mid])
                {
                    Console.WriteLine($"eded tapildi indexi {mid}");
                    a = true;
                    break;
                }
                else if (search > nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            if (!a) { Console.WriteLine("eded arrayda yoxdur"); }


        }
    }
}