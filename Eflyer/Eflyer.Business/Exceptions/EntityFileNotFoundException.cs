namespace Eflyer.Business.Exceptions;

public class EntityFileNotFoundException : Exception
{
    public string PropertyName { get; set; }
    public EntityFileNotFoundException(string propertyName, string? message) : base(message)
    {
        PropertyName = propertyName;
    }
}
