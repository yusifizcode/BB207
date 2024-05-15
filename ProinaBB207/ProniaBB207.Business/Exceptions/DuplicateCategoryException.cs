namespace ProniaBB207.Business.Exceptions;

public class DuplicateCategoryException : Exception
{
    public string PropertyName { get; set; }
    public DuplicateCategoryException(string propertyName, string? message) : base(message)
    {
        PropertyName = propertyName;
    }
}
