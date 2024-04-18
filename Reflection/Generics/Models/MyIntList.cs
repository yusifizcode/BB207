namespace Generics.Models
{
    public class MyIntList
    {
        public int[] Arr = { };

        public void Add(int value)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = value;
        }

        public void RemoveAll(int value)
        {
            int[] newArr = { };
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] != value)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = Arr[i];
                }
            }

            Arr = newArr;
        }
    }
}
