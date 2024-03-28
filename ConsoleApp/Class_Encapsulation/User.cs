namespace Class_Encapsulation
{
    internal class User
    {
        private string _userName; //null
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length > 6 && value.Length < 25) // null.Length
                {
                    _userName = value;
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length > 8 && value.Length < 25)
                {
                    _password = value;
                }
            }
        }
    }
}
