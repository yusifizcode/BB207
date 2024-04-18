namespace ClassTask
{
    public class ValueHolder<T>
    {
        private T _value;
        public void SetValue(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }
    }
}
