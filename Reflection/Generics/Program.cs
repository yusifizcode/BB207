using Generics.Models;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyIntList myIntList = new MyIntList();
            //myIntList.Add(1);
            //myIntList.Add(2);
            //myIntList.Add(3);
            //myIntList.Add(4);

            //myIntList.RemoveAll(3);


            //MyStringList myStringList = new MyStringList();
            //myStringList.Add("salam");
            //myStringList.Add("sagol");
            //myStringList.Add("test");
            //myStringList.Add("lorem");
            //myStringList.Add("ipsum");

            //myStringList.RemoveAll("test");


            //MyHumanList myHumanList = new MyHumanList();
            //Human human = new Human();
            //human.Name = "salam";
            //human.Surname = "test";

            //myHumanList.Add(human);

            //foreach (var item in myStringList.Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in myIntList.Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //MyList<int> myList = new MyList<int>();

            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(5);

            //myList.RemoveAll(3);

            //foreach (var item in myList.Arr)
            //{
            //    Console.WriteLine(item);
            //}


            //MyList<string> stringList = new MyList<string>();

            //stringList.Add("a");
            //stringList.Add("b");
            //stringList.Add("c");
            //stringList.Add("d");
            //stringList.Add("e");

            //foreach (var item in stringList.Arr)
            //{
            //    Console.WriteLine(item);
            //}
            Human human = new Human();
            //MyList<int> myList = new MyList<int>();

            //MyList<Employee, Human> myList1 = new MyList<Employee, Human>();

            //Human human = new Human { Name = "salam", Surname = "sagol" };

            //MyList<int, string> myList = new MyList<int, string>();
            //MyList<char, Human> myList2 = new MyList<char, Human>();

            //MyList<char> myList2 = new MyList<char>();

            //Char char1 = new Char();
            //Int32 int32 = new Int32();


            //String str = new String();

            MyList myList = new MyList();

            myList.RemoveAll<string>();
        }
    }

    static class Test
    {

    }
}