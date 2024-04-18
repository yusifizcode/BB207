namespace ClassTask
{
    public class Swap<T>
    {
        public void ChangeValue(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
