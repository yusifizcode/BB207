namespace Generics.Models
{
    public class MyHumanList
    {
        public Human[] Arr = { };

        public void Add(Human value)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = value;
        }

        public void RemoveAll(Human value)
        {
            Human[] newArr = { };
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
