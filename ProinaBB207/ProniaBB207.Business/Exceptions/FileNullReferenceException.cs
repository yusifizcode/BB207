namespace ProniaBB207.Business.Exceptions;

public class FileNullReferenceException : Exception
{
    public string PropertyName { get; set; }
    public FileNullReferenceException(string propertyName, string? message) : base(message)
    {
        PropertyName = propertyName;
    }
}
