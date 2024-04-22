namespace Core.Helpers
{
    public static class Helper
    {
        public static bool CheckFullName(this string fullName)
        {
            fullName = fullName?.Trim();
            int count = 0;
            if (string.IsNullOrWhiteSpace(fullName)) return false;
            if (!char.IsUpper(fullName[0])) return false;

            for (int i = 1; i < fullName.Length - 1; i++)
            {
                if (fullName[i] == ' ')
                {
                    count++;
                }
            }

            if (count != 1) return false;

            for (int i = 1; i < fullName.Length - 1; i++)
            {
                if (fullName[i] == ' ' && !char.IsUpper(fullName[i + 1]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckPassword(this string pass)
        {
            pass = pass?.Trim();
            if (string.IsNullOrWhiteSpace(pass)) return false;
            if (pass.Length < 6) return false;

            bool checkLower = false;
            bool checkUpper = false;
            bool checkDigit = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLower(pass[i])) checkLower = true;
                if (char.IsUpper(pass[i])) checkUpper = true;
                if (char.IsDigit(pass[i])) checkDigit = true;
            }

            if (checkLower && checkUpper && checkDigit) return true;
            return false;
        }
    }
}
