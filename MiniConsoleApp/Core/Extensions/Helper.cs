namespace Core.Extensions
{
    public static class Helper
    {
        public static bool CheckValue(this string value)
        {
            value = value.Trim();
            if (!string.IsNullOrEmpty(value) && value.Length >= 3 && char.IsUpper(value[0]))
            {
                for (int i = 1; i < value.Length; i++)
                {
                    if (!char.IsLower(value[i]) && !char.IsLetter(value[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        public static bool CheckGroupName(this string value)
        {
            value = value.Trim();
            if (!string.IsNullOrEmpty(value) && value.Length == 5)
            {
                if (char.IsUpper(value[0]) && char.IsUpper(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
