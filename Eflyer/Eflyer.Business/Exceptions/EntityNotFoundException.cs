namespace Eflyer.Business.Exceptions;

public class EntityNotFoundException : Exception
{
    public string PropertyName { get; set; }
    public EntityNotFoundException(string propertyName, string? message) : base(message)
    {
        PropertyName = propertyName;
    }
}
