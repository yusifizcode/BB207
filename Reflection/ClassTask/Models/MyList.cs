namespace ClassTask.Models
{
    public class MyList<T>
    {
        T[] Arr = { };
        public int Length { get => Arr.Length; }


        public void Add(T value)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = value;
        }
        public T[] GetAllValues()
        {
            return Arr;
        }
        public void Remove(T value)
        {
            int wantedIndex = Array.IndexOf(Arr, value);

            for (int i = wantedIndex; i < Arr.Length - 1; i++)
            {
                Arr[i] = Arr[i + 1];
            }

            if (Arr.Length > 0)
            {
                Array.Resize(ref Arr, Arr.Length - 1);
            }
        }
        public void RemoveAll(T value)
        {
            T[] newArr = { };

            foreach (T item in Arr)
            {
                if (!item.Equals(value))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = item;
                }
            }

            Arr = newArr;
        }
    }
}
