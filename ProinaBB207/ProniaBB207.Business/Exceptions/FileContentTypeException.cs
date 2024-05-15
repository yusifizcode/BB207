namespace ProniaBB207.Business.Exceptions;

public class FileContentTypeException : Exception
{
    public string PropertyName { get; set; }
    public FileContentTypeException(string propertyName, string? message) : base(message)
    {
        PropertyName = propertyName;
    }
}
