namespace ProniaBB207.Business.Exceptions
{
    public class FileNotFoundException : Exception
    {
        public string PropertyName { get; set; }
        public FileNotFoundException(string propertyName, string? message) : base(message)
        {
            PropertyName = propertyName;
        }
    }
}
