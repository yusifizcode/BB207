namespace Eflyer.Business.Exceptions;

public class ImageFileRequiredException : Exception
{
    public string PropertyName { get; set; }
    public ImageFileRequiredException(string propertyName, string? message) : base(message)
    {
        PropertyName = propertyName;
    }
}
