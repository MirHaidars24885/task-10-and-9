namespace Task10.Exceptions;

public class DoesntExistException : Exception
{
    public DoesntExistException(string message) : base(message)
    {
        
    }
}