namespace Eflyer.Business.Exceptions;

public class FileSizeException : Exception
{
    public string PropertyName { get; set; }
    public FileSizeException(string propertyName, string? message) : base(message)
    {
        PropertyName = propertyName;
    }
}
