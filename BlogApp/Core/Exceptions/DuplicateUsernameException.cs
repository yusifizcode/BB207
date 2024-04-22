namespace Core.Exceptions
{
    public class DuplicateUsernameException : Exception
    {
        public DuplicateUsernameException(string? message) : base(message)
        {
        }
    }
}
