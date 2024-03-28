namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Verilen iki ededin yerini deyisdiren metod
            // 2.Ədədlərdən ibarət arrayın mənfi elementlərini müsbətə çevirən method yazın.
            // (array assign olmadan göndərilə bilməsin)
            //3. 2 string parametr qəbul edən bir method yazırsınız.Bu ədədləri Consoledan daxil
            //edirsiniz və əgər int'ə çevirilə bilirsə cəmini qaytarırsınız.
            //(ədədlər mütləq şəkildə method daxilində assign olunmalıdır.)

            //int num1 = 5;
            //int num2 = 15;

            //Console.WriteLine("Before Method: ");
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine("---------------------------");
            //ChangeNumbers(ref num1, ref num2);
            //Console.WriteLine("After Method: ");
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //int[] arr = { 1, 2, -3, 4, -5 };

            //ChangeArrayElements(ref arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            Console.WriteLine("Nese yaz 1: ");
            string inputStr1 = Console.ReadLine();
            Console.WriteLine("Nese yaz 2: ");
            string inputStr2 = Console.ReadLine();

            Console.WriteLine(Sum(inputStr1, inputStr2));

            #region Anonym Object
            //string name = "Reshid";
            //string surname = "Babazade";
            //byte age = 20;
            //string groupName = "BB207";

            //string name1 = "Ayse";
            //string surname1 = "Novruzova";
            //byte age1 = 20;
            //string groupName1 = "BB207";

            //string[] names = { "Reshid", "Gulchohre", "Nicat", "Asime" };
            //string[] surnames = { "Babazada", "Sultanova", "Mecidov" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i] + " - " + surnames[i]);
            //}

            //var student1 = new
            //{
            //    Name = "Asime",
            //    Surname = "Quluzade",
            //    Age = "20 sayilir"
            //};

            //var student2 = new
            //{
            //    Name = "Almaz",
            //    Surname = "Heyderli",
            //    Age = 19,
            //    GroupName = "BB207"
            //};

            //var student3 = new
            //{
            //    Name = "Test",
            //    Surname = "Test1",
            //    Age = 34,
            //    Stip = 150
            //};

            //Console.WriteLine(student2.Surname);
            #endregion

            #region Class, object
            //int[] arr = new int[] { };
            ////String a = "abc";
            //Student student = new Student();
            //student.Name = "Veli";
            //student.Surname = "Hesenli";
            //student.Age = 19;
            //student.GroupName = "BB207";

            //Student student1 = new Student();
            //student1.Name = "Test";
            //student1.Surname = "Test";
            //student1.Age = 19;
            //student1.GroupName = "Test";

            //Student[] students = { student, student1 };

            //for (int i = 0; i < students.Length; i++)
            //{
            //    //Console.WriteLine(students[i].Name + " - " + students[i].Surname);
            //    Console.WriteLine($"{students[i].Name} - {students[i].Surname}");
            //}
            #endregion
        }

        static void ChangeNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void ChangeArrayElements(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = -arr[i];
                }
            }
        }

        //static int Sum(string inputStr1, string inputStr2)
        //{
        //    bool check = true;
        //    for (int i = 0; i < inputStr1.Length; i++)
        //    {
        //        if (!(inputStr1[i] > 47 && inputStr1[i] < 58))
        //        {
        //            check = false;
        //            break;
        //        }
        //    }

        //    for (int i = 0; i < inputStr2.Length; i++)
        //    {
        //        if (!(inputStr2[i] > 47 && inputStr2[i] < 58))
        //        {
        //            check = false;
        //            break;
        //        }
        //    }

        //    if (check == true)
        //    {
        //        return Convert.ToInt32(inputStr1) + Convert.ToInt32(inputStr2);
        //    }
        //    return -1;
        //}

        //static int Sum(string inputStr1, string inputStr2)
        //{
        //    bool check = true;
        //    for (int i = 0; i < inputStr1.Length; i++)
        //    {
        //        if (!char.IsDigit(inputStr1[i]))
        //        {
        //            check = false;
        //            break;
        //        }
        //    }

        //    for (int i = 0; i < inputStr2.Length; i++)
        //    {
        //        if (!(char.IsDigit(inputStr2[i])))
        //        {
        //            check = false;
        //            break;
        //        }
        //    }

        //    if (check == true)
        //    {
        //        return Convert.ToInt32(inputStr1) + Convert.ToInt32(inputStr2);
        //    }
        //    return -1;
        //}

        static int Sum(string inputStr1, string inputStr2)
        {
            bool check1 = int.TryParse(inputStr1, out int a);
            bool check2 = int.TryParse(inputStr2, out int b);

            if (check1 && check2)
            {
                return a + b;
            }

            return -1;
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string GroupName;
    }

    class Desk
    {
        public int Height;
        public int Width;
        public string Color;
    }

    class Product
    {
        public string Name;
        public string BrandName;
        public string ModelName;
        public double Price;
        public double DiscountPercent;
    }


}