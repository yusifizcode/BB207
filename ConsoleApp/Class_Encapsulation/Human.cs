namespace Class_Encapsulation
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public byte _age;
        public byte Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
    }
}
