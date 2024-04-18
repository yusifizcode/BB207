namespace Generics.Models
{
    public class MyList<T, U, Z> where T : ITest
    {
        public T[] Arr = { };

        public void Add(T value)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = value;
        }

        public void RemoveAll()
        {
            T[] newArr = { };
            for (int i = 0; i < Arr.Length; i++)
            {
                //if (!Arr[i].Equals(value))
                //{
                //    Array.Resize(ref newArr, newArr.Length + 1);
                //    newArr[newArr.Length - 1] = Arr[i];
                //}

            }

            Arr = newArr;
        }
    }
}
