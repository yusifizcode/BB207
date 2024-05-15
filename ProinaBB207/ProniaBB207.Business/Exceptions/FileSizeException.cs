namespace ProniaBB207.Business.Exceptions;

public class FileSizeException : Exception
{
    public FileSizeException(string propertyName, string? message) : base(message)
    {
        this.PropertyName = propertyName;
    }

    public string PropertyName { get; set; }
}
